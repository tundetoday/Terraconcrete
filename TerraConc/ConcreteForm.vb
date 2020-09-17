Imports System.Windows.Forms
Imports Microsoft.Reporting.WinForms
Public Class ConcreteForm
    Public Property AllProjects As Boolean
    Public Property Batchall As Boolean
    Public Property BiD As Integer
    Public Property PiD As Integer
    Public Property Currentbatch As Boolean
    Dim Ans As String

    Private Sub ConcreteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            If AllProjects = True Then
                Me.ProjectsTableTableAdapter.Fill(TerraConcDataSet.ProjectsTable)
                Me.Controls.Add(ReportViewer1)
                ReportViewer1.Reset()
                ReportViewer1.Size = Me.Size
                Dim P As DataTable
                Me.ReportViewer1.LocalReport.DataSources.Clear()
                Me.ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\ProjectReport.rdlc"
                'Me.ReportViewer1.LocalReport.ReportPath = "C:\Program Files\Dev\TerraConc\TerraConc\ProjectReport.rdlc"
                P = Me.TerraConcDataSet.Tables("ProjectsTable")
                Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("Projects", P))

                ReportViewer1.RefreshReport()

            End If
            If Currentbatch = True Then
                Me.TableJoinTableAdapter.FillBy(Me.TerraConcDataSet.TableJoin, PiD, BiD)
                Me.Controls.Add(ReportViewer1)
                ReportViewer1.Reset()
                ReportViewer1.Size = Me.Size
                Dim P As DataTable
                Me.ReportViewer1.LocalReport.DataSources.Clear()
                'Me.ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\ConcreteReport.rdlc"
                Me.ReportViewer1.LocalReport.ReportPath = "C:\Program Files\Dev\TerraConc\TerraConc\ConcreteReport.rdlc"
                P = Me.TerraConcDataSet.Tables("TableJoin")
                Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("ConcData", P))
                ReportViewer1.RefreshReport()
            End If
            If Batchall() = True Then
                Me.TableJoinTableAdapter.Fill(Me.TerraConcDataSet.TableJoin, PiD)
                Me.Controls.Add(ReportViewer1)
                ReportViewer1.Reset()
                ReportViewer1.Size = Me.Size
                Dim P As DataTable
                Me.ReportViewer1.LocalReport.DataSources.Clear()
                'Me.ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\ConcreteReport.rdlc"
                Me.ReportViewer1.LocalReport.ReportPath = "C:\Program Files\Dev\TerraConc\TerraConc\ConcreteReport.rdlc"
                P = Me.TerraConcDataSet.Tables("TableJoin")
                Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("ConcData", P))
                ReportViewer1.RefreshReport()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR!")
        End Try

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnCloseAll_Click(sender As Object, e As EventArgs) Handles BtnCloseAll.Click
        Try
            ans = MessageBox.Show("You Currently have unsaved Information,are you sure you want to quit?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If ans = DialogResult.Yes Then
                Me.Close()
                UsersForm.Close()

            End If
            Me.Close()
            ProjectForm.Close()
        Catch ex As Exception

        End Try

    End Sub


End Class