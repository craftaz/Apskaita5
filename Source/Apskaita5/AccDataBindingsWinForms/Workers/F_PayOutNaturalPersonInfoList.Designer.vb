<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Friend Class F_PayOutNaturalPersonInfoList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_PayOutNaturalPersonInfoList))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.DateFromAccDatePicker = New AccControlsWinForms.AccDatePicker
        Me.DateToAccDatePicker = New AccControlsWinForms.AccDatePicker
        Me.RefreshButton = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.NewItemButton = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.PayOutNaturalPersonItemListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChangeItem_MenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteItem_MenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewItem_MenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PayOutNaturalPersonItemListDataListView = New BrightIdeasSoftware.DataListView
        Me.OlvColumn3 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn1 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn2 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn4 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn5 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn6 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn7 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn8 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn9 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn10 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn11 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn12 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn13 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn14 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn15 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn16 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn17 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn18 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn19 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn20 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn21 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn22 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn23 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn24 = New BrightIdeasSoftware.OLVColumn
        Me.ProgressFiller1 = New AccControlsWinForms.ProgressFiller
        Me.ProgressFiller2 = New AccControlsWinForms.ProgressFiller
        Me.Panel1.SuspendLayout()
        CType(Me.PayOutNaturalPersonItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PayOutNaturalPersonItemListDataListView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Controls.Add(Me.DateFromAccDatePicker)
        Me.Panel1.Controls.Add(Me.DateToAccDatePicker)
        Me.Panel1.Controls.Add(Me.RefreshButton)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.NewItemButton)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Panel1.Size = New System.Drawing.Size(940, 45)
        Me.Panel1.TabIndex = 0
        '
        'DateFromAccDatePicker
        '
        Me.DateFromAccDatePicker.BoldedDates = Nothing
        Me.DateFromAccDatePicker.Location = New System.Drawing.Point(61, 12)
        Me.DateFromAccDatePicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateFromAccDatePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateFromAccDatePicker.Name = "DateFromAccDatePicker"
        Me.DateFromAccDatePicker.ReadOnly = False
        Me.DateFromAccDatePicker.ShowWeekNumbers = True
        Me.DateFromAccDatePicker.Size = New System.Drawing.Size(117, 20)
        Me.DateFromAccDatePicker.TabIndex = 0
        '
        'DateToAccDatePicker
        '
        Me.DateToAccDatePicker.BoldedDates = Nothing
        Me.DateToAccDatePicker.Location = New System.Drawing.Point(213, 12)
        Me.DateToAccDatePicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateToAccDatePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateToAccDatePicker.Name = "DateToAccDatePicker"
        Me.DateToAccDatePicker.ReadOnly = False
        Me.DateToAccDatePicker.ShowWeekNumbers = True
        Me.DateToAccDatePicker.Size = New System.Drawing.Size(113, 20)
        Me.DateToAccDatePicker.TabIndex = 1
        '
        'RefreshButton
        '
        Me.RefreshButton.Image = Global.AccDataBindingsWinForms.My.Resources.Resources.Button_Reload_icon_24p
        Me.RefreshButton.Location = New System.Drawing.Point(348, 6)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(33, 33)
        Me.RefreshButton.TabIndex = 2
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(21, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Nuo:"
        '
        'NewItemButton
        '
        Me.NewItemButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NewItemButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.NewItemButton.Enabled = False
        Me.NewItemButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewItemButton.Location = New System.Drawing.Point(853, 12)
        Me.NewItemButton.Name = "NewItemButton"
        Me.NewItemButton.Size = New System.Drawing.Size(75, 23)
        Me.NewItemButton.TabIndex = 3
        Me.NewItemButton.Text = "Naujas"
        Me.NewItemButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(184, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Iki:"
        '
        'PayOutNaturalPersonItemListBindingSource
        '
        Me.PayOutNaturalPersonItemListBindingSource.DataSource = GetType(ApskaitaObjects.ActiveReports.PayOutNaturalPersonInfoList)
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeItem_MenuItem, Me.DeleteItem_MenuItem, Me.NewItem_MenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(111, 70)
        '
        'ChangeItem_MenuItem
        '
        Me.ChangeItem_MenuItem.Name = "ChangeItem_MenuItem"
        Me.ChangeItem_MenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ChangeItem_MenuItem.Text = "Keisti"
        '
        'DeleteItem_MenuItem
        '
        Me.DeleteItem_MenuItem.Name = "DeleteItem_MenuItem"
        Me.DeleteItem_MenuItem.Size = New System.Drawing.Size(110, 22)
        Me.DeleteItem_MenuItem.Text = "Ištrinti"
        '
        'NewItem_MenuItem
        '
        Me.NewItem_MenuItem.Name = "NewItem_MenuItem"
        Me.NewItem_MenuItem.Size = New System.Drawing.Size(110, 22)
        Me.NewItem_MenuItem.Text = "Naujas"
        '
        'PayOutNaturalPersonItemListDataListView
        '
        Me.PayOutNaturalPersonItemListDataListView.AllColumns.Add(Me.OlvColumn3)
        Me.PayOutNaturalPersonItemListDataListView.AllColumns.Add(Me.OlvColumn1)
        Me.PayOutNaturalPersonItemListDataListView.AllColumns.Add(Me.OlvColumn2)
        Me.PayOutNaturalPersonItemListDataListView.AllColumns.Add(Me.OlvColumn4)
        Me.PayOutNaturalPersonItemListDataListView.AllColumns.Add(Me.OlvColumn5)
        Me.PayOutNaturalPersonItemListDataListView.AllColumns.Add(Me.OlvColumn6)
        Me.PayOutNaturalPersonItemListDataListView.AllColumns.Add(Me.OlvColumn7)
        Me.PayOutNaturalPersonItemListDataListView.AllColumns.Add(Me.OlvColumn8)
        Me.PayOutNaturalPersonItemListDataListView.AllColumns.Add(Me.OlvColumn9)
        Me.PayOutNaturalPersonItemListDataListView.AllColumns.Add(Me.OlvColumn10)
        Me.PayOutNaturalPersonItemListDataListView.AllColumns.Add(Me.OlvColumn11)
        Me.PayOutNaturalPersonItemListDataListView.AllColumns.Add(Me.OlvColumn12)
        Me.PayOutNaturalPersonItemListDataListView.AllColumns.Add(Me.OlvColumn13)
        Me.PayOutNaturalPersonItemListDataListView.AllColumns.Add(Me.OlvColumn14)
        Me.PayOutNaturalPersonItemListDataListView.AllColumns.Add(Me.OlvColumn15)
        Me.PayOutNaturalPersonItemListDataListView.AllColumns.Add(Me.OlvColumn16)
        Me.PayOutNaturalPersonItemListDataListView.AllColumns.Add(Me.OlvColumn17)
        Me.PayOutNaturalPersonItemListDataListView.AllColumns.Add(Me.OlvColumn18)
        Me.PayOutNaturalPersonItemListDataListView.AllColumns.Add(Me.OlvColumn19)
        Me.PayOutNaturalPersonItemListDataListView.AllColumns.Add(Me.OlvColumn20)
        Me.PayOutNaturalPersonItemListDataListView.AllColumns.Add(Me.OlvColumn21)
        Me.PayOutNaturalPersonItemListDataListView.AllColumns.Add(Me.OlvColumn22)
        Me.PayOutNaturalPersonItemListDataListView.AllColumns.Add(Me.OlvColumn23)
        Me.PayOutNaturalPersonItemListDataListView.AllColumns.Add(Me.OlvColumn24)
        Me.PayOutNaturalPersonItemListDataListView.AllowColumnReorder = True
        Me.PayOutNaturalPersonItemListDataListView.AutoGenerateColumns = False
        Me.PayOutNaturalPersonItemListDataListView.CausesValidation = False
        Me.PayOutNaturalPersonItemListDataListView.CellEditUseWholeCell = False
        Me.PayOutNaturalPersonItemListDataListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn3, Me.OlvColumn6, Me.OlvColumn7, Me.OlvColumn8, Me.OlvColumn9, Me.OlvColumn10, Me.OlvColumn11, Me.OlvColumn12, Me.OlvColumn13, Me.OlvColumn15, Me.OlvColumn16, Me.OlvColumn17, Me.OlvColumn18, Me.OlvColumn19, Me.OlvColumn20, Me.OlvColumn21, Me.OlvColumn22})
        Me.PayOutNaturalPersonItemListDataListView.Cursor = System.Windows.Forms.Cursors.Default
        Me.PayOutNaturalPersonItemListDataListView.DataSource = Me.PayOutNaturalPersonItemListBindingSource
        Me.PayOutNaturalPersonItemListDataListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PayOutNaturalPersonItemListDataListView.FullRowSelect = True
        Me.PayOutNaturalPersonItemListDataListView.HasCollapsibleGroups = False
        Me.PayOutNaturalPersonItemListDataListView.HeaderWordWrap = True
        Me.PayOutNaturalPersonItemListDataListView.HideSelection = False
        Me.PayOutNaturalPersonItemListDataListView.IncludeColumnHeadersInCopy = True
        Me.PayOutNaturalPersonItemListDataListView.Location = New System.Drawing.Point(0, 45)
        Me.PayOutNaturalPersonItemListDataListView.Name = "PayOutNaturalPersonItemListDataListView"
        Me.PayOutNaturalPersonItemListDataListView.RenderNonEditableCheckboxesAsDisabled = True
        Me.PayOutNaturalPersonItemListDataListView.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu
        Me.PayOutNaturalPersonItemListDataListView.SelectedBackColor = System.Drawing.Color.PaleGreen
        Me.PayOutNaturalPersonItemListDataListView.SelectedForeColor = System.Drawing.Color.Black
        Me.PayOutNaturalPersonItemListDataListView.ShowCommandMenuOnRightClick = True
        Me.PayOutNaturalPersonItemListDataListView.ShowGroups = False
        Me.PayOutNaturalPersonItemListDataListView.ShowImagesOnSubItems = True
        Me.PayOutNaturalPersonItemListDataListView.ShowItemCountOnGroups = True
        Me.PayOutNaturalPersonItemListDataListView.ShowItemToolTips = True
        Me.PayOutNaturalPersonItemListDataListView.Size = New System.Drawing.Size(940, 504)
        Me.PayOutNaturalPersonItemListDataListView.TabIndex = 1
        Me.PayOutNaturalPersonItemListDataListView.UnfocusedSelectedBackColor = System.Drawing.Color.PaleGreen
        Me.PayOutNaturalPersonItemListDataListView.UnfocusedSelectedForeColor = System.Drawing.Color.Black
        Me.PayOutNaturalPersonItemListDataListView.UseCellFormatEvents = True
        Me.PayOutNaturalPersonItemListDataListView.UseCompatibleStateImageBehavior = False
        Me.PayOutNaturalPersonItemListDataListView.UseFilterIndicator = True
        Me.PayOutNaturalPersonItemListDataListView.UseFiltering = True
        Me.PayOutNaturalPersonItemListDataListView.UseHotItem = True
        Me.PayOutNaturalPersonItemListDataListView.UseNotifyPropertyChanged = True
        Me.PayOutNaturalPersonItemListDataListView.View = System.Windows.Forms.View.Details
        '
        'OlvColumn3
        '
        Me.OlvColumn3.AspectName = "Date"
        Me.OlvColumn3.AspectToStringFormat = "{0:d}"
        Me.OlvColumn3.CellEditUseWholeCell = True
        Me.OlvColumn3.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn3.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn3.IsEditable = False
        Me.OlvColumn3.Text = "Data"
        Me.OlvColumn3.ToolTipText = ""
        Me.OlvColumn3.Width = 91
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
        'OlvColumn2
        '
        Me.OlvColumn2.AspectName = "JournalEntryID"
        Me.OlvColumn2.CellEditUseWholeCell = True
        Me.OlvColumn2.DisplayIndex = 2
        Me.OlvColumn2.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn2.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn2.IsEditable = False
        Me.OlvColumn2.IsVisible = False
        Me.OlvColumn2.Text = "BŽ ID"
        Me.OlvColumn2.ToolTipText = ""
        Me.OlvColumn2.Width = 100
        '
        'OlvColumn4
        '
        Me.OlvColumn4.AspectName = "Content"
        Me.OlvColumn4.CellEditUseWholeCell = True
        Me.OlvColumn4.DisplayIndex = 3
        Me.OlvColumn4.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn4.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn4.IsEditable = False
        Me.OlvColumn4.IsVisible = False
        Me.OlvColumn4.Text = "Aprašas"
        Me.OlvColumn4.ToolTipText = ""
        Me.OlvColumn4.Width = 100
        '
        'OlvColumn5
        '
        Me.OlvColumn5.AspectName = "DocNumber"
        Me.OlvColumn5.CellEditUseWholeCell = True
        Me.OlvColumn5.DisplayIndex = 4
        Me.OlvColumn5.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn5.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn5.IsEditable = False
        Me.OlvColumn5.IsVisible = False
        Me.OlvColumn5.Text = "Dok. Nr."
        Me.OlvColumn5.ToolTipText = ""
        Me.OlvColumn5.Width = 100
        '
        'OlvColumn6
        '
        Me.OlvColumn6.AspectName = "PersonInfo"
        Me.OlvColumn6.CellEditUseWholeCell = True
        Me.OlvColumn6.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn6.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn6.IsEditable = False
        Me.OlvColumn6.Text = "Asmuo"
        Me.OlvColumn6.ToolTipText = ""
        Me.OlvColumn6.Width = 138
        '
        'OlvColumn7
        '
        Me.OlvColumn7.AspectName = "PersonCodeSODRA"
        Me.OlvColumn7.CellEditUseWholeCell = True
        Me.OlvColumn7.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn7.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn7.IsEditable = False
        Me.OlvColumn7.Text = "Asmens SODROS kodas"
        Me.OlvColumn7.ToolTipText = ""
        Me.OlvColumn7.Width = 88
        '
        'OlvColumn8
        '
        Me.OlvColumn8.AspectName = "SumBruto"
        Me.OlvColumn8.AspectToStringFormat = "{0:##,0.00}"
        Me.OlvColumn8.CellEditUseWholeCell = True
        Me.OlvColumn8.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn8.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn8.IsEditable = False
        Me.OlvColumn8.Text = "Suma Bruto"
        Me.OlvColumn8.ToolTipText = ""
        Me.OlvColumn8.Width = 79
        '
        'OlvColumn9
        '
        Me.OlvColumn9.AspectName = "RateGPM"
        Me.OlvColumn9.AspectToStringFormat = "{0:##,0.00}"
        Me.OlvColumn9.CellEditUseWholeCell = True
        Me.OlvColumn9.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn9.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn9.IsEditable = False
        Me.OlvColumn9.Text = "Tar. GPM"
        Me.OlvColumn9.ToolTipText = ""
        Me.OlvColumn9.Width = 58
        '
        'OlvColumn10
        '
        Me.OlvColumn10.AspectName = "DeductionGPM"
        Me.OlvColumn10.AspectToStringFormat = "{0:##,0.00}"
        Me.OlvColumn10.CellEditUseWholeCell = True
        Me.OlvColumn10.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn10.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn10.IsEditable = False
        Me.OlvColumn10.Text = "Išsk. GPM"
        Me.OlvColumn10.ToolTipText = ""
        Me.OlvColumn10.Width = 65
        '
        'OlvColumn11
        '
        Me.OlvColumn11.AspectName = "RatePSDForPerson"
        Me.OlvColumn11.AspectToStringFormat = "{0:##,0.00}"
        Me.OlvColumn11.CellEditUseWholeCell = True
        Me.OlvColumn11.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn11.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn11.IsEditable = False
        Me.OlvColumn11.Text = "Tar. PSD išsk."
        Me.OlvColumn11.ToolTipText = ""
        Me.OlvColumn11.Width = 66
        '
        'OlvColumn12
        '
        Me.OlvColumn12.AspectName = "DeductionPSD"
        Me.OlvColumn12.AspectToStringFormat = "{0:##,0.00}"
        Me.OlvColumn12.CellEditUseWholeCell = True
        Me.OlvColumn12.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn12.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn12.IsEditable = False
        Me.OlvColumn12.Text = "Išsk. PSD"
        Me.OlvColumn12.ToolTipText = ""
        Me.OlvColumn12.Width = 74
        '
        'OlvColumn13
        '
        Me.OlvColumn13.AspectName = "RateSODRAForPerson"
        Me.OlvColumn13.AspectToStringFormat = "{0:##,0.00}"
        Me.OlvColumn13.CellEditUseWholeCell = True
        Me.OlvColumn13.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn13.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn13.IsEditable = False
        Me.OlvColumn13.Text = "Tar. SODRA išsk."
        Me.OlvColumn13.ToolTipText = ""
        Me.OlvColumn13.Width = 52
        '
        'OlvColumn14
        '
        Me.OlvColumn14.AspectName = "SODRABase"
        Me.OlvColumn14.CellEditUseWholeCell = True
        Me.OlvColumn14.DisplayIndex = 13
        Me.OlvColumn14.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn14.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn14.IsEditable = False
        Me.OlvColumn14.IsVisible = False
        Me.OlvColumn14.Text = "SODRA bazė (%)"
        Me.OlvColumn14.ToolTipText = ""
        Me.OlvColumn14.Width = 100
        '
        'OlvColumn15
        '
        Me.OlvColumn15.AspectName = "DeductionSODRA"
        Me.OlvColumn15.AspectToStringFormat = "{0:##,0.00}"
        Me.OlvColumn15.CellEditUseWholeCell = True
        Me.OlvColumn15.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn15.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn15.IsEditable = False
        Me.OlvColumn15.Text = "Išsk. SODRA"
        Me.OlvColumn15.ToolTipText = ""
        Me.OlvColumn15.Width = 78
        '
        'OlvColumn16
        '
        Me.OlvColumn16.AspectName = "SumNeto"
        Me.OlvColumn16.AspectToStringFormat = "{0:##,0.00}"
        Me.OlvColumn16.CellEditUseWholeCell = True
        Me.OlvColumn16.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn16.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn16.IsEditable = False
        Me.OlvColumn16.Text = "Suma Neto"
        Me.OlvColumn16.ToolTipText = ""
        Me.OlvColumn16.Width = 74
        '
        'OlvColumn17
        '
        Me.OlvColumn17.AspectName = "RatePSDForCompany"
        Me.OlvColumn17.AspectToStringFormat = "{0:##,0.00}"
        Me.OlvColumn17.CellEditUseWholeCell = True
        Me.OlvColumn17.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn17.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn17.IsEditable = False
        Me.OlvColumn17.Text = "Tar. PSD prisk."
        Me.OlvColumn17.ToolTipText = ""
        Me.OlvColumn17.Width = 100
        '
        'OlvColumn18
        '
        Me.OlvColumn18.AspectName = "ContributionPSD"
        Me.OlvColumn18.AspectToStringFormat = "{0:##,0.00}"
        Me.OlvColumn18.CellEditUseWholeCell = True
        Me.OlvColumn18.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn18.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn18.IsEditable = False
        Me.OlvColumn18.Text = "Prisk. PSD"
        Me.OlvColumn18.ToolTipText = ""
        Me.OlvColumn18.Width = 100
        '
        'OlvColumn19
        '
        Me.OlvColumn19.AspectName = "RateSODRAForCompany"
        Me.OlvColumn19.AspectToStringFormat = "{0:##,0.00}"
        Me.OlvColumn19.CellEditUseWholeCell = True
        Me.OlvColumn19.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn19.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn19.IsEditable = False
        Me.OlvColumn19.Text = "Tar. SODRA prisk."
        Me.OlvColumn19.ToolTipText = ""
        Me.OlvColumn19.Width = 100
        '
        'OlvColumn20
        '
        Me.OlvColumn20.AspectName = "ContributionSODRA"
        Me.OlvColumn20.AspectToStringFormat = "{0:##,0.00}"
        Me.OlvColumn20.CellEditUseWholeCell = True
        Me.OlvColumn20.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn20.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn20.IsEditable = False
        Me.OlvColumn20.Text = "Prisk. SODRA"
        Me.OlvColumn20.ToolTipText = ""
        Me.OlvColumn20.Width = 100
        '
        'OlvColumn21
        '
        Me.OlvColumn21.AspectName = "CodeVMI"
        Me.OlvColumn21.CellEditUseWholeCell = True
        Me.OlvColumn21.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn21.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn21.IsEditable = False
        Me.OlvColumn21.Text = "Kodas VMI dekl."
        Me.OlvColumn21.ToolTipText = ""
        Me.OlvColumn21.Width = 100
        '
        'OlvColumn22
        '
        Me.OlvColumn22.AspectName = "CodeSODRA"
        Me.OlvColumn22.CellEditUseWholeCell = True
        Me.OlvColumn22.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn22.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn22.IsEditable = False
        Me.OlvColumn22.Text = "Kodas SODRA dekl."
        Me.OlvColumn22.ToolTipText = ""
        Me.OlvColumn22.Width = 100
        '
        'OlvColumn23
        '
        Me.OlvColumn23.AspectName = "TotalPSD"
        Me.OlvColumn23.AspectToStringFormat = "{0:##,0.00}"
        Me.OlvColumn23.CellEditUseWholeCell = True
        Me.OlvColumn23.DisplayIndex = 22
        Me.OlvColumn23.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn23.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn23.IsEditable = False
        Me.OlvColumn23.IsVisible = False
        Me.OlvColumn23.Text = "Viso PSD"
        Me.OlvColumn23.ToolTipText = ""
        Me.OlvColumn23.Width = 100
        '
        'OlvColumn24
        '
        Me.OlvColumn24.AspectName = "TotalSODRA"
        Me.OlvColumn24.AspectToStringFormat = "{0:##,0.00}"
        Me.OlvColumn24.CellEditUseWholeCell = True
        Me.OlvColumn24.DisplayIndex = 23
        Me.OlvColumn24.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn24.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn24.IsEditable = False
        Me.OlvColumn24.IsVisible = False
        Me.OlvColumn24.Text = "Viso SODRA"
        Me.OlvColumn24.ToolTipText = ""
        Me.OlvColumn24.Width = 100
        '
        'ProgressFiller1
        '
        Me.ProgressFiller1.Location = New System.Drawing.Point(171, 66)
        Me.ProgressFiller1.Name = "ProgressFiller1"
        Me.ProgressFiller1.Size = New System.Drawing.Size(185, 72)
        Me.ProgressFiller1.TabIndex = 5
        Me.ProgressFiller1.Visible = False
        '
        'ProgressFiller2
        '
        Me.ProgressFiller2.Location = New System.Drawing.Point(401, 64)
        Me.ProgressFiller2.Name = "ProgressFiller2"
        Me.ProgressFiller2.Size = New System.Drawing.Size(177, 74)
        Me.ProgressFiller2.TabIndex = 6
        Me.ProgressFiller2.Visible = False
        '
        'F_PayOutNaturalPersonInfoList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(940, 549)
        Me.Controls.Add(Me.PayOutNaturalPersonItemListDataListView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ProgressFiller2)
        Me.Controls.Add(Me.ProgressFiller1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_PayOutNaturalPersonInfoList"
        Me.ShowInTaskbar = False
        Me.Text = "Išmokos fiziniams asmenims"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PayOutNaturalPersonItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PayOutNaturalPersonItemListDataListView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents NewItemButton As System.Windows.Forms.Button
    Friend WithEvents PayOutNaturalPersonItemListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ChangeItem_MenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteItem_MenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewItem_MenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PayOutNaturalPersonItemListDataListView As BrightIdeasSoftware.DataListView
    Friend WithEvents OlvColumn1 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn2 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn3 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn4 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn5 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn6 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn7 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn8 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn9 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn10 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn11 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn12 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn13 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn14 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn15 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn16 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn17 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn18 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn19 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn20 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn21 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn22 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn23 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn24 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ProgressFiller1 As AccControlsWinForms.ProgressFiller
    Friend WithEvents ProgressFiller2 As AccControlsWinForms.ProgressFiller
    Friend WithEvents DateFromAccDatePicker As AccControlsWinForms.AccDatePicker
    Friend WithEvents DateToAccDatePicker As AccControlsWinForms.AccDatePicker
End Class
