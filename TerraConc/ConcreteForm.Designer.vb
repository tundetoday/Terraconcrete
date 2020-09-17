<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConcreteForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConcreteForm))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TerraConcDataSet = New TerraConc.TerraConcDataSet()
        Me.ProjectsTableTableAdapter = New TerraConc.TerraConcDataSetTableAdapters.ProjectsTableTableAdapter()
        Me.TableAdapterManager = New TerraConc.TerraConcDataSetTableAdapters.TableAdapterManager()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnCloseAll = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.TableJoinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableJoinTableAdapter = New TerraConc.TerraConcDataSetTableAdapters.TableJoinTableAdapter()
        Me.BatchTableTableAdapter = New TerraConc.TerraConcDataSetTableAdapters.BatchTableTableAdapter()
        CType(Me.TerraConcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TableJoinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer1.TabIndex = 0
        '
        'TerraConcDataSet
        '
        Me.TerraConcDataSet.DataSetName = "TerraConcDataSet"
        Me.TerraConcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProjectsTableTableAdapter
        '
        Me.ProjectsTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BatchTableTableAdapter = Nothing
        Me.TableAdapterManager.ProjectsTableTableAdapter = Me.ProjectsTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = TerraConc.TerraConcDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserstableTableAdapter = Nothing
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.BtnCloseAll)
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 692)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(692, 38)
        Me.Panel1.TabIndex = 0
        '
        'BtnCloseAll
        '
        Me.BtnCloseAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCloseAll.Location = New System.Drawing.Point(335, 8)
        Me.BtnCloseAll.Name = "BtnCloseAll"
        Me.BtnCloseAll.Size = New System.Drawing.Size(103, 23)
        Me.BtnCloseAll.TabIndex = 102
        Me.BtnCloseAll.Text = "Exit Application"
        Me.BtnCloseAll.UseVisualStyleBackColor = True
        Me.BtnCloseAll.Visible = False
        '
        'BtnClose
        '
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.Location = New System.Drawing.Point(254, 8)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 101
        Me.BtnClose.Text = "Cl&ose"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'TableJoinBindingSource
        '
        Me.TableJoinBindingSource.DataMember = "TableJoin"
        Me.TableJoinBindingSource.DataSource = Me.TerraConcDataSet
        '
        'TableJoinTableAdapter
        '
        Me.TableJoinTableAdapter.ClearBeforeFill = True
        '
        'BatchTableTableAdapter
        '
        Me.BatchTableTableAdapter.ClearBeforeFill = True
        '
        'ConcreteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(692, 730)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConcreteForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Concrete Report"
        Me.TopMost = True
        CType(Me.TerraConcDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.TableJoinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TerraConcDataSet As TerraConcDataSet
    Friend WithEvents ProjectsTableTableAdapter As TerraConcDataSetTableAdapters.ProjectsTableTableAdapter


    Friend WithEvents TableAdapterManager As TerraConcDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnCloseAll As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents TableJoinBindingSource As BindingSource
    Friend WithEvents TableJoinTableAdapter As TerraConcDataSetTableAdapters.TableJoinTableAdapter
    Friend WithEvents BatchTableTableAdapter As TerraConcDataSetTableAdapters.BatchTableTableAdapter
End Class
