<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Friend Class F_WorkTimeClassList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_WorkTimeClassList))
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.FetchTypicalWorkTimeClassListButton = New System.Windows.Forms.Button
        Me.ICancelButton = New System.Windows.Forms.Button
        Me.IOkButton = New System.Windows.Forms.Button
        Me.IApplyButton = New System.Windows.Forms.Button
        Me.WorkTimeClassListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WorkTimeClassListDataListView = New BrightIdeasSoftware.DataListView
        Me.OlvColumn2 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn1 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn3 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn4 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn5 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn6 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn7 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn8 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn9 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn10 = New BrightIdeasSoftware.OLVColumn
        Me.ProgressFiller1 = New AccControlsWinForms.ProgressFiller
        Me.ProgressFiller2 = New AccControlsWinForms.ProgressFiller
        Me.Panel2.SuspendLayout()
        CType(Me.WorkTimeClassListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkTimeClassListDataListView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.Controls.Add(Me.FetchTypicalWorkTimeClassListButton)
        Me.Panel2.Controls.Add(Me.ICancelButton)
        Me.Panel2.Controls.Add(Me.IOkButton)
        Me.Panel2.Controls.Add(Me.IApplyButton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 374)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(862, 32)
        Me.Panel2.TabIndex = 54
        '
        'FetchTypicalWorkTimeClassListButton
        '
        Me.FetchTypicalWorkTimeClassListButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FetchTypicalWorkTimeClassListButton.Location = New System.Drawing.Point(12, 6)
        Me.FetchTypicalWorkTimeClassListButton.Name = "FetchTypicalWorkTimeClassListButton"
        Me.FetchTypicalWorkTimeClassListButton.Size = New System.Drawing.Size(89, 23)
        Me.FetchTypicalWorkTimeClassListButton.TabIndex = 15
        Me.FetchTypicalWorkTimeClassListButton.Text = "Tipinis"
        Me.FetchTypicalWorkTimeClassListButton.UseVisualStyleBackColor = True
        '
        'ICancelButton
        '
        Me.ICancelButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ICancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ICancelButton.Location = New System.Drawing.Point(761, 6)
        Me.ICancelButton.Name = "ICancelButton"
        Me.ICancelButton.Size = New System.Drawing.Size(89, 23)
        Me.ICancelButton.TabIndex = 14
        Me.ICancelButton.Text = "Atšaukti"
        Me.ICancelButton.UseVisualStyleBackColor = True
        '
        'IOkButton
        '
        Me.IOkButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IOkButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IOkButton.Location = New System.Drawing.Point(555, 6)
        Me.IOkButton.Name = "IOkButton"
        Me.IOkButton.Size = New System.Drawing.Size(89, 23)
        Me.IOkButton.TabIndex = 13
        Me.IOkButton.Text = "Ok"
        Me.IOkButton.UseVisualStyleBackColor = True
        '
        'IApplyButton
        '
        Me.IApplyButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IApplyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IApplyButton.Location = New System.Drawing.Point(659, 6)
        Me.IApplyButton.Name = "IApplyButton"
        Me.IApplyButton.Size = New System.Drawing.Size(89, 23)
        Me.IApplyButton.TabIndex = 12
        Me.IApplyButton.Text = "Išsaugoti"
        Me.IApplyButton.UseVisualStyleBackColor = True
        '
        'WorkTimeClassListBindingSource
        '
        Me.WorkTimeClassListBindingSource.DataSource = GetType(ApskaitaObjects.Workers.WorkTimeClass)
        '
        'WorkTimeClassListDataListView
        '
        Me.WorkTimeClassListDataListView.AllColumns.Add(Me.OlvColumn2)
        Me.WorkTimeClassListDataListView.AllColumns.Add(Me.OlvColumn1)
        Me.WorkTimeClassListDataListView.AllColumns.Add(Me.OlvColumn3)
        Me.WorkTimeClassListDataListView.AllColumns.Add(Me.OlvColumn4)
        Me.WorkTimeClassListDataListView.AllColumns.Add(Me.OlvColumn5)
        Me.WorkTimeClassListDataListView.AllColumns.Add(Me.OlvColumn6)
        Me.WorkTimeClassListDataListView.AllColumns.Add(Me.OlvColumn7)
        Me.WorkTimeClassListDataListView.AllColumns.Add(Me.OlvColumn8)
        Me.WorkTimeClassListDataListView.AllColumns.Add(Me.OlvColumn9)
        Me.WorkTimeClassListDataListView.AllColumns.Add(Me.OlvColumn10)
        Me.WorkTimeClassListDataListView.AllowColumnReorder = True
        Me.WorkTimeClassListDataListView.AutoGenerateColumns = False
        Me.WorkTimeClassListDataListView.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClickAlways
        Me.WorkTimeClassListDataListView.CellEditEnterChangesRows = True
        Me.WorkTimeClassListDataListView.CellEditTabChangesRows = True
        Me.WorkTimeClassListDataListView.CellEditUseWholeCell = False
        Me.WorkTimeClassListDataListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn2, Me.OlvColumn3, Me.OlvColumn4, Me.OlvColumn5, Me.OlvColumn6, Me.OlvColumn7, Me.OlvColumn8, Me.OlvColumn9, Me.OlvColumn10})
        Me.WorkTimeClassListDataListView.Cursor = System.Windows.Forms.Cursors.Default
        Me.WorkTimeClassListDataListView.DataSource = Me.WorkTimeClassListBindingSource
        Me.WorkTimeClassListDataListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorkTimeClassListDataListView.FullRowSelect = True
        Me.WorkTimeClassListDataListView.HasCollapsibleGroups = False
        Me.WorkTimeClassListDataListView.HeaderWordWrap = True
        Me.WorkTimeClassListDataListView.HideSelection = False
        Me.WorkTimeClassListDataListView.IncludeColumnHeadersInCopy = True
        Me.WorkTimeClassListDataListView.Location = New System.Drawing.Point(0, 0)
        Me.WorkTimeClassListDataListView.Name = "WorkTimeClassListDataListView"
        Me.WorkTimeClassListDataListView.RenderNonEditableCheckboxesAsDisabled = True
        Me.WorkTimeClassListDataListView.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu
        Me.WorkTimeClassListDataListView.SelectedBackColor = System.Drawing.Color.PaleGreen
        Me.WorkTimeClassListDataListView.SelectedForeColor = System.Drawing.Color.Black
        Me.WorkTimeClassListDataListView.ShowCommandMenuOnRightClick = True
        Me.WorkTimeClassListDataListView.ShowGroups = False
        Me.WorkTimeClassListDataListView.ShowImagesOnSubItems = True
        Me.WorkTimeClassListDataListView.ShowItemCountOnGroups = True
        Me.WorkTimeClassListDataListView.ShowItemToolTips = True
        Me.WorkTimeClassListDataListView.Size = New System.Drawing.Size(862, 374)
        Me.WorkTimeClassListDataListView.TabIndex = 55
        Me.WorkTimeClassListDataListView.UnfocusedSelectedBackColor = System.Drawing.Color.PaleGreen
        Me.WorkTimeClassListDataListView.UnfocusedSelectedForeColor = System.Drawing.Color.Black
        Me.WorkTimeClassListDataListView.UseCellFormatEvents = True
        Me.WorkTimeClassListDataListView.UseCompatibleStateImageBehavior = False
        Me.WorkTimeClassListDataListView.UseFilterIndicator = True
        Me.WorkTimeClassListDataListView.UseFiltering = True
        Me.WorkTimeClassListDataListView.UseHotItem = True
        Me.WorkTimeClassListDataListView.UseNotifyPropertyChanged = True
        Me.WorkTimeClassListDataListView.View = System.Windows.Forms.View.Details
        '
        'OlvColumn2
        '
        Me.OlvColumn2.AspectName = "Code"
        Me.OlvColumn2.CellEditUseWholeCell = True
        Me.OlvColumn2.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn2.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn2.Text = "Kodas"
        Me.OlvColumn2.ToolTipText = ""
        Me.OlvColumn2.Width = 68
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
        Me.OlvColumn3.AspectName = "Name"
        Me.OlvColumn3.CellEditUseWholeCell = True
        Me.OlvColumn3.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn3.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn3.Text = "Pavadinimas"
        Me.OlvColumn3.ToolTipText = ""
        Me.OlvColumn3.Width = 260
        '
        'OlvColumn4
        '
        Me.OlvColumn4.AspectName = "TypeHumanReadable"
        Me.OlvColumn4.CellEditUseWholeCell = True
        Me.OlvColumn4.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn4.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn4.Text = "Tipas"
        Me.OlvColumn4.ToolTipText = ""
        Me.OlvColumn4.Width = 136
        '
        'OlvColumn5
        '
        Me.OlvColumn5.AspectName = "InclusionPercentage"
        Me.OlvColumn5.AspectToStringFormat = "{0:##,0.00}"
        Me.OlvColumn5.CellEditUseWholeCell = True
        Me.OlvColumn5.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn5.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn5.Text = "Įskaitymo %"
        Me.OlvColumn5.ToolTipText = ""
        Me.OlvColumn5.Width = 69
        '
        'OlvColumn6
        '
        Me.OlvColumn6.AspectName = "SpecialWageShemaApplicable"
        Me.OlvColumn6.CellEditUseWholeCell = True
        Me.OlvColumn6.CheckBoxes = True
        Me.OlvColumn6.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn6.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn6.Text = "Spec. Apm."
        Me.OlvColumn6.ToolTipText = "Speciali apmokėjimo schema"
        Me.OlvColumn6.Width = 46
        '
        'OlvColumn7
        '
        Me.OlvColumn7.AspectName = "SpecialWageShema"
        Me.OlvColumn7.CellEditUseWholeCell = True
        Me.OlvColumn7.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn7.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn7.Text = "Spec. Apm. formulė"
        Me.OlvColumn7.ToolTipText = ""
        Me.OlvColumn7.Width = 115
        '
        'OlvColumn8
        '
        Me.OlvColumn8.AspectName = "WithoutWorkHours"
        Me.OlvColumn8.CellEditUseWholeCell = True
        Me.OlvColumn8.CheckBoxes = True
        Me.OlvColumn8.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn8.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn8.Text = "Be Val."
        Me.OlvColumn8.ToolTipText = ""
        Me.OlvColumn8.Width = 51
        '
        'OlvColumn9
        '
        Me.OlvColumn9.AspectName = "AlreadyIncludedInGeneralTime"
        Me.OlvColumn9.CellEditUseWholeCell = True
        Me.OlvColumn9.CheckBoxes = True
        Me.OlvColumn9.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn9.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn9.Text = "Jau Įsk."
        Me.OlvColumn9.ToolTipText = "Jau įskaičiuota į bazinę eilutę"
        Me.OlvColumn9.Width = 52
        '
        'OlvColumn10
        '
        Me.OlvColumn10.AspectName = "IsInUse"
        Me.OlvColumn10.CellEditUseWholeCell = True
        Me.OlvColumn10.CheckBoxes = True
        Me.OlvColumn10.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlvColumn10.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn10.IsEditable = False
        Me.OlvColumn10.Text = "Naudojama"
        Me.OlvColumn10.ToolTipText = ""
        Me.OlvColumn10.Width = 52
        '
        'ProgressFiller1
        '
        Me.ProgressFiller1.Location = New System.Drawing.Point(150, 22)
        Me.ProgressFiller1.Name = "ProgressFiller1"
        Me.ProgressFiller1.Size = New System.Drawing.Size(128, 74)
        Me.ProgressFiller1.TabIndex = 56
        Me.ProgressFiller1.Visible = False
        '
        'ProgressFiller2
        '
        Me.ProgressFiller2.Location = New System.Drawing.Point(311, 17)
        Me.ProgressFiller2.Name = "ProgressFiller2"
        Me.ProgressFiller2.Size = New System.Drawing.Size(150, 90)
        Me.ProgressFiller2.TabIndex = 57
        Me.ProgressFiller2.Visible = False
        '
        'F_WorkTimeClassList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 406)
        Me.Controls.Add(Me.WorkTimeClassListDataListView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ProgressFiller2)
        Me.Controls.Add(Me.ProgressFiller1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_WorkTimeClassList"
        Me.ShowInTaskbar = False
        Me.Text = "Darbo laiko rūšys"
        Me.Panel2.ResumeLayout(False)
        CType(Me.WorkTimeClassListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkTimeClassListDataListView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ICancelButton As System.Windows.Forms.Button
    Friend WithEvents IOkButton As System.Windows.Forms.Button
    Friend WithEvents IApplyButton As System.Windows.Forms.Button
    Friend WithEvents WorkTimeClassListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FetchTypicalWorkTimeClassListButton As System.Windows.Forms.Button
    Friend WithEvents WorkTimeClassListDataListView As BrightIdeasSoftware.DataListView
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
    Friend WithEvents ProgressFiller1 As AccControlsWinForms.ProgressFiller
    Friend WithEvents ProgressFiller2 As AccControlsWinForms.ProgressFiller
End Class
