<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Friend Class F_Service
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim AccountPurchaseLabel As System.Windows.Forms.Label
        Dim AccountSalesLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim NameShortLabel As System.Windows.Forms.Label
        Dim TypeHumanReadableLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim ServiceCodeLabel As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Service))
        Me.AccountPurchaseAccGridComboBox = New AccControlsWinForms.AccListComboBox
        Me.ServiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccountSalesAccGridComboBox = New AccControlsWinForms.AccListComboBox
        Me.AccountVatPurchaseAccGridComboBox = New AccControlsWinForms.AccListComboBox
        Me.AccountVatSalesAccGridComboBox = New AccControlsWinForms.AccListComboBox
        Me.AmountAccTextBox = New AccControlsWinForms.AccTextBox
        Me.IDTextBox = New System.Windows.Forms.TextBox
        Me.IsObsoleteCheckBox = New System.Windows.Forms.CheckBox
        Me.NameShortTextBox = New System.Windows.Forms.TextBox
        Me.RateVatPurchaseComboBox = New System.Windows.Forms.ComboBox
        Me.RateVatSalesComboBox = New System.Windows.Forms.ComboBox
        Me.TypeHumanReadableComboBox = New System.Windows.Forms.ComboBox
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.RegionalPricesDataListView = New BrightIdeasSoftware.DataListView
        Me.OlvColumn7 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn6 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn8 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn9 = New BrightIdeasSoftware.OLVColumn
        Me.RegionalPricesSortedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ServiceCodeTextBox = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.ICancelButton = New System.Windows.Forms.Button
        Me.IOkButton = New System.Windows.Forms.Button
        Me.IApplyButton = New System.Windows.Forms.Button
        Me.RegionalContentsSortedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegionalContentsDataListView = New BrightIdeasSoftware.DataListView
        Me.OlvColumn2 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn1 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn3 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn4 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn5 = New BrightIdeasSoftware.OLVColumn
        Me.ProgressFiller1 = New AccControlsWinForms.ProgressFiller
        Me.ErrorWarnInfoProvider1 = New AccControlsWinForms.ErrorWarnInfoProvider(Me.components)
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.DeclarationSchemaPurchaseAccListComboBox = New AccControlsWinForms.AccListComboBox
        Me.DeclarationSchemaSalesAccListComboBox = New AccControlsWinForms.AccListComboBox
        AccountPurchaseLabel = New System.Windows.Forms.Label
        AccountSalesLabel = New System.Windows.Forms.Label
        AmountLabel = New System.Windows.Forms.Label
        IDLabel = New System.Windows.Forms.Label
        NameShortLabel = New System.Windows.Forms.Label
        TypeHumanReadableLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        ServiceCodeLabel = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        CType(Me.ServiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.RegionalPricesDataListView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegionalPricesSortedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.RegionalContentsSortedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegionalContentsDataListView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorWarnInfoProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'AccountPurchaseLabel
        '
        AccountPurchaseLabel.AutoSize = True
        AccountPurchaseLabel.Dock = System.Windows.Forms.DockStyle.Fill
        AccountPurchaseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AccountPurchaseLabel.Location = New System.Drawing.Point(155, 0)
        AccountPurchaseLabel.Name = "AccountPurchaseLabel"
        AccountPurchaseLabel.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        AccountPurchaseLabel.Size = New System.Drawing.Size(189, 19)
        AccountPurchaseLabel.TabIndex = 0
        AccountPurchaseLabel.Text = "ĮSIGIJIMAI"
        AccountPurchaseLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'AccountSalesLabel
        '
        AccountSalesLabel.AutoSize = True
        AccountSalesLabel.Dock = System.Windows.Forms.DockStyle.Fill
        AccountSalesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AccountSalesLabel.Location = New System.Drawing.Point(370, 0)
        AccountSalesLabel.Name = "AccountSalesLabel"
        AccountSalesLabel.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        AccountSalesLabel.Size = New System.Drawing.Size(189, 19)
        AccountSalesLabel.TabIndex = 2
        AccountSalesLabel.Text = "PARDAVIMAI"
        AccountSalesLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'AmountLabel
        '
        AmountLabel.AutoSize = True
        AmountLabel.Dock = System.Windows.Forms.DockStyle.Fill
        AmountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AmountLabel.Location = New System.Drawing.Point(3, 127)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        AmountLabel.Size = New System.Drawing.Size(146, 26)
        AmountLabel.TabIndex = 8
        AmountLabel.Text = "Kiekis:"
        AmountLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(117, 9)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(24, 13)
        IDLabel.TabIndex = 10
        IDLabel.Text = "ID:"
        '
        'NameShortLabel
        '
        NameShortLabel.AutoSize = True
        NameShortLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameShortLabel.Location = New System.Drawing.Point(8, 35)
        NameShortLabel.Name = "NameShortLabel"
        NameShortLabel.Size = New System.Drawing.Size(133, 13)
        NameShortLabel.TabIndex = 14
        NameShortLabel.Text = "Trumpas pavadinimas:"
        '
        'TypeHumanReadableLabel
        '
        TypeHumanReadableLabel.AutoSize = True
        TypeHumanReadableLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TypeHumanReadableLabel.Location = New System.Drawing.Point(274, 9)
        TypeHumanReadableLabel.Name = "TypeHumanReadableLabel"
        TypeHumanReadableLabel.Size = New System.Drawing.Size(42, 13)
        TypeHumanReadableLabel.TabIndex = 20
        TypeHumanReadableLabel.Text = "Tipas:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(3, 19)
        Label1.Name = "Label1"
        Label1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Label1.Size = New System.Drawing.Size(146, 27)
        Label1.TabIndex = 20
        Label1.Text = "Apskaitos sąskaita:"
        Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(3, 46)
        Label2.Name = "Label2"
        Label2.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Label2.Size = New System.Drawing.Size(146, 27)
        Label2.TabIndex = 24
        Label2.Text = "PVM schema:"
        Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(3, 100)
        Label3.Name = "Label3"
        Label3.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Label3.Size = New System.Drawing.Size(146, 27)
        Label3.TabIndex = 24
        Label3.Text = "PVM apskaitos sąskaita:"
        Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(3, 0)
        Label4.Name = "Label4"
        Label4.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Label4.Size = New System.Drawing.Size(320, 25)
        Label4.TabIndex = 15
        Label4.Text = "Paslaugos vnt. kainos"
        Label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ServiceCodeLabel
        '
        ServiceCodeLabel.AutoSize = True
        ServiceCodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ServiceCodeLabel.Location = New System.Drawing.Point(30, 61)
        ServiceCodeLabel.Name = "ServiceCodeLabel"
        ServiceCodeLabel.Size = New System.Drawing.Size(107, 13)
        ServiceCodeLabel.TabIndex = 23
        ServiceCodeLabel.Text = "Paslaugos kodas:"
        '
        'AccountPurchaseAccGridComboBox
        '
        Me.AccountPurchaseAccGridComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ServiceBindingSource, "AccountPurchase", True))
        Me.AccountPurchaseAccGridComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccountPurchaseAccGridComboBox.EmptyValueString = ""
        Me.AccountPurchaseAccGridComboBox.InstantBinding = True
        Me.AccountPurchaseAccGridComboBox.Location = New System.Drawing.Point(155, 22)
        Me.AccountPurchaseAccGridComboBox.Name = "AccountPurchaseAccGridComboBox"
        Me.AccountPurchaseAccGridComboBox.Size = New System.Drawing.Size(189, 21)
        Me.AccountPurchaseAccGridComboBox.TabIndex = 0
        '
        'ServiceBindingSource
        '
        Me.ServiceBindingSource.DataSource = GetType(ApskaitaObjects.Documents.Service)
        '
        'AccountSalesAccGridComboBox
        '
        Me.AccountSalesAccGridComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ServiceBindingSource, "AccountSales", True))
        Me.AccountSalesAccGridComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccountSalesAccGridComboBox.EmptyValueString = ""
        Me.AccountSalesAccGridComboBox.InstantBinding = True
        Me.AccountSalesAccGridComboBox.Location = New System.Drawing.Point(370, 22)
        Me.AccountSalesAccGridComboBox.Name = "AccountSalesAccGridComboBox"
        Me.AccountSalesAccGridComboBox.Size = New System.Drawing.Size(189, 21)
        Me.AccountSalesAccGridComboBox.TabIndex = 3
        '
        'AccountVatPurchaseAccGridComboBox
        '
        Me.AccountVatPurchaseAccGridComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ServiceBindingSource, "AccountVatPurchase", True))
        Me.AccountVatPurchaseAccGridComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccountVatPurchaseAccGridComboBox.EmptyValueString = ""
        Me.AccountVatPurchaseAccGridComboBox.InstantBinding = True
        Me.AccountVatPurchaseAccGridComboBox.Location = New System.Drawing.Point(155, 103)
        Me.AccountVatPurchaseAccGridComboBox.Name = "AccountVatPurchaseAccGridComboBox"
        Me.AccountVatPurchaseAccGridComboBox.Size = New System.Drawing.Size(189, 21)
        Me.AccountVatPurchaseAccGridComboBox.TabIndex = 2
        '
        'AccountVatSalesAccGridComboBox
        '
        Me.AccountVatSalesAccGridComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ServiceBindingSource, "AccountVatSales", True))
        Me.AccountVatSalesAccGridComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccountVatSalesAccGridComboBox.EmptyValueString = ""
        Me.AccountVatSalesAccGridComboBox.InstantBinding = True
        Me.AccountVatSalesAccGridComboBox.Location = New System.Drawing.Point(370, 103)
        Me.AccountVatSalesAccGridComboBox.Name = "AccountVatSalesAccGridComboBox"
        Me.AccountVatSalesAccGridComboBox.Size = New System.Drawing.Size(189, 21)
        Me.AccountVatSalesAccGridComboBox.TabIndex = 5
        '
        'AmountAccTextBox
        '
        Me.AmountAccTextBox.DataBindings.Add(New System.Windows.Forms.Binding("DecimalValue", Me.ServiceBindingSource, "Amount", True))
        Me.AmountAccTextBox.DecimalLength = 4
        Me.AmountAccTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AmountAccTextBox.Location = New System.Drawing.Point(155, 130)
        Me.AmountAccTextBox.Name = "AmountAccTextBox"
        Me.AmountAccTextBox.Size = New System.Drawing.Size(189, 20)
        Me.AmountAccTextBox.TabIndex = 6
        Me.AmountAccTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiceBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(147, 6)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(121, 20)
        Me.IDTextBox.TabIndex = 11
        Me.IDTextBox.TabStop = False
        Me.IDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IsObsoleteCheckBox
        '
        Me.IsObsoleteCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IsObsoleteCheckBox.AutoSize = True
        Me.IsObsoleteCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ServiceBindingSource, "IsObsolete", True))
        Me.IsObsoleteCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsObsoleteCheckBox.Location = New System.Drawing.Point(464, 60)
        Me.IsObsoleteCheckBox.Name = "IsObsoleteCheckBox"
        Me.IsObsoleteCheckBox.Size = New System.Drawing.Size(117, 17)
        Me.IsObsoleteCheckBox.TabIndex = 3
        Me.IsObsoleteCheckBox.Text = "Nebenaudojama"
        '
        'NameShortTextBox
        '
        Me.NameShortTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NameShortTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiceBindingSource, "NameShort", True))
        Me.NameShortTextBox.Location = New System.Drawing.Point(147, 32)
        Me.NameShortTextBox.Name = "NameShortTextBox"
        Me.NameShortTextBox.Size = New System.Drawing.Size(437, 20)
        Me.NameShortTextBox.TabIndex = 1
        '
        'RateVatPurchaseComboBox
        '
        Me.RateVatPurchaseComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiceBindingSource, "RateVatPurchase", True))
        Me.RateVatPurchaseComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RateVatPurchaseComboBox.FormattingEnabled = True
        Me.RateVatPurchaseComboBox.Location = New System.Drawing.Point(155, 76)
        Me.RateVatPurchaseComboBox.Name = "RateVatPurchaseComboBox"
        Me.RateVatPurchaseComboBox.Size = New System.Drawing.Size(189, 21)
        Me.RateVatPurchaseComboBox.TabIndex = 1
        '
        'RateVatSalesComboBox
        '
        Me.RateVatSalesComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiceBindingSource, "RateVatSales", True))
        Me.RateVatSalesComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RateVatSalesComboBox.FormattingEnabled = True
        Me.RateVatSalesComboBox.Location = New System.Drawing.Point(370, 76)
        Me.RateVatSalesComboBox.Name = "RateVatSalesComboBox"
        Me.RateVatSalesComboBox.Size = New System.Drawing.Size(189, 21)
        Me.RateVatSalesComboBox.TabIndex = 4
        '
        'TypeHumanReadableComboBox
        '
        Me.TypeHumanReadableComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TypeHumanReadableComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiceBindingSource, "TypeHumanReadable", True))
        Me.TypeHumanReadableComboBox.FormattingEnabled = True
        Me.TypeHumanReadableComboBox.Location = New System.Drawing.Point(322, 5)
        Me.TypeHumanReadableComboBox.Name = "TypeHumanReadableComboBox"
        Me.TypeHumanReadableComboBox.Size = New System.Drawing.Size(262, 21)
        Me.TypeHumanReadableComboBox.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.RegionalPricesDataListView, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Label4, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(604, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(326, 237)
        Me.TableLayoutPanel2.TabIndex = 5
        '
        'RegionalPricesDataListView
        '
        Me.RegionalPricesDataListView.AllColumns.Add(Me.OlvColumn7)
        Me.RegionalPricesDataListView.AllColumns.Add(Me.OlvColumn6)
        Me.RegionalPricesDataListView.AllColumns.Add(Me.OlvColumn8)
        Me.RegionalPricesDataListView.AllColumns.Add(Me.OlvColumn9)
        Me.RegionalPricesDataListView.AllowColumnReorder = True
        Me.RegionalPricesDataListView.AutoGenerateColumns = False
        Me.RegionalPricesDataListView.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClickAlways
        Me.RegionalPricesDataListView.CellEditEnterChangesRows = True
        Me.RegionalPricesDataListView.CellEditTabChangesRows = True
        Me.RegionalPricesDataListView.CellEditUseWholeCell = False
        Me.RegionalPricesDataListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn7, Me.OlvColumn8, Me.OlvColumn9})
        Me.RegionalPricesDataListView.Cursor = System.Windows.Forms.Cursors.Default
        Me.RegionalPricesDataListView.DataSource = Me.RegionalPricesSortedBindingSource
        Me.RegionalPricesDataListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RegionalPricesDataListView.FullRowSelect = True
        Me.RegionalPricesDataListView.HasCollapsibleGroups = False
        Me.RegionalPricesDataListView.HeaderWordWrap = True
        Me.RegionalPricesDataListView.HideSelection = False
        Me.RegionalPricesDataListView.IncludeColumnHeadersInCopy = True
        Me.RegionalPricesDataListView.Location = New System.Drawing.Point(3, 28)
        Me.RegionalPricesDataListView.Name = "RegionalPricesDataListView"
        Me.RegionalPricesDataListView.RenderNonEditableCheckboxesAsDisabled = True
        Me.RegionalPricesDataListView.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu
        Me.RegionalPricesDataListView.SelectedBackColor = System.Drawing.Color.PaleGreen
        Me.RegionalPricesDataListView.SelectedForeColor = System.Drawing.Color.Black
        Me.RegionalPricesDataListView.ShowCommandMenuOnRightClick = True
        Me.RegionalPricesDataListView.ShowGroups = False
        Me.RegionalPricesDataListView.ShowImagesOnSubItems = True
        Me.RegionalPricesDataListView.ShowItemCountOnGroups = True
        Me.RegionalPricesDataListView.ShowItemToolTips = True
        Me.RegionalPricesDataListView.Size = New System.Drawing.Size(320, 206)
        Me.RegionalPricesDataListView.TabIndex = 16
        Me.RegionalPricesDataListView.UnfocusedSelectedBackColor = System.Drawing.Color.PaleGreen
        Me.RegionalPricesDataListView.UnfocusedSelectedForeColor = System.Drawing.Color.Black
        Me.RegionalPricesDataListView.UseCellFormatEvents = True
        Me.RegionalPricesDataListView.UseCompatibleStateImageBehavior = False
        Me.RegionalPricesDataListView.UseFilterIndicator = True
        Me.RegionalPricesDataListView.UseFiltering = True
        Me.RegionalPricesDataListView.UseHotItem = True
        Me.RegionalPricesDataListView.UseNotifyPropertyChanged = True
        Me.RegionalPricesDataListView.View = System.Windows.Forms.View.Details
        '
        'OlvColumn7
        '
        Me.OlvColumn7.AspectName = "CurrencyCode"
        Me.OlvColumn7.CellEditUseWholeCell = True
        Me.OlvColumn7.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn7.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn7.Text = "Valiuta"
        Me.OlvColumn7.ToolTipText = ""
        Me.OlvColumn7.Width = 86
        '
        'OlvColumn6
        '
        Me.OlvColumn6.AspectName = "ID"
        Me.OlvColumn6.CellEditUseWholeCell = True
        Me.OlvColumn6.DisplayIndex = 1
        Me.OlvColumn6.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn6.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn6.IsEditable = False
        Me.OlvColumn6.IsVisible = False
        Me.OlvColumn6.Text = "ID"
        Me.OlvColumn6.ToolTipText = ""
        Me.OlvColumn6.Width = 100
        '
        'OlvColumn8
        '
        Me.OlvColumn8.AspectName = "ValuePerUnitSales"
        Me.OlvColumn8.AspectToStringFormat = "{0:##,0.0000}"
        Me.OlvColumn8.CellEditUseWholeCell = True
        Me.OlvColumn8.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn8.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn8.Text = "Pardavimo"
        Me.OlvColumn8.ToolTipText = ""
        Me.OlvColumn8.Width = 115
        '
        'OlvColumn9
        '
        Me.OlvColumn9.AspectName = "ValuePerUnitPurchases"
        Me.OlvColumn9.AspectToStringFormat = "{0:##,0.0000}"
        Me.OlvColumn9.CellEditUseWholeCell = True
        Me.OlvColumn9.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn9.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn9.Text = "Pirkimo"
        Me.OlvColumn9.ToolTipText = ""
        Me.OlvColumn9.Width = 114
        '
        'RegionalPricesSortedBindingSource
        '
        Me.RegionalPricesSortedBindingSource.DataMember = "RegionalPrices"
        Me.RegionalPricesSortedBindingSource.DataSource = Me.ServiceBindingSource
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel1.Controls.Add(ServiceCodeLabel)
        Me.Panel1.Controls.Add(Me.ServiceCodeTextBox)
        Me.Panel1.Controls.Add(IDLabel)
        Me.Panel1.Controls.Add(Me.IsObsoleteCheckBox)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Controls.Add(NameShortLabel)
        Me.Panel1.Controls.Add(Me.NameShortTextBox)
        Me.Panel1.Controls.Add(Me.TypeHumanReadableComboBox)
        Me.Panel1.Controls.Add(Me.IDTextBox)
        Me.Panel1.Controls.Add(TypeHumanReadableLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Panel1.Size = New System.Drawing.Size(930, 240)
        Me.Panel1.TabIndex = 0
        '
        'ServiceCodeTextBox
        '
        Me.ServiceCodeTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ServiceCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiceBindingSource, "ServiceCode", True))
        Me.ServiceCodeTextBox.Location = New System.Drawing.Point(147, 58)
        Me.ServiceCodeTextBox.MaxLength = 15
        Me.ServiceCodeTextBox.Name = "ServiceCodeTextBox"
        Me.ServiceCodeTextBox.Size = New System.Drawing.Size(296, 20)
        Me.ServiceCodeTextBox.TabIndex = 2
        Me.ServiceCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.Controls.Add(Me.ICancelButton)
        Me.Panel2.Controls.Add(Me.IOkButton)
        Me.Panel2.Controls.Add(Me.IApplyButton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 485)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(930, 32)
        Me.Panel2.TabIndex = 2
        '
        'ICancelButton
        '
        Me.ICancelButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ICancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ICancelButton.Location = New System.Drawing.Point(829, 6)
        Me.ICancelButton.Name = "ICancelButton"
        Me.ICancelButton.Size = New System.Drawing.Size(89, 23)
        Me.ICancelButton.TabIndex = 2
        Me.ICancelButton.Text = "Atšaukti"
        Me.ICancelButton.UseVisualStyleBackColor = True
        '
        'IOkButton
        '
        Me.IOkButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IOkButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IOkButton.Location = New System.Drawing.Point(623, 6)
        Me.IOkButton.Name = "IOkButton"
        Me.IOkButton.Size = New System.Drawing.Size(89, 23)
        Me.IOkButton.TabIndex = 0
        Me.IOkButton.Text = "Ok"
        Me.IOkButton.UseVisualStyleBackColor = True
        '
        'IApplyButton
        '
        Me.IApplyButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IApplyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IApplyButton.Location = New System.Drawing.Point(727, 6)
        Me.IApplyButton.Name = "IApplyButton"
        Me.IApplyButton.Size = New System.Drawing.Size(89, 23)
        Me.IApplyButton.TabIndex = 1
        Me.IApplyButton.Text = "Išsaugoti"
        Me.IApplyButton.UseVisualStyleBackColor = True
        '
        'RegionalContentsSortedBindingSource
        '
        Me.RegionalContentsSortedBindingSource.DataMember = "RegionalContents"
        Me.RegionalContentsSortedBindingSource.DataSource = Me.ServiceBindingSource
        '
        'RegionalContentsDataListView
        '
        Me.RegionalContentsDataListView.AllColumns.Add(Me.OlvColumn2)
        Me.RegionalContentsDataListView.AllColumns.Add(Me.OlvColumn1)
        Me.RegionalContentsDataListView.AllColumns.Add(Me.OlvColumn3)
        Me.RegionalContentsDataListView.AllColumns.Add(Me.OlvColumn4)
        Me.RegionalContentsDataListView.AllColumns.Add(Me.OlvColumn5)
        Me.RegionalContentsDataListView.AllowColumnReorder = True
        Me.RegionalContentsDataListView.AutoGenerateColumns = False
        Me.RegionalContentsDataListView.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClickAlways
        Me.RegionalContentsDataListView.CellEditEnterChangesRows = True
        Me.RegionalContentsDataListView.CellEditTabChangesRows = True
        Me.RegionalContentsDataListView.CellEditUseWholeCell = False
        Me.RegionalContentsDataListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn2, Me.OlvColumn3, Me.OlvColumn4, Me.OlvColumn5})
        Me.RegionalContentsDataListView.Cursor = System.Windows.Forms.Cursors.Default
        Me.RegionalContentsDataListView.DataSource = Me.RegionalContentsSortedBindingSource
        Me.RegionalContentsDataListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RegionalContentsDataListView.FullRowSelect = True
        Me.RegionalContentsDataListView.HasCollapsibleGroups = False
        Me.RegionalContentsDataListView.HeaderWordWrap = True
        Me.RegionalContentsDataListView.HideSelection = False
        Me.RegionalContentsDataListView.IncludeColumnHeadersInCopy = True
        Me.RegionalContentsDataListView.Location = New System.Drawing.Point(0, 240)
        Me.RegionalContentsDataListView.Name = "RegionalContentsDataListView"
        Me.RegionalContentsDataListView.RenderNonEditableCheckboxesAsDisabled = True
        Me.RegionalContentsDataListView.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu
        Me.RegionalContentsDataListView.SelectedBackColor = System.Drawing.Color.PaleGreen
        Me.RegionalContentsDataListView.SelectedForeColor = System.Drawing.Color.Black
        Me.RegionalContentsDataListView.ShowCommandMenuOnRightClick = True
        Me.RegionalContentsDataListView.ShowGroups = False
        Me.RegionalContentsDataListView.ShowImagesOnSubItems = True
        Me.RegionalContentsDataListView.ShowItemCountOnGroups = True
        Me.RegionalContentsDataListView.ShowItemToolTips = True
        Me.RegionalContentsDataListView.Size = New System.Drawing.Size(930, 245)
        Me.RegionalContentsDataListView.TabIndex = 3
        Me.RegionalContentsDataListView.UnfocusedSelectedBackColor = System.Drawing.Color.PaleGreen
        Me.RegionalContentsDataListView.UnfocusedSelectedForeColor = System.Drawing.Color.Black
        Me.RegionalContentsDataListView.UseCellFormatEvents = True
        Me.RegionalContentsDataListView.UseCompatibleStateImageBehavior = False
        Me.RegionalContentsDataListView.UseFilterIndicator = True
        Me.RegionalContentsDataListView.UseFiltering = True
        Me.RegionalContentsDataListView.UseHotItem = True
        Me.RegionalContentsDataListView.UseNotifyPropertyChanged = True
        Me.RegionalContentsDataListView.View = System.Windows.Forms.View.Details
        '
        'OlvColumn2
        '
        Me.OlvColumn2.AspectName = "LanguageName"
        Me.OlvColumn2.CellEditUseWholeCell = True
        Me.OlvColumn2.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn2.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn2.Text = "Regiono kalba"
        Me.OlvColumn2.ToolTipText = ""
        Me.OlvColumn2.Width = 113
        '
        'OlvColumn1
        '
        Me.OlvColumn1.AspectName = "ID"
        Me.OlvColumn1.CellEditUseWholeCell = True
        Me.OlvColumn1.DisplayIndex = 1
        Me.OlvColumn1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn1.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn1.IsEditable = False
        Me.OlvColumn1.IsVisible = False
        Me.OlvColumn1.Text = "ID"
        Me.OlvColumn1.ToolTipText = ""
        Me.OlvColumn1.Width = 100
        '
        'OlvColumn3
        '
        Me.OlvColumn3.AspectName = "ContentInvoice"
        Me.OlvColumn3.CellEditUseWholeCell = True
        Me.OlvColumn3.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn3.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn3.Text = "Turinys sąskaitoje faktūroje"
        Me.OlvColumn3.ToolTipText = ""
        Me.OlvColumn3.Width = 311
        '
        'OlvColumn4
        '
        Me.OlvColumn4.AspectName = "MeasureUnit"
        Me.OlvColumn4.CellEditUseWholeCell = True
        Me.OlvColumn4.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn4.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn4.Text = "Mato vnt."
        Me.OlvColumn4.ToolTipText = ""
        Me.OlvColumn4.Width = 100
        '
        'OlvColumn5
        '
        Me.OlvColumn5.AspectName = "VatExempt"
        Me.OlvColumn5.CellEditUseWholeCell = True
        Me.OlvColumn5.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn5.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn5.Text = "PVM išimties paaiškinimas"
        Me.OlvColumn5.ToolTipText = ""
        Me.OlvColumn5.Width = 368
        '
        'ProgressFiller1
        '
        Me.ProgressFiller1.Location = New System.Drawing.Point(11, 358)
        Me.ProgressFiller1.Name = "ProgressFiller1"
        Me.ProgressFiller1.Size = New System.Drawing.Size(228, 51)
        Me.ProgressFiller1.TabIndex = 4
        Me.ProgressFiller1.Visible = False
        '
        'ErrorWarnInfoProvider1
        '
        Me.ErrorWarnInfoProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorWarnInfoProvider1.BlinkStyleInformation = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorWarnInfoProvider1.BlinkStyleWarning = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorWarnInfoProvider1.ContainerControl = Me
        Me.ErrorWarnInfoProvider1.DataSource = Me.ServiceBindingSource
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 5
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.DeclarationSchemaSalesAccListComboBox, 3, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.DeclarationSchemaPurchaseAccListComboBox, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.AmountAccTextBox, 1, 5)
        Me.TableLayoutPanel3.Controls.Add(Label3, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.AccountVatSalesAccGridComboBox, 3, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.RateVatSalesComboBox, 3, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.AccountSalesAccGridComboBox, 3, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.RateVatPurchaseComboBox, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(AmountLabel, 0, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.AccountPurchaseAccGridComboBox, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Label2, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Label1, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(AccountPurchaseLabel, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(AccountSalesLabel, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Label5, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.AccountVatPurchaseAccGridComboBox, 1, 4)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 84)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 6
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(583, 150)
        Me.TableLayoutPanel3.TabIndex = 5
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(3, 73)
        Label5.Name = "Label5"
        Label5.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Label5.Size = New System.Drawing.Size(146, 27)
        Label5.TabIndex = 25
        Label5.Text = "PVM tarifas:"
        Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DeclarationSchemaPurchaseAccListComboBox
        '
        Me.DeclarationSchemaPurchaseAccListComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ServiceBindingSource, "DeclarationSchemaPurchase", True))
        Me.DeclarationSchemaPurchaseAccListComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DeclarationSchemaPurchaseAccListComboBox.EmptyValueString = ""
        Me.DeclarationSchemaPurchaseAccListComboBox.InstantBinding = True
        Me.DeclarationSchemaPurchaseAccListComboBox.Location = New System.Drawing.Point(155, 49)
        Me.DeclarationSchemaPurchaseAccListComboBox.Name = "DeclarationSchemaPurchaseAccListComboBox"
        Me.DeclarationSchemaPurchaseAccListComboBox.Size = New System.Drawing.Size(189, 21)
        Me.DeclarationSchemaPurchaseAccListComboBox.TabIndex = 5
        '
        'DeclarationSchemaSalesAccListComboBox
        '
        Me.DeclarationSchemaSalesAccListComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ServiceBindingSource, "DeclarationSchemaSales", True))
        Me.DeclarationSchemaSalesAccListComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DeclarationSchemaSalesAccListComboBox.EmptyValueString = ""
        Me.DeclarationSchemaSalesAccListComboBox.InstantBinding = True
        Me.DeclarationSchemaSalesAccListComboBox.Location = New System.Drawing.Point(370, 49)
        Me.DeclarationSchemaSalesAccListComboBox.Name = "DeclarationSchemaSalesAccListComboBox"
        Me.DeclarationSchemaSalesAccListComboBox.Size = New System.Drawing.Size(189, 21)
        Me.DeclarationSchemaSalesAccListComboBox.TabIndex = 5
        '
        'F_Service
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 517)
        Me.Controls.Add(Me.RegionalContentsDataListView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ProgressFiller1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_Service"
        Me.ShowInTaskbar = False
        Me.Text = "Paslaugos duomenys"
        CType(Me.ServiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.RegionalPricesDataListView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegionalPricesSortedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.RegionalContentsSortedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegionalContentsDataListView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorWarnInfoProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AccountPurchaseAccGridComboBox As AccControlsWinForms.AccListComboBox
    Friend WithEvents ServiceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccountSalesAccGridComboBox As AccControlsWinForms.AccListComboBox
    Friend WithEvents AccountVatPurchaseAccGridComboBox As AccControlsWinForms.AccListComboBox
    Friend WithEvents AccountVatSalesAccGridComboBox As AccControlsWinForms.AccListComboBox
    Friend WithEvents AmountAccTextBox As AccControlsWinForms.AccTextBox
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IsObsoleteCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents NameShortTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RateVatPurchaseComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RateVatSalesComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TypeHumanReadableComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents RegionalPricesSortedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ICancelButton As System.Windows.Forms.Button
    Friend WithEvents IOkButton As System.Windows.Forms.Button
    Friend WithEvents IApplyButton As System.Windows.Forms.Button
    Friend WithEvents RegionalContentsSortedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ServiceCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RegionalPricesDataListView As BrightIdeasSoftware.DataListView
    Friend WithEvents RegionalContentsDataListView As BrightIdeasSoftware.DataListView
    Friend WithEvents OlvColumn1 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn2 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn3 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn4 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn5 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn6 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn7 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn8 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn9 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ProgressFiller1 As AccControlsWinForms.ProgressFiller
    Friend WithEvents ErrorWarnInfoProvider1 As AccControlsWinForms.ErrorWarnInfoProvider
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DeclarationSchemaSalesAccListComboBox As AccControlsWinForms.AccListComboBox
    Friend WithEvents DeclarationSchemaPurchaseAccListComboBox As AccControlsWinForms.AccListComboBox
End Class
