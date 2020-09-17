<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BatchForm
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
        Dim BatchDateLabel As System.Windows.Forms.Label
        Dim NoOfSpecimenLabel As System.Windows.Forms.Label
        Dim SpecimenAgeLabel As System.Windows.Forms.Label
        Dim StructuralElementLabel As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim CompStrength1Label As System.Windows.Forms.Label
        Dim FractureType1Label As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim BatchIdentificationNoLabel As System.Windows.Forms.Label
        Dim NameOfSamplerLabel As System.Windows.Forms.Label
        Dim BatchTimeLabel As System.Windows.Forms.Label
        Dim SupplySourceLabel As System.Windows.Forms.Label
        Dim MethodOfCompactionLabel As System.Windows.Forms.Label
        Dim SpecificationOfConcreteMixLabel As System.Windows.Forms.Label
        Dim CuringConditionsLabel As System.Windows.Forms.Label
        Dim TestMethodLabel As System.Windows.Forms.Label
        Dim TestCertificateLabel As System.Windows.Forms.Label
        Dim DateDeliveredLabel As System.Windows.Forms.Label
        Dim ApprovedDateLabel As System.Windows.Forms.Label
        Dim CheckedDateLabel As System.Windows.Forms.Label
        Dim ApprovedByLabel As System.Windows.Forms.Label
        Dim CheckedByLabel As System.Windows.Forms.Label
        Dim TestedByLabel As System.Windows.Forms.Label
        Dim ConcreteGradeLabel As System.Windows.Forms.Label
        Dim TestdateLabel As System.Windows.Forms.Label
        Dim TestingLaboratoryLabel As System.Windows.Forms.Label
        Dim AveStrengthLabel As System.Windows.Forms.Label
        Dim CompiledByLabel As System.Windows.Forms.Label
        Dim ProjectIDLabel As System.Windows.Forms.Label
        Dim BatchIdLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BatchForm))
        Me.BtnAddNew = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewBatchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BatchReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectBatchReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BatchTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ToolStripUser = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BatchTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabl = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripbatch = New System.Windows.Forms.ToolStripLabel()
        Me.TerraConcDataSet = New TerraConc.TerraConcDataSet()
        Me.BatchDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BatchTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Specimen1DTextBox = New System.Windows.Forms.TextBox()
        Me.Specimen2DTextBox = New System.Windows.Forms.TextBox()
        Me.Specimen3DTextBox = New System.Windows.Forms.TextBox()
        Me.Specimen4DTextBox = New System.Windows.Forms.TextBox()
        Me.Specimen5DTextBox = New System.Windows.Forms.TextBox()
        Me.Specimen1LTextBox = New System.Windows.Forms.TextBox()
        Me.Specimen2LTextBox = New System.Windows.Forms.TextBox()
        Me.Specimen3LTextBox = New System.Windows.Forms.TextBox()
        Me.Specimen4LTextBox = New System.Windows.Forms.TextBox()
        Me.Specimen5LTextBox = New System.Windows.Forms.TextBox()
        Me.GrpSpecimen = New System.Windows.Forms.GroupBox()
        Me.LenTb = New System.Windows.Forms.TextBox()
        Me.CompiledByLabl = New System.Windows.Forms.Label()
        Me.SubMergedMass10TextBox = New System.Windows.Forms.TextBox()
        Me.CubeDim = New System.Windows.Forms.TextBox()
        Me.SubMergedMass9TextBox = New System.Windows.Forms.TextBox()
        Me.ChkbSameDim = New System.Windows.Forms.CheckBox()
        Me.SubMergedMass8TextBox = New System.Windows.Forms.TextBox()
        Me.SubMergedMass7TextBox = New System.Windows.Forms.TextBox()
        Me.SubMergedMass6TextBox = New System.Windows.Forms.TextBox()
        Me.Mass10TextBox = New System.Windows.Forms.TextBox()
        Me.Mass9TextBox = New System.Windows.Forms.TextBox()
        Me.Mass8TextBox = New System.Windows.Forms.TextBox()
        Me.Mass7TextBox = New System.Windows.Forms.TextBox()
        Me.Mass6TextBox = New System.Windows.Forms.TextBox()
        Me.Specimen10HTextBox = New System.Windows.Forms.TextBox()
        Me.Specimen9HTextBox = New System.Windows.Forms.TextBox()
        Me.ChkSubmerged = New System.Windows.Forms.CheckBox()
        Me.Specimen8HTextBox = New System.Windows.Forms.TextBox()
        Me.Specimen7HTextBox = New System.Windows.Forms.TextBox()
        Me.Specimen6HTextBox = New System.Windows.Forms.TextBox()
        Me.Specimen10LTextBox = New System.Windows.Forms.TextBox()
        Me.Specimen9LTextBox = New System.Windows.Forms.TextBox()
        Me.Specimen8LTextBox = New System.Windows.Forms.TextBox()
        Me.Specimen7LTextBox = New System.Windows.Forms.TextBox()
        Me.Specimen6LTextBox = New System.Windows.Forms.TextBox()
        Me.Lab10 = New System.Windows.Forms.Label()
        Me.Lab9 = New System.Windows.Forms.Label()
        Me.Lab8 = New System.Windows.Forms.Label()
        Me.Lab7 = New System.Windows.Forms.Label()
        Me.Lab6 = New System.Windows.Forms.Label()
        Me.Specimen10DTextBox = New System.Windows.Forms.TextBox()
        Me.Specimen9DTextBox = New System.Windows.Forms.TextBox()
        Me.Specimen8DTextBox = New System.Windows.Forms.TextBox()
        Me.Specimen7DTextBox = New System.Windows.Forms.TextBox()
        Me.Specimen6DTextBox = New System.Windows.Forms.TextBox()
        Me.Lab5 = New System.Windows.Forms.Label()
        Me.Lab4 = New System.Windows.Forms.Label()
        Me.Lab3 = New System.Windows.Forms.Label()
        Me.Lab2 = New System.Windows.Forms.Label()
        Me.Lab1 = New System.Windows.Forms.Label()
        Me.SubMergedMass5TextBox = New System.Windows.Forms.TextBox()
        Me.SubMergedMass4TextBox = New System.Windows.Forms.TextBox()
        Me.SubMergedMass3TextBox = New System.Windows.Forms.TextBox()
        Me.SubMergedMass2TextBox = New System.Windows.Forms.TextBox()
        Me.SubMergedMass1TextBox = New System.Windows.Forms.TextBox()
        Me.SubMergedLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Mass5TextBox = New System.Windows.Forms.TextBox()
        Me.Mass4TextBox = New System.Windows.Forms.TextBox()
        Me.Mass3TextBox = New System.Windows.Forms.TextBox()
        Me.Mass2TextBox = New System.Windows.Forms.TextBox()
        Me.Mass1TextBox = New System.Windows.Forms.TextBox()
        Me.Specimen5HTextBox = New System.Windows.Forms.TextBox()
        Me.LblHgt = New System.Windows.Forms.Label()
        Me.Specimen4HTextBox = New System.Windows.Forms.TextBox()
        Me.Specimen3HTextBox = New System.Windows.Forms.TextBox()
        Me.Specimen2HTextBox = New System.Windows.Forms.TextBox()
        Me.LblLen1 = New System.Windows.Forms.Label()
        Me.LblLen = New System.Windows.Forms.Label()
        Me.Specimen1HTextBox = New System.Windows.Forms.TextBox()
        Me.LblDia1 = New System.Windows.Forms.Label()
        Me.LblDia = New System.Windows.Forms.Label()
        Me.GrpBatch = New System.Windows.Forms.GroupBox()
        Me.BtnApply = New System.Windows.Forms.Button()
        Me.MethodOfCompactionComboBox = New System.Windows.Forms.ComboBox()
        Me.BatchTimeTextBox = New System.Windows.Forms.TextBox()
        Me.NoOfSpecimen = New System.Windows.Forms.NumericUpDown()
        Me.TestMethodComboBox = New System.Windows.Forms.ComboBox()
        Me.CuringConditionsTextBox = New System.Windows.Forms.TextBox()
        Me.SpecificationOfConcreteMixTextBox = New System.Windows.Forms.TextBox()
        Me.SupplySourceTextBox = New System.Windows.Forms.TextBox()
        Me.NameOfSamplerTextBox = New System.Windows.Forms.TextBox()
        Me.BatchIdentificationNoTextBox = New System.Windows.Forms.TextBox()
        Me.StructuralElementComboBox = New System.Windows.Forms.ComboBox()
        Me.CmbShape = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SpecimenAgeTextBox = New System.Windows.Forms.TextBox()
        Me.Grptest = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TestCertificateTextBox = New System.Windows.Forms.TextBox()
        Me.DateDeliveredDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ApprovedDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CheckedDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ApprovedByTextBox = New System.Windows.Forms.TextBox()
        Me.CheckedByTextBox = New System.Windows.Forms.TextBox()
        Me.TestedByTextBox = New System.Windows.Forms.TextBox()
        Me.ConcreteGradeTextBox = New System.Windows.Forms.TextBox()
        Me.TestdateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TestingLaboratoryTextBox = New System.Windows.Forms.TextBox()
        Me.AveStrength = New System.Windows.Forms.Label()
        Me.AveDensity = New System.Windows.Forms.Label()
        Me.CompStrength10 = New System.Windows.Forms.Label()
        Me.CompStrength9 = New System.Windows.Forms.Label()
        Me.CompStrength8 = New System.Windows.Forms.Label()
        Me.CompStrength7 = New System.Windows.Forms.Label()
        Me.CompStrength6 = New System.Windows.Forms.Label()
        Me.Density10 = New System.Windows.Forms.Label()
        Me.Density9 = New System.Windows.Forms.Label()
        Me.Density8 = New System.Windows.Forms.Label()
        Me.Density7 = New System.Windows.Forms.Label()
        Me.Density6 = New System.Windows.Forms.Label()
        Me.Area10 = New System.Windows.Forms.Label()
        Me.Area9 = New System.Windows.Forms.Label()
        Me.Area8 = New System.Windows.Forms.Label()
        Me.Area7 = New System.Windows.Forms.Label()
        Me.Area6 = New System.Windows.Forms.Label()
        Me.MaxLoad10TextBox = New System.Windows.Forms.TextBox()
        Me.MaxLoad9TextBox = New System.Windows.Forms.TextBox()
        Me.MaxLoad8TextBox = New System.Windows.Forms.TextBox()
        Me.MaxLoad7TextBox = New System.Windows.Forms.TextBox()
        Me.MaxLoad6TextBox = New System.Windows.Forms.TextBox()
        Me.Density5 = New System.Windows.Forms.Label()
        Me.Density4 = New System.Windows.Forms.Label()
        Me.Density3 = New System.Windows.Forms.Label()
        Me.Density2 = New System.Windows.Forms.Label()
        Me.Density1 = New System.Windows.Forms.Label()
        Me.Area5 = New System.Windows.Forms.Label()
        Me.Area4 = New System.Windows.Forms.Label()
        Me.Area3 = New System.Windows.Forms.Label()
        Me.Area2 = New System.Windows.Forms.Label()
        Me.Area1 = New System.Windows.Forms.Label()
        Me.CompStrength5 = New System.Windows.Forms.Label()
        Me.CompStrength4 = New System.Windows.Forms.Label()
        Me.CompStrength3 = New System.Windows.Forms.Label()
        Me.CompStrength2 = New System.Windows.Forms.Label()
        Me.CompStrength1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MaxLoad1TextBox = New System.Windows.Forms.TextBox()
        Me.MaxLoad2TextBox = New System.Windows.Forms.TextBox()
        Me.MaxLoad3TextBox = New System.Windows.Forms.TextBox()
        Me.MaxLoad4TextBox = New System.Windows.Forms.TextBox()
        Me.MaxLoad5TextBox = New System.Windows.Forms.TextBox()
        Me.FractureType10 = New System.Windows.Forms.ComboBox()
        Me.FractureType9 = New System.Windows.Forms.ComboBox()
        Me.FractureType8 = New System.Windows.Forms.ComboBox()
        Me.FractureType7 = New System.Windows.Forms.ComboBox()
        Me.FractureType6 = New System.Windows.Forms.ComboBox()
        Me.FractureType5 = New System.Windows.Forms.ComboBox()
        Me.FractureType4 = New System.Windows.Forms.ComboBox()
        Me.FractureType3 = New System.Windows.Forms.ComboBox()
        Me.FractureType2 = New System.Windows.Forms.ComboBox()
        Me.FractureType1 = New System.Windows.Forms.ComboBox()
        Me.Btncalculate = New System.Windows.Forms.Button()
        Me.BtnExitProgram = New System.Windows.Forms.Button()
        Me.BtnFirst = New System.Windows.Forms.Button()
        Me.BtnPrev = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnLast = New System.Windows.Forms.Button()
        Me.Err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.GrpMove = New System.Windows.Forms.GroupBox()
        Me.BatchTableTableAdapter = New TerraConc.TerraConcDataSetTableAdapters.BatchTableTableAdapter()
        Me.TableAdapterManager = New TerraConc.TerraConcDataSetTableAdapters.TableAdapterManager()
        Me.BatchTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.BatchIdentificationNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameOfSamplerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BatchDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BatchTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuringConditionsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestingLaboratoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestCertificateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplySourceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConcreteGradeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpecificationOfConcreteMixDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoOfSpecimenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpecimenConditionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MethodOfCompactionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDeliveredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestMethodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AveMassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AveDensityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AveStrengthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpecimenAgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StructuralElementDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpecimenShapeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApprovedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckedDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApprovedDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectIDTextBox = New System.Windows.Forms.TextBox()
        Me.BatchIdTextBox = New System.Windows.Forms.TextBox()
        BatchDateLabel = New System.Windows.Forms.Label()
        NoOfSpecimenLabel = New System.Windows.Forms.Label()
        SpecimenAgeLabel = New System.Windows.Forms.Label()
        StructuralElementLabel = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        CompStrength1Label = New System.Windows.Forms.Label()
        FractureType1Label = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        BatchIdentificationNoLabel = New System.Windows.Forms.Label()
        NameOfSamplerLabel = New System.Windows.Forms.Label()
        BatchTimeLabel = New System.Windows.Forms.Label()
        SupplySourceLabel = New System.Windows.Forms.Label()
        MethodOfCompactionLabel = New System.Windows.Forms.Label()
        SpecificationOfConcreteMixLabel = New System.Windows.Forms.Label()
        CuringConditionsLabel = New System.Windows.Forms.Label()
        TestMethodLabel = New System.Windows.Forms.Label()
        TestCertificateLabel = New System.Windows.Forms.Label()
        DateDeliveredLabel = New System.Windows.Forms.Label()
        ApprovedDateLabel = New System.Windows.Forms.Label()
        CheckedDateLabel = New System.Windows.Forms.Label()
        ApprovedByLabel = New System.Windows.Forms.Label()
        CheckedByLabel = New System.Windows.Forms.Label()
        TestedByLabel = New System.Windows.Forms.Label()
        ConcreteGradeLabel = New System.Windows.Forms.Label()
        TestdateLabel = New System.Windows.Forms.Label()
        TestingLaboratoryLabel = New System.Windows.Forms.Label()
        AveStrengthLabel = New System.Windows.Forms.Label()
        CompiledByLabel = New System.Windows.Forms.Label()
        ProjectIDLabel = New System.Windows.Forms.Label()
        BatchIdLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.BatchTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BatchTableBindingNavigator.SuspendLayout()
        CType(Me.TerraConcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpSpecimen.SuspendLayout()
        Me.GrpBatch.SuspendLayout()
        CType(Me.NoOfSpecimen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grptest.SuspendLayout()
        CType(Me.Err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpMove.SuspendLayout()
        CType(Me.BatchTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BatchDateLabel
        '
        BatchDateLabel.AutoSize = True
        BatchDateLabel.Location = New System.Drawing.Point(6, 140)
        BatchDateLabel.Name = "BatchDateLabel"
        BatchDateLabel.Size = New System.Drawing.Size(64, 13)
        BatchDateLabel.TabIndex = 38
        BatchDateLabel.Text = "Batch Date:"
        '
        'NoOfSpecimenLabel
        '
        NoOfSpecimenLabel.AutoSize = True
        NoOfSpecimenLabel.Location = New System.Drawing.Point(6, 209)
        NoOfSpecimenLabel.Name = "NoOfSpecimenLabel"
        NoOfSpecimenLabel.Size = New System.Drawing.Size(88, 13)
        NoOfSpecimenLabel.TabIndex = 40
        NoOfSpecimenLabel.Text = "No Of Specimen:"
        '
        'SpecimenAgeLabel
        '
        SpecimenAgeLabel.AutoSize = True
        SpecimenAgeLabel.Location = New System.Drawing.Point(5, 332)
        SpecimenAgeLabel.Name = "SpecimenAgeLabel"
        SpecimenAgeLabel.Size = New System.Drawing.Size(115, 13)
        SpecimenAgeLabel.TabIndex = 94
        SpecimenAgeLabel.Text = "Specimen Age (Days) :"
        '
        'StructuralElementLabel
        '
        StructuralElementLabel.AutoSize = True
        StructuralElementLabel.Location = New System.Drawing.Point(6, 82)
        StructuralElementLabel.Name = "StructuralElementLabel"
        StructuralElementLabel.Size = New System.Drawing.Size(96, 13)
        StructuralElementLabel.TabIndex = 57
        StructuralElementLabel.Text = "Structural Element:"
        '
        'Label7
        '
        Label7.CausesValidation = False
        Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(2, 18)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(67, 30)
        Label7.TabIndex = 114
        Label7.Text = "Specimen Number:"
        Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CompStrength1Label
        '
        CompStrength1Label.Location = New System.Drawing.Point(254, 17)
        CompStrength1Label.Name = "CompStrength1Label"
        CompStrength1Label.Size = New System.Drawing.Size(75, 30)
        CompStrength1Label.TabIndex = 112
        CompStrength1Label.Text = "Comp. Strength "
        CompStrength1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FractureType1Label
        '
        FractureType1Label.Location = New System.Drawing.Point(1281, 57)
        FractureType1Label.Name = "FractureType1Label"
        FractureType1Label.Size = New System.Drawing.Size(72, 30)
        FractureType1Label.TabIndex = 115
        FractureType1Label.Text = "Fracture Type"
        FractureType1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Label10.Location = New System.Drawing.Point(69, 17)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(75, 30)
        Label10.TabIndex = 125
        Label10.Text = "Area (mm)"
        Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Label8.Location = New System.Drawing.Point(150, 17)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(98, 30)
        Label8.TabIndex = 136
        Label8.Text = "Density Kg/m³"
        Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BatchIdentificationNoLabel
        '
        BatchIdentificationNoLabel.AutoSize = True
        BatchIdentificationNoLabel.Location = New System.Drawing.Point(6, 36)
        BatchIdentificationNoLabel.Name = "BatchIdentificationNoLabel"
        BatchIdentificationNoLabel.Size = New System.Drawing.Size(118, 13)
        BatchIdentificationNoLabel.TabIndex = 96
        BatchIdentificationNoLabel.Text = "Batch Identification No:"
        '
        'NameOfSamplerLabel
        '
        NameOfSamplerLabel.AutoSize = True
        NameOfSamplerLabel.Location = New System.Drawing.Point(6, 186)
        NameOfSamplerLabel.Name = "NameOfSamplerLabel"
        NameOfSamplerLabel.Size = New System.Drawing.Size(93, 13)
        NameOfSamplerLabel.TabIndex = 97
        NameOfSamplerLabel.Text = "Name Of Sampler:"
        '
        'BatchTimeLabel
        '
        BatchTimeLabel.AutoSize = True
        BatchTimeLabel.Location = New System.Drawing.Point(6, 163)
        BatchTimeLabel.Name = "BatchTimeLabel"
        BatchTimeLabel.Size = New System.Drawing.Size(64, 13)
        BatchTimeLabel.TabIndex = 98
        BatchTimeLabel.Text = "Batch Time:"
        '
        'SupplySourceLabel
        '
        SupplySourceLabel.AutoSize = True
        SupplySourceLabel.Location = New System.Drawing.Point(6, 59)
        SupplySourceLabel.Name = "SupplySourceLabel"
        SupplySourceLabel.Size = New System.Drawing.Size(79, 13)
        SupplySourceLabel.TabIndex = 99
        SupplySourceLabel.Text = "Supply Source:"
        '
        'MethodOfCompactionLabel
        '
        MethodOfCompactionLabel.AutoSize = True
        MethodOfCompactionLabel.Location = New System.Drawing.Point(6, 232)
        MethodOfCompactionLabel.Name = "MethodOfCompactionLabel"
        MethodOfCompactionLabel.Size = New System.Drawing.Size(119, 13)
        MethodOfCompactionLabel.TabIndex = 100
        MethodOfCompactionLabel.Text = "Method Of Compaction:"
        '
        'SpecificationOfConcreteMixLabel
        '
        SpecificationOfConcreteMixLabel.Location = New System.Drawing.Point(6, 102)
        SpecificationOfConcreteMixLabel.Name = "SpecificationOfConcreteMixLabel"
        SpecificationOfConcreteMixLabel.Size = New System.Drawing.Size(85, 31)
        SpecificationOfConcreteMixLabel.TabIndex = 101
        SpecificationOfConcreteMixLabel.Text = "Specification Of Concrete Mix:"
        '
        'CuringConditionsLabel
        '
        CuringConditionsLabel.AutoSize = True
        CuringConditionsLabel.Location = New System.Drawing.Point(8, 284)
        CuringConditionsLabel.Name = "CuringConditionsLabel"
        CuringConditionsLabel.Size = New System.Drawing.Size(92, 13)
        CuringConditionsLabel.TabIndex = 160
        CuringConditionsLabel.Text = "Curing Conditions:"
        '
        'TestMethodLabel
        '
        TestMethodLabel.AutoSize = True
        TestMethodLabel.Location = New System.Drawing.Point(8, 309)
        TestMethodLabel.Name = "TestMethodLabel"
        TestMethodLabel.Size = New System.Drawing.Size(70, 13)
        TestMethodLabel.TabIndex = 161
        TestMethodLabel.Text = "Test Method:"
        '
        'TestCertificateLabel
        '
        TestCertificateLabel.AutoSize = True
        TestCertificateLabel.Location = New System.Drawing.Point(6, 420)
        TestCertificateLabel.Name = "TestCertificateLabel"
        TestCertificateLabel.Size = New System.Drawing.Size(81, 13)
        TestCertificateLabel.TabIndex = 205
        TestCertificateLabel.Text = "Test Certificate:"
        '
        'DateDeliveredLabel
        '
        DateDeliveredLabel.AutoSize = True
        DateDeliveredLabel.Location = New System.Drawing.Point(215, 313)
        DateDeliveredLabel.Name = "DateDeliveredLabel"
        DateDeliveredLabel.Size = New System.Drawing.Size(81, 13)
        DateDeliveredLabel.TabIndex = 203
        DateDeliveredLabel.Text = "Date Delivered:"
        '
        'ApprovedDateLabel
        '
        ApprovedDateLabel.AutoSize = True
        ApprovedDateLabel.Location = New System.Drawing.Point(215, 376)
        ApprovedDateLabel.Name = "ApprovedDateLabel"
        ApprovedDateLabel.Size = New System.Drawing.Size(82, 13)
        ApprovedDateLabel.TabIndex = 201
        ApprovedDateLabel.Text = "Approved Date:"
        '
        'CheckedDateLabel
        '
        CheckedDateLabel.AutoSize = True
        CheckedDateLabel.Location = New System.Drawing.Point(215, 355)
        CheckedDateLabel.Name = "CheckedDateLabel"
        CheckedDateLabel.Size = New System.Drawing.Size(79, 13)
        CheckedDateLabel.TabIndex = 199
        CheckedDateLabel.Text = "Checked Date:"
        '
        'ApprovedByLabel
        '
        ApprovedByLabel.AutoSize = True
        ApprovedByLabel.Location = New System.Drawing.Point(6, 376)
        ApprovedByLabel.Name = "ApprovedByLabel"
        ApprovedByLabel.Size = New System.Drawing.Size(71, 13)
        ApprovedByLabel.TabIndex = 197
        ApprovedByLabel.Text = "Approved By:"
        '
        'CheckedByLabel
        '
        CheckedByLabel.AutoSize = True
        CheckedByLabel.Location = New System.Drawing.Point(6, 355)
        CheckedByLabel.Name = "CheckedByLabel"
        CheckedByLabel.Size = New System.Drawing.Size(68, 13)
        CheckedByLabel.TabIndex = 195
        CheckedByLabel.Text = "Checked By:"
        '
        'TestedByLabel
        '
        TestedByLabel.AutoSize = True
        TestedByLabel.Location = New System.Drawing.Point(6, 334)
        TestedByLabel.Name = "TestedByLabel"
        TestedByLabel.Size = New System.Drawing.Size(58, 13)
        TestedByLabel.TabIndex = 193
        TestedByLabel.Text = "Tested By:"
        '
        'ConcreteGradeLabel
        '
        ConcreteGradeLabel.AutoSize = True
        ConcreteGradeLabel.Location = New System.Drawing.Point(6, 313)
        ConcreteGradeLabel.Name = "ConcreteGradeLabel"
        ConcreteGradeLabel.Size = New System.Drawing.Size(85, 13)
        ConcreteGradeLabel.TabIndex = 191
        ConcreteGradeLabel.Text = "Concrete Grade:"
        '
        'TestdateLabel
        '
        TestdateLabel.AutoSize = True
        TestdateLabel.Location = New System.Drawing.Point(215, 334)
        TestdateLabel.Name = "TestdateLabel"
        TestdateLabel.Size = New System.Drawing.Size(52, 13)
        TestdateLabel.TabIndex = 189
        TestdateLabel.Text = "Testdate:"
        '
        'TestingLaboratoryLabel
        '
        TestingLaboratoryLabel.AutoSize = True
        TestingLaboratoryLabel.Location = New System.Drawing.Point(6, 292)
        TestingLaboratoryLabel.Name = "TestingLaboratoryLabel"
        TestingLaboratoryLabel.Size = New System.Drawing.Size(98, 13)
        TestingLaboratoryLabel.TabIndex = 187
        TestingLaboratoryLabel.Text = "Testing Laboratory:"
        '
        'AveStrengthLabel
        '
        AveStrengthLabel.Location = New System.Drawing.Point(218, 396)
        AveStrengthLabel.Name = "AveStrengthLabel"
        AveStrengthLabel.Size = New System.Drawing.Size(75, 20)
        AveStrengthLabel.TabIndex = 207
        AveStrengthLabel.Text = "Ave. Strength:"
        AveStrengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CompiledByLabel
        '
        CompiledByLabel.AutoSize = True
        CompiledByLabel.Location = New System.Drawing.Point(6, 401)
        CompiledByLabel.Name = "CompiledByLabel"
        CompiledByLabel.Size = New System.Drawing.Size(68, 13)
        CompiledByLabel.TabIndex = 161
        CompiledByLabel.Text = "Compiled By:"
        CompiledByLabel.Visible = False
        '
        'ProjectIDLabel
        '
        ProjectIDLabel.AutoSize = True
        ProjectIDLabel.Location = New System.Drawing.Point(1089, 51)
        ProjectIDLabel.Name = "ProjectIDLabel"
        ProjectIDLabel.Size = New System.Drawing.Size(57, 13)
        ProjectIDLabel.TabIndex = 168
        ProjectIDLabel.Text = "Project ID:"
        '
        'BatchIdLabel
        '
        BatchIdLabel.AutoSize = True
        BatchIdLabel.Location = New System.Drawing.Point(1089, 94)
        BatchIdLabel.Name = "BatchIdLabel"
        BatchIdLabel.Size = New System.Drawing.Size(50, 13)
        BatchIdLabel.TabIndex = 169
        BatchIdLabel.Text = "Batch Id:"
        '
        'BtnAddNew
        '
        Me.BtnAddNew.ForeColor = System.Drawing.Color.Black
        Me.BtnAddNew.Location = New System.Drawing.Point(304, 515)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(60, 23)
        Me.BtnAddNew.TabIndex = 34
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.ForeColor = System.Drawing.Color.Black
        Me.BtnClose.Location = New System.Drawing.Point(544, 515)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(60, 23)
        Me.BtnClose.TabIndex = 33
        Me.BtnClose.Text = "&Back"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.ForeColor = System.Drawing.Color.Black
        Me.BtnCancel.Location = New System.Drawing.Point(484, 515)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(60, 23)
        Me.BtnCancel.TabIndex = 32
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.ForeColor = System.Drawing.Color.Black
        Me.BtnSave.Location = New System.Drawing.Point(424, 515)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(60, 23)
        Me.BtnSave.TabIndex = 31
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(99, 24)
        Me.MenuStrip1.TabIndex = 35
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewBatchToolStripMenuItem, Me.CloseToolStripMenuItem, Me.ExitApplicationToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewBatchToolStripMenuItem
        '
        Me.NewBatchToolStripMenuItem.Name = "NewBatchToolStripMenuItem"
        Me.NewBatchToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.NewBatchToolStripMenuItem.Text = "New Batch"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'ExitApplicationToolStripMenuItem
        '
        Me.ExitApplicationToolStripMenuItem.Name = "ExitApplicationToolStripMenuItem"
        Me.ExitApplicationToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ExitApplicationToolStripMenuItem.Text = "Exit Program"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BatchReportToolStripMenuItem, Me.ProjectBatchReportToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'BatchReportToolStripMenuItem
        '
        Me.BatchReportToolStripMenuItem.Name = "BatchReportToolStripMenuItem"
        Me.BatchReportToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.BatchReportToolStripMenuItem.Text = "Current Batch Report"
        '
        'ProjectBatchReportToolStripMenuItem
        '
        Me.ProjectBatchReportToolStripMenuItem.Name = "ProjectBatchReportToolStripMenuItem"
        Me.ProjectBatchReportToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ProjectBatchReportToolStripMenuItem.Text = "Project Batch Report"
        '
        'BatchTableBindingNavigator
        '
        Me.BatchTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BatchTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BatchTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BatchTableBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BatchTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.ToolStripUser, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BatchTableBindingNavigatorSaveItem, Me.ToolStripLabl, Me.ToolStripbatch})
        Me.BatchTableBindingNavigator.Location = New System.Drawing.Point(0, 688)
        Me.BatchTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BatchTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BatchTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BatchTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BatchTableBindingNavigator.Name = "BatchTableBindingNavigator"
        Me.BatchTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BatchTableBindingNavigator.Size = New System.Drawing.Size(1118, 25)
        Me.BatchTableBindingNavigator.TabIndex = 36
        Me.BatchTableBindingNavigator.Text = "BindingNavigator1"
        Me.BatchTableBindingNavigator.Visible = False
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
        'ToolStripUser
        '
        Me.ToolStripUser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripUser.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripUser.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripUser.Name = "ToolStripUser"
        Me.ToolStripUser.Size = New System.Drawing.Size(80, 22)
        Me.ToolStripUser.Text = "Current User"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BatchTableBindingNavigatorSaveItem
        '
        Me.BatchTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BatchTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("BatchTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BatchTableBindingNavigatorSaveItem.Name = "BatchTableBindingNavigatorSaveItem"
        Me.BatchTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BatchTableBindingNavigatorSaveItem.Text = "Save Data"
        Me.BatchTableBindingNavigatorSaveItem.Visible = False
        '
        'ToolStripLabl
        '
        Me.ToolStripLabl.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabl.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabl.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripLabl.Name = "ToolStripLabl"
        Me.ToolStripLabl.Size = New System.Drawing.Size(0, 22)
        '
        'ToolStripbatch
        '
        Me.ToolStripbatch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripbatch.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripbatch.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripbatch.Name = "ToolStripbatch"
        Me.ToolStripbatch.Size = New System.Drawing.Size(0, 22)
        '
        'TerraConcDataSet
        '
        Me.TerraConcDataSet.DataSetName = "TerraConcDataSet"
        Me.TerraConcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BatchDateDateTimePicker
        '
        Me.BatchDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BatchTableBindingSource, "BatchDate", True))
        Me.BatchDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BatchDateDateTimePicker.Location = New System.Drawing.Point(128, 136)
        Me.BatchDateDateTimePicker.Name = "BatchDateDateTimePicker"
        Me.BatchDateDateTimePicker.Size = New System.Drawing.Size(139, 20)
        Me.BatchDateDateTimePicker.TabIndex = 4
        '
        'BatchTableBindingSource
        '
        Me.BatchTableBindingSource.DataMember = "BatchTable"
        Me.BatchTableBindingSource.DataSource = Me.TerraConcDataSet
        '
        'Specimen1DTextBox
        '
        Me.Specimen1DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Specimen1D", True))
        Me.Specimen1DTextBox.Location = New System.Drawing.Point(76, 55)
        Me.Specimen1DTextBox.Name = "Specimen1DTextBox"
        Me.Specimen1DTextBox.Size = New System.Drawing.Size(52, 20)
        Me.Specimen1DTextBox.TabIndex = 45
        Me.Specimen1DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Specimen1DTextBox.Visible = False
        '
        'Specimen2DTextBox
        '
        Me.Specimen2DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Specimen2D", True))
        Me.Specimen2DTextBox.Location = New System.Drawing.Point(76, 78)
        Me.Specimen2DTextBox.Name = "Specimen2DTextBox"
        Me.Specimen2DTextBox.Size = New System.Drawing.Size(52, 20)
        Me.Specimen2DTextBox.TabIndex = 46
        Me.Specimen2DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Specimen2DTextBox.Visible = False
        '
        'Specimen3DTextBox
        '
        Me.Specimen3DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Specimen3D", True))
        Me.Specimen3DTextBox.Location = New System.Drawing.Point(76, 101)
        Me.Specimen3DTextBox.Name = "Specimen3DTextBox"
        Me.Specimen3DTextBox.Size = New System.Drawing.Size(52, 20)
        Me.Specimen3DTextBox.TabIndex = 47
        Me.Specimen3DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Specimen3DTextBox.Visible = False
        '
        'Specimen4DTextBox
        '
        Me.Specimen4DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Specimen4D", True))
        Me.Specimen4DTextBox.Location = New System.Drawing.Point(76, 124)
        Me.Specimen4DTextBox.Name = "Specimen4DTextBox"
        Me.Specimen4DTextBox.Size = New System.Drawing.Size(52, 20)
        Me.Specimen4DTextBox.TabIndex = 48
        Me.Specimen4DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Specimen4DTextBox.Visible = False
        '
        'Specimen5DTextBox
        '
        Me.Specimen5DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Specimen5D", True))
        Me.Specimen5DTextBox.Location = New System.Drawing.Point(76, 147)
        Me.Specimen5DTextBox.Name = "Specimen5DTextBox"
        Me.Specimen5DTextBox.Size = New System.Drawing.Size(52, 20)
        Me.Specimen5DTextBox.TabIndex = 49
        Me.Specimen5DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Specimen5DTextBox.Visible = False
        '
        'Specimen1LTextBox
        '
        Me.Specimen1LTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Specimen1L", True))
        Me.Specimen1LTextBox.Location = New System.Drawing.Point(129, 55)
        Me.Specimen1LTextBox.Name = "Specimen1LTextBox"
        Me.Specimen1LTextBox.Size = New System.Drawing.Size(50, 20)
        Me.Specimen1LTextBox.TabIndex = 55
        Me.Specimen1LTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Specimen1LTextBox.Visible = False
        '
        'Specimen2LTextBox
        '
        Me.Specimen2LTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Specimen2L", True))
        Me.Specimen2LTextBox.Location = New System.Drawing.Point(129, 78)
        Me.Specimen2LTextBox.Name = "Specimen2LTextBox"
        Me.Specimen2LTextBox.Size = New System.Drawing.Size(50, 20)
        Me.Specimen2LTextBox.TabIndex = 56
        Me.Specimen2LTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Specimen2LTextBox.Visible = False
        '
        'Specimen3LTextBox
        '
        Me.Specimen3LTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Specimen3L", True))
        Me.Specimen3LTextBox.Location = New System.Drawing.Point(129, 101)
        Me.Specimen3LTextBox.Name = "Specimen3LTextBox"
        Me.Specimen3LTextBox.Size = New System.Drawing.Size(50, 20)
        Me.Specimen3LTextBox.TabIndex = 57
        Me.Specimen3LTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Specimen3LTextBox.Visible = False
        '
        'Specimen4LTextBox
        '
        Me.Specimen4LTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Specimen4L", True))
        Me.Specimen4LTextBox.Location = New System.Drawing.Point(129, 124)
        Me.Specimen4LTextBox.Name = "Specimen4LTextBox"
        Me.Specimen4LTextBox.Size = New System.Drawing.Size(50, 20)
        Me.Specimen4LTextBox.TabIndex = 58
        Me.Specimen4LTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Specimen4LTextBox.Visible = False
        '
        'Specimen5LTextBox
        '
        Me.Specimen5LTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Specimen5L", True))
        Me.Specimen5LTextBox.Location = New System.Drawing.Point(129, 147)
        Me.Specimen5LTextBox.Name = "Specimen5LTextBox"
        Me.Specimen5LTextBox.Size = New System.Drawing.Size(50, 20)
        Me.Specimen5LTextBox.TabIndex = 59
        Me.Specimen5LTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Specimen5LTextBox.Visible = False
        '
        'GrpSpecimen
        '
        Me.GrpSpecimen.Controls.Add(Me.LenTb)
        Me.GrpSpecimen.Controls.Add(CompiledByLabel)
        Me.GrpSpecimen.Controls.Add(Me.CompiledByLabl)
        Me.GrpSpecimen.Controls.Add(Me.SubMergedMass10TextBox)
        Me.GrpSpecimen.Controls.Add(Me.CubeDim)
        Me.GrpSpecimen.Controls.Add(Me.SubMergedMass9TextBox)
        Me.GrpSpecimen.Controls.Add(Me.ChkbSameDim)
        Me.GrpSpecimen.Controls.Add(Me.SubMergedMass8TextBox)
        Me.GrpSpecimen.Controls.Add(Me.SubMergedMass7TextBox)
        Me.GrpSpecimen.Controls.Add(Me.SubMergedMass6TextBox)
        Me.GrpSpecimen.Controls.Add(Me.Mass10TextBox)
        Me.GrpSpecimen.Controls.Add(Me.Mass9TextBox)
        Me.GrpSpecimen.Controls.Add(Me.Mass8TextBox)
        Me.GrpSpecimen.Controls.Add(Me.Mass7TextBox)
        Me.GrpSpecimen.Controls.Add(Me.Mass6TextBox)
        Me.GrpSpecimen.Controls.Add(Me.Specimen10HTextBox)
        Me.GrpSpecimen.Controls.Add(Me.Specimen9HTextBox)
        Me.GrpSpecimen.Controls.Add(Me.ChkSubmerged)
        Me.GrpSpecimen.Controls.Add(Me.Specimen8HTextBox)
        Me.GrpSpecimen.Controls.Add(Me.Specimen7HTextBox)
        Me.GrpSpecimen.Controls.Add(Me.Specimen6HTextBox)
        Me.GrpSpecimen.Controls.Add(Me.Specimen10LTextBox)
        Me.GrpSpecimen.Controls.Add(Me.Specimen9LTextBox)
        Me.GrpSpecimen.Controls.Add(Me.Specimen8LTextBox)
        Me.GrpSpecimen.Controls.Add(Me.Specimen7LTextBox)
        Me.GrpSpecimen.Controls.Add(Me.Specimen6LTextBox)
        Me.GrpSpecimen.Controls.Add(Me.Lab10)
        Me.GrpSpecimen.Controls.Add(Me.Lab9)
        Me.GrpSpecimen.Controls.Add(Me.Lab8)
        Me.GrpSpecimen.Controls.Add(Me.Lab7)
        Me.GrpSpecimen.Controls.Add(Me.Lab6)
        Me.GrpSpecimen.Controls.Add(Me.Specimen10DTextBox)
        Me.GrpSpecimen.Controls.Add(Me.Specimen9DTextBox)
        Me.GrpSpecimen.Controls.Add(Me.Specimen8DTextBox)
        Me.GrpSpecimen.Controls.Add(Me.Specimen7DTextBox)
        Me.GrpSpecimen.Controls.Add(Me.Specimen6DTextBox)
        Me.GrpSpecimen.Controls.Add(Me.Lab5)
        Me.GrpSpecimen.Controls.Add(Me.Lab4)
        Me.GrpSpecimen.Controls.Add(Me.Lab3)
        Me.GrpSpecimen.Controls.Add(Me.Lab2)
        Me.GrpSpecimen.Controls.Add(Me.Lab1)
        Me.GrpSpecimen.Controls.Add(Me.SubMergedMass5TextBox)
        Me.GrpSpecimen.Controls.Add(Me.SubMergedMass4TextBox)
        Me.GrpSpecimen.Controls.Add(Me.SubMergedMass3TextBox)
        Me.GrpSpecimen.Controls.Add(Me.SubMergedMass2TextBox)
        Me.GrpSpecimen.Controls.Add(Me.SubMergedMass1TextBox)
        Me.GrpSpecimen.Controls.Add(Me.SubMergedLabel)
        Me.GrpSpecimen.Controls.Add(Label7)
        Me.GrpSpecimen.Controls.Add(Me.Label6)
        Me.GrpSpecimen.Controls.Add(Me.Mass5TextBox)
        Me.GrpSpecimen.Controls.Add(Me.Mass4TextBox)
        Me.GrpSpecimen.Controls.Add(Me.Mass3TextBox)
        Me.GrpSpecimen.Controls.Add(Me.Mass2TextBox)
        Me.GrpSpecimen.Controls.Add(Me.Mass1TextBox)
        Me.GrpSpecimen.Controls.Add(Me.Specimen5HTextBox)
        Me.GrpSpecimen.Controls.Add(Me.LblHgt)
        Me.GrpSpecimen.Controls.Add(Me.Specimen4HTextBox)
        Me.GrpSpecimen.Controls.Add(Me.Specimen3HTextBox)
        Me.GrpSpecimen.Controls.Add(Me.Specimen2HTextBox)
        Me.GrpSpecimen.Controls.Add(Me.LblLen1)
        Me.GrpSpecimen.Controls.Add(Me.LblLen)
        Me.GrpSpecimen.Controls.Add(Me.Specimen1HTextBox)
        Me.GrpSpecimen.Controls.Add(Me.LblDia1)
        Me.GrpSpecimen.Controls.Add(Me.LblDia)
        Me.GrpSpecimen.Controls.Add(Me.Specimen1LTextBox)
        Me.GrpSpecimen.Controls.Add(Me.Specimen5DTextBox)
        Me.GrpSpecimen.Controls.Add(Me.Specimen2LTextBox)
        Me.GrpSpecimen.Controls.Add(Me.Specimen1DTextBox)
        Me.GrpSpecimen.Controls.Add(Me.Specimen3LTextBox)
        Me.GrpSpecimen.Controls.Add(Me.Specimen4DTextBox)
        Me.GrpSpecimen.Controls.Add(Me.Specimen4LTextBox)
        Me.GrpSpecimen.Controls.Add(Me.Specimen2DTextBox)
        Me.GrpSpecimen.Controls.Add(Me.Specimen5LTextBox)
        Me.GrpSpecimen.Controls.Add(Me.Specimen3DTextBox)
        Me.GrpSpecimen.Location = New System.Drawing.Point(290, 31)
        Me.GrpSpecimen.Name = "GrpSpecimen"
        Me.GrpSpecimen.Size = New System.Drawing.Size(349, 468)
        Me.GrpSpecimen.TabIndex = 1
        Me.GrpSpecimen.TabStop = False
        Me.GrpSpecimen.Text = "Specimen Details"
        '
        'LenTb
        '
        Me.LenTb.Location = New System.Drawing.Point(273, 356)
        Me.LenTb.Name = "LenTb"
        Me.LenTb.Size = New System.Drawing.Size(52, 20)
        Me.LenTb.TabIndex = 163
        Me.LenTb.Visible = False
        '
        'CompiledByLabl
        '
        Me.CompiledByLabl.Location = New System.Drawing.Point(84, 396)
        Me.CompiledByLabl.Name = "CompiledByLabl"
        Me.CompiledByLabl.Size = New System.Drawing.Size(100, 23)
        Me.CompiledByLabl.TabIndex = 162
        Me.CompiledByLabl.Text = "Label1"
        Me.CompiledByLabl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CompiledByLabl.Visible = False
        '
        'SubMergedMass10TextBox
        '
        Me.SubMergedMass10TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "SubMergedMass10", True))
        Me.SubMergedMass10TextBox.Location = New System.Drawing.Point(292, 262)
        Me.SubMergedMass10TextBox.Name = "SubMergedMass10TextBox"
        Me.SubMergedMass10TextBox.Size = New System.Drawing.Size(50, 20)
        Me.SubMergedMass10TextBox.TabIndex = 160
        Me.SubMergedMass10TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SubMergedMass10TextBox.Visible = False
        '
        'CubeDim
        '
        Me.CubeDim.Location = New System.Drawing.Point(215, 356)
        Me.CubeDim.Name = "CubeDim"
        Me.CubeDim.Size = New System.Drawing.Size(52, 20)
        Me.CubeDim.TabIndex = 161
        Me.CubeDim.Visible = False
        '
        'SubMergedMass9TextBox
        '
        Me.SubMergedMass9TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "SubMergedMass9", True))
        Me.SubMergedMass9TextBox.Location = New System.Drawing.Point(292, 239)
        Me.SubMergedMass9TextBox.Name = "SubMergedMass9TextBox"
        Me.SubMergedMass9TextBox.Size = New System.Drawing.Size(50, 20)
        Me.SubMergedMass9TextBox.TabIndex = 159
        Me.SubMergedMass9TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SubMergedMass9TextBox.Visible = False
        '
        'ChkbSameDim
        '
        Me.ChkbSameDim.AutoSize = True
        Me.ChkbSameDim.Location = New System.Drawing.Point(6, 359)
        Me.ChkbSameDim.Name = "ChkbSameDim"
        Me.ChkbSameDim.Size = New System.Drawing.Size(204, 17)
        Me.ChkbSameDim.TabIndex = 97
        Me.ChkbSameDim.Text = "Same Specimen Norminal Dimensions"
        Me.ChkbSameDim.UseVisualStyleBackColor = True
        Me.ChkbSameDim.Visible = False
        '
        'SubMergedMass8TextBox
        '
        Me.SubMergedMass8TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "SubMergedMass8", True))
        Me.SubMergedMass8TextBox.Location = New System.Drawing.Point(292, 216)
        Me.SubMergedMass8TextBox.Name = "SubMergedMass8TextBox"
        Me.SubMergedMass8TextBox.Size = New System.Drawing.Size(50, 20)
        Me.SubMergedMass8TextBox.TabIndex = 158
        Me.SubMergedMass8TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SubMergedMass8TextBox.Visible = False
        '
        'SubMergedMass7TextBox
        '
        Me.SubMergedMass7TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "SubMergedMass7", True))
        Me.SubMergedMass7TextBox.Location = New System.Drawing.Point(292, 193)
        Me.SubMergedMass7TextBox.Name = "SubMergedMass7TextBox"
        Me.SubMergedMass7TextBox.Size = New System.Drawing.Size(50, 20)
        Me.SubMergedMass7TextBox.TabIndex = 157
        Me.SubMergedMass7TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SubMergedMass7TextBox.Visible = False
        '
        'SubMergedMass6TextBox
        '
        Me.SubMergedMass6TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "SubMergedMass6", True))
        Me.SubMergedMass6TextBox.Location = New System.Drawing.Point(292, 170)
        Me.SubMergedMass6TextBox.Name = "SubMergedMass6TextBox"
        Me.SubMergedMass6TextBox.Size = New System.Drawing.Size(50, 20)
        Me.SubMergedMass6TextBox.TabIndex = 156
        Me.SubMergedMass6TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SubMergedMass6TextBox.Visible = False
        '
        'Mass10TextBox
        '
        Me.Mass10TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Mass10", True))
        Me.Mass10TextBox.Location = New System.Drawing.Point(236, 262)
        Me.Mass10TextBox.Name = "Mass10TextBox"
        Me.Mass10TextBox.Size = New System.Drawing.Size(50, 20)
        Me.Mass10TextBox.TabIndex = 84
        Me.Mass10TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Mass10TextBox.Visible = False
        '
        'Mass9TextBox
        '
        Me.Mass9TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Mass9", True))
        Me.Mass9TextBox.Location = New System.Drawing.Point(236, 239)
        Me.Mass9TextBox.Name = "Mass9TextBox"
        Me.Mass9TextBox.Size = New System.Drawing.Size(50, 20)
        Me.Mass9TextBox.TabIndex = 83
        Me.Mass9TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Mass9TextBox.Visible = False
        '
        'Mass8TextBox
        '
        Me.Mass8TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Mass8", True))
        Me.Mass8TextBox.Location = New System.Drawing.Point(236, 216)
        Me.Mass8TextBox.Name = "Mass8TextBox"
        Me.Mass8TextBox.Size = New System.Drawing.Size(50, 20)
        Me.Mass8TextBox.TabIndex = 82
        Me.Mass8TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Mass8TextBox.Visible = False
        '
        'Mass7TextBox
        '
        Me.Mass7TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Mass7", True))
        Me.Mass7TextBox.Location = New System.Drawing.Point(236, 193)
        Me.Mass7TextBox.Name = "Mass7TextBox"
        Me.Mass7TextBox.Size = New System.Drawing.Size(50, 20)
        Me.Mass7TextBox.TabIndex = 81
        Me.Mass7TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Mass7TextBox.Visible = False
        '
        'Mass6TextBox
        '
        Me.Mass6TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Mass6", True))
        Me.Mass6TextBox.Location = New System.Drawing.Point(236, 170)
        Me.Mass6TextBox.Name = "Mass6TextBox"
        Me.Mass6TextBox.Size = New System.Drawing.Size(50, 20)
        Me.Mass6TextBox.TabIndex = 80
        Me.Mass6TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Mass6TextBox.Visible = False
        '
        'Specimen10HTextBox
        '
        Me.Specimen10HTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Specimen10H", True))
        Me.Specimen10HTextBox.Location = New System.Drawing.Point(183, 262)
        Me.Specimen10HTextBox.Name = "Specimen10HTextBox"
        Me.Specimen10HTextBox.Size = New System.Drawing.Size(50, 20)
        Me.Specimen10HTextBox.TabIndex = 74
        Me.Specimen10HTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Specimen10HTextBox.Visible = False
        '
        'Specimen9HTextBox
        '
        Me.Specimen9HTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Specimen9H", True))
        Me.Specimen9HTextBox.Location = New System.Drawing.Point(183, 239)
        Me.Specimen9HTextBox.Name = "Specimen9HTextBox"
        Me.Specimen9HTextBox.Size = New System.Drawing.Size(50, 20)
        Me.Specimen9HTextBox.TabIndex = 73
        Me.Specimen9HTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Specimen9HTextBox.Visible = False
        '
        'ChkSubmerged
        '
        Me.ChkSubmerged.AutoSize = True
        Me.ChkSubmerged.Location = New System.Drawing.Point(6, 336)
        Me.ChkSubmerged.Name = "ChkSubmerged"
        Me.ChkSubmerged.Size = New System.Drawing.Size(188, 17)
        Me.ChkSubmerged.TabIndex = 96
        Me.ChkSubmerged.Text = "Mass of Submerged Specimen, kg"
        Me.ChkSubmerged.UseVisualStyleBackColor = True
        '
        'Specimen8HTextBox
        '
        Me.Specimen8HTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Specimen8H", True))
        Me.Specimen8HTextBox.Location = New System.Drawing.Point(183, 216)
        Me.Specimen8HTextBox.Name = "Specimen8HTextBox"
        Me.Specimen8HTextBox.Size = New System.Drawing.Size(50, 20)
        Me.Specimen8HTextBox.TabIndex = 72
        Me.Specimen8HTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Specimen8HTextBox.Visible = False
        '
        'Specimen7HTextBox
        '
        Me.Specimen7HTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Specimen7H", True))
        Me.Specimen7HTextBox.Location = New System.Drawing.Point(183, 193)
        Me.Specimen7HTextBox.Name = "Specimen7HTextBox"
        Me.Specimen7HTextBox.Size = New System.Drawing.Size(50, 20)
        Me.Specimen7HTextBox.TabIndex = 71
        Me.Specimen7HTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Specimen7HTextBox.Visible = False
        '
        'Specimen6HTextBox
        '
        Me.Specimen6HTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Specimen6H", True))
        Me.Specimen6HTextBox.Location = New System.Drawing.Point(183, 170)
        Me.Specimen6HTextBox.Name = "Specimen6HTextBox"
        Me.Specimen6HTextBox.Size = New System.Drawing.Size(50, 20)
        Me.Specimen6HTextBox.TabIndex = 70
        Me.Specimen6HTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Specimen6HTextBox.Visible = False
        '
        'Specimen10LTextBox
        '
        Me.Specimen10LTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Specimen10L", True))
        Me.Specimen10LTextBox.Location = New System.Drawing.Point(129, 262)
        Me.Specimen10LTextBox.Name = "Specimen10LTextBox"
        Me.Specimen10LTextBox.Size = New System.Drawing.Size(50, 20)
        Me.Specimen10LTextBox.TabIndex = 64
        Me.Specimen10LTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Specimen10LTextBox.Visible = False
        '
        'Specimen9LTextBox
        '
        Me.Specimen9LTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Specimen9L", True))
        Me.Specimen9LTextBox.Location = New System.Drawing.Point(129, 239)
        Me.Specimen9LTextBox.Name = "Specimen9LTextBox"
        Me.Specimen9LTextBox.Size = New System.Drawing.Size(50, 20)
        Me.Specimen9LTextBox.TabIndex = 63
        Me.Specimen9LTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Specimen9LTextBox.Visible = False
        '
        'Specimen8LTextBox
        '
        Me.Specimen8LTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Specimen8L", True))
        Me.Specimen8LTextBox.Location = New System.Drawing.Point(129, 216)
        Me.Specimen8LTextBox.Name = "Specimen8LTextBox"
        Me.Specimen8LTextBox.Size = New System.Drawing.Size(50, 20)
        Me.Specimen8LTextBox.TabIndex = 62
        Me.Specimen8LTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Specimen8LTextBox.Visible = False
        '
        'Specimen7LTextBox
        '
        Me.Specimen7LTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Specimen7L", True))
        Me.Specimen7LTextBox.Location = New System.Drawing.Point(129, 193)
        Me.Specimen7LTextBox.Name = "Specimen7LTextBox"
        Me.Specimen7LTextBox.Size = New System.Drawing.Size(50, 20)
        Me.Specimen7LTextBox.TabIndex = 61
        Me.Specimen7LTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Specimen7LTextBox.Visible = False
        '
        'Specimen6LTextBox
        '
        Me.Specimen6LTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Specimen6L", True))
        Me.Specimen6LTextBox.Location = New System.Drawing.Point(129, 170)
        Me.Specimen6LTextBox.Name = "Specimen6LTextBox"
        Me.Specimen6LTextBox.Size = New System.Drawing.Size(50, 20)
        Me.Specimen6LTextBox.TabIndex = 60
        Me.Specimen6LTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Specimen6LTextBox.Visible = False
        '
        'Lab10
        '
        Me.Lab10.AutoSize = True
        Me.Lab10.Location = New System.Drawing.Point(2, 266)
        Me.Lab10.Name = "Lab10"
        Me.Lab10.Size = New System.Drawing.Size(72, 13)
        Me.Lab10.TabIndex = 140
        Me.Lab10.Text = "Specimen 10:"
        Me.Lab10.Visible = False
        '
        'Lab9
        '
        Me.Lab9.AutoSize = True
        Me.Lab9.Location = New System.Drawing.Point(2, 243)
        Me.Lab9.Name = "Lab9"
        Me.Lab9.Size = New System.Drawing.Size(66, 13)
        Me.Lab9.TabIndex = 139
        Me.Lab9.Text = "Specimen 9:"
        Me.Lab9.Visible = False
        '
        'Lab8
        '
        Me.Lab8.AutoSize = True
        Me.Lab8.Location = New System.Drawing.Point(2, 220)
        Me.Lab8.Name = "Lab8"
        Me.Lab8.Size = New System.Drawing.Size(66, 13)
        Me.Lab8.TabIndex = 138
        Me.Lab8.Text = "Specimen 8:"
        Me.Lab8.Visible = False
        '
        'Lab7
        '
        Me.Lab7.AutoSize = True
        Me.Lab7.Location = New System.Drawing.Point(2, 197)
        Me.Lab7.Name = "Lab7"
        Me.Lab7.Size = New System.Drawing.Size(66, 13)
        Me.Lab7.TabIndex = 137
        Me.Lab7.Text = "Specimen 7:"
        Me.Lab7.Visible = False
        '
        'Lab6
        '
        Me.Lab6.AutoSize = True
        Me.Lab6.Location = New System.Drawing.Point(2, 174)
        Me.Lab6.Name = "Lab6"
        Me.Lab6.Size = New System.Drawing.Size(66, 13)
        Me.Lab6.TabIndex = 136
        Me.Lab6.Text = "Specimen 6:"
        Me.Lab6.Visible = False
        '
        'Specimen10DTextBox
        '
        Me.Specimen10DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Specimen10D", True))
        Me.Specimen10DTextBox.Location = New System.Drawing.Point(76, 262)
        Me.Specimen10DTextBox.Name = "Specimen10DTextBox"
        Me.Specimen10DTextBox.Size = New System.Drawing.Size(52, 20)
        Me.Specimen10DTextBox.TabIndex = 54
        Me.Specimen10DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Specimen10DTextBox.Visible = False
        '
        'Specimen9DTextBox
        '
        Me.Specimen9DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Specimen9D", True))
        Me.Specimen9DTextBox.Location = New System.Drawing.Point(76, 239)
        Me.Specimen9DTextBox.Name = "Specimen9DTextBox"
        Me.Specimen9DTextBox.Size = New System.Drawing.Size(52, 20)
        Me.Specimen9DTextBox.TabIndex = 53
        Me.Specimen9DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Specimen9DTextBox.Visible = False
        '
        'Specimen8DTextBox
        '
        Me.Specimen8DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Specimen8D", True))
        Me.Specimen8DTextBox.Location = New System.Drawing.Point(76, 216)
        Me.Specimen8DTextBox.Name = "Specimen8DTextBox"
        Me.Specimen8DTextBox.Size = New System.Drawing.Size(52, 20)
        Me.Specimen8DTextBox.TabIndex = 52
        Me.Specimen8DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Specimen8DTextBox.Visible = False
        '
        'Specimen7DTextBox
        '
        Me.Specimen7DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Specimen7D", True))
        Me.Specimen7DTextBox.Location = New System.Drawing.Point(76, 193)
        Me.Specimen7DTextBox.Name = "Specimen7DTextBox"
        Me.Specimen7DTextBox.Size = New System.Drawing.Size(52, 20)
        Me.Specimen7DTextBox.TabIndex = 51
        Me.Specimen7DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Specimen7DTextBox.Visible = False
        '
        'Specimen6DTextBox
        '
        Me.Specimen6DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Specimen6D", True))
        Me.Specimen6DTextBox.Location = New System.Drawing.Point(76, 170)
        Me.Specimen6DTextBox.Name = "Specimen6DTextBox"
        Me.Specimen6DTextBox.Size = New System.Drawing.Size(52, 20)
        Me.Specimen6DTextBox.TabIndex = 50
        Me.Specimen6DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Specimen6DTextBox.Visible = False
        '
        'Lab5
        '
        Me.Lab5.AutoSize = True
        Me.Lab5.Location = New System.Drawing.Point(2, 151)
        Me.Lab5.Name = "Lab5"
        Me.Lab5.Size = New System.Drawing.Size(66, 13)
        Me.Lab5.TabIndex = 130
        Me.Lab5.Text = "Specimen 5:"
        Me.Lab5.Visible = False
        '
        'Lab4
        '
        Me.Lab4.AutoSize = True
        Me.Lab4.Location = New System.Drawing.Point(2, 128)
        Me.Lab4.Name = "Lab4"
        Me.Lab4.Size = New System.Drawing.Size(66, 13)
        Me.Lab4.TabIndex = 129
        Me.Lab4.Text = "Specimen 4:"
        Me.Lab4.Visible = False
        '
        'Lab3
        '
        Me.Lab3.AutoSize = True
        Me.Lab3.Location = New System.Drawing.Point(2, 105)
        Me.Lab3.Name = "Lab3"
        Me.Lab3.Size = New System.Drawing.Size(66, 13)
        Me.Lab3.TabIndex = 128
        Me.Lab3.Text = "Specimen 3:"
        Me.Lab3.Visible = False
        '
        'Lab2
        '
        Me.Lab2.AutoSize = True
        Me.Lab2.Location = New System.Drawing.Point(2, 82)
        Me.Lab2.Name = "Lab2"
        Me.Lab2.Size = New System.Drawing.Size(66, 13)
        Me.Lab2.TabIndex = 127
        Me.Lab2.Text = "Specimen 2:"
        Me.Lab2.Visible = False
        '
        'Lab1
        '
        Me.Lab1.AutoSize = True
        Me.Lab1.Location = New System.Drawing.Point(2, 59)
        Me.Lab1.Name = "Lab1"
        Me.Lab1.Size = New System.Drawing.Size(66, 13)
        Me.Lab1.TabIndex = 126
        Me.Lab1.Text = "Specimen 1:"
        Me.Lab1.Visible = False
        '
        'SubMergedMass5TextBox
        '
        Me.SubMergedMass5TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "SubMergedMass5", True))
        Me.SubMergedMass5TextBox.Location = New System.Drawing.Point(292, 147)
        Me.SubMergedMass5TextBox.Name = "SubMergedMass5TextBox"
        Me.SubMergedMass5TextBox.Size = New System.Drawing.Size(50, 20)
        Me.SubMergedMass5TextBox.TabIndex = 125
        Me.SubMergedMass5TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SubMergedMass5TextBox.Visible = False
        '
        'SubMergedMass4TextBox
        '
        Me.SubMergedMass4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "SubMergedMass4", True))
        Me.SubMergedMass4TextBox.Location = New System.Drawing.Point(292, 124)
        Me.SubMergedMass4TextBox.Name = "SubMergedMass4TextBox"
        Me.SubMergedMass4TextBox.Size = New System.Drawing.Size(50, 20)
        Me.SubMergedMass4TextBox.TabIndex = 124
        Me.SubMergedMass4TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SubMergedMass4TextBox.Visible = False
        '
        'SubMergedMass3TextBox
        '
        Me.SubMergedMass3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "SubMergedMass3", True))
        Me.SubMergedMass3TextBox.Location = New System.Drawing.Point(292, 101)
        Me.SubMergedMass3TextBox.Name = "SubMergedMass3TextBox"
        Me.SubMergedMass3TextBox.Size = New System.Drawing.Size(50, 20)
        Me.SubMergedMass3TextBox.TabIndex = 123
        Me.SubMergedMass3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SubMergedMass3TextBox.Visible = False
        '
        'SubMergedMass2TextBox
        '
        Me.SubMergedMass2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "SubMergedMass2", True))
        Me.SubMergedMass2TextBox.Location = New System.Drawing.Point(292, 78)
        Me.SubMergedMass2TextBox.Name = "SubMergedMass2TextBox"
        Me.SubMergedMass2TextBox.Size = New System.Drawing.Size(50, 20)
        Me.SubMergedMass2TextBox.TabIndex = 86
        Me.SubMergedMass2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SubMergedMass2TextBox.Visible = False
        '
        'SubMergedMass1TextBox
        '
        Me.SubMergedMass1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "SubMergedMass1", True))
        Me.SubMergedMass1TextBox.Location = New System.Drawing.Point(292, 55)
        Me.SubMergedMass1TextBox.Name = "SubMergedMass1TextBox"
        Me.SubMergedMass1TextBox.Size = New System.Drawing.Size(50, 20)
        Me.SubMergedMass1TextBox.TabIndex = 85
        Me.SubMergedMass1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SubMergedMass1TextBox.Visible = False
        '
        'SubMergedLabel
        '
        Me.SubMergedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubMergedLabel.Location = New System.Drawing.Point(292, 18)
        Me.SubMergedLabel.Name = "SubMergedLabel"
        Me.SubMergedLabel.Size = New System.Drawing.Size(46, 30)
        Me.SubMergedLabel.TabIndex = 120
        Me.SubMergedLabel.Text = "Sub. Mass (Kg)"
        Me.SubMergedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(240, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 30)
        Me.Label6.TabIndex = 112
        Me.Label6.Text = "Mass in Air (Kg)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Mass5TextBox
        '
        Me.Mass5TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Mass5", True))
        Me.Mass5TextBox.Location = New System.Drawing.Point(236, 147)
        Me.Mass5TextBox.Name = "Mass5TextBox"
        Me.Mass5TextBox.Size = New System.Drawing.Size(50, 20)
        Me.Mass5TextBox.TabIndex = 79
        Me.Mass5TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Mass5TextBox.Visible = False
        '
        'Mass4TextBox
        '
        Me.Mass4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Mass4", True))
        Me.Mass4TextBox.Location = New System.Drawing.Point(236, 124)
        Me.Mass4TextBox.Name = "Mass4TextBox"
        Me.Mass4TextBox.Size = New System.Drawing.Size(50, 20)
        Me.Mass4TextBox.TabIndex = 78
        Me.Mass4TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Mass4TextBox.Visible = False
        '
        'Mass3TextBox
        '
        Me.Mass3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Mass3", True))
        Me.Mass3TextBox.Location = New System.Drawing.Point(236, 101)
        Me.Mass3TextBox.Name = "Mass3TextBox"
        Me.Mass3TextBox.Size = New System.Drawing.Size(50, 20)
        Me.Mass3TextBox.TabIndex = 77
        Me.Mass3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Mass3TextBox.Visible = False
        '
        'Mass2TextBox
        '
        Me.Mass2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Mass2", True))
        Me.Mass2TextBox.Location = New System.Drawing.Point(236, 78)
        Me.Mass2TextBox.Name = "Mass2TextBox"
        Me.Mass2TextBox.Size = New System.Drawing.Size(50, 20)
        Me.Mass2TextBox.TabIndex = 76
        Me.Mass2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Mass2TextBox.Visible = False
        '
        'Mass1TextBox
        '
        Me.Mass1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Mass1", True))
        Me.Mass1TextBox.Location = New System.Drawing.Point(236, 55)
        Me.Mass1TextBox.Name = "Mass1TextBox"
        Me.Mass1TextBox.Size = New System.Drawing.Size(50, 20)
        Me.Mass1TextBox.TabIndex = 75
        Me.Mass1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Mass1TextBox.Visible = False
        '
        'Specimen5HTextBox
        '
        Me.Specimen5HTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Specimen5H", True))
        Me.Specimen5HTextBox.Location = New System.Drawing.Point(183, 147)
        Me.Specimen5HTextBox.Name = "Specimen5HTextBox"
        Me.Specimen5HTextBox.Size = New System.Drawing.Size(50, 20)
        Me.Specimen5HTextBox.TabIndex = 69
        Me.Specimen5HTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Specimen5HTextBox.Visible = False
        '
        'LblHgt
        '
        Me.LblHgt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHgt.Location = New System.Drawing.Point(180, 17)
        Me.LblHgt.Name = "LblHgt"
        Me.LblHgt.Size = New System.Drawing.Size(53, 30)
        Me.LblHgt.TabIndex = 101
        Me.LblHgt.Text = "Height (mm)"
        Me.LblHgt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Specimen4HTextBox
        '
        Me.Specimen4HTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Specimen4H", True))
        Me.Specimen4HTextBox.Location = New System.Drawing.Point(183, 124)
        Me.Specimen4HTextBox.Name = "Specimen4HTextBox"
        Me.Specimen4HTextBox.Size = New System.Drawing.Size(50, 20)
        Me.Specimen4HTextBox.TabIndex = 68
        Me.Specimen4HTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Specimen4HTextBox.Visible = False
        '
        'Specimen3HTextBox
        '
        Me.Specimen3HTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Specimen3H", True))
        Me.Specimen3HTextBox.Location = New System.Drawing.Point(183, 101)
        Me.Specimen3HTextBox.Name = "Specimen3HTextBox"
        Me.Specimen3HTextBox.Size = New System.Drawing.Size(50, 20)
        Me.Specimen3HTextBox.TabIndex = 67
        Me.Specimen3HTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Specimen3HTextBox.Visible = False
        '
        'Specimen2HTextBox
        '
        Me.Specimen2HTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Specimen2H", True))
        Me.Specimen2HTextBox.Location = New System.Drawing.Point(183, 78)
        Me.Specimen2HTextBox.Name = "Specimen2HTextBox"
        Me.Specimen2HTextBox.Size = New System.Drawing.Size(50, 20)
        Me.Specimen2HTextBox.TabIndex = 66
        Me.Specimen2HTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Specimen2HTextBox.Visible = False
        '
        'LblLen1
        '
        Me.LblLen1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLen1.Location = New System.Drawing.Point(265, 322)
        Me.LblLen1.Name = "LblLen1"
        Me.LblLen1.Size = New System.Drawing.Size(53, 30)
        Me.LblLen1.TabIndex = 64
        Me.LblLen1.Text = "Length (mm)"
        Me.LblLen1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblLen1.Visible = False
        '
        'LblLen
        '
        Me.LblLen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLen.Location = New System.Drawing.Point(126, 17)
        Me.LblLen.Name = "LblLen"
        Me.LblLen.Size = New System.Drawing.Size(53, 30)
        Me.LblLen.TabIndex = 64
        Me.LblLen.Text = "Length (mm)"
        Me.LblLen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Specimen1HTextBox
        '
        Me.Specimen1HTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Specimen1H", True))
        Me.Specimen1HTextBox.Location = New System.Drawing.Point(183, 55)
        Me.Specimen1HTextBox.Name = "Specimen1HTextBox"
        Me.Specimen1HTextBox.Size = New System.Drawing.Size(50, 20)
        Me.Specimen1HTextBox.TabIndex = 65
        Me.Specimen1HTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Specimen1HTextBox.Visible = False
        '
        'LblDia1
        '
        Me.LblDia1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDia1.Location = New System.Drawing.Point(215, 322)
        Me.LblDia1.Name = "LblDia1"
        Me.LblDia1.Size = New System.Drawing.Size(52, 30)
        Me.LblDia1.TabIndex = 54
        Me.LblDia1.Text = "Diameter (mm)"
        Me.LblDia1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblDia1.Visible = False
        '
        'LblDia
        '
        Me.LblDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDia.Location = New System.Drawing.Point(76, 17)
        Me.LblDia.Name = "LblDia"
        Me.LblDia.Size = New System.Drawing.Size(52, 30)
        Me.LblDia.TabIndex = 54
        Me.LblDia.Text = "Diameter (mm)"
        Me.LblDia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GrpBatch
        '
        Me.GrpBatch.Controls.Add(Me.BtnApply)
        Me.GrpBatch.Controls.Add(Me.MethodOfCompactionComboBox)
        Me.GrpBatch.Controls.Add(Me.BatchTimeTextBox)
        Me.GrpBatch.Controls.Add(Me.NoOfSpecimen)
        Me.GrpBatch.Controls.Add(TestMethodLabel)
        Me.GrpBatch.Controls.Add(Me.TestMethodComboBox)
        Me.GrpBatch.Controls.Add(CuringConditionsLabel)
        Me.GrpBatch.Controls.Add(Me.CuringConditionsTextBox)
        Me.GrpBatch.Controls.Add(SpecificationOfConcreteMixLabel)
        Me.GrpBatch.Controls.Add(Me.SpecificationOfConcreteMixTextBox)
        Me.GrpBatch.Controls.Add(MethodOfCompactionLabel)
        Me.GrpBatch.Controls.Add(SupplySourceLabel)
        Me.GrpBatch.Controls.Add(Me.SupplySourceTextBox)
        Me.GrpBatch.Controls.Add(BatchTimeLabel)
        Me.GrpBatch.Controls.Add(NameOfSamplerLabel)
        Me.GrpBatch.Controls.Add(Me.NameOfSamplerTextBox)
        Me.GrpBatch.Controls.Add(BatchIdentificationNoLabel)
        Me.GrpBatch.Controls.Add(Me.BatchIdentificationNoTextBox)
        Me.GrpBatch.Controls.Add(StructuralElementLabel)
        Me.GrpBatch.Controls.Add(Me.StructuralElementComboBox)
        Me.GrpBatch.Controls.Add(Me.CmbShape)
        Me.GrpBatch.Controls.Add(Me.Label3)
        Me.GrpBatch.Controls.Add(BatchDateLabel)
        Me.GrpBatch.Controls.Add(Me.SpecimenAgeTextBox)
        Me.GrpBatch.Controls.Add(Me.BatchDateDateTimePicker)
        Me.GrpBatch.Controls.Add(NoOfSpecimenLabel)
        Me.GrpBatch.Controls.Add(SpecimenAgeLabel)
        Me.GrpBatch.Location = New System.Drawing.Point(3, 31)
        Me.GrpBatch.Name = "GrpBatch"
        Me.GrpBatch.Size = New System.Drawing.Size(283, 468)
        Me.GrpBatch.TabIndex = 0
        Me.GrpBatch.TabStop = False
        Me.GrpBatch.Text = "Batch Information"
        '
        'BtnApply
        '
        Me.BtnApply.Location = New System.Drawing.Point(168, 420)
        Me.BtnApply.Name = "BtnApply"
        Me.BtnApply.Size = New System.Drawing.Size(97, 21)
        Me.BtnApply.TabIndex = 163
        Me.BtnApply.Text = "Apply"
        Me.BtnApply.UseVisualStyleBackColor = True
        '
        'MethodOfCompactionComboBox
        '
        Me.MethodOfCompactionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "MethodOfCompaction", True))
        Me.MethodOfCompactionComboBox.FormattingEnabled = True
        Me.MethodOfCompactionComboBox.Items.AddRange(New Object() {"By Hand", "Vibration"})
        Me.MethodOfCompactionComboBox.Location = New System.Drawing.Point(129, 228)
        Me.MethodOfCompactionComboBox.Name = "MethodOfCompactionComboBox"
        Me.MethodOfCompactionComboBox.Size = New System.Drawing.Size(136, 21)
        Me.MethodOfCompactionComboBox.TabIndex = 8
        '
        'BatchTimeTextBox
        '
        Me.BatchTimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "BatchTime", True))
        Me.BatchTimeTextBox.Location = New System.Drawing.Point(128, 160)
        Me.BatchTimeTextBox.Name = "BatchTimeTextBox"
        Me.BatchTimeTextBox.Size = New System.Drawing.Size(139, 20)
        Me.BatchTimeTextBox.TabIndex = 162
        Me.BatchTimeTextBox.Text = "hh:mm:ss"
        '
        'NoOfSpecimen
        '
        Me.NoOfSpecimen.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BatchTableBindingSource, "NoOfSpecimen", True))
        Me.NoOfSpecimen.Location = New System.Drawing.Point(129, 205)
        Me.NoOfSpecimen.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NoOfSpecimen.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NoOfSpecimen.Name = "NoOfSpecimen"
        Me.NoOfSpecimen.Size = New System.Drawing.Size(138, 20)
        Me.NoOfSpecimen.TabIndex = 7
        Me.NoOfSpecimen.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'TestMethodComboBox
        '
        Me.TestMethodComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "TestMethod", True))
        Me.TestMethodComboBox.FormattingEnabled = True
        Me.TestMethodComboBox.Items.AddRange(New Object() {"BS 1881-116 : 1983", "ASTM C39/C39M − 20"})
        Me.TestMethodComboBox.Location = New System.Drawing.Point(127, 306)
        Me.TestMethodComboBox.Name = "TestMethodComboBox"
        Me.TestMethodComboBox.Size = New System.Drawing.Size(139, 21)
        Me.TestMethodComboBox.TabIndex = 12
        '
        'CuringConditionsTextBox
        '
        Me.CuringConditionsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "CuringConditions", True))
        Me.CuringConditionsTextBox.Location = New System.Drawing.Point(127, 281)
        Me.CuringConditionsTextBox.Name = "CuringConditionsTextBox"
        Me.CuringConditionsTextBox.Size = New System.Drawing.Size(139, 20)
        Me.CuringConditionsTextBox.TabIndex = 11
        '
        'SpecificationOfConcreteMixTextBox
        '
        Me.SpecificationOfConcreteMixTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "SpecificationOfConcreteMix", True))
        Me.SpecificationOfConcreteMixTextBox.Location = New System.Drawing.Point(128, 102)
        Me.SpecificationOfConcreteMixTextBox.Multiline = True
        Me.SpecificationOfConcreteMixTextBox.Name = "SpecificationOfConcreteMixTextBox"
        Me.SpecificationOfConcreteMixTextBox.Size = New System.Drawing.Size(139, 31)
        Me.SpecificationOfConcreteMixTextBox.TabIndex = 3
        '
        'SupplySourceTextBox
        '
        Me.SupplySourceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "SupplySource", True))
        Me.SupplySourceTextBox.Location = New System.Drawing.Point(128, 55)
        Me.SupplySourceTextBox.Name = "SupplySourceTextBox"
        Me.SupplySourceTextBox.Size = New System.Drawing.Size(139, 20)
        Me.SupplySourceTextBox.TabIndex = 1
        '
        'NameOfSamplerTextBox
        '
        Me.NameOfSamplerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "NameOfSampler", True))
        Me.NameOfSamplerTextBox.Location = New System.Drawing.Point(128, 182)
        Me.NameOfSamplerTextBox.Name = "NameOfSamplerTextBox"
        Me.NameOfSamplerTextBox.Size = New System.Drawing.Size(139, 20)
        Me.NameOfSamplerTextBox.TabIndex = 6
        '
        'BatchIdentificationNoTextBox
        '
        Me.BatchIdentificationNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "BatchIdentificationNo", True))
        Me.BatchIdentificationNoTextBox.Location = New System.Drawing.Point(128, 32)
        Me.BatchIdentificationNoTextBox.Name = "BatchIdentificationNoTextBox"
        Me.BatchIdentificationNoTextBox.Size = New System.Drawing.Size(139, 20)
        Me.BatchIdentificationNoTextBox.TabIndex = 0
        '
        'StructuralElementComboBox
        '
        Me.StructuralElementComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "StructuralElement", True))
        Me.StructuralElementComboBox.FormattingEnabled = True
        Me.StructuralElementComboBox.Items.AddRange(New Object() {"Beam", "Slab", "Retaining Wall", "Column", "Foundation Footing"})
        Me.StructuralElementComboBox.Location = New System.Drawing.Point(128, 78)
        Me.StructuralElementComboBox.Name = "StructuralElementComboBox"
        Me.StructuralElementComboBox.Size = New System.Drawing.Size(139, 21)
        Me.StructuralElementComboBox.TabIndex = 2
        '
        'CmbShape
        '
        Me.CmbShape.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "SpecimenShape", True))
        Me.CmbShape.FormattingEnabled = True
        Me.CmbShape.Items.AddRange(New Object() {"Cube", "Cylinder", "Other"})
        Me.CmbShape.Location = New System.Drawing.Point(128, 253)
        Me.CmbShape.Name = "CmbShape"
        Me.CmbShape.Size = New System.Drawing.Size(139, 21)
        Me.CmbShape.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Specimen Shape :"
        '
        'SpecimenAgeTextBox
        '
        Me.SpecimenAgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "SpecimenAge", True))
        Me.SpecimenAgeTextBox.Location = New System.Drawing.Point(127, 328)
        Me.SpecimenAgeTextBox.Name = "SpecimenAgeTextBox"
        Me.SpecimenAgeTextBox.ReadOnly = True
        Me.SpecimenAgeTextBox.Size = New System.Drawing.Size(139, 20)
        Me.SpecimenAgeTextBox.TabIndex = 10
        Me.SpecimenAgeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Grptest
        '
        Me.Grptest.Controls.Add(Me.Label9)
        Me.Grptest.Controls.Add(Me.TestCertificateTextBox)
        Me.Grptest.Controls.Add(DateDeliveredLabel)
        Me.Grptest.Controls.Add(TestCertificateLabel)
        Me.Grptest.Controls.Add(Me.DateDeliveredDateTimePicker)
        Me.Grptest.Controls.Add(ApprovedDateLabel)
        Me.Grptest.Controls.Add(Me.ApprovedDateDateTimePicker)
        Me.Grptest.Controls.Add(CheckedDateLabel)
        Me.Grptest.Controls.Add(Me.CheckedDateDateTimePicker)
        Me.Grptest.Controls.Add(ApprovedByLabel)
        Me.Grptest.Controls.Add(Me.ApprovedByTextBox)
        Me.Grptest.Controls.Add(CheckedByLabel)
        Me.Grptest.Controls.Add(Me.CheckedByTextBox)
        Me.Grptest.Controls.Add(TestedByLabel)
        Me.Grptest.Controls.Add(Me.TestedByTextBox)
        Me.Grptest.Controls.Add(ConcreteGradeLabel)
        Me.Grptest.Controls.Add(Me.ConcreteGradeTextBox)
        Me.Grptest.Controls.Add(TestdateLabel)
        Me.Grptest.Controls.Add(Me.TestdateDateTimePicker)
        Me.Grptest.Controls.Add(TestingLaboratoryLabel)
        Me.Grptest.Controls.Add(Me.TestingLaboratoryTextBox)
        Me.Grptest.Controls.Add(AveStrengthLabel)
        Me.Grptest.Controls.Add(Me.AveStrength)
        Me.Grptest.Controls.Add(Me.AveDensity)
        Me.Grptest.Controls.Add(Me.CompStrength10)
        Me.Grptest.Controls.Add(Me.CompStrength9)
        Me.Grptest.Controls.Add(Me.CompStrength8)
        Me.Grptest.Controls.Add(Me.CompStrength7)
        Me.Grptest.Controls.Add(Me.CompStrength6)
        Me.Grptest.Controls.Add(Me.Density10)
        Me.Grptest.Controls.Add(Me.Density9)
        Me.Grptest.Controls.Add(Me.Density8)
        Me.Grptest.Controls.Add(Me.Density7)
        Me.Grptest.Controls.Add(Me.Density6)
        Me.Grptest.Controls.Add(Me.Area10)
        Me.Grptest.Controls.Add(Me.Area9)
        Me.Grptest.Controls.Add(Me.Area8)
        Me.Grptest.Controls.Add(Me.Area7)
        Me.Grptest.Controls.Add(Me.Area6)
        Me.Grptest.Controls.Add(Me.MaxLoad10TextBox)
        Me.Grptest.Controls.Add(Me.MaxLoad9TextBox)
        Me.Grptest.Controls.Add(Me.MaxLoad8TextBox)
        Me.Grptest.Controls.Add(Me.MaxLoad7TextBox)
        Me.Grptest.Controls.Add(Me.MaxLoad6TextBox)
        Me.Grptest.Controls.Add(Label8)
        Me.Grptest.Controls.Add(Me.Density5)
        Me.Grptest.Controls.Add(Me.Density4)
        Me.Grptest.Controls.Add(Me.Density3)
        Me.Grptest.Controls.Add(Me.Density2)
        Me.Grptest.Controls.Add(Me.Density1)
        Me.Grptest.Controls.Add(Me.Area5)
        Me.Grptest.Controls.Add(Me.Area4)
        Me.Grptest.Controls.Add(Me.Area3)
        Me.Grptest.Controls.Add(Me.Area2)
        Me.Grptest.Controls.Add(Me.Area1)
        Me.Grptest.Controls.Add(Label10)
        Me.Grptest.Controls.Add(Me.CompStrength5)
        Me.Grptest.Controls.Add(Me.CompStrength4)
        Me.Grptest.Controls.Add(Me.CompStrength3)
        Me.Grptest.Controls.Add(Me.CompStrength2)
        Me.Grptest.Controls.Add(Me.CompStrength1)
        Me.Grptest.Controls.Add(Me.Label5)
        Me.Grptest.Controls.Add(CompStrength1Label)
        Me.Grptest.Controls.Add(Me.MaxLoad1TextBox)
        Me.Grptest.Controls.Add(Me.MaxLoad2TextBox)
        Me.Grptest.Controls.Add(Me.MaxLoad3TextBox)
        Me.Grptest.Controls.Add(Me.MaxLoad4TextBox)
        Me.Grptest.Controls.Add(Me.MaxLoad5TextBox)
        Me.Grptest.Location = New System.Drawing.Point(645, 31)
        Me.Grptest.Name = "Grptest"
        Me.Grptest.Size = New System.Drawing.Size(401, 468)
        Me.Grptest.TabIndex = 2
        Me.Grptest.TabStop = False
        Me.Grptest.Text = "Test Information"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(6, 396)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 20)
        Me.Label9.TabIndex = 210
        Me.Label9.Text = "Ave. Density:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TestCertificateTextBox
        '
        Me.TestCertificateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "TestCertificate", True))
        Me.TestCertificateTextBox.Location = New System.Drawing.Point(105, 419)
        Me.TestCertificateTextBox.Multiline = True
        Me.TestCertificateTextBox.Name = "TestCertificateTextBox"
        Me.TestCertificateTextBox.ReadOnly = True
        Me.TestCertificateTextBox.Size = New System.Drawing.Size(279, 34)
        Me.TestCertificateTextBox.TabIndex = 161
        '
        'DateDeliveredDateTimePicker
        '
        Me.DateDeliveredDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BatchTableBindingSource, "DateDelivered", True))
        Me.DateDeliveredDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDeliveredDateTimePicker.Location = New System.Drawing.Point(299, 309)
        Me.DateDeliveredDateTimePicker.Name = "DateDeliveredDateTimePicker"
        Me.DateDeliveredDateTimePicker.Size = New System.Drawing.Size(78, 20)
        Me.DateDeliveredDateTimePicker.TabIndex = 204
        '
        'ApprovedDateDateTimePicker
        '
        Me.ApprovedDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BatchTableBindingSource, "ApprovedDate", True))
        Me.ApprovedDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ApprovedDateDateTimePicker.Location = New System.Drawing.Point(299, 372)
        Me.ApprovedDateDateTimePicker.Name = "ApprovedDateDateTimePicker"
        Me.ApprovedDateDateTimePicker.Size = New System.Drawing.Size(78, 20)
        Me.ApprovedDateDateTimePicker.TabIndex = 202
        '
        'CheckedDateDateTimePicker
        '
        Me.CheckedDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BatchTableBindingSource, "CheckedDate", True))
        Me.CheckedDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.CheckedDateDateTimePicker.Location = New System.Drawing.Point(299, 351)
        Me.CheckedDateDateTimePicker.Name = "CheckedDateDateTimePicker"
        Me.CheckedDateDateTimePicker.Size = New System.Drawing.Size(78, 20)
        Me.CheckedDateDateTimePicker.TabIndex = 200
        '
        'ApprovedByTextBox
        '
        Me.ApprovedByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "ApprovedBy", True))
        Me.ApprovedByTextBox.Location = New System.Drawing.Point(105, 372)
        Me.ApprovedByTextBox.Name = "ApprovedByTextBox"
        Me.ApprovedByTextBox.Size = New System.Drawing.Size(104, 20)
        Me.ApprovedByTextBox.TabIndex = 198
        '
        'CheckedByTextBox
        '
        Me.CheckedByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "CheckedBy", True))
        Me.CheckedByTextBox.Location = New System.Drawing.Point(105, 351)
        Me.CheckedByTextBox.Name = "CheckedByTextBox"
        Me.CheckedByTextBox.Size = New System.Drawing.Size(104, 20)
        Me.CheckedByTextBox.TabIndex = 196
        '
        'TestedByTextBox
        '
        Me.TestedByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "TestedBy", True))
        Me.TestedByTextBox.Location = New System.Drawing.Point(105, 330)
        Me.TestedByTextBox.Name = "TestedByTextBox"
        Me.TestedByTextBox.Size = New System.Drawing.Size(104, 20)
        Me.TestedByTextBox.TabIndex = 194
        '
        'ConcreteGradeTextBox
        '
        Me.ConcreteGradeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "ConcreteGrade", True))
        Me.ConcreteGradeTextBox.Location = New System.Drawing.Point(105, 309)
        Me.ConcreteGradeTextBox.Name = "ConcreteGradeTextBox"
        Me.ConcreteGradeTextBox.Size = New System.Drawing.Size(104, 20)
        Me.ConcreteGradeTextBox.TabIndex = 192
        '
        'TestdateDateTimePicker
        '
        Me.TestdateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BatchTableBindingSource, "Testdate", True))
        Me.TestdateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TestdateDateTimePicker.Location = New System.Drawing.Point(299, 330)
        Me.TestdateDateTimePicker.Name = "TestdateDateTimePicker"
        Me.TestdateDateTimePicker.Size = New System.Drawing.Size(78, 20)
        Me.TestdateDateTimePicker.TabIndex = 190
        '
        'TestingLaboratoryTextBox
        '
        Me.TestingLaboratoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "TestingLaboratory", True))
        Me.TestingLaboratoryTextBox.Location = New System.Drawing.Point(105, 288)
        Me.TestingLaboratoryTextBox.Name = "TestingLaboratoryTextBox"
        Me.TestingLaboratoryTextBox.Size = New System.Drawing.Size(272, 20)
        Me.TestingLaboratoryTextBox.TabIndex = 188
        '
        'AveStrength
        '
        Me.AveStrength.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "AveStrength", True))
        Me.AveStrength.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AveStrength.ForeColor = System.Drawing.Color.Navy
        Me.AveStrength.Location = New System.Drawing.Point(302, 396)
        Me.AveStrength.Name = "AveStrength"
        Me.AveStrength.Size = New System.Drawing.Size(82, 20)
        Me.AveStrength.TabIndex = 208
        Me.AveStrength.Text = "Label9"
        Me.AveStrength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AveDensity
        '
        Me.AveDensity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "AveDensity", True))
        Me.AveDensity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AveDensity.ForeColor = System.Drawing.Color.Navy
        Me.AveDensity.Location = New System.Drawing.Point(105, 396)
        Me.AveDensity.Name = "AveDensity"
        Me.AveDensity.Size = New System.Drawing.Size(93, 20)
        Me.AveDensity.TabIndex = 209
        Me.AveDensity.Text = "Label9"
        Me.AveDensity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CompStrength10
        '
        Me.CompStrength10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CompStrength10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "CompStrength10", True))
        Me.CompStrength10.ForeColor = System.Drawing.Color.Navy
        Me.CompStrength10.Location = New System.Drawing.Point(254, 262)
        Me.CompStrength10.Name = "CompStrength10"
        Me.CompStrength10.Size = New System.Drawing.Size(75, 20)
        Me.CompStrength10.TabIndex = 186
        Me.CompStrength10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CompStrength10.Visible = False
        '
        'CompStrength9
        '
        Me.CompStrength9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CompStrength9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "CompStrength9", True))
        Me.CompStrength9.ForeColor = System.Drawing.Color.Navy
        Me.CompStrength9.Location = New System.Drawing.Point(254, 239)
        Me.CompStrength9.Name = "CompStrength9"
        Me.CompStrength9.Size = New System.Drawing.Size(75, 20)
        Me.CompStrength9.TabIndex = 185
        Me.CompStrength9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CompStrength9.Visible = False
        '
        'CompStrength8
        '
        Me.CompStrength8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CompStrength8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "CompStrength8", True))
        Me.CompStrength8.ForeColor = System.Drawing.Color.Navy
        Me.CompStrength8.Location = New System.Drawing.Point(254, 216)
        Me.CompStrength8.Name = "CompStrength8"
        Me.CompStrength8.Size = New System.Drawing.Size(75, 20)
        Me.CompStrength8.TabIndex = 184
        Me.CompStrength8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CompStrength8.Visible = False
        '
        'CompStrength7
        '
        Me.CompStrength7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CompStrength7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "CompStrength7", True))
        Me.CompStrength7.ForeColor = System.Drawing.Color.Navy
        Me.CompStrength7.Location = New System.Drawing.Point(254, 193)
        Me.CompStrength7.Name = "CompStrength7"
        Me.CompStrength7.Size = New System.Drawing.Size(75, 20)
        Me.CompStrength7.TabIndex = 183
        Me.CompStrength7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CompStrength7.Visible = False
        '
        'CompStrength6
        '
        Me.CompStrength6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CompStrength6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "CompStrength6", True))
        Me.CompStrength6.ForeColor = System.Drawing.Color.Navy
        Me.CompStrength6.Location = New System.Drawing.Point(254, 169)
        Me.CompStrength6.Name = "CompStrength6"
        Me.CompStrength6.Size = New System.Drawing.Size(75, 20)
        Me.CompStrength6.TabIndex = 182
        Me.CompStrength6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CompStrength6.Visible = False
        '
        'Density10
        '
        Me.Density10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Density10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Density10", True))
        Me.Density10.ForeColor = System.Drawing.Color.Navy
        Me.Density10.Location = New System.Drawing.Point(150, 262)
        Me.Density10.Name = "Density10"
        Me.Density10.Size = New System.Drawing.Size(98, 20)
        Me.Density10.TabIndex = 181
        Me.Density10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Density10.Visible = False
        '
        'Density9
        '
        Me.Density9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Density9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Density9", True))
        Me.Density9.ForeColor = System.Drawing.Color.Navy
        Me.Density9.Location = New System.Drawing.Point(150, 239)
        Me.Density9.Name = "Density9"
        Me.Density9.Size = New System.Drawing.Size(98, 20)
        Me.Density9.TabIndex = 180
        Me.Density9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Density9.Visible = False
        '
        'Density8
        '
        Me.Density8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Density8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Density8", True))
        Me.Density8.ForeColor = System.Drawing.Color.Navy
        Me.Density8.Location = New System.Drawing.Point(150, 216)
        Me.Density8.Name = "Density8"
        Me.Density8.Size = New System.Drawing.Size(98, 20)
        Me.Density8.TabIndex = 179
        Me.Density8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Density8.Visible = False
        '
        'Density7
        '
        Me.Density7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Density7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Density7", True))
        Me.Density7.ForeColor = System.Drawing.Color.Navy
        Me.Density7.Location = New System.Drawing.Point(150, 193)
        Me.Density7.Name = "Density7"
        Me.Density7.Size = New System.Drawing.Size(98, 20)
        Me.Density7.TabIndex = 178
        Me.Density7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Density7.Visible = False
        '
        'Density6
        '
        Me.Density6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Density6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Density6", True))
        Me.Density6.ForeColor = System.Drawing.Color.Navy
        Me.Density6.Location = New System.Drawing.Point(150, 169)
        Me.Density6.Name = "Density6"
        Me.Density6.Size = New System.Drawing.Size(98, 20)
        Me.Density6.TabIndex = 177
        Me.Density6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Density6.Visible = False
        '
        'Area10
        '
        Me.Area10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Area10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Area10", True))
        Me.Area10.ForeColor = System.Drawing.Color.Navy
        Me.Area10.Location = New System.Drawing.Point(69, 262)
        Me.Area10.Name = "Area10"
        Me.Area10.Size = New System.Drawing.Size(75, 20)
        Me.Area10.TabIndex = 176
        Me.Area10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Area10.Visible = False
        '
        'Area9
        '
        Me.Area9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Area9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Area9", True))
        Me.Area9.ForeColor = System.Drawing.Color.Navy
        Me.Area9.Location = New System.Drawing.Point(69, 239)
        Me.Area9.Name = "Area9"
        Me.Area9.Size = New System.Drawing.Size(75, 20)
        Me.Area9.TabIndex = 175
        Me.Area9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Area9.Visible = False
        '
        'Area8
        '
        Me.Area8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Area8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Area8", True))
        Me.Area8.ForeColor = System.Drawing.Color.Navy
        Me.Area8.Location = New System.Drawing.Point(69, 216)
        Me.Area8.Name = "Area8"
        Me.Area8.Size = New System.Drawing.Size(75, 20)
        Me.Area8.TabIndex = 174
        Me.Area8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Area8.Visible = False
        '
        'Area7
        '
        Me.Area7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Area7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Area7", True))
        Me.Area7.ForeColor = System.Drawing.Color.Navy
        Me.Area7.Location = New System.Drawing.Point(69, 193)
        Me.Area7.Name = "Area7"
        Me.Area7.Size = New System.Drawing.Size(75, 20)
        Me.Area7.TabIndex = 173
        Me.Area7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Area7.Visible = False
        '
        'Area6
        '
        Me.Area6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Area6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Area6", True))
        Me.Area6.ForeColor = System.Drawing.Color.Navy
        Me.Area6.Location = New System.Drawing.Point(69, 169)
        Me.Area6.Name = "Area6"
        Me.Area6.Size = New System.Drawing.Size(75, 20)
        Me.Area6.TabIndex = 172
        Me.Area6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Area6.Visible = False
        '
        'MaxLoad10TextBox
        '
        Me.MaxLoad10TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "MaxLoad10", True))
        Me.MaxLoad10TextBox.Location = New System.Drawing.Point(9, 262)
        Me.MaxLoad10TextBox.Name = "MaxLoad10TextBox"
        Me.MaxLoad10TextBox.Size = New System.Drawing.Size(55, 20)
        Me.MaxLoad10TextBox.TabIndex = 104
        Me.MaxLoad10TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaxLoad10TextBox.Visible = False
        '
        'MaxLoad9TextBox
        '
        Me.MaxLoad9TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "MaxLoad9", True))
        Me.MaxLoad9TextBox.Location = New System.Drawing.Point(9, 239)
        Me.MaxLoad9TextBox.Name = "MaxLoad9TextBox"
        Me.MaxLoad9TextBox.Size = New System.Drawing.Size(55, 20)
        Me.MaxLoad9TextBox.TabIndex = 103
        Me.MaxLoad9TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaxLoad9TextBox.Visible = False
        '
        'MaxLoad8TextBox
        '
        Me.MaxLoad8TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "MaxLoad8", True))
        Me.MaxLoad8TextBox.Location = New System.Drawing.Point(9, 216)
        Me.MaxLoad8TextBox.Name = "MaxLoad8TextBox"
        Me.MaxLoad8TextBox.Size = New System.Drawing.Size(55, 20)
        Me.MaxLoad8TextBox.TabIndex = 102
        Me.MaxLoad8TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaxLoad8TextBox.Visible = False
        '
        'MaxLoad7TextBox
        '
        Me.MaxLoad7TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "MaxLoad7", True))
        Me.MaxLoad7TextBox.Location = New System.Drawing.Point(9, 193)
        Me.MaxLoad7TextBox.Name = "MaxLoad7TextBox"
        Me.MaxLoad7TextBox.Size = New System.Drawing.Size(55, 20)
        Me.MaxLoad7TextBox.TabIndex = 101
        Me.MaxLoad7TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaxLoad7TextBox.Visible = False
        '
        'MaxLoad6TextBox
        '
        Me.MaxLoad6TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "MaxLoad6", True))
        Me.MaxLoad6TextBox.Location = New System.Drawing.Point(9, 170)
        Me.MaxLoad6TextBox.Name = "MaxLoad6TextBox"
        Me.MaxLoad6TextBox.Size = New System.Drawing.Size(55, 20)
        Me.MaxLoad6TextBox.TabIndex = 100
        Me.MaxLoad6TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaxLoad6TextBox.Visible = False
        '
        'Density5
        '
        Me.Density5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Density5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Density5", True))
        Me.Density5.ForeColor = System.Drawing.Color.Navy
        Me.Density5.Location = New System.Drawing.Point(150, 146)
        Me.Density5.Name = "Density5"
        Me.Density5.Size = New System.Drawing.Size(98, 20)
        Me.Density5.TabIndex = 135
        Me.Density5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Density5.Visible = False
        '
        'Density4
        '
        Me.Density4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Density4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Density4", True))
        Me.Density4.ForeColor = System.Drawing.Color.Navy
        Me.Density4.Location = New System.Drawing.Point(150, 123)
        Me.Density4.Name = "Density4"
        Me.Density4.Size = New System.Drawing.Size(98, 20)
        Me.Density4.TabIndex = 134
        Me.Density4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Density4.Visible = False
        '
        'Density3
        '
        Me.Density3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Density3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Density3", True))
        Me.Density3.ForeColor = System.Drawing.Color.Navy
        Me.Density3.Location = New System.Drawing.Point(150, 100)
        Me.Density3.Name = "Density3"
        Me.Density3.Size = New System.Drawing.Size(98, 20)
        Me.Density3.TabIndex = 133
        Me.Density3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Density3.Visible = False
        '
        'Density2
        '
        Me.Density2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Density2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Density2", True))
        Me.Density2.ForeColor = System.Drawing.Color.Navy
        Me.Density2.Location = New System.Drawing.Point(150, 77)
        Me.Density2.Name = "Density2"
        Me.Density2.Size = New System.Drawing.Size(98, 20)
        Me.Density2.TabIndex = 132
        Me.Density2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Density2.Visible = False
        '
        'Density1
        '
        Me.Density1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Density1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Density1", True))
        Me.Density1.ForeColor = System.Drawing.Color.Navy
        Me.Density1.Location = New System.Drawing.Point(150, 54)
        Me.Density1.Name = "Density1"
        Me.Density1.Size = New System.Drawing.Size(98, 20)
        Me.Density1.TabIndex = 131
        Me.Density1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Density1.Visible = False
        '
        'Area5
        '
        Me.Area5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Area5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Area5", True))
        Me.Area5.ForeColor = System.Drawing.Color.Navy
        Me.Area5.Location = New System.Drawing.Point(69, 146)
        Me.Area5.Name = "Area5"
        Me.Area5.Size = New System.Drawing.Size(75, 20)
        Me.Area5.TabIndex = 130
        Me.Area5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Area5.Visible = False
        '
        'Area4
        '
        Me.Area4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Area4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Area4", True))
        Me.Area4.ForeColor = System.Drawing.Color.Navy
        Me.Area4.Location = New System.Drawing.Point(69, 123)
        Me.Area4.Name = "Area4"
        Me.Area4.Size = New System.Drawing.Size(75, 20)
        Me.Area4.TabIndex = 129
        Me.Area4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Area4.Visible = False
        '
        'Area3
        '
        Me.Area3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Area3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Area3", True))
        Me.Area3.ForeColor = System.Drawing.Color.Navy
        Me.Area3.Location = New System.Drawing.Point(69, 100)
        Me.Area3.Name = "Area3"
        Me.Area3.Size = New System.Drawing.Size(75, 20)
        Me.Area3.TabIndex = 128
        Me.Area3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Area3.Visible = False
        '
        'Area2
        '
        Me.Area2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Area2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Area2", True))
        Me.Area2.ForeColor = System.Drawing.Color.Navy
        Me.Area2.Location = New System.Drawing.Point(69, 77)
        Me.Area2.Name = "Area2"
        Me.Area2.Size = New System.Drawing.Size(75, 20)
        Me.Area2.TabIndex = 127
        Me.Area2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Area2.Visible = False
        '
        'Area1
        '
        Me.Area1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Area1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "Area1", True))
        Me.Area1.ForeColor = System.Drawing.Color.Navy
        Me.Area1.Location = New System.Drawing.Point(69, 54)
        Me.Area1.Name = "Area1"
        Me.Area1.Size = New System.Drawing.Size(75, 20)
        Me.Area1.TabIndex = 126
        Me.Area1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Area1.Visible = False
        '
        'CompStrength5
        '
        Me.CompStrength5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CompStrength5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "CompStrength5", True))
        Me.CompStrength5.ForeColor = System.Drawing.Color.Navy
        Me.CompStrength5.Location = New System.Drawing.Point(254, 146)
        Me.CompStrength5.Name = "CompStrength5"
        Me.CompStrength5.Size = New System.Drawing.Size(75, 20)
        Me.CompStrength5.TabIndex = 124
        Me.CompStrength5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CompStrength5.Visible = False
        '
        'CompStrength4
        '
        Me.CompStrength4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CompStrength4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "CompStrength4", True))
        Me.CompStrength4.ForeColor = System.Drawing.Color.Navy
        Me.CompStrength4.Location = New System.Drawing.Point(254, 123)
        Me.CompStrength4.Name = "CompStrength4"
        Me.CompStrength4.Size = New System.Drawing.Size(75, 20)
        Me.CompStrength4.TabIndex = 123
        Me.CompStrength4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CompStrength4.Visible = False
        '
        'CompStrength3
        '
        Me.CompStrength3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CompStrength3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "CompStrength3", True))
        Me.CompStrength3.ForeColor = System.Drawing.Color.Navy
        Me.CompStrength3.Location = New System.Drawing.Point(254, 100)
        Me.CompStrength3.Name = "CompStrength3"
        Me.CompStrength3.Size = New System.Drawing.Size(75, 20)
        Me.CompStrength3.TabIndex = 122
        Me.CompStrength3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CompStrength3.Visible = False
        '
        'CompStrength2
        '
        Me.CompStrength2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CompStrength2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "CompStrength2", True))
        Me.CompStrength2.ForeColor = System.Drawing.Color.Navy
        Me.CompStrength2.Location = New System.Drawing.Point(254, 77)
        Me.CompStrength2.Name = "CompStrength2"
        Me.CompStrength2.Size = New System.Drawing.Size(75, 20)
        Me.CompStrength2.TabIndex = 121
        Me.CompStrength2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CompStrength2.Visible = False
        '
        'CompStrength1
        '
        Me.CompStrength1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CompStrength1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "CompStrength1", True))
        Me.CompStrength1.ForeColor = System.Drawing.Color.Navy
        Me.CompStrength1.Location = New System.Drawing.Point(254, 54)
        Me.CompStrength1.Name = "CompStrength1"
        Me.CompStrength1.Size = New System.Drawing.Size(75, 20)
        Me.CompStrength1.TabIndex = 120
        Me.CompStrength1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CompStrength1.Visible = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(9, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 30)
        Me.Label5.TabIndex = 113
        Me.Label5.Text = "Max. Load (Kn)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MaxLoad1TextBox
        '
        Me.MaxLoad1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "MaxLoad1", True))
        Me.MaxLoad1TextBox.Location = New System.Drawing.Point(9, 55)
        Me.MaxLoad1TextBox.Name = "MaxLoad1TextBox"
        Me.MaxLoad1TextBox.Size = New System.Drawing.Size(55, 20)
        Me.MaxLoad1TextBox.TabIndex = 95
        Me.MaxLoad1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaxLoad1TextBox.Visible = False
        '
        'MaxLoad2TextBox
        '
        Me.MaxLoad2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "MaxLoad2", True))
        Me.MaxLoad2TextBox.Location = New System.Drawing.Point(9, 78)
        Me.MaxLoad2TextBox.Name = "MaxLoad2TextBox"
        Me.MaxLoad2TextBox.Size = New System.Drawing.Size(55, 20)
        Me.MaxLoad2TextBox.TabIndex = 96
        Me.MaxLoad2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaxLoad2TextBox.Visible = False
        '
        'MaxLoad3TextBox
        '
        Me.MaxLoad3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "MaxLoad3", True))
        Me.MaxLoad3TextBox.Location = New System.Drawing.Point(9, 101)
        Me.MaxLoad3TextBox.Name = "MaxLoad3TextBox"
        Me.MaxLoad3TextBox.Size = New System.Drawing.Size(55, 20)
        Me.MaxLoad3TextBox.TabIndex = 97
        Me.MaxLoad3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaxLoad3TextBox.Visible = False
        '
        'MaxLoad4TextBox
        '
        Me.MaxLoad4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "MaxLoad4", True))
        Me.MaxLoad4TextBox.Location = New System.Drawing.Point(9, 124)
        Me.MaxLoad4TextBox.Name = "MaxLoad4TextBox"
        Me.MaxLoad4TextBox.Size = New System.Drawing.Size(55, 20)
        Me.MaxLoad4TextBox.TabIndex = 98
        Me.MaxLoad4TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaxLoad4TextBox.Visible = False
        '
        'MaxLoad5TextBox
        '
        Me.MaxLoad5TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "MaxLoad5", True))
        Me.MaxLoad5TextBox.Location = New System.Drawing.Point(9, 147)
        Me.MaxLoad5TextBox.Name = "MaxLoad5TextBox"
        Me.MaxLoad5TextBox.Size = New System.Drawing.Size(55, 20)
        Me.MaxLoad5TextBox.TabIndex = 99
        Me.MaxLoad5TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaxLoad5TextBox.Visible = False
        '
        'FractureType10
        '
        Me.FractureType10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "FractureType10", True))
        Me.FractureType10.FormattingEnabled = True
        Me.FractureType10.Location = New System.Drawing.Point(1284, 302)
        Me.FractureType10.Name = "FractureType10"
        Me.FractureType10.Size = New System.Drawing.Size(72, 21)
        Me.FractureType10.TabIndex = 171
        Me.FractureType10.Visible = False
        '
        'FractureType9
        '
        Me.FractureType9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "FractureType9", True))
        Me.FractureType9.FormattingEnabled = True
        Me.FractureType9.Location = New System.Drawing.Point(1284, 278)
        Me.FractureType9.Name = "FractureType9"
        Me.FractureType9.Size = New System.Drawing.Size(72, 21)
        Me.FractureType9.TabIndex = 170
        Me.FractureType9.Visible = False
        '
        'FractureType8
        '
        Me.FractureType8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "FractureType8", True))
        Me.FractureType8.FormattingEnabled = True
        Me.FractureType8.Location = New System.Drawing.Point(1284, 256)
        Me.FractureType8.Name = "FractureType8"
        Me.FractureType8.Size = New System.Drawing.Size(72, 21)
        Me.FractureType8.TabIndex = 169
        Me.FractureType8.Visible = False
        '
        'FractureType7
        '
        Me.FractureType7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "FractureType7", True))
        Me.FractureType7.FormattingEnabled = True
        Me.FractureType7.Location = New System.Drawing.Point(1284, 233)
        Me.FractureType7.Name = "FractureType7"
        Me.FractureType7.Size = New System.Drawing.Size(72, 21)
        Me.FractureType7.TabIndex = 168
        Me.FractureType7.Visible = False
        '
        'FractureType6
        '
        Me.FractureType6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "FractureType6", True))
        Me.FractureType6.FormattingEnabled = True
        Me.FractureType6.Location = New System.Drawing.Point(1284, 210)
        Me.FractureType6.Name = "FractureType6"
        Me.FractureType6.Size = New System.Drawing.Size(72, 21)
        Me.FractureType6.TabIndex = 167
        Me.FractureType6.Visible = False
        '
        'FractureType5
        '
        Me.FractureType5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "FractureType5", True))
        Me.FractureType5.FormattingEnabled = True
        Me.FractureType5.Items.AddRange(New Object() {"Type 1", "Type 2", "Type 3", "Type 4", "Type 5", "Type 6"})
        Me.FractureType5.Location = New System.Drawing.Point(1284, 187)
        Me.FractureType5.Name = "FractureType5"
        Me.FractureType5.Size = New System.Drawing.Size(72, 21)
        Me.FractureType5.TabIndex = 119
        Me.FractureType5.Visible = False
        '
        'FractureType4
        '
        Me.FractureType4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "FractureType4", True))
        Me.FractureType4.FormattingEnabled = True
        Me.FractureType4.Items.AddRange(New Object() {"Type 1", "Type 2", "Type 3", "Type 4", "Type 5", "Type 6"})
        Me.FractureType4.Location = New System.Drawing.Point(1284, 164)
        Me.FractureType4.Name = "FractureType4"
        Me.FractureType4.Size = New System.Drawing.Size(72, 21)
        Me.FractureType4.TabIndex = 118
        Me.FractureType4.Visible = False
        '
        'FractureType3
        '
        Me.FractureType3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "FractureType3", True))
        Me.FractureType3.FormattingEnabled = True
        Me.FractureType3.Items.AddRange(New Object() {"Type 1", "Type 2", "Type 3", "Type 4", "Type 5", "Type 6"})
        Me.FractureType3.Location = New System.Drawing.Point(1284, 141)
        Me.FractureType3.Name = "FractureType3"
        Me.FractureType3.Size = New System.Drawing.Size(72, 21)
        Me.FractureType3.TabIndex = 117
        Me.FractureType3.Visible = False
        '
        'FractureType2
        '
        Me.FractureType2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "FractureType2", True))
        Me.FractureType2.FormattingEnabled = True
        Me.FractureType2.Items.AddRange(New Object() {"Type 1", "Type 2", "Type 3", "Type 4", "Type 5", "Type 6"})
        Me.FractureType2.Location = New System.Drawing.Point(1284, 118)
        Me.FractureType2.Name = "FractureType2"
        Me.FractureType2.Size = New System.Drawing.Size(72, 21)
        Me.FractureType2.TabIndex = 116
        Me.FractureType2.Visible = False
        '
        'FractureType1
        '
        Me.FractureType1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "FractureType1", True))
        Me.FractureType1.FormattingEnabled = True
        Me.FractureType1.Items.AddRange(New Object() {"Type 1", "Type 2", "Type 3", "Type 4", "Type 5", "Type 6"})
        Me.FractureType1.Location = New System.Drawing.Point(1284, 95)
        Me.FractureType1.Name = "FractureType1"
        Me.FractureType1.Size = New System.Drawing.Size(72, 21)
        Me.FractureType1.TabIndex = 114
        Me.FractureType1.Visible = False
        '
        'Btncalculate
        '
        Me.Btncalculate.ForeColor = System.Drawing.Color.Black
        Me.Btncalculate.Location = New System.Drawing.Point(874, 515)
        Me.Btncalculate.Name = "Btncalculate"
        Me.Btncalculate.Size = New System.Drawing.Size(75, 23)
        Me.Btncalculate.TabIndex = 99
        Me.Btncalculate.Text = "Calculate"
        Me.Btncalculate.UseVisualStyleBackColor = True
        Me.Btncalculate.Visible = False
        '
        'BtnExitProgram
        '
        Me.BtnExitProgram.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExitProgram.ForeColor = System.Drawing.Color.Black
        Me.BtnExitProgram.Location = New System.Drawing.Point(604, 515)
        Me.BtnExitProgram.Name = "BtnExitProgram"
        Me.BtnExitProgram.Size = New System.Drawing.Size(80, 23)
        Me.BtnExitProgram.TabIndex = 100
        Me.BtnExitProgram.Text = "Exit Program"
        Me.BtnExitProgram.UseVisualStyleBackColor = True
        '
        'BtnFirst
        '
        Me.BtnFirst.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFirst.ForeColor = System.Drawing.Color.Black
        Me.BtnFirst.Location = New System.Drawing.Point(9, 13)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(75, 20)
        Me.BtnFirst.TabIndex = 101
        Me.BtnFirst.Text = "|< First"
        Me.BtnFirst.UseVisualStyleBackColor = True
        '
        'BtnPrev
        '
        Me.BtnPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrev.ForeColor = System.Drawing.Color.Black
        Me.BtnPrev.Location = New System.Drawing.Point(9, 36)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(75, 20)
        Me.BtnPrev.TabIndex = 102
        Me.BtnPrev.Text = "<<  Previous"
        Me.BtnPrev.UseVisualStyleBackColor = True
        '
        'BtnNext
        '
        Me.BtnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNext.ForeColor = System.Drawing.Color.Black
        Me.BtnNext.Location = New System.Drawing.Point(9, 59)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(75, 20)
        Me.BtnNext.TabIndex = 103
        Me.BtnNext.Text = "Next >>"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnLast
        '
        Me.BtnLast.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLast.ForeColor = System.Drawing.Color.Black
        Me.BtnLast.Location = New System.Drawing.Point(9, 82)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(75, 20)
        Me.BtnLast.TabIndex = 104
        Me.BtnLast.Text = "Last >|"
        Me.BtnLast.UseVisualStyleBackColor = True
        '
        'Err
        '
        Me.Err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.Err.ContainerControl = Me
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(364, 515)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(60, 23)
        Me.BtnEdit.TabIndex = 164
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'GrpMove
        '
        Me.GrpMove.Controls.Add(Me.BtnFirst)
        Me.GrpMove.Controls.Add(Me.BtnPrev)
        Me.GrpMove.Controls.Add(Me.BtnNext)
        Me.GrpMove.Controls.Add(Me.BtnLast)
        Me.GrpMove.Location = New System.Drawing.Point(1051, 217)
        Me.GrpMove.Name = "GrpMove"
        Me.GrpMove.Size = New System.Drawing.Size(95, 111)
        Me.GrpMove.TabIndex = 165
        Me.GrpMove.TabStop = False
        '
        'BatchTableTableAdapter
        '
        Me.BatchTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BatchTableTableAdapter = Me.BatchTableTableAdapter
        Me.TableAdapterManager.ProjectsTableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TerraConc.TerraConcDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserstableTableAdapter = Nothing
        '
        'BatchTableDataGridView
        '
        Me.BatchTableDataGridView.AllowUserToAddRows = False
        Me.BatchTableDataGridView.AllowUserToDeleteRows = False
        Me.BatchTableDataGridView.AutoGenerateColumns = False
        Me.BatchTableDataGridView.ColumnHeadersHeight = 30
        Me.BatchTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.BatchTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BatchIdentificationNoDataGridViewTextBoxColumn, Me.NameOfSamplerDataGridViewTextBoxColumn, Me.BatchDateDataGridViewTextBoxColumn, Me.BatchTimeDataGridViewTextBoxColumn, Me.TestdateDataGridViewTextBoxColumn, Me.CuringConditionsDataGridViewTextBoxColumn, Me.TestingLaboratoryDataGridViewTextBoxColumn, Me.TestCertificateDataGridViewTextBoxColumn, Me.SupplySourceDataGridViewTextBoxColumn, Me.ConcreteGradeDataGridViewTextBoxColumn, Me.SpecificationOfConcreteMixDataGridViewTextBoxColumn, Me.NoOfSpecimenDataGridViewTextBoxColumn, Me.SpecimenConditionDataGridViewTextBoxColumn, Me.MethodOfCompactionDataGridViewTextBoxColumn, Me.DateDeliveredDataGridViewTextBoxColumn, Me.TestMethodDataGridViewTextBoxColumn, Me.AveMassDataGridViewTextBoxColumn, Me.AveDensityDataGridViewTextBoxColumn, Me.AveStrengthDataGridViewTextBoxColumn, Me.SpecimenAgeDataGridViewTextBoxColumn, Me.StructuralElementDataGridViewTextBoxColumn, Me.SpecimenShapeDataGridViewTextBoxColumn, Me.TestedByDataGridViewTextBoxColumn, Me.CheckedByDataGridViewTextBoxColumn, Me.ApprovedByDataGridViewTextBoxColumn, Me.CheckedDateDataGridViewTextBoxColumn, Me.ApprovedDateDataGridViewTextBoxColumn})
        Me.BatchTableDataGridView.DataSource = Me.BatchTableBindingSource
        Me.BatchTableDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BatchTableDataGridView.Location = New System.Drawing.Point(0, 569)
        Me.BatchTableDataGridView.Name = "BatchTableDataGridView"
        Me.BatchTableDataGridView.ReadOnly = True
        Me.BatchTableDataGridView.RowHeadersWidth = 20
        Me.BatchTableDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BatchTableDataGridView.Size = New System.Drawing.Size(1168, 144)
        Me.BatchTableDataGridView.TabIndex = 167
        '
        'BatchIdentificationNoDataGridViewTextBoxColumn
        '
        Me.BatchIdentificationNoDataGridViewTextBoxColumn.DataPropertyName = "BatchIdentificationNo"
        Me.BatchIdentificationNoDataGridViewTextBoxColumn.HeaderText = "Batch Id. No"
        Me.BatchIdentificationNoDataGridViewTextBoxColumn.Name = "BatchIdentificationNoDataGridViewTextBoxColumn"
        Me.BatchIdentificationNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.BatchIdentificationNoDataGridViewTextBoxColumn.Width = 60
        '
        'NameOfSamplerDataGridViewTextBoxColumn
        '
        Me.NameOfSamplerDataGridViewTextBoxColumn.DataPropertyName = "NameOfSampler"
        Me.NameOfSamplerDataGridViewTextBoxColumn.HeaderText = "Name Of Sampler"
        Me.NameOfSamplerDataGridViewTextBoxColumn.Name = "NameOfSamplerDataGridViewTextBoxColumn"
        Me.NameOfSamplerDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BatchDateDataGridViewTextBoxColumn
        '
        Me.BatchDateDataGridViewTextBoxColumn.DataPropertyName = "BatchDate"
        Me.BatchDateDataGridViewTextBoxColumn.HeaderText = "Batch Date"
        Me.BatchDateDataGridViewTextBoxColumn.Name = "BatchDateDataGridViewTextBoxColumn"
        Me.BatchDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.BatchDateDataGridViewTextBoxColumn.Width = 75
        '
        'BatchTimeDataGridViewTextBoxColumn
        '
        Me.BatchTimeDataGridViewTextBoxColumn.DataPropertyName = "BatchTime"
        Me.BatchTimeDataGridViewTextBoxColumn.HeaderText = "Batch Time"
        Me.BatchTimeDataGridViewTextBoxColumn.Name = "BatchTimeDataGridViewTextBoxColumn"
        Me.BatchTimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.BatchTimeDataGridViewTextBoxColumn.Width = 75
        '
        'TestdateDataGridViewTextBoxColumn
        '
        Me.TestdateDataGridViewTextBoxColumn.DataPropertyName = "Testdate"
        Me.TestdateDataGridViewTextBoxColumn.HeaderText = "Test Date"
        Me.TestdateDataGridViewTextBoxColumn.Name = "TestdateDataGridViewTextBoxColumn"
        Me.TestdateDataGridViewTextBoxColumn.ReadOnly = True
        Me.TestdateDataGridViewTextBoxColumn.Width = 75
        '
        'CuringConditionsDataGridViewTextBoxColumn
        '
        Me.CuringConditionsDataGridViewTextBoxColumn.DataPropertyName = "CuringConditions"
        Me.CuringConditionsDataGridViewTextBoxColumn.HeaderText = "Curing Conditions"
        Me.CuringConditionsDataGridViewTextBoxColumn.Name = "CuringConditionsDataGridViewTextBoxColumn"
        Me.CuringConditionsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TestingLaboratoryDataGridViewTextBoxColumn
        '
        Me.TestingLaboratoryDataGridViewTextBoxColumn.DataPropertyName = "TestingLaboratory"
        Me.TestingLaboratoryDataGridViewTextBoxColumn.HeaderText = "Testing Laboratory"
        Me.TestingLaboratoryDataGridViewTextBoxColumn.Name = "TestingLaboratoryDataGridViewTextBoxColumn"
        Me.TestingLaboratoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TestCertificateDataGridViewTextBoxColumn
        '
        Me.TestCertificateDataGridViewTextBoxColumn.DataPropertyName = "TestCertificate"
        Me.TestCertificateDataGridViewTextBoxColumn.HeaderText = "Test Certificate"
        Me.TestCertificateDataGridViewTextBoxColumn.Name = "TestCertificateDataGridViewTextBoxColumn"
        Me.TestCertificateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SupplySourceDataGridViewTextBoxColumn
        '
        Me.SupplySourceDataGridViewTextBoxColumn.DataPropertyName = "SupplySource"
        Me.SupplySourceDataGridViewTextBoxColumn.HeaderText = "Supply Source"
        Me.SupplySourceDataGridViewTextBoxColumn.Name = "SupplySourceDataGridViewTextBoxColumn"
        Me.SupplySourceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ConcreteGradeDataGridViewTextBoxColumn
        '
        Me.ConcreteGradeDataGridViewTextBoxColumn.DataPropertyName = "ConcreteGrade"
        Me.ConcreteGradeDataGridViewTextBoxColumn.HeaderText = "Concrete Grade"
        Me.ConcreteGradeDataGridViewTextBoxColumn.Name = "ConcreteGradeDataGridViewTextBoxColumn"
        Me.ConcreteGradeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SpecificationOfConcreteMixDataGridViewTextBoxColumn
        '
        Me.SpecificationOfConcreteMixDataGridViewTextBoxColumn.DataPropertyName = "SpecificationOfConcreteMix"
        Me.SpecificationOfConcreteMixDataGridViewTextBoxColumn.HeaderText = "Specification Of ConcreteMix"
        Me.SpecificationOfConcreteMixDataGridViewTextBoxColumn.Name = "SpecificationOfConcreteMixDataGridViewTextBoxColumn"
        Me.SpecificationOfConcreteMixDataGridViewTextBoxColumn.ReadOnly = True
        Me.SpecificationOfConcreteMixDataGridViewTextBoxColumn.Width = 50
        '
        'NoOfSpecimenDataGridViewTextBoxColumn
        '
        Me.NoOfSpecimenDataGridViewTextBoxColumn.DataPropertyName = "NoOfSpecimen"
        Me.NoOfSpecimenDataGridViewTextBoxColumn.HeaderText = "NoOfSpecimen"
        Me.NoOfSpecimenDataGridViewTextBoxColumn.Name = "NoOfSpecimenDataGridViewTextBoxColumn"
        Me.NoOfSpecimenDataGridViewTextBoxColumn.ReadOnly = True
        Me.NoOfSpecimenDataGridViewTextBoxColumn.Width = 50
        '
        'SpecimenConditionDataGridViewTextBoxColumn
        '
        Me.SpecimenConditionDataGridViewTextBoxColumn.DataPropertyName = "SpecimenCondition"
        Me.SpecimenConditionDataGridViewTextBoxColumn.HeaderText = "SpecimenCondition"
        Me.SpecimenConditionDataGridViewTextBoxColumn.Name = "SpecimenConditionDataGridViewTextBoxColumn"
        Me.SpecimenConditionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MethodOfCompactionDataGridViewTextBoxColumn
        '
        Me.MethodOfCompactionDataGridViewTextBoxColumn.DataPropertyName = "MethodOfCompaction"
        Me.MethodOfCompactionDataGridViewTextBoxColumn.HeaderText = "MethodOfCompaction"
        Me.MethodOfCompactionDataGridViewTextBoxColumn.Name = "MethodOfCompactionDataGridViewTextBoxColumn"
        Me.MethodOfCompactionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateDeliveredDataGridViewTextBoxColumn
        '
        Me.DateDeliveredDataGridViewTextBoxColumn.DataPropertyName = "DateDelivered"
        Me.DateDeliveredDataGridViewTextBoxColumn.HeaderText = "DateDelivered"
        Me.DateDeliveredDataGridViewTextBoxColumn.Name = "DateDeliveredDataGridViewTextBoxColumn"
        Me.DateDeliveredDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateDeliveredDataGridViewTextBoxColumn.Width = 50
        '
        'TestMethodDataGridViewTextBoxColumn
        '
        Me.TestMethodDataGridViewTextBoxColumn.DataPropertyName = "TestMethod"
        Me.TestMethodDataGridViewTextBoxColumn.HeaderText = "TestMethod"
        Me.TestMethodDataGridViewTextBoxColumn.Name = "TestMethodDataGridViewTextBoxColumn"
        Me.TestMethodDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AveMassDataGridViewTextBoxColumn
        '
        Me.AveMassDataGridViewTextBoxColumn.DataPropertyName = "AveMass"
        Me.AveMassDataGridViewTextBoxColumn.HeaderText = "AveMass"
        Me.AveMassDataGridViewTextBoxColumn.Name = "AveMassDataGridViewTextBoxColumn"
        Me.AveMassDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AveDensityDataGridViewTextBoxColumn
        '
        Me.AveDensityDataGridViewTextBoxColumn.DataPropertyName = "AveDensity"
        Me.AveDensityDataGridViewTextBoxColumn.HeaderText = "AveDensity"
        Me.AveDensityDataGridViewTextBoxColumn.Name = "AveDensityDataGridViewTextBoxColumn"
        Me.AveDensityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AveStrengthDataGridViewTextBoxColumn
        '
        Me.AveStrengthDataGridViewTextBoxColumn.DataPropertyName = "AveStrength"
        Me.AveStrengthDataGridViewTextBoxColumn.HeaderText = "AveStrength"
        Me.AveStrengthDataGridViewTextBoxColumn.Name = "AveStrengthDataGridViewTextBoxColumn"
        Me.AveStrengthDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SpecimenAgeDataGridViewTextBoxColumn
        '
        Me.SpecimenAgeDataGridViewTextBoxColumn.DataPropertyName = "SpecimenAge"
        Me.SpecimenAgeDataGridViewTextBoxColumn.HeaderText = "SpecimenAge"
        Me.SpecimenAgeDataGridViewTextBoxColumn.Name = "SpecimenAgeDataGridViewTextBoxColumn"
        Me.SpecimenAgeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StructuralElementDataGridViewTextBoxColumn
        '
        Me.StructuralElementDataGridViewTextBoxColumn.DataPropertyName = "StructuralElement"
        Me.StructuralElementDataGridViewTextBoxColumn.HeaderText = "StructuralElement"
        Me.StructuralElementDataGridViewTextBoxColumn.Name = "StructuralElementDataGridViewTextBoxColumn"
        Me.StructuralElementDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SpecimenShapeDataGridViewTextBoxColumn
        '
        Me.SpecimenShapeDataGridViewTextBoxColumn.DataPropertyName = "SpecimenShape"
        Me.SpecimenShapeDataGridViewTextBoxColumn.HeaderText = "SpecimenShape"
        Me.SpecimenShapeDataGridViewTextBoxColumn.Name = "SpecimenShapeDataGridViewTextBoxColumn"
        Me.SpecimenShapeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TestedByDataGridViewTextBoxColumn
        '
        Me.TestedByDataGridViewTextBoxColumn.DataPropertyName = "TestedBy"
        Me.TestedByDataGridViewTextBoxColumn.HeaderText = "TestedBy"
        Me.TestedByDataGridViewTextBoxColumn.Name = "TestedByDataGridViewTextBoxColumn"
        Me.TestedByDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CheckedByDataGridViewTextBoxColumn
        '
        Me.CheckedByDataGridViewTextBoxColumn.DataPropertyName = "CheckedBy"
        Me.CheckedByDataGridViewTextBoxColumn.HeaderText = "CheckedBy"
        Me.CheckedByDataGridViewTextBoxColumn.Name = "CheckedByDataGridViewTextBoxColumn"
        Me.CheckedByDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApprovedByDataGridViewTextBoxColumn
        '
        Me.ApprovedByDataGridViewTextBoxColumn.DataPropertyName = "ApprovedBy"
        Me.ApprovedByDataGridViewTextBoxColumn.HeaderText = "ApprovedBy"
        Me.ApprovedByDataGridViewTextBoxColumn.Name = "ApprovedByDataGridViewTextBoxColumn"
        Me.ApprovedByDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CheckedDateDataGridViewTextBoxColumn
        '
        Me.CheckedDateDataGridViewTextBoxColumn.DataPropertyName = "CheckedDate"
        Me.CheckedDateDataGridViewTextBoxColumn.HeaderText = "CheckedDate"
        Me.CheckedDateDataGridViewTextBoxColumn.Name = "CheckedDateDataGridViewTextBoxColumn"
        Me.CheckedDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApprovedDateDataGridViewTextBoxColumn
        '
        Me.ApprovedDateDataGridViewTextBoxColumn.DataPropertyName = "ApprovedDate"
        Me.ApprovedDateDataGridViewTextBoxColumn.HeaderText = "ApprovedDate"
        Me.ApprovedDateDataGridViewTextBoxColumn.Name = "ApprovedDateDataGridViewTextBoxColumn"
        Me.ApprovedDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProjectIDTextBox
        '
        Me.ProjectIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "ProjectID", True))
        Me.ProjectIDTextBox.Location = New System.Drawing.Point(1092, 67)
        Me.ProjectIDTextBox.Name = "ProjectIDTextBox"
        Me.ProjectIDTextBox.Size = New System.Drawing.Size(54, 20)
        Me.ProjectIDTextBox.TabIndex = 169
        '
        'BatchIdTextBox
        '
        Me.BatchIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BatchTableBindingSource, "BatchId", True))
        Me.BatchIdTextBox.Location = New System.Drawing.Point(1092, 110)
        Me.BatchIdTextBox.Name = "BatchIdTextBox"
        Me.BatchIdTextBox.Size = New System.Drawing.Size(56, 20)
        Me.BatchIdTextBox.TabIndex = 170
        '
        'BatchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(1168, 713)
        Me.Controls.Add(BatchIdLabel)
        Me.Controls.Add(Me.BatchIdTextBox)
        Me.Controls.Add(ProjectIDLabel)
        Me.Controls.Add(Me.ProjectIDTextBox)
        Me.Controls.Add(Me.BatchTableDataGridView)
        Me.Controls.Add(Me.GrpMove)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.Grptest)
        Me.Controls.Add(Me.GrpBatch)
        Me.Controls.Add(Me.GrpSpecimen)
        Me.Controls.Add(Me.BtnExitProgram)
        Me.Controls.Add(Me.Btncalculate)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(FractureType1Label)
        Me.Controls.Add(Me.FractureType1)
        Me.Controls.Add(Me.FractureType2)
        Me.Controls.Add(Me.FractureType3)
        Me.Controls.Add(Me.FractureType4)
        Me.Controls.Add(Me.FractureType5)
        Me.Controls.Add(Me.FractureType6)
        Me.Controls.Add(Me.FractureType7)
        Me.Controls.Add(Me.FractureType8)
        Me.Controls.Add(Me.FractureType9)
        Me.Controls.Add(Me.FractureType10)
        Me.Controls.Add(Me.BatchTableBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BatchForm"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Concrete Batch Information"
        Me.TopMost = True
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.BatchTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BatchTableBindingNavigator.ResumeLayout(False)
        Me.BatchTableBindingNavigator.PerformLayout()
        CType(Me.TerraConcDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpSpecimen.ResumeLayout(False)
        Me.GrpSpecimen.PerformLayout()
        Me.GrpBatch.ResumeLayout(False)
        Me.GrpBatch.PerformLayout()
        CType(Me.NoOfSpecimen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grptest.ResumeLayout(False)
        Me.Grptest.PerformLayout()
        CType(Me.Err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpMove.ResumeLayout(False)
        CType(Me.BatchTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAddNew As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewBatchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BatchReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TerraConcDataSet As TerraConcDataSet
    Friend WithEvents BatchTableTableAdapter As TerraConcDataSetTableAdapters.BatchTableTableAdapter
    Friend WithEvents TableAdapterManager As TerraConcDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BatchTableBindingNavigator As BindingNavigator
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
    Friend WithEvents BatchTableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents BatchDateDateTimePicker As DateTimePicker
    Friend WithEvents Specimen1DTextBox As TextBox
    Friend WithEvents Specimen2DTextBox As TextBox
    Friend WithEvents Specimen3DTextBox As TextBox
    Friend WithEvents Specimen4DTextBox As TextBox
    Friend WithEvents Specimen5DTextBox As TextBox
    Friend WithEvents Specimen1LTextBox As TextBox
    Friend WithEvents Specimen2LTextBox As TextBox
    Friend WithEvents Specimen3LTextBox As TextBox
    Friend WithEvents Specimen4LTextBox As TextBox
    Friend WithEvents Specimen5LTextBox As TextBox
    Friend WithEvents GrpSpecimen As GroupBox
    Friend WithEvents LblDia As Label
    Friend WithEvents GrpBatch As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LblLen As Label
    Friend WithEvents CmbShape As ComboBox
    Friend WithEvents StructuralElementComboBox As ComboBox
    Friend WithEvents SpecimenAgeTextBox As TextBox
    Friend WithEvents LblHgt As Label
    Friend WithEvents Specimen1HTextBox As TextBox
    Friend WithEvents Specimen2HTextBox As TextBox
    Friend WithEvents Specimen3HTextBox As TextBox
    Friend WithEvents Specimen4HTextBox As TextBox
    Friend WithEvents Specimen5HTextBox As TextBox
    Friend WithEvents Btncalculate As Button
    Friend WithEvents BtnExitProgram As Button
    Friend WithEvents Mass4TextBox As TextBox
    Friend WithEvents Mass3TextBox As TextBox
    Friend WithEvents Mass2TextBox As TextBox
    Friend WithEvents Mass1TextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Mass5TextBox As TextBox
    Friend WithEvents BtnFirst As Button
    Friend WithEvents BtnPrev As Button
    Friend WithEvents BtnNext As Button
    Friend WithEvents BtnLast As Button
    Friend WithEvents DateOfBatchDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr4DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr5DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr6DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr7DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr8DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr9DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr10DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr11DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr12DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr13DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr14DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr15DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr16DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr17DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr18DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr19DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr20DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr21DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr22DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr23DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr24DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr25DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr26DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr27DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr28DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr29DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr30DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr31DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr32DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr33DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr34DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr35DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr36DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr37DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr38DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr39DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr40DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr41DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr42DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr43DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr44DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr45DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr46DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr47DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr48DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr49DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr50DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr51DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Grptest As GroupBox
    Friend WithEvents Density5 As Label
    Friend WithEvents Density4 As Label
    Friend WithEvents Density3 As Label
    Friend WithEvents Density2 As Label
    Friend WithEvents Density1 As Label
    Friend WithEvents Area5 As Label
    Friend WithEvents Area4 As Label
    Friend WithEvents Area3 As Label
    Friend WithEvents Area2 As Label
    Friend WithEvents Area1 As Label
    Friend WithEvents CompStrength5 As Label
    Friend WithEvents CompStrength4 As Label
    Friend WithEvents CompStrength3 As Label
    Friend WithEvents CompStrength2 As Label
    Friend WithEvents CompStrength1 As Label
    Friend WithEvents FractureType5 As ComboBox
    Friend WithEvents FractureType4 As ComboBox
    Friend WithEvents FractureType3 As ComboBox
    Friend WithEvents FractureType2 As ComboBox
    Friend WithEvents FractureType1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents MaxLoad1TextBox As TextBox
    Friend WithEvents MaxLoad2TextBox As TextBox
    Friend WithEvents MaxLoad3TextBox As TextBox
    Friend WithEvents MaxLoad4TextBox As TextBox
    Friend WithEvents MaxLoad5TextBox As TextBox
    Friend WithEvents Err As ErrorProvider
    Friend WithEvents SubMergedLabel As Label
    Friend WithEvents ChkbSameDim As CheckBox
    Friend WithEvents ChkSubmerged As CheckBox
    Friend WithEvents SubMergedMass5TextBox As TextBox
    Friend WithEvents SubMergedMass4TextBox As TextBox
    Friend WithEvents SubMergedMass3TextBox As TextBox
    Friend WithEvents SubMergedMass2TextBox As TextBox
    Friend WithEvents SubMergedMass1TextBox As TextBox
    Friend WithEvents Lab2 As Label
    Friend WithEvents Lab1 As Label
    Friend WithEvents Lab5 As Label
    Friend WithEvents Lab4 As Label
    Friend WithEvents Lab3 As Label
    Friend WithEvents SubMergedMass10TextBox As TextBox
    Friend WithEvents SubMergedMass9TextBox As TextBox
    Friend WithEvents SubMergedMass8TextBox As TextBox
    Friend WithEvents SubMergedMass7TextBox As TextBox
    Friend WithEvents SubMergedMass6TextBox As TextBox
    Friend WithEvents Mass10TextBox As TextBox
    Friend WithEvents Mass9TextBox As TextBox
    Friend WithEvents Mass8TextBox As TextBox
    Friend WithEvents Mass7TextBox As TextBox
    Friend WithEvents Mass6TextBox As TextBox
    Friend WithEvents Specimen10HTextBox As TextBox
    Friend WithEvents Specimen9HTextBox As TextBox
    Friend WithEvents Specimen8HTextBox As TextBox
    Friend WithEvents Specimen7HTextBox As TextBox
    Friend WithEvents Specimen6HTextBox As TextBox
    Friend WithEvents Specimen10LTextBox As TextBox
    Friend WithEvents Specimen9LTextBox As TextBox
    Friend WithEvents Specimen8LTextBox As TextBox
    Friend WithEvents Specimen7LTextBox As TextBox
    Friend WithEvents Specimen6LTextBox As TextBox
    Friend WithEvents Lab10 As Label
    Friend WithEvents Lab9 As Label
    Friend WithEvents Lab8 As Label
    Friend WithEvents Lab7 As Label
    Friend WithEvents Lab6 As Label
    Friend WithEvents Specimen10DTextBox As TextBox
    Friend WithEvents Specimen9DTextBox As TextBox
    Friend WithEvents Specimen8DTextBox As TextBox
    Friend WithEvents Specimen7DTextBox As TextBox
    Friend WithEvents Specimen6DTextBox As TextBox
    Friend WithEvents SpecificationOfConcreteMixTextBox As TextBox
    Friend WithEvents SupplySourceTextBox As TextBox
    Friend WithEvents NameOfSamplerTextBox As TextBox
    Friend WithEvents BatchIdentificationNoTextBox As TextBox
    Friend WithEvents CuringConditionsTextBox As TextBox
    Friend WithEvents CompStrength10 As Label
    Friend WithEvents CompStrength9 As Label
    Friend WithEvents CompStrength8 As Label
    Friend WithEvents CompStrength7 As Label
    Friend WithEvents CompStrength6 As Label
    Friend WithEvents Density10 As Label
    Friend WithEvents Density9 As Label
    Friend WithEvents Density8 As Label
    Friend WithEvents Density7 As Label
    Friend WithEvents Density6 As Label
    Friend WithEvents Area10 As Label
    Friend WithEvents Area9 As Label
    Friend WithEvents Area8 As Label
    Friend WithEvents Area7 As Label
    Friend WithEvents Area6 As Label
    Friend WithEvents FractureType10 As ComboBox
    Friend WithEvents FractureType9 As ComboBox
    Friend WithEvents FractureType8 As ComboBox
    Friend WithEvents FractureType7 As ComboBox
    Friend WithEvents FractureType6 As ComboBox
    Friend WithEvents MaxLoad10TextBox As TextBox
    Friend WithEvents MaxLoad9TextBox As TextBox
    Friend WithEvents MaxLoad8TextBox As TextBox
    Friend WithEvents MaxLoad7TextBox As TextBox
    Friend WithEvents MaxLoad6TextBox As TextBox
    Friend WithEvents TestMethodComboBox As ComboBox
    Friend WithEvents NoOfSpecimen As NumericUpDown
    Friend WithEvents ToolStripLabl As ToolStripLabel
    Friend WithEvents ToolStripbatch As ToolStripLabel
    Friend WithEvents Label9 As Label
    Friend WithEvents DateDeliveredDateTimePicker As DateTimePicker
    Friend WithEvents ApprovedDateDateTimePicker As DateTimePicker
    Friend WithEvents CheckedDateDateTimePicker As DateTimePicker
    Friend WithEvents ApprovedByTextBox As TextBox
    Friend WithEvents CheckedByTextBox As TextBox
    Friend WithEvents TestedByTextBox As TextBox
    Friend WithEvents ConcreteGradeTextBox As TextBox
    Friend WithEvents TestdateDateTimePicker As DateTimePicker
    Friend WithEvents TestingLaboratoryTextBox As TextBox
    Friend WithEvents AveStrength As Label
    Friend WithEvents AveDensity As Label
    Friend WithEvents TestCertificateTextBox As TextBox
    Friend WithEvents CubeDim As TextBox
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitApplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProjectBatchReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MethodOfCompactionComboBox As ComboBox
    Friend WithEvents BatchTimeTextBox As TextBox
    Friend WithEvents ToolStripUser As ToolStripLabel
    Friend WithEvents CompiledByLabl As Label
    Friend WithEvents BtnApply As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents GrpMove As GroupBox
    Friend WithEvents BatchTableDataGridView As DataGridView
    Friend WithEvents BatchTableBindingSource As BindingSource
    Friend WithEvents ProjectIDTextBox As TextBox
    Friend WithEvents BatchIdTextBox As TextBox
    Friend WithEvents LenTb As TextBox
    Friend WithEvents LblLen1 As Label
    Friend WithEvents LblDia1 As Label
    Friend WithEvents BatchIdentificationNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameOfSamplerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BatchDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BatchTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TestdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CuringConditionsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TestingLaboratoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TestCertificateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplySourceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConcreteGradeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpecificationOfConcreteMixDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoOfSpecimenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpecimenConditionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MethodOfCompactionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDeliveredDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TestMethodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AveMassDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AveDensityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AveStrengthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpecimenAgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StructuralElementDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpecimenShapeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TestedByDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CheckedByDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApprovedByDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CheckedDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApprovedDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
