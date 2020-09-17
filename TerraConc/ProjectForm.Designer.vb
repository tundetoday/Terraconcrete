<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProjectForm
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
        Dim ProjectIDLabel As System.Windows.Forms.Label
        Dim ProjectNameLabel As System.Windows.Forms.Label
        Dim ProjectAddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim ClientNameLabel As System.Windows.Forms.Label
        Dim ClientAddressLabel As System.Windows.Forms.Label
        Dim ContactPersonLabel As System.Windows.Forms.Label
        Dim ContactPhoneNoLabel As System.Windows.Forms.Label
        Dim ContactEmailLabel As System.Windows.Forms.Label
        Dim PlotNoLabel As System.Windows.Forms.Label
        Dim ProjectStartLabel As System.Windows.Forms.Label
        Dim ProjectEndLabel As System.Windows.Forms.Label
        Dim StructureTypeLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProjectForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ProjectsTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ProjectsTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TerraConcDataSet = New TerraConc.TerraConcDataSet()
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
        Me.ProjectsTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ProjectIDTextBox = New System.Windows.Forms.TextBox()
        Me.ProjectNameTextBox = New System.Windows.Forms.TextBox()
        Me.ProjectAddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.ClientNameTextBox = New System.Windows.Forms.TextBox()
        Me.ClientAddressTextBox = New System.Windows.Forms.TextBox()
        Me.ContactPersonTextBox = New System.Windows.Forms.TextBox()
        Me.ContactPhoneNoTextBox = New System.Windows.Forms.TextBox()
        Me.ContactEmailTextBox = New System.Windows.Forms.TextBox()
        Me.PlotNoTextBox = New System.Windows.Forms.TextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.StructureTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.ProjectEndDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ProjectStartDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ProjectsTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BatchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewBatchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllProjectsReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnAddNew = New System.Windows.Forms.Button()
        Me.BtnShowBatch = New System.Windows.Forms.Button()
        Me.OpenFileDialogProject = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialogProjects = New System.Windows.Forms.SaveFileDialog()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SearchComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SearchTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GoButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ProjectsTableTableAdapter = New TerraConc.TerraConcDataSetTableAdapters.ProjectsTableTableAdapter()
        Me.TableAdapterManager = New TerraConc.TerraConcDataSetTableAdapters.TableAdapterManager()
        Me.BatchTableTableAdapter = New TerraConc.TerraConcDataSetTableAdapters.BatchTableTableAdapter()
        Me.BtnCloseApp = New System.Windows.Forms.Button()
        ProjectIDLabel = New System.Windows.Forms.Label()
        ProjectNameLabel = New System.Windows.Forms.Label()
        ProjectAddressLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        ClientNameLabel = New System.Windows.Forms.Label()
        ClientAddressLabel = New System.Windows.Forms.Label()
        ContactPersonLabel = New System.Windows.Forms.Label()
        ContactPhoneNoLabel = New System.Windows.Forms.Label()
        ContactEmailLabel = New System.Windows.Forms.Label()
        PlotNoLabel = New System.Windows.Forms.Label()
        ProjectStartLabel = New System.Windows.Forms.Label()
        ProjectEndLabel = New System.Windows.Forms.Label()
        StructureTypeLabel1 = New System.Windows.Forms.Label()
        CType(Me.ProjectsTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProjectsTableBindingNavigator.SuspendLayout()
        CType(Me.ProjectsTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TerraConcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ProjectsTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProjectIDLabel
        '
        ProjectIDLabel.AutoSize = True
        ProjectIDLabel.Location = New System.Drawing.Point(163, 601)
        ProjectIDLabel.Name = "ProjectIDLabel"
        ProjectIDLabel.Size = New System.Drawing.Size(57, 13)
        ProjectIDLabel.TabIndex = 1
        ProjectIDLabel.Text = "Project ID:"
        '
        'ProjectNameLabel
        '
        ProjectNameLabel.AutoSize = True
        ProjectNameLabel.Location = New System.Drawing.Point(10, 62)
        ProjectNameLabel.Name = "ProjectNameLabel"
        ProjectNameLabel.Size = New System.Drawing.Size(74, 13)
        ProjectNameLabel.TabIndex = 3
        ProjectNameLabel.Text = "Project Name:"
        '
        'ProjectAddressLabel
        '
        ProjectAddressLabel.AutoSize = True
        ProjectAddressLabel.Location = New System.Drawing.Point(10, 127)
        ProjectAddressLabel.Name = "ProjectAddressLabel"
        ProjectAddressLabel.Size = New System.Drawing.Size(84, 13)
        ProjectAddressLabel.TabIndex = 5
        ProjectAddressLabel.Text = "Project Address:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(10, 166)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 7
        CityLabel.Text = "City:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(10, 192)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(35, 13)
        StateLabel.TabIndex = 9
        StateLabel.Text = "State:"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(10, 218)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(46, 13)
        CountryLabel.TabIndex = 11
        CountryLabel.Text = "Country:"
        '
        'ClientNameLabel
        '
        ClientNameLabel.AutoSize = True
        ClientNameLabel.Location = New System.Drawing.Point(10, 244)
        ClientNameLabel.Name = "ClientNameLabel"
        ClientNameLabel.Size = New System.Drawing.Size(67, 13)
        ClientNameLabel.TabIndex = 13
        ClientNameLabel.Text = "Client Name:"
        '
        'ClientAddressLabel
        '
        ClientAddressLabel.AutoSize = True
        ClientAddressLabel.Location = New System.Drawing.Point(10, 270)
        ClientAddressLabel.Name = "ClientAddressLabel"
        ClientAddressLabel.Size = New System.Drawing.Size(77, 13)
        ClientAddressLabel.TabIndex = 15
        ClientAddressLabel.Text = "Client Address:"
        '
        'ContactPersonLabel
        '
        ContactPersonLabel.AutoSize = True
        ContactPersonLabel.Location = New System.Drawing.Point(10, 314)
        ContactPersonLabel.Name = "ContactPersonLabel"
        ContactPersonLabel.Size = New System.Drawing.Size(83, 13)
        ContactPersonLabel.TabIndex = 17
        ContactPersonLabel.Text = "Contact Person:"
        '
        'ContactPhoneNoLabel
        '
        ContactPhoneNoLabel.AutoSize = True
        ContactPhoneNoLabel.Location = New System.Drawing.Point(10, 340)
        ContactPhoneNoLabel.Name = "ContactPhoneNoLabel"
        ContactPhoneNoLabel.Size = New System.Drawing.Size(98, 13)
        ContactPhoneNoLabel.TabIndex = 19
        ContactPhoneNoLabel.Text = "Contact Phone No:"
        '
        'ContactEmailLabel
        '
        ContactEmailLabel.AutoSize = True
        ContactEmailLabel.Location = New System.Drawing.Point(10, 366)
        ContactEmailLabel.Name = "ContactEmailLabel"
        ContactEmailLabel.Size = New System.Drawing.Size(75, 13)
        ContactEmailLabel.TabIndex = 21
        ContactEmailLabel.Text = "Contact Email:"
        '
        'PlotNoLabel
        '
        PlotNoLabel.AutoSize = True
        PlotNoLabel.Location = New System.Drawing.Point(10, 30)
        PlotNoLabel.Name = "PlotNoLabel"
        PlotNoLabel.Size = New System.Drawing.Size(108, 13)
        PlotNoLabel.TabIndex = 23
        PlotNoLabel.Text = "Plot Identification No:"
        '
        'ProjectStartLabel
        '
        ProjectStartLabel.AutoSize = True
        ProjectStartLabel.Location = New System.Drawing.Point(10, 400)
        ProjectStartLabel.Name = "ProjectStartLabel"
        ProjectStartLabel.Size = New System.Drawing.Size(68, 13)
        ProjectStartLabel.TabIndex = 24
        ProjectStartLabel.Text = "Project Start:"
        '
        'ProjectEndLabel
        '
        ProjectEndLabel.AutoSize = True
        ProjectEndLabel.Location = New System.Drawing.Point(10, 426)
        ProjectEndLabel.Name = "ProjectEndLabel"
        ProjectEndLabel.Size = New System.Drawing.Size(65, 13)
        ProjectEndLabel.TabIndex = 25
        ProjectEndLabel.Text = "Project End:"
        '
        'StructureTypeLabel1
        '
        StructureTypeLabel1.AutoSize = True
        StructureTypeLabel1.Location = New System.Drawing.Point(10, 449)
        StructureTypeLabel1.Name = "StructureTypeLabel1"
        StructureTypeLabel1.Size = New System.Drawing.Size(80, 13)
        StructureTypeLabel1.TabIndex = 33
        StructureTypeLabel1.Text = "Structure Type:"
        '
        'ProjectsTableBindingNavigator
        '
        Me.ProjectsTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProjectsTableBindingNavigator.BindingSource = Me.ProjectsTableBindingSource
        Me.ProjectsTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProjectsTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProjectsTableBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProjectsTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProjectsTableBindingNavigatorSaveItem, Me.ToolStripLabel1})
        Me.ProjectsTableBindingNavigator.Location = New System.Drawing.Point(0, 653)
        Me.ProjectsTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProjectsTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProjectsTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProjectsTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProjectsTableBindingNavigator.Name = "ProjectsTableBindingNavigator"
        Me.ProjectsTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProjectsTableBindingNavigator.Size = New System.Drawing.Size(1039, 25)
        Me.ProjectsTableBindingNavigator.TabIndex = 0
        Me.ProjectsTableBindingNavigator.Text = "BindingNavigator1"
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
        'ProjectsTableBindingSource
        '
        Me.ProjectsTableBindingSource.DataMember = "ProjectsTable"
        Me.ProjectsTableBindingSource.DataSource = Me.TerraConcDataSet
        '
        'TerraConcDataSet
        '
        Me.TerraConcDataSet.DataSetName = "TerraConcDataSet"
        Me.TerraConcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'ProjectsTableBindingNavigatorSaveItem
        '
        Me.ProjectsTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProjectsTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProjectsTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProjectsTableBindingNavigatorSaveItem.Name = "ProjectsTableBindingNavigatorSaveItem"
        Me.ProjectsTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProjectsTableBindingNavigatorSaveItem.Text = "Save Data"
        Me.ProjectsTableBindingNavigatorSaveItem.Visible = False
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripLabel1.IsLink = True
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(90, 22)
        Me.ToolStripLabel1.Text = "Current User :"
        '
        'ProjectIDTextBox
        '
        Me.ProjectIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProjectsTableBindingSource, "ProjectID", True))
        Me.ProjectIDTextBox.Location = New System.Drawing.Point(226, 597)
        Me.ProjectIDTextBox.Name = "ProjectIDTextBox"
        Me.ProjectIDTextBox.ReadOnly = True
        Me.ProjectIDTextBox.Size = New System.Drawing.Size(57, 20)
        Me.ProjectIDTextBox.TabIndex = 2
        Me.ProjectIDTextBox.TabStop = False
        '
        'ProjectNameTextBox
        '
        Me.ProjectNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProjectsTableBindingSource, "ProjectName", True))
        Me.ProjectNameTextBox.Location = New System.Drawing.Point(117, 59)
        Me.ProjectNameTextBox.Multiline = True
        Me.ProjectNameTextBox.Name = "ProjectNameTextBox"
        Me.ProjectNameTextBox.Size = New System.Drawing.Size(147, 46)
        Me.ProjectNameTextBox.TabIndex = 2
        '
        'ProjectAddressTextBox
        '
        Me.ProjectAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProjectsTableBindingSource, "ProjectAddress", True))
        Me.ProjectAddressTextBox.Location = New System.Drawing.Point(117, 111)
        Me.ProjectAddressTextBox.Multiline = True
        Me.ProjectAddressTextBox.Name = "ProjectAddressTextBox"
        Me.ProjectAddressTextBox.Size = New System.Drawing.Size(147, 46)
        Me.ProjectAddressTextBox.TabIndex = 3
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProjectsTableBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(117, 163)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(147, 20)
        Me.CityTextBox.TabIndex = 4
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProjectsTableBindingSource, "State", True))
        Me.StateTextBox.Location = New System.Drawing.Point(117, 189)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(147, 20)
        Me.StateTextBox.TabIndex = 5
        '
        'CountryTextBox
        '
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProjectsTableBindingSource, "Country", True))
        Me.CountryTextBox.Location = New System.Drawing.Point(117, 215)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(147, 20)
        Me.CountryTextBox.TabIndex = 6
        '
        'ClientNameTextBox
        '
        Me.ClientNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProjectsTableBindingSource, "ClientName", True))
        Me.ClientNameTextBox.Location = New System.Drawing.Point(117, 241)
        Me.ClientNameTextBox.Name = "ClientNameTextBox"
        Me.ClientNameTextBox.Size = New System.Drawing.Size(147, 20)
        Me.ClientNameTextBox.TabIndex = 7
        '
        'ClientAddressTextBox
        '
        Me.ClientAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProjectsTableBindingSource, "ClientAddress", True))
        Me.ClientAddressTextBox.Location = New System.Drawing.Point(117, 267)
        Me.ClientAddressTextBox.Multiline = True
        Me.ClientAddressTextBox.Name = "ClientAddressTextBox"
        Me.ClientAddressTextBox.Size = New System.Drawing.Size(147, 38)
        Me.ClientAddressTextBox.TabIndex = 8
        '
        'ContactPersonTextBox
        '
        Me.ContactPersonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProjectsTableBindingSource, "ContactPerson", True))
        Me.ContactPersonTextBox.Location = New System.Drawing.Point(117, 311)
        Me.ContactPersonTextBox.Name = "ContactPersonTextBox"
        Me.ContactPersonTextBox.Size = New System.Drawing.Size(147, 20)
        Me.ContactPersonTextBox.TabIndex = 9
        '
        'ContactPhoneNoTextBox
        '
        Me.ContactPhoneNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProjectsTableBindingSource, "ContactPhoneNo", True))
        Me.ContactPhoneNoTextBox.Location = New System.Drawing.Point(117, 337)
        Me.ContactPhoneNoTextBox.Name = "ContactPhoneNoTextBox"
        Me.ContactPhoneNoTextBox.Size = New System.Drawing.Size(147, 20)
        Me.ContactPhoneNoTextBox.TabIndex = 10
        '
        'ContactEmailTextBox
        '
        Me.ContactEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProjectsTableBindingSource, "ContactEmail", True))
        Me.ContactEmailTextBox.Location = New System.Drawing.Point(117, 363)
        Me.ContactEmailTextBox.Name = "ContactEmailTextBox"
        Me.ContactEmailTextBox.Size = New System.Drawing.Size(147, 20)
        Me.ContactEmailTextBox.TabIndex = 11
        '
        'PlotNoTextBox
        '
        Me.PlotNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProjectsTableBindingSource, "PlotNo", True))
        Me.PlotNoTextBox.Location = New System.Drawing.Point(117, 27)
        Me.PlotNoTextBox.Name = "PlotNoTextBox"
        Me.PlotNoTextBox.Size = New System.Drawing.Size(147, 20)
        Me.PlotNoTextBox.TabIndex = 1
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 33)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(StructureTypeLabel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.StructureTypeComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(ProjectEndLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ProjectEndDateTimePicker)
        Me.SplitContainer1.Panel1.Controls.Add(ProjectStartLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ProjectStartDateTimePicker)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PlotNoTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(PlotNoLabel)
        Me.SplitContainer1.Panel1.Controls.Add(ProjectNameLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ContactEmailTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ProjectNameTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(ContactEmailLabel)
        Me.SplitContainer1.Panel1.Controls.Add(ProjectAddressLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ContactPhoneNoTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ProjectAddressTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(ContactPhoneNoLabel)
        Me.SplitContainer1.Panel1.Controls.Add(CityLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ContactPersonTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CityTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(ContactPersonLabel)
        Me.SplitContainer1.Panel1.Controls.Add(StateLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ClientAddressTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.StateTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(ClientAddressLabel)
        Me.SplitContainer1.Panel1.Controls.Add(CountryLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ClientNameTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CountryTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(ClientNameLabel)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ProjectsTableDataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(1007, 511)
        Me.SplitContainer1.SplitterDistance = 284
        Me.SplitContainer1.TabIndex = 25
        '
        'StructureTypeComboBox
        '
        Me.StructureTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProjectsTableBindingSource, "StructureType", True))
        Me.StructureTypeComboBox.FormattingEnabled = True
        Me.StructureTypeComboBox.Items.AddRange(New Object() {"Bridge", "Drains", "Retaining wall", "Residential Building ", "Commercial Units", "Office Blocks"})
        Me.StructureTypeComboBox.Location = New System.Drawing.Point(117, 449)
        Me.StructureTypeComboBox.Name = "StructureTypeComboBox"
        Me.StructureTypeComboBox.Size = New System.Drawing.Size(145, 21)
        Me.StructureTypeComboBox.TabIndex = 34
        '
        'ProjectEndDateTimePicker
        '
        Me.ProjectEndDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProjectsTableBindingSource, "ProjectEnd", True))
        Me.ProjectEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ProjectEndDateTimePicker.Location = New System.Drawing.Point(117, 422)
        Me.ProjectEndDateTimePicker.Name = "ProjectEndDateTimePicker"
        Me.ProjectEndDateTimePicker.Size = New System.Drawing.Size(145, 20)
        Me.ProjectEndDateTimePicker.TabIndex = 13
        '
        'ProjectStartDateTimePicker
        '
        Me.ProjectStartDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProjectsTableBindingSource, "ProjectStart", True))
        Me.ProjectStartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ProjectStartDateTimePicker.Location = New System.Drawing.Point(117, 396)
        Me.ProjectStartDateTimePicker.Name = "ProjectStartDateTimePicker"
        Me.ProjectStartDateTimePicker.Size = New System.Drawing.Size(145, 20)
        Me.ProjectStartDateTimePicker.TabIndex = 12
        '
        'ProjectsTableDataGridView
        '
        Me.ProjectsTableDataGridView.AllowUserToAddRows = False
        Me.ProjectsTableDataGridView.AllowUserToDeleteRows = False
        Me.ProjectsTableDataGridView.AllowUserToResizeColumns = False
        Me.ProjectsTableDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.NullValue = "-"
        Me.ProjectsTableDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ProjectsTableDataGridView.AutoGenerateColumns = False
        Me.ProjectsTableDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.ProjectsTableDataGridView.ColumnHeadersHeight = 25
        Me.ProjectsTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.ProjectsTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.ProjectsTableDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProjectsTableDataGridView.DataSource = Me.ProjectsTableBindingSource
        Me.ProjectsTableDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProjectsTableDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.ProjectsTableDataGridView.MultiSelect = False
        Me.ProjectsTableDataGridView.Name = "ProjectsTableDataGridView"
        Me.ProjectsTableDataGridView.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProjectsTableDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ProjectsTableDataGridView.RowHeadersWidth = 20
        Me.ProjectsTableDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.ProjectsTableDataGridView.RowTemplate.ReadOnly = True
        Me.ProjectsTableDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ProjectsTableDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProjectsTableDataGridView.Size = New System.Drawing.Size(715, 507)
        Me.ProjectsTableDataGridView.StandardTab = True
        Me.ProjectsTableDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProjectName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Project Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ProjectAddress"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Project Address"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn4.HeaderText = "City"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 75
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "State"
        Me.DataGridViewTextBoxColumn5.HeaderText = "State"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 75
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Country"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Country"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 75
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ClientName"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Client Name"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ClientAddress"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Client Address"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ContactPerson"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Contact Person"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ContactPhoneNo"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Contact Phone No"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ContactEmail"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Contact Email"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "PlotNo"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Plot No"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.BatchToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(151, 24)
        Me.MenuStrip1.TabIndex = 26
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewProjectToolStripMenuItem, Me.ExitApplicationToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewProjectToolStripMenuItem
        '
        Me.NewProjectToolStripMenuItem.Name = "NewProjectToolStripMenuItem"
        Me.NewProjectToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.NewProjectToolStripMenuItem.Text = "New Project"
        '
        'ExitApplicationToolStripMenuItem
        '
        Me.ExitApplicationToolStripMenuItem.Name = "ExitApplicationToolStripMenuItem"
        Me.ExitApplicationToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ExitApplicationToolStripMenuItem.Text = "&Exit Application"
        '
        'BatchToolStripMenuItem
        '
        Me.BatchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewBatchToolStripMenuItem})
        Me.BatchToolStripMenuItem.Name = "BatchToolStripMenuItem"
        Me.BatchToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.BatchToolStripMenuItem.Text = "Batch"
        '
        'ViewBatchToolStripMenuItem
        '
        Me.ViewBatchToolStripMenuItem.Name = "ViewBatchToolStripMenuItem"
        Me.ViewBatchToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ViewBatchToolStripMenuItem.Text = "View Batch"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProjectReportToolStripMenuItem, Me.AllProjectsReportToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'ProjectReportToolStripMenuItem
        '
        Me.ProjectReportToolStripMenuItem.Name = "ProjectReportToolStripMenuItem"
        Me.ProjectReportToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.ProjectReportToolStripMenuItem.Text = "Project Details Report"
        '
        'AllProjectsReportToolStripMenuItem
        '
        Me.AllProjectsReportToolStripMenuItem.Name = "AllProjectsReportToolStripMenuItem"
        Me.AllProjectsReportToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.AllProjectsReportToolStripMenuItem.Text = "Projects Concrete Tests Report"
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.ForeColor = System.Drawing.Color.Black
        Me.BtnSave.Location = New System.Drawing.Point(506, 564)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(62, 23)
        Me.BtnSave.TabIndex = 27
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.ForeColor = System.Drawing.Color.Black
        Me.BtnCancel.Location = New System.Drawing.Point(568, 564)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(62, 23)
        Me.BtnCancel.TabIndex = 28
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.ForeColor = System.Drawing.Color.Black
        Me.BtnClose.Location = New System.Drawing.Point(630, 564)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(62, 23)
        Me.BtnClose.TabIndex = 29
        Me.BtnClose.Text = "&Back"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnAddNew
        '
        Me.BtnAddNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddNew.ForeColor = System.Drawing.Color.Black
        Me.BtnAddNew.Location = New System.Drawing.Point(382, 564)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(62, 23)
        Me.BtnAddNew.TabIndex = 30
        Me.BtnAddNew.Text = "&Add New"
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'BtnShowBatch
        '
        Me.BtnShowBatch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnShowBatch.ForeColor = System.Drawing.Color.Black
        Me.BtnShowBatch.Location = New System.Drawing.Point(692, 564)
        Me.BtnShowBatch.Name = "BtnShowBatch"
        Me.BtnShowBatch.Size = New System.Drawing.Size(131, 23)
        Me.BtnShowBatch.TabIndex = 31
        Me.BtnShowBatch.Text = "Show Concrete Batch"
        Me.BtnShowBatch.UseVisualStyleBackColor = True
        '
        'OpenFileDialogProject
        '
        Me.OpenFileDialogProject.FileName = "OpenFileDialog1"
        '
        'BtnEdit
        '
        Me.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEdit.ForeColor = System.Drawing.Color.Black
        Me.BtnEdit.Location = New System.Drawing.Point(444, 564)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(62, 23)
        Me.BtnEdit.TabIndex = 33
        Me.BtnEdit.Text = "&Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'ToolStrip
        '
        Me.ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton, Me.ToolStripSeparator3, Me.SearchComboBox, Me.ToolStripSeparator4, Me.SearchTextBox, Me.ToolStripSeparator1, Me.GoButton, Me.ToolStripSeparator2, Me.ToolStripLabel})
        Me.ToolStrip.Location = New System.Drawing.Point(436, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(384, 25)
        Me.ToolStrip.TabIndex = 115
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton
        '
        Me.ToolStripDropDownButton.Name = "ToolStripDropDownButton"
        Me.ToolStripDropDownButton.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripDropDownButton.Text = "Search By :"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'SearchComboBox
        '
        Me.SearchComboBox.AutoCompleteCustomSource.AddRange(New String() {"Project Name", "Project Address", "City", "Client Name", "Date Completed", "Job Ref"})
        Me.SearchComboBox.Items.AddRange(New Object() {"Project Name", "Project Address", "City/State", "Country", "Client Name", "Date Started", "Job Ref"})
        Me.SearchComboBox.Name = "SearchComboBox"
        Me.SearchComboBox.Size = New System.Drawing.Size(121, 25)
        Me.SearchComboBox.ToolTipText = "Select Search Criteria"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'GoButton
        '
        Me.GoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.GoButton.Image = CType(resources.GetObject("GoButton.Image"), System.Drawing.Image)
        Me.GoButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(26, 22)
        Me.GoButton.Text = "Go"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel
        '
        Me.ToolStripLabel.Name = "ToolStripLabel"
        Me.ToolStripLabel.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel.Text = "Reset"
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
        'BatchTableTableAdapter
        '
        Me.BatchTableTableAdapter.ClearBeforeFill = True
        '
        'BtnCloseApp
        '
        Me.BtnCloseApp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnCloseApp.Location = New System.Drawing.Point(829, 564)
        Me.BtnCloseApp.Name = "BtnCloseApp"
        Me.BtnCloseApp.Size = New System.Drawing.Size(80, 23)
        Me.BtnCloseApp.TabIndex = 116
        Me.BtnCloseApp.Text = "&Exit Program"
        Me.BtnCloseApp.UseVisualStyleBackColor = True
        '
        'ProjectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 678)
        Me.Controls.Add(Me.BtnCloseApp)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(ProjectIDLabel)
        Me.Controls.Add(Me.BtnShowBatch)
        Me.Controls.Add(Me.ProjectIDTextBox)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ProjectsTableBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "ProjectForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Project Information"
        Me.TopMost = True
        CType(Me.ProjectsTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProjectsTableBindingNavigator.ResumeLayout(False)
        Me.ProjectsTableBindingNavigator.PerformLayout()
        CType(Me.ProjectsTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TerraConcDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ProjectsTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TerraConcDataSet As TerraConcDataSet
    Friend WithEvents ProjectsTableBindingSource As BindingSource
    Friend WithEvents ProjectsTableTableAdapter As TerraConcDataSetTableAdapters.ProjectsTableTableAdapter
    Friend WithEvents TableAdapterManager As TerraConcDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProjectsTableBindingNavigator As BindingNavigator
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
    Friend WithEvents ProjectsTableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ProjectIDTextBox As TextBox
    Friend WithEvents ProjectNameTextBox As TextBox
    Friend WithEvents ProjectAddressTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents CountryTextBox As TextBox
    Friend WithEvents ClientNameTextBox As TextBox
    Friend WithEvents ClientAddressTextBox As TextBox
    Friend WithEvents ContactPersonTextBox As TextBox
    Friend WithEvents ContactPhoneNoTextBox As TextBox
    Friend WithEvents ContactEmailTextBox As TextBox
    Friend WithEvents PlotNoTextBox As TextBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitApplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BatchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewBatchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProjectReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllProjectsReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents ProjectsTableDataGridView As DataGridView
    Friend WithEvents BtnAddNew As Button
    Friend WithEvents BtnShowBatch As Button
    Friend WithEvents OpenFileDialogProject As OpenFileDialog
    Friend WithEvents SaveFileDialogProjects As SaveFileDialog
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents BatchTableTableAdapter As TerraConcDataSetTableAdapters.BatchTableTableAdapter
    Friend WithEvents ProjectEndDateTimePicker As DateTimePicker
    Friend WithEvents ProjectStartDateTimePicker As DateTimePicker
    Friend WithEvents BtnEdit As Button
    Friend WithEvents StructureTypeComboBox As ComboBox
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents ToolStripDropDownButton As ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents SearchComboBox As ToolStripComboBox
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents SearchTextBox As ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents GoButton As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel As ToolStripLabel
    Friend WithEvents BtnCloseApp As Button
End Class
