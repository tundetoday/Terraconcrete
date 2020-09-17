Imports System.Management
Public Class UsersForm
    Public Property User As String
    Dim a As Integer

    Private Sub UsersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.UserstableTableAdapter.Fill(Me.TerraConcDataSet.Userstable)
            DefaultState()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BtnAddNew_Click(sender As Object, e As EventArgs) Handles BtnAddNew.Click
        Try
            If CmbStatus.Text <> "Admin" Then
                MessageBox.Show("You need to be an Admin to Add a user.Contact Admin.", "Admin Role!")
                Exit Sub
            Else
                EditState()
                UserstableBindingSource.AddNew()
                'UserIDTextBox.Text = UserstableTableAdapter.maxQuery() + 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click
        Try
            Dim C() As Control = {TbTitle, TbFN, TbLN, TbUN, Tbpassword, CmbStatus}
            a = 0
            For x = 0 To C.Length - 1
                If C(x).Text.Length = 0 Or C(x).Text = " " Then
                    a = a + 1
                End If
            Next
            If a > 0 Then
                For x = 0 To C.Length - 1
                    If C(x).Text.Length = 0 Or C(x).Text = " " Then
                        C(x).BackColor = Color.Beige

                    Else
                        C(x).BackColor = SystemColors.Window
                        Err.Icon.Dispose()
                    End If
                Next
                MessageBox.Show("Invalid User Profile.", "Input Valid Credentials!")
                Exit Sub
            End If
            'Dim AddPix As DialogResult = MessageBox.Show("Do you want to Add user Picture ?", "User Picture!", MessageBoxButtons.YesNo)
            'If AddPix = DialogResult.Yes Then

            'If UserstableTableAdapter.CheckQuery(CInt(UserIDTextBox.Text)) = 0 Then
            '    UserstableBindingSource.EndEdit()
            '    UserstableTableAdapter.InsertQuery(TbTitle.Text, TbFN.Text, TbLN.Text, TbUN.Text, Tbpassword.Text, CmbStatus.Text, IO.File.ReadAllBytes(UserPicture.ImageLocation))
            '    MessageBox.Show("Your Profile has been Created Successfully", "Add User")
            'Else

            UserstableBindingSource.EndEdit()
            'UserstableTableAdapter.UpdateQuery(TbTitle.Text, TbFN.Text, TbLN.Text, Tbpassword.Text, TbUN.Text, CmbStatus.Text, IO.File.ReadAllBytes(UserPicture.ImageLocation), UserIDTextBox.Text)
            UserstableTableAdapter.Update(TerraConcDataSet.Userstable)
            MessageBox.Show("User Updated Successfully", "Add User")
            'End If

            'Else
            '    UserstableBindingSource.EndEdit()
            '    UserstableTableAdapter.UpdateU(TbTitle.Text, TbFN.Text, TbLN.Text, Tbpassword.Text, TbUN.Text, CmbStatus.Text, UserIDTextBox.Text)
            '    MessageBox.Show("User Updated Successfully", "Add User")
            'End If
            DefaultState()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Try
            'Dim ans As DialogResult = MessageBox.Show(TbUN.Text & " ,Login UnSuccessful!", "Login Status!", MessageBoxButtons.RetryCancel)
            Dim ans As DialogResult = MessageBox.Show("Are you sure you want to quit?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If ans = DialogResult.Yes Then
                Me.Close()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnBrowseImage_Click(sender As Object, e As EventArgs) Handles BtnBrowseImage.Click
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        BtnBrowseImage.Enabled = False
        OpenFileDialg.FileName = ""
        OpenFileDialg.ShowDialog()
        If OpenFileDialg.FileName = "" Then
            MessageBox.Show("Open File Location", "No Image Selected!")
            Exit Sub
        Else
            OpenFileDialg.FileName = OpenFileDialg.FileName
            'UserPicture.ImageLocation = OpenFileDialg.FileName
            UserPicture.Image = Image.FromFile(OpenFileDialg.FileName)
        End If
        'Else
        '    Exit Sub
        'End If
    End Sub
    Sub Login()
        Try
            If TbPass.Text = "" Then
                MessageBox.Show("Invalid Password,Enter Valid Password!", "Logon Status!")
                User = TbFN.Text & " ," & TbLN.Text
            ElseIf TbPass.Text = Tbpassword.Text Then
                MessageBox.Show("Login Successful!", "Logon Status!")
                User = TbFN.Text & " ," & TbLN.Text
                TbPass.Clear()
                Dim p As New ProjectForm
                p.ShowDialog()
            Else
                Dim ans As DialogResult = MessageBox.Show(TbUN.Text & " ,Login UnSuccessful!", "Login Status!", MessageBoxButtons.RetryCancel)
                TbPass.Text = String.Empty
                If DialogResult.Retry Then
                Else
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Try
            TbPass.Visible = True
            Login()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Try
            Dim C() As Control = {TbTitle, TbFN, TbLN, TbUN, Tbpassword, CmbStatus}

            For x = 0 To C.Length - 1
                C(x).BackColor = SystemColors.Window
            Next
            Err.Clear()
            UserstableBindingSource.CancelEdit()
            TerraConcDataSet.Userstable.RejectChanges()
            UserstableBindingSource.Sort = "Userid"
            'MessageBox.Show("Cancel Successful !", "Cancel Status")
            DefaultState()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        EditState()

        '    TbPass.Clear()
        'Else
        '    MessageBox.Show("Log in to Edit Profile!", "Edit Status!")
        'End If


    End Sub
    Sub DefaultState()
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        UserstableBindingSource.Sort = "Userid"
        TbPass.Text = ""
        TbTitle.ReadOnly = True
        TbFN.ReadOnly = True
        TbLN.ReadOnly = True
        TbUN.ReadOnly = True
        Tbpassword.Visible = False
        BtnLogin.Enabled = True
        BtnEdit.Enabled = True
        BtnClose.Enabled = True
        BtnAddNew.Enabled = True
        CmbStatus.Enabled = False
        Btnsave.Visible = False
        BtnCancel.Visible = False
        BtnBrowseImage.Visible = False
    End Sub
    Sub EditState()
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        BtnAddNew.Enabled = False
        BtnLogin.Enabled = False
        BtnEdit.Enabled = False
        BtnClose.Enabled = False
        TbPass.Visible = False
        TbTitle.ReadOnly = False
        TbFN.ReadOnly = False
        TbLN.ReadOnly = False
        TbUN.ReadOnly = False
        Tbpassword.Visible = True
        Btnsave.Visible = True
        BtnCancel.Visible = True
        BtnBrowseImage.Visible = True
        CmbStatus.Enabled = True
        BtnBrowseImage.Enabled = True
        TbPass.Focus()
    End Sub
    Private Sub UserstableDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UserstableDataGridView.CellContentClick
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        DefaultState()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        Dim Op() As TextBox = {TbCompName, TbCompUserName, TbCapsLockOn, TbOpSystem, TbWrkArea}
        For x = 0 To Op.Length - 1
            Op(x).Clear()
        Next
    End Sub

    Private Sub BtnCompInfo_Click(sender As Object, e As EventArgs) Handles BtnCompInfo.Click
        Dim q As New SelectQuery("Win32_bios")
        Dim search As New ManagementObjectSearcher(q)
        Dim info As New ManagementObject
        Dim SN As String = ""
        For Each info In search.Get
            'MessageBox.Show("Serial Number : " & info("Serialnumber").ToString)
            SN = SN + info("Serialnumber").ToString
        Next
        'MXL7312F9V
        'A6336076545CV6
        TbCompName.Text = sn
        TbCompUserName.Text = My.User.Name
        TbOpSystem.Text = My.Computer.Info.OSFullName
        TbCapsLockOn.Text = My.Computer.Keyboard.CapsLock
        TbWrkArea.Text = My.Computer.Screen.WorkingArea.ToString

        'computer code
        Dim er As Integer = SN.Length
        Dim Cc
        For x = 0 To SN.Length - 1
            If Char.IsNumber(SN.Substring(x, 1)) Then
                Cc = Chr(65 + SN.Substring(x, 1))
            Else
                Cc = Asc("SN.Substring(x, 1)")

            End If
            MessageBox.Show(SN.Substring(x, 1))
            MessageBox.Show(Cc)

            TbCompcode.Text = TbCompcode.Text + Cc.ToString

        Next

    End Sub
    Sub RegCode()

    End Sub
End Class