Imports System.IO
Public Class ProjectForm
    Dim Newproject, Valid As Boolean, y As Integer, Ans As String
    Private Sub ProjectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Me.ProjectsTableTableAdapter.Fill(Me.TerraConcDataSet.ProjectsTable) = 0 Then
                Lockstate()
            Else
                Me.ProjectsTableTableAdapter.Fill(Me.TerraConcDataSet.ProjectsTable)
                Defaultsate()
            End If
            ToolStripLabel1.Text = "Current User : " & UsersForm.User
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error !")
        End Try
    End Sub

    Private Sub BtnAddNew_Click(sender As Object, e As EventArgs) Handles BtnAddNew.Click, NewProjectToolStripMenuItem.Click
        Try

            Newproject = True
            EditState()
            ProjectsTableBindingSource.AddNew()
            ProjectsTableTableAdapter.Update(TerraConcDataSet.ProjectsTable)
            ProjectsTableBindingSource.Sort = "projectId"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click, ExitApplicationToolStripMenuItem.Click
        Try
            If Newproject = False Then
                Me.Close()
                Exit Sub
            Else
                Ans = MessageBox.Show("You Currently have unsaved Information,are you sure you want to quit?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If Ans = DialogResult.Yes Then
                    Me.Close()

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            Dim c() As Control = {PlotNoTextBox, ProjectNameTextBox, ProjectAddressTextBox, CityTextBox, StateTextBox, CountryTextBox, ClientNameTextBox,
                ClientAddressTextBox, ContactPersonTextBox, ContactPhoneNoTextBox, ContactEmailTextBox, StructureTypeComboBox}
            y = 0

            For x = 0 To c.Length - 1
                If c(x).Text.Length = 0 Then y = y + 1
            Next
            If y > 0 Then
                For x = 0 To c.Length - 1
                    If c(x).Text.Length = 0 Or c(x).Text.Trim = " " Then
                        c(x).BackColor = SystemColors.AppWorkspace
                    Else
                        c(x).BackColor = SystemColors.Window
                    End If
                Next
                MessageBox.Show("Enter Relevant Project Information !", "Incomplete Project Details!")
                Exit Sub
            Else
                For x = 0 To c.Length - 1
                    c(x).BackColor = SystemColors.Window
                Next
                ProjectsTableBindingSource.EndEdit()
                ProjectsTableTableAdapter.Update(TerraConcDataSet.ProjectsTable)
                MessageBox.Show("Save Successful !", "Save Status")
                ProjectsTableBindingSource.Sort = "projectId"
            End If
            Defaultsate()

            Newproject = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ViewBatchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewBatchToolStripMenuItem.Click
        ShowBatch()
    End Sub
    Sub ShowBatch()
        Try
            If Not IsNumeric(ProjectIDTextBox.Text) Then
                MessageBox.Show("Select Valid Project.", "Project Error!")
            Else
                Dim f As New BatchForm
                f.PiD = CInt(ProjectIDTextBox.Text)
                f.ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub BtnShowBatch_Click(sender As Object, e As EventArgs) Handles BtnShowBatch.Click, ProjectsTableDataGridView.DoubleClick
        ShowBatch()
    End Sub

    Private Sub ProjectReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjectReportToolStripMenuItem.Click
        Try
            If Me.ProjectsTableTableAdapter.Fill(Me.TerraConcDataSet.ProjectsTable) = 0 Then
                MessageBox.Show("No Projects Currently.", "Report error!")
            Else
                Dim f As New ConcreteForm
                f.AllProjects = True
                f.Show()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnUserProfile_Click(sender As Object, e As EventArgs)
        Dim f As New UsersForm
        f.ShowDialog()
    End Sub
    Private Sub AllProjectsReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllProjectsReportToolStripMenuItem.Click
        Try
            If Me.ProjectsTableTableAdapter.Fill(Me.TerraConcDataSet.ProjectsTable) = 0 Or Not IsNumeric(ProjectIDTextBox.Text) Then
                MessageBox.Show("No  Project Selected.", "Report error!")
            ElseIf BatchTableTableAdapter.CheckQuery(ProjectIDTextBox.Text) > 0 Then
                Dim f As New ConcreteForm
                f.Batchall = True
                f.PiD = ProjectIDTextBox.Text
                f.Show()
            Else
                MessageBox.Show("This Project Currently has no tested concrete specimens.", "Project Report!")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Try
            If Newproject = True And Me.ProjectsTableTableAdapter.Fill(Me.TerraConcDataSet.ProjectsTable) = 0 Then
                Lockstate()
            ElseIf Me.ProjectsTableTableAdapter.Fill(Me.TerraConcDataSet.ProjectsTable) = 0 Then
                Lockstate()

            ElseIf Me.ProjectsTableTableAdapter.Fill(Me.TerraConcDataSet.ProjectsTable) > 0 Then
                Defaultsate()
                ProjectsTableBindingSource.CancelEdit()
                TerraConcDataSet.ProjectsTable.RejectChanges()
                ProjectsTableBindingSource.Sort = "projectId"
                Dim c() As Control = {PlotNoTextBox, ProjectNameTextBox, ProjectAddressTextBox, CityTextBox, StateTextBox, CountryTextBox, ClientNameTextBox,
               ClientAddressTextBox, ContactPersonTextBox, ContactPhoneNoTextBox, ContactEmailTextBox, StructureTypeComboBox}
                For x = 0 To c.Length - 1
                    c(x).BackColor = SystemColors.Window
                Next
            End If
            Newproject = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    Sub Defaultsate()
        Try
            Dim c() As Control = {SplitContainer1.Panel1, BtnCancel, MenuStrip1, BtnAddNew, BtnShowBatch, ProjectsTableDataGridView, BtnEdit, ProjectsTableBindingNavigator}
            For x = 0 To c.Length - 1
                c(x).Enabled = True
            Next
            BtnSave.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub StructureTypeTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StateTextBox.KeyPress, ProjectStartDateTimePicker.KeyPress, ProjectNameTextBox.KeyPress, ProjectEndDateTimePicker.KeyPress, ProjectAddressTextBox.KeyPress, PlotNoTextBox.KeyPress, CountryTextBox.KeyPress, ContactPhoneNoTextBox.KeyPress, ContactPersonTextBox.KeyPress, ContactEmailTextBox.KeyPress, ClientNameTextBox.KeyPress, ClientAddressTextBox.KeyPress, CityTextBox.KeyPress
        Try
            Dim c() As Control = {PlotNoTextBox, ProjectNameTextBox, ProjectAddressTextBox, CityTextBox, StateTextBox, CountryTextBox, ClientNameTextBox,
               ClientAddressTextBox, ContactPersonTextBox, ContactPhoneNoTextBox, ContactEmailTextBox, ProjectStartDateTimePicker, ProjectEndDateTimePicker, StructureTypeComboBox}
            For x = 0 To c.Length - 1
                If e.KeyChar = ChrW(Keys.Enter) Then
                    If CType(sender, Control).Name = c(x).Name Then
                        c(x + 1).Focus()
                        c(x + 1).Text = String.Empty
                        My.Computer.Audio.Stop()
                    End If
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Try
            EditState()
            BtnEdit.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub EditState()
        Try
            Dim c() As Control = {ProjectsTableBindingNavigator, ProjectsTableDataGridView, BtnAddNew, MenuStrip1, BtnEdit, BtnShowBatch}

            For x = 0 To c.Length - 1
                c(x).Enabled = False
            Next
            Dim d() As Control = {SplitContainer1.Panel1, BtnSave, BtnCancel}
            For x = 0 To d.Length - 1
                d(x).Enabled = True
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub Lockstate()
        Dim c() As Control = {SplitContainer1.Panel1, BtnCancel, BtnSave, BtnShowBatch, ProjectsTableDataGridView, BtnEdit,
                                   ProjectsTableBindingNavigator}
        For x = 0 To c.Length - 1
            c(x).Enabled = False
        Next
        MenuStrip1.Enabled = True
        BtnAddNew.Enabled = True
    End Sub
    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        Try
            If Trim(SearchComboBox.Text).Length = 0 Then
                SearchComboBox.Focus()
                SearchComboBox.BackColor = Color.Beige
                SearchComboBox.ToolTipText = "Enter Valid Searh Text"
                MessageBox.Show("Select Search Criteria.", "Selection required!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                SearchComboBox.BackColor = SystemColors.Window
            End If

            If Trim(SearchTextBox.Text).Length = 0 Then
                SearchTextBox.Focus()
                SearchTextBox.ToolTipText = "Enter Valid Searh Text"
                SearchTextBox.BackColor = Color.Beige
                MessageBox.Show("Enter search Text", "Enter Text!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                SearchTextBox.BackColor = SystemColors.Window
            End If

            Select Case SearchComboBox.SelectedIndex
                Case 0 'Project Name
                    If ProjectsTableTableAdapter.FillByPname(Me.TerraConcDataSet.ProjectsTable, SearchTextBox.Text) = 0 Then
                        MessageBox.Show("Search Text not found.", "Search Results!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.ProjectsTableTableAdapter.Fill(Me.TerraConcDataSet.ProjectsTable)
                    Else
                        ProjectsTableTableAdapter.FillByPname(Me.TerraConcDataSet.ProjectsTable, SearchTextBox.Text)
                    End If
                Case 1 'Project Address
                    ProjectsTableTableAdapter.FillByPLcn(Me.TerraConcDataSet.ProjectsTable, SearchTextBox.Text)
                Case 2 'City
                    ProjectsTableTableAdapter.FillByCity(Me.TerraConcDataSet.ProjectsTable, SearchTextBox.Text)
                Case 3 'Country
                    ProjectsTableTableAdapter.FillByCountry(Me.TerraConcDataSet.ProjectsTable, SearchTextBox.Text)

                Case 4 'CName
                    ProjectsTableTableAdapter.FillByCName(Me.TerraConcDataSet.ProjectsTable, SearchTextBox.Text)
                Case 5 'Date Completed
                    ProjectsTableTableAdapter.FillByPStart(Me.TerraConcDataSet.ProjectsTable, SearchTextBox.Text)
                    'Case 6 'Jref
                    '    ProjectsTableTableAdapter.FillByJref(Me.TerraConcDataSet.ProjectsTable, SearchTextBox.Text)
            End Select
            SearchComboBox.Text = String.Empty
            SearchTextBox.Text = String.Empty
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Search Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripLabel_Click(sender As Object, e As EventArgs) Handles ToolStripLabel.Click
        Try
            SearchComboBox.Text = String.Empty
            SearchTextBox.Text = String.Empty
            Me.ProjectsTableTableAdapter.Fill(Me.TerraConcDataSet.ProjectsTable)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error !")
        End Try
    End Sub
    Private Sub BtnCloseApp_Click(sender As Object, e As EventArgs) Handles BtnClose.Click, ExitApplicationToolStripMenuItem.Click, BtnCloseApp.Click
        Try
            Dim ans As DialogResult = MessageBox.Show("Are you sure you want to quit?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If ans = DialogResult.Yes Then
                Application.Exit()
            Else
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error !")
        End Try
    End Sub
End Class
