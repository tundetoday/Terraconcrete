Public Class BatchForm
    Public Property PiD As Integer
    Public Property BiD As Integer
    Public Property Specimen As Boolean
    Dim MaxNoOfset, b, h, x As Integer, BatchEntry, Newbatch, SpecimenValid, Calculation, Submerge As Boolean
    Dim ans As DialogResult
    Private Sub BatchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ToolStripLabl.Text = "Project ID :" & PiD
            ProjectIDTextBox.Text = PiD
            BatchIdTextBox.Text = BiD
            ToolStripUser.Text = "Current User : " & UsersForm.User
            BatchEntry = False
            If Me.BatchTableTableAdapter.CheckQuery(PiD) = 0 Then
                LockState()
            Else
                Me.BatchTableTableAdapter.Fill(Me.TerraConcDataSet.BatchTable, PiD)
                ValidateSpecimenEntry()
                ViewState()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Try
            BtnEdit.Enabled = False
            BtnApply.Visible = True
            BtnSave.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ChkSubmerged_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSubmerged.CheckedChanged
        Try
            If BatchEntry = True Then
                ValidateSpecimenEntry()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnAddNew_Click(sender As Object, e As EventArgs) Handles BtnAddNew.Click, NewBatchToolStripMenuItem.Click
        Try
            Newbatch = True
            BatchTableBindingSource.AddNew()
            BatchTableTableAdapter.Update(TerraConcDataSet.BatchTable)
            AddState()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub ViewState()
        Try
            If Me.BatchTableTableAdapter.CheckQuery(PiD) > 0 Then
                ValidateSpecimenEntry()
                BtnSave.Enabled = False
                BtnCancel.Enabled = False
                BtnApply.Visible = False
                Btncalculate.Enabled = False
                BtnApply.Visible = False
                ChkSubmerged.Visible = False
            Else
                LockState()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub LockState()
        Try
            Dim B() As Control = {GrpBatch, GrpSpecimen, Grptest, GrpMove, BtnSave, BtnEdit, BtnCancel}
            For x = 0 To B.Length - 1
                B(x).Enabled = False
            Next
            BtnApply.Visible = True
            BtnAddNew.Enabled = True
            Newbatch = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub AddState()
        Try
            BtnAddNew.Enabled = False
            GrpBatch.Enabled = True
            GrpSpecimen.Enabled = False
            Grptest.Enabled = False
            BtnSave.Enabled = False
            BtnCancel.Enabled = True
            BtnApply.Visible = True
            BtnEdit.Enabled = False
            BatchIdentificationNoTextBox.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnApply_Click(sender As Object, e As EventArgs) Handles BtnApply.Click
        Try
            BtnApply.Visible = False
            ValidateBatchEntry()
            If BatchEntry = True Then ValidateSpecimenEntry()
            BtnSave.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub ValidateBatchEntry()
        Try
            h = 0
            MaxNoOfset = 10
            ToolStripbatch.Text = "Batch ID : " & BatchIdTextBox.Text
            Dim G() As Control = {BatchIdentificationNoTextBox, SupplySourceTextBox, StructuralElementComboBox, BatchDateDateTimePicker, BatchTimeTextBox, NameOfSamplerTextBox, NoOfSpecimen _
                        , MethodOfCompactionComboBox, CmbShape}
            For x = 0 To G.Length - 1
                If G(x).Text.Trim.Length = 0 Then
                    h = h + 1
                End If
            Next

            If h > 0 Then
                For x = 0 To G.Length - 1
                    If G(x).Text.Length = 0 Or G(x).Text.Trim.Length = 0 Then
                        G(x).BackColor = Color.Beige
                        Err.SetError(G(x), "This Column Cannot be blank!")
                    Else
                        G(x).BackColor = SystemColors.Window
                        Err.SetError(G(x), "")
                        Err.Icon.Dispose()
                    End If
                Next

                BatchEntry = False
                GrpSpecimen.Enabled = False
                BtnApply.Text = "Click Here to Proceed"
                BtnApply.ForeColor = Color.Red
                MessageBox.Show("Incomplete Batch Information.", "Incomplete Entry!")
                Btncalculate.Visible = False
                Exit Sub
            Else
                BtnApply.Text = "Apply"
                BtnApply.ForeColor = Color.Black
                For x = 0 To G.Length - 1
                    If G(x).Text.Trim.Length > 0 Then
                        G(x).BackColor = SystemColors.Window
                        Err.SetError(G(x), "")
                        Err.Icon.Dispose()
                    End If
                Next
            End If
            BatchEntry = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub ValidateSpecimenEntry()
        Try
            'Validate Specimen data
            Dim Diameter() As TextBox = {Specimen1DTextBox, Specimen2DTextBox, Specimen3DTextBox, Specimen4DTextBox, Specimen5DTextBox,
            Specimen6DTextBox, Specimen7DTextBox, Specimen8DTextBox, Specimen9DTextBox, Specimen10DTextBox}
            Dim Length() As TextBox = {Specimen1LTextBox, Specimen2LTextBox, Specimen3LTextBox, Specimen4LTextBox, Specimen5LTextBox _
                , Specimen6LTextBox, Specimen7LTextBox, Specimen8LTextBox, Specimen9LTextBox, Specimen10LTextBox}
            Dim Height() As TextBox = {Specimen1HTextBox, Specimen2HTextBox, Specimen3HTextBox, Specimen4HTextBox, Specimen5HTextBox _
            , Specimen6HTextBox, Specimen7HTextBox, Specimen8HTextBox, Specimen9HTextBox, Specimen10HTextBox}
            Dim Pmax() As TextBox = {MaxLoad1TextBox, MaxLoad2TextBox, MaxLoad3TextBox, MaxLoad4TextBox, MaxLoad5TextBox,
                MaxLoad6TextBox, MaxLoad7TextBox, MaxLoad8TextBox, MaxLoad9TextBox, MaxLoad10TextBox}
            Dim C() As Control = {GrpSpecimen, Grptest, GrpMove, BtnClose, BtnExitProgram}
            Dim SubMerged() As Control = {SubMergedMass1TextBox, SubMergedMass2TextBox, SubMergedMass3TextBox, SubMergedMass4TextBox, SubMergedMass5TextBox,
                SubMergedMass6TextBox, SubMergedMass7TextBox, SubMergedMass8TextBox, SubMergedMass9TextBox, SubMergedMass10TextBox}
            Dim Mass() As TextBox = {Mass1TextBox, Mass2TextBox, Mass3TextBox, Mass4TextBox, Mass5TextBox, Mass6TextBox, Mass7TextBox, Mass8TextBox, Mass9TextBox, Mass10TextBox}
            Dim A() As Label = {Area1, Area2, Area3, Area4, Area5, Area6, Area7, Area8, Area9, Area10}
            Dim Strength() As Label = {CompStrength1, CompStrength2, CompStrength3, CompStrength4, CompStrength5, CompStrength6, CompStrength7, CompStrength8, CompStrength9, CompStrength10}
            Dim Density() As Label = {Density1, Density2, Density3, Density4, Density5, Density6, Density7, Density8, Density9, Density10}
            Dim Fracture() As Control = {FractureType1, FractureType2, FractureType3, FractureType4, FractureType5, FractureType6, FractureType7, FractureType8, FractureType9, FractureType10}
            Dim SpecLabel() As Control = {Lab1, Lab2, Lab3, Lab4, Lab5, Lab6, Lab7, Lab8, Lab9, Lab10}

            'Block all Textboxes
            For x = 0 To 9
                Dim Cont() As Control = {Diameter(x), Length(x), Height(x), Pmax(x), Mass(x), A(x), Strength(x), Density(x), Fracture(x), SpecLabel(x), SubMerged(x)}
                For y = 0 To Cont.Length - 1
                    If Cont(y).Visible = True Then
                        Cont(y).Visible = False
                    End If
                Next
            Next
            GrpSpecimen.Enabled = True
            Grptest.Enabled = True
            Btncalculate.Visible = True
            BtnEdit.Enabled = True
            BtnSave.Enabled = True
            'CheckB same Dimensions
            If Newbatch = True Then
                ChkbSameDim.Visible = True

                'If ChkbSameDim.Checked = True Then
                '    CubeDim.Visible = True
                'End If
                'CubeDim.Visible = True
            End If
            'Cube Validation
            If CmbShape.SelectedIndex = 0 Then
                LblDia.Text = "Length (mm)"
                LblLen.Text = "Breadth (mm)"
                LblHgt.Text = "Width(mm)"
                LblHgt.Enabled = True
                If ChkSubmerged.Checked = True Then
                    For x = 0 To NoOfSpecimen.Value - 1
                        Dim Cont() As Control = {Diameter(x), Length(x), Height(x), Pmax(x), Mass(x), SubMerged(x), A(x), Strength(x), Density(x), Fracture(x), SpecLabel(x)}
                        For y = 0 To Cont.Length - 1
                            If Cont(y).Visible = False Then
                                Cont(y).Visible = True
                            End If
                        Next
                    Next
                Else
                    For x = 0 To NoOfSpecimen.Value - 1
                        Dim Cont() As Control = {Diameter(x), Length(x), Height(x), Pmax(x), Mass(x), A(x), Strength(x), Density(x), Fracture(x), SpecLabel(x)}
                        For y = 0 To Cont.Length - 1
                            If Cont(y).Visible = False Then
                                Cont(y).Visible = True
                            End If
                        Next
                    Next
                End If

                'Cylinder Validation
            ElseIf CmbShape.SelectedIndex = 1 Then
                LblDia.Text = "Diameter (mm)"
                LblLen.Text = "Length (mm)"
                LblHgt.Enabled = False
                If ChkSubmerged.Checked = True Then
                    For x = 0 To NoOfSpecimen.Value - 1
                        Dim Cont() As Control = {Diameter(x), Length(x), Pmax(x), Mass(x), SubMerged(x), A(x), Strength(x), Density(x), Fracture(x), SpecLabel(x)}
                        For y = 0 To Cont.Length - 1
                            If Cont(y).Visible = False Then
                                Cont(y).Visible = True
                            End If
                        Next
                    Next
                Else
                    For x = 0 To NoOfSpecimen.Value - 1
                        Dim Cont() As Control = {Diameter(x), Length(x), Pmax(x), Mass(x), A(x), Strength(x), Density(x), Fracture(x), SpecLabel(x)}
                        For y = 0 To Cont.Length - 1
                            If Cont(y).Visible = False Then
                                Cont(y).Visible = True
                            End If
                        Next

                    Next
                End If
            Else
                LblDia.Text = "Length (mm)"
                LblLen.Text = "Breadth (mm)"
                LblHgt.Text = "Width(mm)"
                LblHgt.Enabled = True
                If ChkSubmerged.Checked = True Then
                    For x = 0 To NoOfSpecimen.Value - 1
                        Dim Cont() As Control = {Diameter(x), Length(x), Height(x), Pmax(x), Mass(x), SubMerged(x), A(x), Strength(x), Density(x), Fracture(x), SpecLabel(x)}
                        For y = 0 To Cont.Length - 1
                            If Cont(y).Visible = False Then
                                Cont(y).Visible = True
                            End If
                        Next
                    Next
                Else
                    For x = 0 To NoOfSpecimen.Value - 1
                        Dim Cont() As Control = {Diameter(x), Length(x), Height(x), Pmax(x), Mass(x), A(x), Strength(x), Density(x), Fracture(x), SpecLabel(x)}
                        For y = 0 To Cont.Length - 1
                            If Cont(y).Visible = False Then
                                Cont(y).Visible = True
                            End If
                        Next
                    Next
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CmbShape_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbShape.SelectedIndexChanged
        Try
            If Newbatch = True Then
                If BatchEntry = False Then
                    Exit Sub
                Else
                    ValidateBatchEntry()
                    If BatchEntry = False Then
                        Exit Sub
                    Else
                        ValidateSpecimenEntry()

                    End If

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CubeDim_TextChanged(sender As Object, e As EventArgs) Handles CubeDim.TextChanged
        Try
            Dim Diameter() As TextBox = {Specimen1DTextBox, Specimen2DTextBox, Specimen3DTextBox, Specimen4DTextBox, Specimen5DTextBox,
            Specimen6DTextBox, Specimen7DTextBox, Specimen8DTextBox, Specimen9DTextBox, Specimen10DTextBox}
            Dim Length() As TextBox = {Specimen1LTextBox, Specimen2LTextBox, Specimen3LTextBox, Specimen4LTextBox, Specimen5LTextBox _
                , Specimen6LTextBox, Specimen7LTextBox, Specimen8LTextBox, Specimen9LTextBox, Specimen10LTextBox}
            Dim Height() As TextBox = {Specimen1HTextBox, Specimen2HTextBox, Specimen3HTextBox, Specimen4HTextBox, Specimen5HTextBox _
            , Specimen6HTextBox, Specimen7HTextBox, Specimen8HTextBox, Specimen9HTextBox, Specimen10HTextBox}

            If ChkbSameDim.Checked = True Then
                If CmbShape.SelectedIndex = 1 Then
                    For x = 0 To NoOfSpecimen.Value - 1
                        Dim Cont() As Control = {Diameter(x)}
                        For y = 0 To Cont.Length - 1
                            If Cont(y).Visible = True Then
                                Cont(y).Text = CubeDim.Text
                            End If
                        Next
                    Next
                Else
                    For x = 0 To NoOfSpecimen.Value - 1
                        Dim Cont() As Control = {Diameter(x), Length(x), Height(x)}
                        For y = 0 To Cont.Length - 1
                            If Cont(y).Visible = True Then
                                Cont(y).Text = CubeDim.Text
                            End If
                        Next
                    Next
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub LenTb_TextChanged(sender As Object, e As EventArgs) Handles LenTb.TextChanged
        Try
            Dim Length() As TextBox = {Specimen1LTextBox, Specimen2LTextBox, Specimen3LTextBox, Specimen4LTextBox, Specimen5LTextBox _
                            , Specimen6LTextBox, Specimen7LTextBox, Specimen8LTextBox, Specimen9LTextBox, Specimen10LTextBox}
            If CmbShape.SelectedIndex = 1 Then
                For x = 0 To NoOfSpecimen.Value - 1
                    Dim Cont() As Control = {Length(x)}
                    For y = 0 To Cont.Length - 1
                        If Cont(y).Visible = True Then
                            Cont(y).Text = LenTb.Text
                        End If
                    Next
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ChkbSameDim_CheckedChanged(sender As Object, e As EventArgs) Handles ChkbSameDim.CheckedChanged
        Try
            If ChkbSameDim.Checked = True Then
                If CmbShape.SelectedIndex = 1 Then
                    CubeDim.Visible = True
                    LenTb.Visible = True
                    LblDia1.Visible = True
                    LblLen1.Visible = True
                Else
                    LenTb.Visible = False
                    LblDia1.Visible = False
                    LblLen1.Visible = False
                    CubeDim.Visible = True
                End If
            Else
                LenTb.Visible = False
                LblDia1.Visible = False
                LblLen1.Visible = False
                CubeDim.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Btncalculate_Click(sender As Object, e As EventArgs) Handles Btncalculate.Click
        Try
            ValidateBatchEntry()
            If BatchEntry = True Then
                Calc()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub Calc()
        Dim Diameter() As TextBox = {Specimen1DTextBox, Specimen2DTextBox, Specimen3DTextBox, Specimen4DTextBox, Specimen5DTextBox,
            Specimen6DTextBox, Specimen7DTextBox, Specimen8DTextBox, Specimen9DTextBox, Specimen10DTextBox}
        Dim Length() As TextBox = {Specimen1LTextBox, Specimen2LTextBox, Specimen3LTextBox, Specimen4LTextBox, Specimen5LTextBox _
            , Specimen6LTextBox, Specimen7LTextBox, Specimen8LTextBox, Specimen9LTextBox, Specimen10LTextBox}
        Dim Height() As TextBox = {Specimen1HTextBox, Specimen2HTextBox, Specimen3HTextBox, Specimen4HTextBox, Specimen5HTextBox _
        , Specimen6HTextBox, Specimen7HTextBox, Specimen8HTextBox, Specimen9HTextBox, Specimen10HTextBox}
        Dim Pmax() As TextBox = {MaxLoad1TextBox, MaxLoad2TextBox, MaxLoad3TextBox, MaxLoad4TextBox, MaxLoad5TextBox,
            MaxLoad6TextBox, MaxLoad7TextBox, MaxLoad8TextBox, MaxLoad9TextBox, MaxLoad10TextBox}
        Dim C() As Control = {GrpSpecimen, Grptest, BtnFirst, BtnNext, BtnPrev, BtnLast, BtnClose, BtnExitProgram}
        Dim SubMerged() As Control = {SubMergedMass1TextBox, SubMergedMass2TextBox, SubMergedMass3TextBox, SubMergedMass4TextBox, SubMergedMass5TextBox,
            SubMergedMass6TextBox, SubMergedMass7TextBox, SubMergedMass8TextBox, SubMergedMass9TextBox, SubMergedMass10TextBox}
        Dim Mass() As TextBox = {Mass1TextBox, Mass2TextBox, Mass3TextBox, Mass4TextBox, Mass5TextBox, Mass6TextBox, Mass7TextBox, Mass8TextBox, Mass9TextBox, Mass10TextBox}
        Dim A() As Label = {Area1, Area2, Area3, Area4, Area5, Area6, Area7, Area8, Area9, Area10}
        Dim Strength() As Label = {CompStrength1, CompStrength2, CompStrength3, CompStrength4, CompStrength5, CompStrength6, CompStrength7, CompStrength8, CompStrength9, CompStrength10}
        Dim Density() As Label = {Density1, Density2, Density3, Density4, Density5, Density6, Density7, Density8, Density9, Density10}
        Dim Fracture() As Control = {FractureType1, FractureType2, FractureType3, FractureType4, FractureType5, FractureType6, FractureType7, FractureType8, FractureType9, FractureType10}
        Dim SpecLabel() As Control = {Lab1, Lab2, Lab3, Lab4, Lab5, Lab6, Lab7, Lab8, Lab9, Lab10}

        Dim area, TempArea, TempConc, TempDense, Tempmass, TempPmax, ConcStrength, AveConc, AveMass, AvePmax, Volume, dense As Double, ConCount As Integer
        Calculation = False
        Try
            For x = 0 To A.Length - 1
                If A(x).Visible = True Then
                    A(x).Text = String.Empty
                    Density(x).Text = String.Empty
                    Fracture(x).Text = String.Empty
                End If
            Next
            TestCertificateTextBox.Text = String.Empty
            h = 0
            ConCount = 0
            TempArea = 0
            TempConc = 0
            TempDense = 0
            Tempmass = 0
            TempPmax = 0
            'Cylinder Calculations
            If CmbShape.SelectedIndex = 1 Then
                If ChkSubmerged.Checked = False Then
                    For x = 0 To NoOfSpecimen.Value - 1
                        Dim EntrySet() As TextBox = {Diameter(x), Length(x), Pmax(x), Mass(x)}
                        For y = 0 To EntrySet.Length - 1
                            If EntrySet(y).Text.Trim.Length = 0 Or Not IsNumeric(EntrySet(y).Text) Then
                                h = h + 1
                                EntrySet(y).BackColor = Color.Beige
                                Err.SetError(EntrySet(y), "Incomplete Entry!")
                            Else
                                EntrySet(y).BackColor = SystemColors.Window
                                Err.SetError(EntrySet(y), "")
                                Err.Icon.Dispose()
                            End If
                        Next
                    Next
                    If h > 0 Then
                        MessageBox.Show("Enter valid Test Results!", "Invalidate Test Results.")
                        Exit Sub
                    ElseIf h = 0 Then
                        For x = 0 To NoOfSpecimen.Value - 1
                            Dim EntrySet() As TextBox = {Diameter(x), Length(x), Pmax(x), Mass(x)}
                            Dim MassValue As Double = CDbl(Mass(x).Text)
                            Dim PMaxValue As Double = CDbl(Pmax(x).Text)
                            For y = 0 To EntrySet.Length - 1
                                EntrySet(y).BackColor = SystemColors.Window
                                Err.SetError(EntrySet(y), "")
                                Err.Icon.Dispose()
                            Next
                            area = Math.Round(3.1416 * Math.Pow(CDbl(Diameter(x).Text), 2) * 0.25, 2)
                            ConcStrength = Math.Round((4000 * CDbl(Pmax(x).Text)) / (3.1416 * CDbl(Diameter(x).Text) * CDbl(Diameter(x).Text)), 2)
                            Volume = area * CDbl(Length(x).Text)
                            dense = Math.Round((4000000000 * CDbl(Mass(x).Text) / (CDbl(Length(x).Text) * CDbl(Diameter(x).Text) * CDbl(Diameter(x).Text) * 3.142)), 2)
                            Tempmass = Tempmass + MassValue
                            TempPmax = TempPmax + PMaxValue
                            TempArea = TempArea + area
                            ConCount = ConCount + 1
                            TempConc = TempConc + ConcStrength
                            TempDense = TempDense + dense
                            'Mass(x).Text = CStr(MassValue.ToString("0.00 Kg"))
                            'Pmax(x).Text = CStr(PMaxValue.ToString("0.00 KN"))
                            A(x).Text = CStr(area.ToString("0.00 m²"))
                            Density(x).Text = CStr(dense.ToString("0.00 Kg/m³"))
                            Strength(x).Text = CStr(ConcStrength.ToString("0.00 Mpa"))
                        Next
                        AveMass = Math.Round(Tempmass / ConCount, 2)
                        AvePmax = Math.Round(TempPmax / ConCount, 2)
                        AveConc = Math.Round(TempConc / ConCount, 2)
                        AveDensity.Text = CStr(Math.Round(TempDense / ConCount, 2).ToString("0.00 Kg/m³"))
                        AveStrength.Text = CStr(AveConc.ToString("0.00 Mpa"))
                        Certificate()
                        Calculation = True
                        Exit Sub
                    End If

                ElseIf ChkSubmerged.Checked = True Then
                    For x = 0 To NoOfSpecimen.Value - 1
                        Dim EntrySet() As TextBox = {Diameter(x), Length(x), Pmax(x), Mass(x), SubMerged(x)}

                        For y = 0 To EntrySet.Length - 1
                            If EntrySet(y).Text.Trim.Length = 0 Or Not IsNumeric(EntrySet(y).Text) Then
                                h = h + 1
                                EntrySet(y).BackColor = Color.Beige
                                Err.SetError(EntrySet(y), "Incomplete Entry!")
                            Else
                                EntrySet(y).BackColor = SystemColors.Window
                                Err.SetError(EntrySet(y), "")
                                Err.Icon.Dispose()
                            End If
                        Next
                    Next
                    If h > 0 Then
                        MessageBox.Show("Enter valid Test Results!", "Invalidate Test Results.")
                        Exit Sub
                    ElseIf h = 0 Then
                        For x = 0 To NoOfSpecimen.Value - 1
                            Dim EntrySet() As TextBox = {Diameter(x), Length(x), Pmax(x), Mass(x), SubMerged(x)}

                            For y = 0 To EntrySet.Length - 1
                                EntrySet(y).BackColor = SystemColors.Window
                                Err.SetError(EntrySet(y), "")
                                Err.Icon.Dispose()
                            Next
                            area = Math.Round(3.142 * Math.Pow(CDbl(Diameter(x).Text), 2) * 0.25, 2)
                            ConcStrength = Math.Round((4000 * CDbl(Pmax(x).Text)) / (3.142 * CDbl(Diameter(x).Text) * CDbl(Diameter(x).Text)), 2)
                            Volume = area * CDbl(Length(x).Text)
                            dense = Math.Round((CDbl(Mass(x).Text) * 997.5) / (CDbl(Mass(x).Text) - CDbl(SubMerged(x).Text)), 2)

                            TempArea = TempArea + area
                            ConCount = ConCount + 1
                            TempConc = TempConc + ConcStrength
                            TempDense = TempDense + dense
                            A(x).Text = CStr(area.ToString("0.00 m²"))
                            Density(x).Text = CStr(dense.ToString("0.00 Kg/m³"))
                            Strength(x).Text = CStr(ConcStrength.ToString("0.00 Mpa"))
                        Next
                        AveMass = Math.Round(Tempmass / ConCount, 2)
                        AvePmax = Math.Round(TempPmax / ConCount, 2)
                        AveConc = Math.Round(TempConc / ConCount, 2)
                        AveDensity.Text = CStr(Math.Round(TempDense / ConCount, 2).ToString("0.00 Kg/m³"))
                        AveStrength.Text = CStr(AveConc.ToString("0.00 Mpa"))
                        Certificate()
                        Calculation = True
                        Exit Sub
                    End If
                End If
            End If
            'Cube Calculations
            If CmbShape.SelectedIndex <> 1 Then
                If ChkSubmerged.Checked = False Then
                    For x = 0 To NoOfSpecimen.Value - 1
                        Dim EntrySet() As TextBox = {Diameter(x), Length(x), Height(x), Pmax(x), Mass(x)}

                        For y = 0 To EntrySet.Length - 1
                            If EntrySet(y).Text.Trim.Length = 0 Or Not IsNumeric(EntrySet(y).Text) Then
                                h = h + 1
                                EntrySet(y).BackColor = Color.Beige
                                Err.SetError(EntrySet(y), "Incomplete Entry!")
                            Else
                                EntrySet(y).BackColor = SystemColors.Window
                                Err.SetError(EntrySet(y), "")
                                Err.Icon.Dispose()
                            End If
                        Next
                    Next
                    If h > 0 Then
                        MessageBox.Show("Enter valid Test Results!", "Invalidate Test Results.")
                        Exit Sub
                    ElseIf h = 0 Then
                        For x = 0 To NoOfSpecimen.Value - 1
                            Dim EntrySet() As TextBox = {Diameter(x), Length(x), Pmax(x), Mass(x)}
                            For y = 0 To EntrySet.Length - 1
                                EntrySet(y).BackColor = SystemColors.Window
                                Err.SetError(EntrySet(y), "")
                                Err.Icon.Dispose()
                            Next
                            area = Math.Round(CDbl(Diameter(x).Text) * CDbl(Length(x).Text), 4)
                            ConcStrength = Math.Round((CDbl(Pmax(x).Text)) * 1000 / area, 3)
                            Volume = area * CDbl(Height(x).Text)
                            dense = Math.Round(CDbl(Mass(x).Text) * 1000000000 / Volume, 2)

                            TempArea = TempArea + area
                            ConCount = ConCount + 1
                            TempConc = TempConc + ConcStrength
                            TempDense = TempDense + dense
                            A(x).Text = CStr(area.ToString("0.00 mm²"))
                            Density(x).Text = CStr(dense.ToString("0.00 Kg/m³"))
                            Strength(x).Text = CStr(ConcStrength.ToString("0.00 N/mm²"))
                        Next
                        AveMass = Math.Round(Tempmass / ConCount, 2)
                        AvePmax = Math.Round(TempPmax / ConCount, 2)
                        AveConc = Math.Round(TempConc / ConCount, 2)
                        AveDensity.Text = CStr(Math.Round(TempDense / ConCount, 2).ToString("0.00 Kg/m³"))
                        AveStrength.Text = CStr(AveConc.ToString("0.00 N/mm²"))
                        Certificate()
                        Calculation = True
                        Exit Sub
                    End If
                ElseIf ChkSubmerged.Checked = True Then
                    For x = 0 To NoOfSpecimen.Value - 1
                        Dim EntrySet() As TextBox = {Diameter(x), Length(x), Height(x), Pmax(x), Mass(x), SubMerged(x)}

                        For y = 0 To EntrySet.Length - 1
                            If EntrySet(y).Text.Trim.Length = 0 Or Not IsNumeric(EntrySet(y).Text) Then
                                h = h + 1
                                EntrySet(y).BackColor = Color.Beige
                                Err.SetError(EntrySet(y), "Incomplete Entry!")
                            Else
                                EntrySet(y).BackColor = SystemColors.Window
                                Err.SetError(EntrySet(y), "")
                                Err.Icon.Dispose()
                            End If
                        Next
                    Next
                    If h > 0 Then
                        MessageBox.Show("Enter valid Test Results!", "Invalidate Test Results.")
                        Exit Sub
                    ElseIf h = 0 Then
                        For x = 0 To NoOfSpecimen.Value - 1
                            Dim EntrySet() As TextBox = {Diameter(x), Length(x), Pmax(x), Mass(x), SubMerged(x)}

                            For y = 0 To EntrySet.Length - 1
                                EntrySet(y).BackColor = SystemColors.Window
                                Err.SetError(EntrySet(y), "")
                                Err.Icon.Dispose()
                            Next
                            area = Math.Round(CDbl(Diameter(x).Text) * CDbl(Length(x).Text), 4)
                            ConcStrength = Math.Round((CDbl(Pmax(x).Text)) * 1000 / area, 3)
                            Volume = area * CDbl(Height(x).Text)
                            dense = Math.Round((CDbl(Mass(x).Text) * 997.5) / (CDbl(Mass(x).Text) - CDbl(SubMerged(x).Text)), 2)

                            TempArea = TempArea + area
                            ConCount = ConCount + 1
                            TempConc = TempConc + ConcStrength
                            TempDense = TempDense + dense
                            A(x).Text = CStr(area.ToString("0.00 mm²"))
                            Density(x).Text = CStr(dense.ToString("0.00 Kg/m³"))
                            Strength(x).Text = CStr(ConcStrength.ToString("0.00 N/mm²"))
                        Next
                        AveMass = Math.Round(Tempmass / ConCount, 2)
                        AvePmax = Math.Round(TempPmax / ConCount, 2)
                        AveConc = Math.Round(TempConc / ConCount, 2)
                        AveDensity.Text = CStr(Math.Round(TempDense / ConCount, 2).ToString("0.00 Kg/m³"))
                        AveStrength.Text = CStr(AveConc.ToString("0.00 N/mm²"))
                        Certificate()
                        Calculation = True
                        Exit Sub
                    End If
                End If
            End If

            BtnApply.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            My.Computer.Audio.Stop()
        End Try
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            SaveBatch()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub SaveBatch()
        Try
            ValidateBatchEntry()
            Dim T() As TextBox = {TestingLaboratoryTextBox, ConcreteGradeTextBox, TestedByTextBox, CheckedByTextBox, ApprovedByTextBox}
            h = 0
            For x = 0 To T.Length - 1
                If T(x).Text.Length = 0 Then h = h + 1
            Next
            If h > 0 Then
                For x = 0 To T.Length - 1
                    If T(x).Text.Length = 0 Then
                        T(x).BackColor = SystemColors.AppWorkspace
                    Else
                        T(x).BackColor = SystemColors.Window
                    End If
                Next
                MessageBox.Show("Enter Relevant Test Information !", "Incomplete Test Details!")
                Exit Sub
            Else
                For x = 0 To T.Length - 1
                    T(x).BackColor = SystemColors.Window
                Next
            End If
            If BatchEntry = True And Newbatch = True Then
                Calc()
                If Calculation = True Then
                    ProjectIDTextBox.Text = PiD
                    BatchTableBindingSource.EndEdit()
                    BatchTableTableAdapter.Update(TerraConcDataSet.BatchTable)
                    MessageBox.Show("Record Saved Successfully!", "Save Record!")
                    GrpBatch.Enabled = True
                    BtnAddNew.Enabled = True
                    BtnSave.Enabled = False
                    BtnEdit.Enabled = True
                    Newbatch = False
                Else

                    Exit Sub
                End If
            Else
                ' Access Condition
                Calc()
                If Calculation = True Then
                    ProjectIDTextBox.Text = PiD
                    BatchTableBindingSource.EndEdit()
                    BatchTableTableAdapter.Update(TerraConcDataSet.BatchTable)
                    MessageBox.Show("Record Updated Successfully!", "Save Record!")
                    GrpBatch.Enabled = True
                    BtnAddNew.Enabled = True
                    BtnSave.Enabled = False
                    BtnEdit.Enabled = True
                Else

                    Exit Sub
                End If
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            My.Computer.Audio.Stop()
        End Try
    End Sub
    Sub Certificate()
        Try
            If TestMethodComboBox.Text.Trim.Length = 0 Then
            Else
                TestCertificateTextBox.Text = "This is to certify that this test was conducted in accordance with " & TestMethodComboBox.Text
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub NoOfSpecimen_ValueChanged(sender As Object, e As EventArgs) Handles NoOfSpecimen.ValueChanged
        Try
            If Newbatch = True Then
                If BatchEntry = False Then

                Else
                    ValidateBatchEntry()
                    ValidateSpecimenEntry()

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BatchReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BatchReportToolStripMenuItem.Click
        Try
            If BatchTableTableAdapter.BatchQuery(BatchIdTextBox.Text, PiD) = 1 Then
                Dim f As New ConcreteForm
                f.Currentbatch = True
                f.PiD = ProjectIDTextBox.Text
                f.BiD = BatchIdTextBox.Text
                f.Show()
            Else
                MessageBox.Show("No valid Concrete batch.", "Batch report Error!")
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            My.Computer.Audio.Stop()
        End Try

    End Sub

    Private Sub BtnFirst_Click(sender As Object, e As EventArgs) Handles BtnFirst.Click
        Try
            ViewState()
            BatchTableBindingSource.MoveFirst()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            My.Computer.Audio.Stop()
        End Try

    End Sub

    Private Sub BtnPrev_Click(sender As Object, e As EventArgs) Handles BtnPrev.Click
        Try
            ViewState()
            BatchTableBindingSource.MovePrevious()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Try
            ViewState()
            BatchTableBindingSource.MoveNext()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnLast_Click(sender As Object, e As EventArgs) Handles BtnLast.Click
        Try
            ViewState()
            BatchTableBindingSource.MoveLast()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub CubeDim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CubeDim.KeyPress
        Try
            Dim Samedim() As TextBox = {CubeDim, LenTb}
            If e.KeyChar <> ChrW(Keys.Back) Then
                If Char.IsNumber(e.KeyChar) Or (e.KeyChar = ".") And (sender.text.indexof(".") = -1) Or e.KeyChar = ChrW(Keys.Enter) Then
                    If e.KeyChar = ChrW(Keys.Enter) Then
                        For x = 0 To Samedim.Length - 1
                            If CType(sender, TextBox).Name = Samedim(x).Name Then
                                Samedim(x + 1).Focus()
                                'e.suppresskeypress = True
                            End If
                        Next
                    End If
                Else
                    MessageBox.Show("Invalid Input! Enter Numeric data Only!", "Error Message")
                    e.Handled = True
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BatchTimeTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BatchTimeTextBox.KeyPress
        Try
            Dim ti As String = "hh:mm:ss"

            If e.KeyChar <> ChrW(Keys.Back) Then
                If Char.IsNumber(e.KeyChar) Or (e.KeyChar = ":") And (sender.text.indexof(".") = -1) Then
                    If e.KeyChar = ChrW(Keys.Enter) Then
                        NameOfSamplerTextBox.Focus()
                    End If
                Else
                    MessageBox.Show("Invalid Input! Enter Format " & ti, "Error Message")
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            My.Computer.Audio.Stop()
        End Try
    End Sub

    Private Sub BatchTableDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BatchTableDataGridView.CellContentClick, BatchTableDataGridView.CellLeave, BatchTableDataGridView.CellEnter, BatchTableDataGridView.CellDoubleClick, BatchTableDataGridView.CellContentDoubleClick, BatchTableDataGridView.CellClick
        Try
            ValidateSpecimenEntry()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub BatchForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Specimen10DTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Specimen9DTextBox.KeyPress, Specimen8DTextBox.KeyPress, Specimen7DTextBox.KeyPress, Specimen6DTextBox.KeyPress, Specimen5DTextBox.KeyPress, Specimen4DTextBox.KeyPress, Specimen3DTextBox.KeyPress, Specimen2DTextBox.KeyPress, Specimen1DTextBox.KeyPress, Specimen10DTextBox.KeyPress, Specimen9LTextBox.KeyPress, Specimen9HTextBox.KeyPress, Specimen8LTextBox.KeyPress, Specimen8HTextBox.KeyPress, Specimen7LTextBox.KeyPress, Specimen7HTextBox.KeyPress, Specimen6LTextBox.KeyPress, Specimen6HTextBox.KeyPress, Specimen5LTextBox.KeyPress, Specimen5HTextBox.KeyPress, Specimen4LTextBox.KeyPress, Specimen4HTextBox.KeyPress, Specimen3LTextBox.KeyPress, Specimen3HTextBox.KeyPress, Specimen2LTextBox.KeyPress, Specimen2HTextBox.KeyPress, Specimen1LTextBox.KeyPress, Specimen1HTextBox.KeyPress, Specimen10LTextBox.KeyPress, Specimen10HTextBox.KeyPress, SubMergedMass9TextBox.KeyPress, SubMergedMass8TextBox.KeyPress, SubMergedMass7TextBox.KeyPress, SubMergedMass6TextBox.KeyPress, SubMergedMass5TextBox.KeyPress, SubMergedMass4TextBox.KeyPress, SubMergedMass3TextBox.KeyPress, SubMergedMass2TextBox.KeyPress, SubMergedMass1TextBox.KeyPress, SubMergedMass10TextBox.KeyPress, Mass9TextBox.KeyPress, Mass8TextBox.KeyPress, Mass7TextBox.KeyPress, Mass6TextBox.KeyPress, Mass5TextBox.KeyPress, Mass4TextBox.KeyPress, Mass3TextBox.KeyPress, Mass2TextBox.KeyPress, Mass1TextBox.KeyPress, Mass10TextBox.KeyPress, MaxLoad9TextBox.KeyPress, MaxLoad8TextBox.KeyPress, MaxLoad7TextBox.KeyPress, MaxLoad6TextBox.KeyPress, MaxLoad5TextBox.KeyPress, MaxLoad4TextBox.KeyPress, MaxLoad3TextBox.KeyPress, MaxLoad2TextBox.KeyPress, MaxLoad1TextBox.KeyPress, MaxLoad10TextBox.KeyPress
        Try
            Dim Tb() As TextBox = {Specimen1DTextBox, Specimen2DTextBox, Specimen3DTextBox, Specimen4DTextBox, Specimen5DTextBox,
                    Specimen6DTextBox, Specimen7DTextBox, Specimen8DTextBox, Specimen9DTextBox, Specimen10DTextBox, Specimen1LTextBox, Specimen2LTextBox, Specimen3LTextBox, Specimen4LTextBox, Specimen5LTextBox _
                , Specimen6LTextBox, Specimen7LTextBox, Specimen8LTextBox, Specimen9LTextBox, Specimen10LTextBox, Specimen1HTextBox, Specimen2HTextBox, Specimen3HTextBox, Specimen4HTextBox, Specimen5HTextBox _
    , Specimen6HTextBox, Specimen7HTextBox, Specimen8HTextBox, Specimen9HTextBox, Specimen10HTextBox, Mass1TextBox, Mass2TextBox, Mass3TextBox, Mass4TextBox, Mass5TextBox, Mass6TextBox, Mass7TextBox, Mass8TextBox _
    , Mass9TextBox, Mass10TextBox, SubMergedMass1TextBox, SubMergedMass2TextBox, SubMergedMass3TextBox, SubMergedMass4TextBox, SubMergedMass5TextBox,
            SubMergedMass6TextBox, SubMergedMass7TextBox, SubMergedMass8TextBox, SubMergedMass9TextBox, SubMergedMass10TextBox}
            If e.KeyChar <> ChrW(Keys.Back) Then
                If Char.IsNumber(e.KeyChar) Or (e.KeyChar = ".") And (sender.text.indexof(".") = -1) Or e.KeyChar = ChrW(Keys.Enter) Then
                    If e.KeyChar = ChrW(Keys.Enter) Then
                        For x = 0 To Tb.Length - 1
                            If CType(sender, TextBox).Name = Tb(x).Name Then
                                Tb(x + 1).Focus()
                                'e.suppresskeypress = True
                            End If
                        Next
                    End If
                Else
                    MessageBox.Show("Invalid Input! Enter Numeric data Only!", "Error Message")
                    e.Handled = True
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub



    'Private Sub FractureType10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FractureType9.KeyPress, FractureType8.KeyPress, FractureType7.KeyPress, FractureType6.KeyPress, FractureType5.KeyPress, FractureType4.KeyPress, FractureType3.KeyPress, FractureType2.KeyPress, FractureType10.KeyPress, FractureType1.KeyPress
    '    Dim Loadings() As Control = {MaxLoad1TextBox, MaxLoad2TextBox, MaxLoad3TextBox, MaxLoad4TextBox, MaxLoad5TextBox,
    '        MaxLoad6TextBox, MaxLoad7TextBox, MaxLoad8TextBox, MaxLoad9TextBox, MaxLoad10TextBox, FractureType1, FractureType2 _
    '        , FractureType3, FractureType4, FractureType5, FractureType6, FractureType7, FractureType8, FractureType9, FractureType10}
    '    For x = 0 To Loadings.Length - 1
    '        If Loadings(x).Visible = True And e.KeyChar = ChrW(Keys.Enter) Then
    '            If Loadings(x + 1).Visible = True Then
    '                If CType(sender, Control).Name = Loadings(x).Name Then
    '                    Loadings(x + 1).Focus()
    '                    Loadings(x + 1).Text = String.Empty
    '                    My.Computer.Audio.Stop()
    '                End If

    '            End If
    '        End If
    '    Next
    'End Sub


    Private Sub ProjectBatchReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjectBatchReportToolStripMenuItem.Click
        Try
            Dim f As New ConcreteForm
            f.Batchall = True
            If f.Batchall = True And BatchTableTableAdapter.CheckQuery(PiD) > 0 Then
                f.PiD = ProjectIDTextBox.Text
                f.Show()
            Else
                MessageBox.Show("This Project Currently has no tested concrete specimens.", "Project Report!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub ClearBatch()
        GrpBatch.Enabled = True
        BtnApply.Text = "Apply"
        BtnApply.ForeColor = Color.Black
        Dim G() As Control = {BatchIdentificationNoTextBox, SupplySourceTextBox, StructuralElementComboBox, BatchDateDateTimePicker, BatchTimeTextBox, NameOfSamplerTextBox, NoOfSpecimen _
                  , MethodOfCompactionComboBox, CmbShape}
        For x = 0 To G.Length - 1
            G(x).BackColor = SystemColors.Window
            Err.SetError(G(x), "")
            Err.Icon.Dispose()
        Next
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Try
            If Newbatch = False And BatchTableTableAdapter.CheckQuery(PiD) > 0 Then
                BatchTableBindingSource.CancelEdit()
                TerraConcDataSet.BatchTable.RejectChanges()
                AddState()
                ClearBatch()
                Exit Sub
            Else
                ans = MessageBox.Show("You Currently have unsaved Information,are you sure you want to cancel?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If ans = DialogResult.Yes Then
                    If BatchTableTableAdapter.CheckQuery(PiD) > 0 Then
                        AddState()
                    Else
                        LockState()
                        ClearBatch()
                    End If
                    BatchTableBindingSource.CancelEdit()
                    TerraConcDataSet.BatchTable.RejectChanges()
                    Newbatch = False
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Try
            If Newbatch = False Then
                Me.Close()
                Exit Sub
            Else
                ans = MessageBox.Show("You Currently have unsaved Information,are you sure you want to quit?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If ans = DialogResult.Yes Then
                Me.Close()
            End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BtnExitProgram_Click(sender As Object, e As EventArgs) Handles BtnExitProgram.Click, ExitApplicationToolStripMenuItem.Click
        Try
            If Newbatch = False Then
                ans = MessageBox.Show("Are you sure you want to quit?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Else
                ans = MessageBox.Show("You Currently have unsaved Information,are you sure you want to quit?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            End If
            If ans = DialogResult.Yes Then
                Application.Exit()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class