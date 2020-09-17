<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsersForm
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
        Dim UserIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsersForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.CmbStatus = New System.Windows.Forms.ComboBox()
        Me.UserstableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TerraConcDataSet = New TerraConc.TerraConcDataSet()
        Me.UserPicture = New System.Windows.Forms.PictureBox()
        Me.Btnsave = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Tbpassword = New System.Windows.Forms.TextBox()
        Me.TbLN = New System.Windows.Forms.TextBox()
        Me.BtnBrowseImage = New System.Windows.Forms.Button()
        Me.LblLN = New System.Windows.Forms.Label()
        Me.TbFN = New System.Windows.Forms.TextBox()
        Me.LblFN = New System.Windows.Forms.Label()
        Me.TbTitle = New System.Windows.Forms.TextBox()
        Me.LabelDesig = New System.Windows.Forms.Label()
        Me.TbPass = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbUN = New System.Windows.Forms.TextBox()
        Me.LblUername = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnAddNew = New System.Windows.Forms.Button()
        Me.UserstableTableAdapter = New TerraConc.TerraConcDataSetTableAdapters.UserstableTableAdapter()
        Me.UserstableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.UserstableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.UserstableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpenFileDialg = New System.Windows.Forms.OpenFileDialog()
        Me.UserIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.Err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TableAdapterManager = New TerraConc.TerraConcDataSetTableAdapters.TableAdapterManager()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnCompInfo = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.TbWrkArea = New System.Windows.Forms.TextBox()
        Me.TbCapsLockOn = New System.Windows.Forms.TextBox()
        Me.TbOpSystem = New System.Windows.Forms.TextBox()
        Me.TbCompUserName = New System.Windows.Forms.TextBox()
        Me.TbCompName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TbCompcode = New System.Windows.Forms.TextBox()
        Me.TbRegCode = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BtnReg = New System.Windows.Forms.Button()
        Me.Btnlater = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        UserIDLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.UserstableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TerraConcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserstableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserstableBindingNavigator.SuspendLayout()
        CType(Me.UserstableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Err, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserIDLabel
        '
        UserIDLabel.AutoSize = True
        UserIDLabel.Location = New System.Drawing.Point(359, 224)
        UserIDLabel.Name = "UserIDLabel"
        UserIDLabel.Size = New System.Drawing.Size(46, 13)
        UserIDLabel.TabIndex = 34
        UserIDLabel.Text = "User ID:"
        UserIDLabel.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnCancel)
        Me.Panel1.Controls.Add(Me.CmbStatus)
        Me.Panel1.Controls.Add(Me.UserPicture)
        Me.Panel1.Controls.Add(Me.Btnsave)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Tbpassword)
        Me.Panel1.Controls.Add(Me.TbLN)
        Me.Panel1.Controls.Add(Me.BtnBrowseImage)
        Me.Panel1.Controls.Add(Me.LblLN)
        Me.Panel1.Controls.Add(Me.TbFN)
        Me.Panel1.Controls.Add(Me.LblFN)
        Me.Panel1.Controls.Add(Me.TbTitle)
        Me.Panel1.Controls.Add(Me.LabelDesig)
        Me.Panel1.Location = New System.Drawing.Point(531, 271)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(395, 159)
        Me.Panel1.TabIndex = 0
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(317, 57)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(62, 23)
        Me.BtnCancel.TabIndex = 40
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        Me.BtnCancel.Visible = False
        '
        'CmbStatus
        '
        Me.CmbStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserstableBindingSource, "Status", True))
        Me.CmbStatus.FormattingEnabled = True
        Me.CmbStatus.Items.AddRange(New Object() {"Admin", "User"})
        Me.CmbStatus.Location = New System.Drawing.Point(80, 133)
        Me.CmbStatus.Name = "CmbStatus"
        Me.CmbStatus.Size = New System.Drawing.Size(98, 21)
        Me.CmbStatus.TabIndex = 17
        Me.CmbStatus.Visible = False
        '
        'UserstableBindingSource
        '
        Me.UserstableBindingSource.DataMember = "Userstable"
        Me.UserstableBindingSource.DataSource = Me.TerraConcDataSet
        '
        'TerraConcDataSet
        '
        Me.TerraConcDataSet.DataSetName = "TerraConcDataSet"
        Me.TerraConcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserPicture
        '
        Me.UserPicture.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.UserstableBindingSource, "UserPhoto", True))
        Me.UserPicture.Location = New System.Drawing.Point(188, 10)
        Me.UserPicture.Name = "UserPicture"
        Me.UserPicture.Size = New System.Drawing.Size(123, 144)
        Me.UserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.UserPicture.TabIndex = 12
        Me.UserPicture.TabStop = False
        Me.UserPicture.Visible = False
        '
        'Btnsave
        '
        Me.Btnsave.Location = New System.Drawing.Point(317, 27)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(62, 23)
        Me.Btnsave.TabIndex = 18
        Me.Btnsave.Text = "Save"
        Me.Btnsave.UseVisualStyleBackColor = True
        Me.Btnsave.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 137)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Status:"
        Me.Label8.Visible = False
        '
        'Tbpassword
        '
        Me.Tbpassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserstableBindingSource, "Password", True))
        Me.Tbpassword.Location = New System.Drawing.Point(80, 110)
        Me.Tbpassword.Name = "Tbpassword"
        Me.Tbpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Tbpassword.Size = New System.Drawing.Size(100, 20)
        Me.Tbpassword.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.Tbpassword, "Enter User Password")
        '
        'TbLN
        '
        Me.TbLN.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserstableBindingSource, "LastName", True))
        Me.TbLN.Location = New System.Drawing.Point(80, 60)
        Me.TbLN.Name = "TbLN"
        Me.TbLN.Size = New System.Drawing.Size(100, 20)
        Me.TbLN.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.TbLN, "Enter last Name")
        Me.TbLN.Visible = False
        '
        'BtnBrowseImage
        '
        Me.BtnBrowseImage.Location = New System.Drawing.Point(317, 86)
        Me.BtnBrowseImage.Name = "BtnBrowseImage"
        Me.BtnBrowseImage.Size = New System.Drawing.Size(62, 23)
        Me.BtnBrowseImage.TabIndex = 16
        Me.BtnBrowseImage.Text = "Add Image"
        Me.BtnBrowseImage.UseVisualStyleBackColor = True
        Me.BtnBrowseImage.Visible = False
        '
        'LblLN
        '
        Me.LblLN.AutoSize = True
        Me.LblLN.Location = New System.Drawing.Point(12, 62)
        Me.LblLN.Name = "LblLN"
        Me.LblLN.Size = New System.Drawing.Size(64, 13)
        Me.LblLN.TabIndex = 4
        Me.LblLN.Text = "Last Name :"
        Me.LblLN.Visible = False
        '
        'TbFN
        '
        Me.TbFN.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserstableBindingSource, "FirstName", True))
        Me.TbFN.Location = New System.Drawing.Point(80, 35)
        Me.TbFN.Name = "TbFN"
        Me.TbFN.Size = New System.Drawing.Size(100, 20)
        Me.TbFN.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.TbFN, "Enter User First Name")
        Me.TbFN.Visible = False
        '
        'LblFN
        '
        Me.LblFN.AutoSize = True
        Me.LblFN.Location = New System.Drawing.Point(12, 37)
        Me.LblFN.Name = "LblFN"
        Me.LblFN.Size = New System.Drawing.Size(63, 13)
        Me.LblFN.TabIndex = 2
        Me.LblFN.Text = "First Name :"
        Me.LblFN.Visible = False
        '
        'TbTitle
        '
        Me.TbTitle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserstableBindingSource, "Designation", True))
        Me.TbTitle.Location = New System.Drawing.Point(80, 10)
        Me.TbTitle.Name = "TbTitle"
        Me.TbTitle.Size = New System.Drawing.Size(100, 20)
        Me.TbTitle.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.TbTitle, "Enter Title")
        Me.TbTitle.Visible = False
        '
        'LabelDesig
        '
        Me.LabelDesig.AutoSize = True
        Me.LabelDesig.Location = New System.Drawing.Point(12, 12)
        Me.LabelDesig.Name = "LabelDesig"
        Me.LabelDesig.Size = New System.Drawing.Size(33, 13)
        Me.LabelDesig.TabIndex = 0
        Me.LabelDesig.Text = "Title :"
        Me.LabelDesig.Visible = False
        '
        'TbPass
        '
        Me.TbPass.Location = New System.Drawing.Point(265, 74)
        Me.TbPass.Name = "TbPass"
        Me.TbPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbPass.Size = New System.Drawing.Size(100, 20)
        Me.TbPass.TabIndex = 39
        Me.ToolTip1.SetToolTip(Me.TbPass, "Enter User Password")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(197, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Password:"
        '
        'TbUN
        '
        Me.TbUN.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserstableBindingSource, "UserName", True))
        Me.TbUN.Location = New System.Drawing.Point(265, 49)
        Me.TbUN.Name = "TbUN"
        Me.TbUN.Size = New System.Drawing.Size(100, 20)
        Me.TbUN.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.TbUN, "Enter User Name,5 minimum characters recommended.")
        '
        'LblUername
        '
        Me.LblUername.AutoSize = True
        Me.LblUername.Location = New System.Drawing.Point(197, 51)
        Me.LblUername.Name = "LblUername"
        Me.LblUername.Size = New System.Drawing.Size(66, 13)
        Me.LblUername.TabIndex = 6
        Me.LblUername.Text = "User Name :"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(49, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Terraconc 1.0.2 "
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(9, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 43)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = " Concrete Compressive Strength Testing Application."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(200, 120)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(75, 29)
        Me.BtnLogin.TabIndex = 31
        Me.BtnLogin.Text = "Log In"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(276, 120)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(89, 29)
        Me.BtnClose.TabIndex = 29
        Me.BtnClose.Text = "Exit Program"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnAddNew
        '
        Me.BtnAddNew.Location = New System.Drawing.Point(208, 213)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(69, 29)
        Me.BtnAddNew.TabIndex = 28
        Me.BtnAddNew.Text = "Add User"
        Me.BtnAddNew.UseVisualStyleBackColor = True
        Me.BtnAddNew.Visible = False
        '
        'UserstableTableAdapter
        '
        Me.UserstableTableAdapter.ClearBeforeFill = True
        '
        'UserstableBindingNavigator
        '
        Me.UserstableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UserstableBindingNavigator.BindingSource = Me.UserstableBindingSource
        Me.UserstableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UserstableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UserstableBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UserstableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UserstableBindingNavigatorSaveItem})
        Me.UserstableBindingNavigator.Location = New System.Drawing.Point(0, 323)
        Me.UserstableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UserstableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UserstableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UserstableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UserstableBindingNavigator.Name = "UserstableBindingNavigator"
        Me.UserstableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UserstableBindingNavigator.Size = New System.Drawing.Size(544, 25)
        Me.UserstableBindingNavigator.TabIndex = 32
        Me.UserstableBindingNavigator.Text = "BindingNavigator1"
        Me.UserstableBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        Me.BindingNavigatorAddNewItem.Visible = False
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(33, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        Me.BindingNavigatorDeleteItem.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 22)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'UserstableBindingNavigatorSaveItem
        '
        Me.UserstableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UserstableBindingNavigatorSaveItem.Image = CType(resources.GetObject("UserstableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UserstableBindingNavigatorSaveItem.Name = "UserstableBindingNavigatorSaveItem"
        Me.UserstableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.UserstableBindingNavigatorSaveItem.Text = "Save Data"
        Me.UserstableBindingNavigatorSaveItem.Visible = False
        '
        'UserstableDataGridView
        '
        Me.UserstableDataGridView.AllowUserToAddRows = False
        Me.UserstableDataGridView.AllowUserToDeleteRows = False
        Me.UserstableDataGridView.AllowUserToResizeRows = False
        Me.UserstableDataGridView.AutoGenerateColumns = False
        Me.UserstableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserstableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.UserstableDataGridView.DataSource = Me.UserstableBindingSource
        Me.UserstableDataGridView.Location = New System.Drawing.Point(531, 230)
        Me.UserstableDataGridView.MultiSelect = False
        Me.UserstableDataGridView.Name = "UserstableDataGridView"
        Me.UserstableDataGridView.ReadOnly = True
        Me.UserstableDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UserstableDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.UserstableDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UserstableDataGridView.Size = New System.Drawing.Size(274, 22)
        Me.UserstableDataGridView.TabIndex = 32
        Me.UserstableDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "UserID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "UserID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Designation"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 50
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Password"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "UserName"
        Me.DataGridViewTextBoxColumn6.HeaderText = "UserName"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'ToolTip1
        '
        Me.ToolTip1.ForeColor = System.Drawing.Color.Maroon
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'OpenFileDialg
        '
        Me.OpenFileDialg.FileName = "OpenFileDialog1"
        Me.OpenFileDialg.Filter = "All Images |*JPG;*PNG;*BMP"
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserstableBindingSource, "UserID", True))
        Me.UserIDTextBox.Location = New System.Drawing.Point(411, 221)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.Size = New System.Drawing.Size(32, 20)
        Me.UserIDTextBox.TabIndex = 35
        Me.UserIDTextBox.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(9, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 36)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = " © Copyright Terracorn Engineering Company Ltd 2020"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(283, 212)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(69, 29)
        Me.BtnEdit.TabIndex = 37
        Me.BtnEdit.Text = "Edit User"
        Me.BtnEdit.UseVisualStyleBackColor = True
        Me.BtnEdit.Visible = False
        '
        'Err
        '
        Me.Err.ContainerControl = Me
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BatchTableTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.ProjectsTableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TerraConc.TerraConcDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserstableTableAdapter = Nothing
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TerraConc.My.Resources.Resources.Terraconc01
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 170)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.TerraConc.My.Resources.Resources.terracorn_logo
        Me.PictureBox2.Location = New System.Drawing.Point(1000, 281)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(96, 96)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.UserstableBindingSource
        Me.ListBox1.DisplayMember = "UserName"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(371, 32)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(122, 173)
        Me.ListBox1.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(375, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "User Names"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnCompInfo)
        Me.GroupBox1.Controls.Add(Me.BtnClear)
        Me.GroupBox1.Controls.Add(Me.TbWrkArea)
        Me.GroupBox1.Controls.Add(Me.TbCapsLockOn)
        Me.GroupBox1.Controls.Add(Me.TbOpSystem)
        Me.GroupBox1.Controls.Add(Me.TbCompUserName)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(531, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 187)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Computer Information"
        '
        'BtnCompInfo
        '
        Me.BtnCompInfo.Location = New System.Drawing.Point(20, 149)
        Me.BtnCompInfo.Name = "BtnCompInfo"
        Me.BtnCompInfo.Size = New System.Drawing.Size(130, 23)
        Me.BtnCompInfo.TabIndex = 11
        Me.BtnCompInfo.Text = "Get Computer Information"
        Me.BtnCompInfo.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(179, 149)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 23)
        Me.BtnClear.TabIndex = 10
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'TbWrkArea
        '
        Me.TbWrkArea.Location = New System.Drawing.Point(130, 123)
        Me.TbWrkArea.Name = "TbWrkArea"
        Me.TbWrkArea.Size = New System.Drawing.Size(222, 20)
        Me.TbWrkArea.TabIndex = 9
        '
        'TbCapsLockOn
        '
        Me.TbCapsLockOn.Location = New System.Drawing.Point(130, 100)
        Me.TbCapsLockOn.Name = "TbCapsLockOn"
        Me.TbCapsLockOn.Size = New System.Drawing.Size(222, 20)
        Me.TbCapsLockOn.TabIndex = 8
        '
        'TbOpSystem
        '
        Me.TbOpSystem.Location = New System.Drawing.Point(130, 77)
        Me.TbOpSystem.Name = "TbOpSystem"
        Me.TbOpSystem.Size = New System.Drawing.Size(222, 20)
        Me.TbOpSystem.TabIndex = 7
        '
        'TbCompUserName
        '
        Me.TbCompUserName.Location = New System.Drawing.Point(130, 54)
        Me.TbCompUserName.Name = "TbCompUserName"
        Me.TbCompUserName.Size = New System.Drawing.Size(222, 20)
        Me.TbCompUserName.TabIndex = 6
        '
        'TbCompName
        '
        Me.TbCompName.Location = New System.Drawing.Point(804, 189)
        Me.TbCompName.Name = "TbCompName"
        Me.TbCompName.Size = New System.Drawing.Size(38, 20)
        Me.TbCompName.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 130)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Working Area"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Caps Lock on"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Operating System"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "User Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Computer Code"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Btnlater)
        Me.GroupBox2.Controls.Add(Me.BtnReg)
        Me.GroupBox2.Controls.Add(Me.TbRegCode)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.TbCompcode)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(39, 312)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(453, 159)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(158, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Registration Panel"
        '
        'TbCompcode
        '
        Me.TbCompcode.Location = New System.Drawing.Point(113, 35)
        Me.TbCompcode.Name = "TbCompcode"
        Me.TbCompcode.Size = New System.Drawing.Size(291, 20)
        Me.TbCompcode.TabIndex = 1
        '
        'TbRegCode
        '
        Me.TbRegCode.Location = New System.Drawing.Point(113, 65)
        Me.TbRegCode.Name = "TbRegCode"
        Me.TbRegCode.Size = New System.Drawing.Size(291, 20)
        Me.TbRegCode.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 69)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Registration Code"
        '
        'BtnReg
        '
        Me.BtnReg.Location = New System.Drawing.Point(26, 102)
        Me.BtnReg.Name = "BtnReg"
        Me.BtnReg.Size = New System.Drawing.Size(75, 23)
        Me.BtnReg.TabIndex = 4
        Me.BtnReg.Text = "Register"
        Me.BtnReg.UseVisualStyleBackColor = True
        '
        'Btnlater
        '
        Me.Btnlater.Location = New System.Drawing.Point(339, 102)
        Me.Btnlater.Name = "Btnlater"
        Me.Btnlater.Size = New System.Drawing.Size(75, 23)
        Me.Btnlater.TabIndex = 5
        Me.Btnlater.Text = "Later"
        Me.Btnlater.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(110, 102)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(223, 44)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Please Send Computer Code to info@terracorn.com.We will provide you with registra" &
    "tion code."
        '
        'UsersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(1124, 498)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TbPass)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(UserIDLabel)
        Me.Controls.Add(Me.UserIDTextBox)
        Me.Controls.Add(Me.TbCompName)
        Me.Controls.Add(Me.UserstableDataGridView)
        Me.Controls.Add(Me.UserstableBindingNavigator)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.TbUN)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.LblUername)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "UsersForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.UserstableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TerraConcDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserstableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserstableBindingNavigator.ResumeLayout(False)
        Me.UserstableBindingNavigator.PerformLayout()
        CType(Me.UserstableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Err, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Tbpassword As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TbUN As TextBox
    Friend WithEvents LblUername As Label
    Friend WithEvents TbLN As TextBox
    Friend WithEvents LblLN As Label
    Friend WithEvents TbFN As TextBox
    Friend WithEvents LblFN As Label
    Friend WithEvents TbTitle As TextBox
    Friend WithEvents LabelDesig As Label
    Friend WithEvents UserPicture As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnBrowseImage As Button
    Friend WithEvents BtnLogin As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnAddNew As Button
    Friend WithEvents TerraConcDataSet As TerraConcDataSet
    Friend WithEvents UserstableBindingSource As BindingSource
    Friend WithEvents UserstableTableAdapter As TerraConcDataSetTableAdapters.UserstableTableAdapter
    Friend WithEvents TableAdapterManager As TerraConcDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UserstableBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents UserstableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents UserstableDataGridView As DataGridView
    Friend WithEvents Btnsave As Button
    Friend WithEvents CmbStatus As ComboBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents OpenFileDialg As OpenFileDialog
    Friend WithEvents UserIDTextBox As TextBox
    Friend WithEvents TbPass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnCancel As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents BtnEdit As Button
    Friend WithEvents Err As ErrorProvider
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnClear As Button
    Friend WithEvents TbWrkArea As TextBox
    Friend WithEvents TbCapsLockOn As TextBox
    Friend WithEvents TbOpSystem As TextBox
    Friend WithEvents TbCompUserName As TextBox
    Friend WithEvents TbCompName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnCompInfo As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Btnlater As Button
    Friend WithEvents BtnReg As Button
    Friend WithEvents TbRegCode As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TbCompcode As TextBox
    Friend WithEvents Label12 As Label
End Class
