<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Friend Class F_LongTermAsset
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
        Dim AcquisitionDateLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim LegalGroupLabel As System.Windows.Forms.Label
        Dim CustomGroupInfoLabel As System.Windows.Forms.Label
        Dim AccountAcquisitionLabel As System.Windows.Forms.Label
        Dim AccountAccumulatedAmortizationLabel As System.Windows.Forms.Label
        Dim AccountValueDecreaseLabel As System.Windows.Forms.Label
        Dim AccountValueIncreaseLabel As System.Windows.Forms.Label
        Dim AccountRevaluedPortionAmmortizationLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim AmmountLabel As System.Windows.Forms.Label
        Dim AmortizationCalculatedForMonthsLabel As System.Windows.Forms.Label
        Dim DefaultAmortizationPeriodLabel As System.Windows.Forms.Label
        Dim InventoryNumberLabel As System.Windows.Forms.Label
        Dim MeasureUnitLabel As System.Windows.Forms.Label
        Dim LiquidationUnitValueLabel As System.Windows.Forms.Label
        Dim AcquisitionJournalEntryIDLabel As System.Windows.Forms.Label
        Dim AcquisitionJournalEntryDocNumberLabel As System.Windows.Forms.Label
        Dim AcquisitionJournalEntryDocContentLabel As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim InsertDateLabel As System.Windows.Forms.Label
        Dim UpdateDateLabel As System.Windows.Forms.Label
        Dim AcquisitionJournalEntryDocTypeHumanReadableLabel As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_LongTermAsset))
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.EditedBaner = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.nCancelButton = New System.Windows.Forms.Button
        Me.ApplyButton = New System.Windows.Forms.Button
        Me.nOkButton = New System.Windows.Forms.Button
        Me.ValueRevaluedPortionPerUnitAccTextBox = New AccControlsWinForms.AccTextBox
        Me.LongTermAssetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ValueRevaluedPortionAccTextBox = New AccControlsWinForms.AccTextBox
        Me.ValuePerUnitAccTextBox = New AccControlsWinForms.AccTextBox
        Me.ValueAccTextBox = New AccControlsWinForms.AccTextBox
        Me.AmmountAccTextBox = New AccControlsWinForms.AccTextBox
        Me.DefaultAmortizationPeriodAccTextBox = New AccControlsWinForms.AccTextBox
        Me.AmortizationCalculatedForMonthsAccTextBox = New AccControlsWinForms.AccTextBox
        Me.LiquidationUnitValueAccTextBox = New AccControlsWinForms.AccTextBox
        Me.ValueIncreaseAmmortizationAccountValuePerUnitAccTextBox = New AccControlsWinForms.AccTextBox
        Me.ValueIncreaseAccountValuePerUnitAccTextBox = New AccControlsWinForms.AccTextBox
        Me.ValueDecreaseAccountValuePerUnitAccTextBox = New AccControlsWinForms.AccTextBox
        Me.AmortizationAccountValuePerUnitAccTextBox = New AccControlsWinForms.AccTextBox
        Me.AcquisitionAccountValuePerUnitAccTextBox = New AccControlsWinForms.AccTextBox
        Me.ValueIncreaseAmmortizationAccountValueAccTextBox = New AccControlsWinForms.AccTextBox
        Me.ValueIncreaseAccountValueAccTextBox = New AccControlsWinForms.AccTextBox
        Me.ValueDecreaseAccountValueAccTextBox = New AccControlsWinForms.AccTextBox
        Me.AmortizationAccountValueAccTextBox = New AccControlsWinForms.AccTextBox
        Me.AcquisitionAccountValueAccTextBox = New AccControlsWinForms.AccTextBox
        Me.AccountRevaluedPortionAmmortizationAccGridComboBox = New AccControlsWinForms.AccListComboBox
        Me.AccountValueIncreaseAccGridComboBox = New AccControlsWinForms.AccListComboBox
        Me.AccountValueDecreaseAccGridComboBox = New AccControlsWinForms.AccListComboBox
        Me.AccountAccumulatedAmortizationAccGridComboBox = New AccControlsWinForms.AccListComboBox
        Me.AccountAcquisitionAccGridComboBox = New AccControlsWinForms.AccListComboBox
        Me.AttachJournalEntryInfoButton = New System.Windows.Forms.Button
        Me.ViewJournalEntryButton = New System.Windows.Forms.Button
        Me.AcquisitionJournalEntryIDTextBox = New System.Windows.Forms.TextBox
        Me.AcquisitionJournalEntryDocContentTextBox = New System.Windows.Forms.TextBox
        Me.AcquisitionJournalEntryDocNumberTextBox = New System.Windows.Forms.TextBox
        Me.MeasureUnitTextBox = New System.Windows.Forms.TextBox
        Me.InventoryNumberTextBox = New System.Windows.Forms.TextBox
        Me.ContinuedUsageCheckBox = New System.Windows.Forms.CheckBox
        Me.LegalGroupComboBox = New System.Windows.Forms.ComboBox
        Me.NameTextBox = New System.Windows.Forms.TextBox
        Me.IDTextBox = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.AcquisitionJournalEntryDocTypeHumanReadableTextBox = New System.Windows.Forms.TextBox
        Me.UpdateDateTextBox = New System.Windows.Forms.TextBox
        Me.InsertDateTextBox = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.ValueIncreaseAmmortizationAccountValueCorrectionNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.ValueIncreaseAccountValueCorrectionNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.AmortizationAccountValueCorrectionNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.ValueDecreaseAccountValueCorrectionNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.AcquisitionAccountValueCorrectionNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.CustomGroupInfoAccGridComboBox = New AccControlsWinForms.AccListComboBox
        Me.AcquisitionDateAccDatePicker = New AccControlsWinForms.AccDatePicker
        Me.ProgressFiller1 = New AccControlsWinForms.ProgressFiller
        Me.ProgressFiller2 = New AccControlsWinForms.ProgressFiller
        Me.ErrorWarnInfoProvider1 = New AccControlsWinForms.ErrorWarnInfoProvider(Me.components)
        AcquisitionDateLabel = New System.Windows.Forms.Label
        IDLabel = New System.Windows.Forms.Label
        NameLabel = New System.Windows.Forms.Label
        LegalGroupLabel = New System.Windows.Forms.Label
        CustomGroupInfoLabel = New System.Windows.Forms.Label
        AccountAcquisitionLabel = New System.Windows.Forms.Label
        AccountAccumulatedAmortizationLabel = New System.Windows.Forms.Label
        AccountValueDecreaseLabel = New System.Windows.Forms.Label
        AccountValueIncreaseLabel = New System.Windows.Forms.Label
        AccountRevaluedPortionAmmortizationLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        AmmountLabel = New System.Windows.Forms.Label
        AmortizationCalculatedForMonthsLabel = New System.Windows.Forms.Label
        DefaultAmortizationPeriodLabel = New System.Windows.Forms.Label
        InventoryNumberLabel = New System.Windows.Forms.Label
        MeasureUnitLabel = New System.Windows.Forms.Label
        LiquidationUnitValueLabel = New System.Windows.Forms.Label
        AcquisitionJournalEntryIDLabel = New System.Windows.Forms.Label
        AcquisitionJournalEntryDocNumberLabel = New System.Windows.Forms.Label
        AcquisitionJournalEntryDocContentLabel = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        Label6 = New System.Windows.Forms.Label
        InsertDateLabel = New System.Windows.Forms.Label
        UpdateDateLabel = New System.Windows.Forms.Label
        AcquisitionJournalEntryDocTypeHumanReadableLabel = New System.Windows.Forms.Label
        Label7 = New System.Windows.Forms.Label
        Me.Panel2.SuspendLayout()
        Me.EditedBaner.SuspendLayout()
        CType(Me.LongTermAssetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.ValueIncreaseAmmortizationAccountValueCorrectionNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValueIncreaseAccountValueCorrectionNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmortizationAccountValueCorrectionNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValueDecreaseAccountValueCorrectionNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AcquisitionAccountValueCorrectionNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.ErrorWarnInfoProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AcquisitionDateLabel
        '
        AcquisitionDateLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        AcquisitionDateLabel.AutoSize = True
        AcquisitionDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AcquisitionDateLabel.Location = New System.Drawing.Point(3, 25)
        AcquisitionDateLabel.Name = "AcquisitionDateLabel"
        AcquisitionDateLabel.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        AcquisitionDateLabel.Size = New System.Drawing.Size(147, 18)
        AcquisitionDateLabel.TabIndex = 0
        AcquisitionDateLabel.Text = "Data:"
        AcquisitionDateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'IDLabel
        '
        IDLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(3, 0)
        IDLabel.Name = "IDLabel"
        IDLabel.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        IDLabel.Size = New System.Drawing.Size(147, 18)
        IDLabel.TabIndex = 2
        IDLabel.Text = "ID:"
        IDLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'NameLabel
        '
        NameLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.Location = New System.Drawing.Point(3, 50)
        NameLabel.Name = "NameLabel"
        NameLabel.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        NameLabel.Size = New System.Drawing.Size(147, 18)
        NameLabel.TabIndex = 5
        NameLabel.Text = "Pavadinimas:"
        NameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LegalGroupLabel
        '
        LegalGroupLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        LegalGroupLabel.AutoSize = True
        LegalGroupLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LegalGroupLabel.Location = New System.Drawing.Point(3, 75)
        LegalGroupLabel.Name = "LegalGroupLabel"
        LegalGroupLabel.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        LegalGroupLabel.Size = New System.Drawing.Size(147, 18)
        LegalGroupLabel.TabIndex = 7
        LegalGroupLabel.Text = "PMĮ grupė:"
        LegalGroupLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CustomGroupInfoLabel
        '
        CustomGroupInfoLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CustomGroupInfoLabel.AutoSize = True
        CustomGroupInfoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CustomGroupInfoLabel.Location = New System.Drawing.Point(3, 100)
        CustomGroupInfoLabel.Name = "CustomGroupInfoLabel"
        CustomGroupInfoLabel.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        CustomGroupInfoLabel.Size = New System.Drawing.Size(147, 18)
        CustomGroupInfoLabel.TabIndex = 9
        CustomGroupInfoLabel.Text = "Turto grupė:"
        CustomGroupInfoLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'AccountAcquisitionLabel
        '
        AccountAcquisitionLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        AccountAcquisitionLabel.AutoSize = True
        AccountAcquisitionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AccountAcquisitionLabel.Location = New System.Drawing.Point(3, 150)
        AccountAcquisitionLabel.Name = "AccountAcquisitionLabel"
        AccountAcquisitionLabel.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        AccountAcquisitionLabel.Size = New System.Drawing.Size(147, 18)
        AccountAcquisitionLabel.TabIndex = 11
        AccountAcquisitionLabel.Text = "Įsigij. savik.:"
        AccountAcquisitionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'AccountAccumulatedAmortizationLabel
        '
        AccountAccumulatedAmortizationLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        AccountAccumulatedAmortizationLabel.AutoSize = True
        AccountAccumulatedAmortizationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AccountAccumulatedAmortizationLabel.Location = New System.Drawing.Point(3, 175)
        AccountAccumulatedAmortizationLabel.Name = "AccountAccumulatedAmortizationLabel"
        AccountAccumulatedAmortizationLabel.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        AccountAccumulatedAmortizationLabel.Size = New System.Drawing.Size(147, 18)
        AccountAccumulatedAmortizationLabel.TabIndex = 13
        AccountAccumulatedAmortizationLabel.Text = "Sukauptos amort.:"
        AccountAccumulatedAmortizationLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'AccountValueDecreaseLabel
        '
        AccountValueDecreaseLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        AccountValueDecreaseLabel.AutoSize = True
        AccountValueDecreaseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AccountValueDecreaseLabel.Location = New System.Drawing.Point(3, 200)
        AccountValueDecreaseLabel.Name = "AccountValueDecreaseLabel"
        AccountValueDecreaseLabel.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        AccountValueDecreaseLabel.Size = New System.Drawing.Size(147, 18)
        AccountValueDecreaseLabel.TabIndex = 15
        AccountValueDecreaseLabel.Text = "Vertės sumaž.:"
        AccountValueDecreaseLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'AccountValueIncreaseLabel
        '
        AccountValueIncreaseLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        AccountValueIncreaseLabel.AutoSize = True
        AccountValueIncreaseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AccountValueIncreaseLabel.Location = New System.Drawing.Point(3, 225)
        AccountValueIncreaseLabel.Name = "AccountValueIncreaseLabel"
        AccountValueIncreaseLabel.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        AccountValueIncreaseLabel.Size = New System.Drawing.Size(147, 18)
        AccountValueIncreaseLabel.TabIndex = 17
        AccountValueIncreaseLabel.Text = "Pervertinimo:"
        AccountValueIncreaseLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'AccountRevaluedPortionAmmortizationLabel
        '
        AccountRevaluedPortionAmmortizationLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        AccountRevaluedPortionAmmortizationLabel.AutoSize = True
        AccountRevaluedPortionAmmortizationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AccountRevaluedPortionAmmortizationLabel.Location = New System.Drawing.Point(3, 250)
        AccountRevaluedPortionAmmortizationLabel.Name = "AccountRevaluedPortionAmmortizationLabel"
        AccountRevaluedPortionAmmortizationLabel.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        AccountRevaluedPortionAmmortizationLabel.Size = New System.Drawing.Size(147, 18)
        AccountRevaluedPortionAmmortizationLabel.TabIndex = 19
        AccountRevaluedPortionAmmortizationLabel.Text = "Pervert. dalies amort.:"
        AccountRevaluedPortionAmmortizationLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(3, 12)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(170, 13)
        Label1.TabIndex = 21
        Label1.Text = "Sąskaitos"
        Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label2
        '
        Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(484, 12)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(170, 13)
        Label2.TabIndex = 32
        Label2.Text = "Vertės viso"
        Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label3
        '
        Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(199, 12)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(170, 13)
        Label3.TabIndex = 38
        Label3.Text = "Vertės vnt."
        Label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'AmmountLabel
        '
        AmmountLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        AmmountLabel.AutoSize = True
        AmmountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AmmountLabel.Location = New System.Drawing.Point(3, 325)
        AmmountLabel.Name = "AmmountLabel"
        AmmountLabel.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        AmmountLabel.Size = New System.Drawing.Size(147, 18)
        AmmountLabel.TabIndex = 38
        AmmountLabel.Text = "Kiekis:"
        AmmountLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'AmortizationCalculatedForMonthsLabel
        '
        AmortizationCalculatedForMonthsLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        AmortizationCalculatedForMonthsLabel.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(AmortizationCalculatedForMonthsLabel, 3)
        AmortizationCalculatedForMonthsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AmortizationCalculatedForMonthsLabel.Location = New System.Drawing.Point(213, 350)
        AmortizationCalculatedForMonthsLabel.Name = "AmortizationCalculatedForMonthsLabel"
        AmortizationCalculatedForMonthsLabel.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        AmortizationCalculatedForMonthsLabel.Size = New System.Drawing.Size(200, 18)
        AmortizationCalculatedForMonthsLabel.TabIndex = 39
        AmortizationCalculatedForMonthsLabel.Text = "Amort. apskaičiuota  už mėnesius:"
        '
        'DefaultAmortizationPeriodLabel
        '
        DefaultAmortizationPeriodLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DefaultAmortizationPeriodLabel.AutoSize = True
        DefaultAmortizationPeriodLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DefaultAmortizationPeriodLabel.Location = New System.Drawing.Point(302, 325)
        DefaultAmortizationPeriodLabel.Name = "DefaultAmortizationPeriodLabel"
        DefaultAmortizationPeriodLabel.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        DefaultAmortizationPeriodLabel.Size = New System.Drawing.Size(111, 18)
        DefaultAmortizationPeriodLabel.TabIndex = 41
        DefaultAmortizationPeriodLabel.Text = "Amort. laikot. (m.):"
        DefaultAmortizationPeriodLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'InventoryNumberLabel
        '
        InventoryNumberLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        InventoryNumberLabel.AutoSize = True
        InventoryNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        InventoryNumberLabel.Location = New System.Drawing.Point(628, 25)
        InventoryNumberLabel.Name = "InventoryNumberLabel"
        InventoryNumberLabel.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        InventoryNumberLabel.Size = New System.Drawing.Size(54, 18)
        InventoryNumberLabel.TabIndex = 42
        InventoryNumberLabel.Text = "Inv. Nr.:"
        InventoryNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MeasureUnitLabel
        '
        MeasureUnitLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        MeasureUnitLabel.AutoSize = True
        MeasureUnitLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MeasureUnitLabel.Location = New System.Drawing.Point(348, 25)
        MeasureUnitLabel.Name = "MeasureUnitLabel"
        MeasureUnitLabel.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        MeasureUnitLabel.Size = New System.Drawing.Size(65, 18)
        MeasureUnitLabel.TabIndex = 43
        MeasureUnitLabel.Text = "Mato vnt.:"
        MeasureUnitLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LiquidationUnitValueLabel
        '
        LiquidationUnitValueLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        LiquidationUnitValueLabel.AutoSize = True
        LiquidationUnitValueLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LiquidationUnitValueLabel.Location = New System.Drawing.Point(586, 325)
        LiquidationUnitValueLabel.Name = "LiquidationUnitValueLabel"
        LiquidationUnitValueLabel.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        LiquidationUnitValueLabel.Size = New System.Drawing.Size(96, 18)
        LiquidationUnitValueLabel.TabIndex = 45
        LiquidationUnitValueLabel.Text = "Likvidac. vertė:"
        LiquidationUnitValueLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'AcquisitionJournalEntryIDLabel
        '
        AcquisitionJournalEntryIDLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        AcquisitionJournalEntryIDLabel.AutoSize = True
        AcquisitionJournalEntryIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AcquisitionJournalEntryIDLabel.Location = New System.Drawing.Point(3, 375)
        AcquisitionJournalEntryIDLabel.Name = "AcquisitionJournalEntryIDLabel"
        AcquisitionJournalEntryIDLabel.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        AcquisitionJournalEntryIDLabel.Size = New System.Drawing.Size(147, 18)
        AcquisitionJournalEntryIDLabel.TabIndex = 55
        AcquisitionJournalEntryIDLabel.Text = "Įsigijimo BŽ ID:"
        AcquisitionJournalEntryIDLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'AcquisitionJournalEntryDocNumberLabel
        '
        AcquisitionJournalEntryDocNumberLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        AcquisitionJournalEntryDocNumberLabel.AutoSize = True
        AcquisitionJournalEntryDocNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AcquisitionJournalEntryDocNumberLabel.Location = New System.Drawing.Point(354, 375)
        AcquisitionJournalEntryDocNumberLabel.Name = "AcquisitionJournalEntryDocNumberLabel"
        AcquisitionJournalEntryDocNumberLabel.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        AcquisitionJournalEntryDocNumberLabel.Size = New System.Drawing.Size(59, 18)
        AcquisitionJournalEntryDocNumberLabel.TabIndex = 57
        AcquisitionJournalEntryDocNumberLabel.Text = "Dok. Nr.:"
        AcquisitionJournalEntryDocNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'AcquisitionJournalEntryDocContentLabel
        '
        AcquisitionJournalEntryDocContentLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        AcquisitionJournalEntryDocContentLabel.AutoSize = True
        AcquisitionJournalEntryDocContentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AcquisitionJournalEntryDocContentLabel.Location = New System.Drawing.Point(3, 400)
        AcquisitionJournalEntryDocContentLabel.Name = "AcquisitionJournalEntryDocContentLabel"
        AcquisitionJournalEntryDocContentLabel.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        AcquisitionJournalEntryDocContentLabel.Size = New System.Drawing.Size(147, 18)
        AcquisitionJournalEntryDocContentLabel.TabIndex = 59
        AcquisitionJournalEntryDocContentLabel.Text = "Turinys:"
        AcquisitionJournalEntryDocContentLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(3, 275)
        Label5.Name = "Label5"
        Label5.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Label5.Size = New System.Drawing.Size(147, 18)
        Label5.TabIndex = 46
        Label5.Text = "Balansinė vertė:"
        Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(3, 300)
        Label6.Name = "Label6"
        Label6.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Label6.Size = New System.Drawing.Size(147, 18)
        Label6.TabIndex = 46
        Label6.Text = "Pervert. balansinė vertė:"
        Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'InsertDateLabel
        '
        InsertDateLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        InsertDateLabel.AutoSize = True
        InsertDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        InsertDateLabel.Location = New System.Drawing.Point(358, 0)
        InsertDateLabel.Name = "InsertDateLabel"
        InsertDateLabel.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        InsertDateLabel.Size = New System.Drawing.Size(55, 18)
        InsertDateLabel.TabIndex = 2
        InsertDateLabel.Text = "Įtraukta:"
        InsertDateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'UpdateDateLabel
        '
        UpdateDateLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        UpdateDateLabel.AutoSize = True
        UpdateDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        UpdateDateLabel.Location = New System.Drawing.Point(622, 0)
        UpdateDateLabel.Name = "UpdateDateLabel"
        UpdateDateLabel.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        UpdateDateLabel.Size = New System.Drawing.Size(60, 18)
        UpdateDateLabel.TabIndex = 4
        UpdateDateLabel.Text = "Pakeista:"
        UpdateDateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'AcquisitionJournalEntryDocTypeHumanReadableLabel
        '
        AcquisitionJournalEntryDocTypeHumanReadableLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        AcquisitionJournalEntryDocTypeHumanReadableLabel.AutoSize = True
        AcquisitionJournalEntryDocTypeHumanReadableLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        AcquisitionJournalEntryDocTypeHumanReadableLabel.Location = New System.Drawing.Point(609, 375)
        AcquisitionJournalEntryDocTypeHumanReadableLabel.Name = "AcquisitionJournalEntryDocTypeHumanReadableLabel"
        AcquisitionJournalEntryDocTypeHumanReadableLabel.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        AcquisitionJournalEntryDocTypeHumanReadableLabel.Size = New System.Drawing.Size(73, 18)
        AcquisitionJournalEntryDocTypeHumanReadableLabel.TabIndex = 2
        AcquisitionJournalEntryDocTypeHumanReadableLabel.Text = "Dok. Tipas:"
        AcquisitionJournalEntryDocTypeHumanReadableLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(395, 12)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(83, 13)
        Label7.TabIndex = 58
        Label7.Text = "Korekcija"
        Label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.Controls.Add(Me.EditedBaner)
        Me.Panel2.Controls.Add(Me.nCancelButton)
        Me.Panel2.Controls.Add(Me.ApplyButton)
        Me.Panel2.Controls.Add(Me.nOkButton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 438)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.Panel2.Size = New System.Drawing.Size(853, 37)
        Me.Panel2.TabIndex = 1
        '
        'EditedBaner
        '
        Me.EditedBaner.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditedBaner.BackColor = System.Drawing.Color.Red
        Me.EditedBaner.Controls.Add(Me.Label4)
        Me.EditedBaner.Location = New System.Drawing.Point(502, 5)
        Me.EditedBaner.Name = "EditedBaner"
        Me.EditedBaner.Size = New System.Drawing.Size(83, 25)
        Me.EditedBaner.TabIndex = 51
        Me.EditedBaner.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "TAISOMA"
        '
        'nCancelButton
        '
        Me.nCancelButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.nCancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nCancelButton.Location = New System.Drawing.Point(766, 7)
        Me.nCancelButton.Name = "nCancelButton"
        Me.nCancelButton.Size = New System.Drawing.Size(75, 23)
        Me.nCancelButton.TabIndex = 2
        Me.nCancelButton.Text = "Atšaukti"
        Me.nCancelButton.UseVisualStyleBackColor = True
        '
        'ApplyButton
        '
        Me.ApplyButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ApplyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplyButton.Location = New System.Drawing.Point(685, 7)
        Me.ApplyButton.Name = "ApplyButton"
        Me.ApplyButton.Size = New System.Drawing.Size(75, 23)
        Me.ApplyButton.TabIndex = 1
        Me.ApplyButton.Text = "Taikyti"
        Me.ApplyButton.UseVisualStyleBackColor = True
        '
        'nOkButton
        '
        Me.nOkButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nOkButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nOkButton.Location = New System.Drawing.Point(604, 7)
        Me.nOkButton.Name = "nOkButton"
        Me.nOkButton.Size = New System.Drawing.Size(75, 23)
        Me.nOkButton.TabIndex = 0
        Me.nOkButton.Text = "OK"
        Me.nOkButton.UseVisualStyleBackColor = True
        '
        'ValueRevaluedPortionPerUnitAccTextBox
        '
        Me.ValueRevaluedPortionPerUnitAccTextBox.DataBindings.Add(New System.Windows.Forms.Binding("DecimalValue", Me.LongTermAssetBindingSource, "ValueRevaluedPortionPerUnit", True))
        Me.ValueRevaluedPortionPerUnitAccTextBox.DecimalLength = 4
        Me.ValueRevaluedPortionPerUnitAccTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ValueRevaluedPortionPerUnitAccTextBox.Location = New System.Drawing.Point(199, 178)
        Me.ValueRevaluedPortionPerUnitAccTextBox.Name = "ValueRevaluedPortionPerUnitAccTextBox"
        Me.ValueRevaluedPortionPerUnitAccTextBox.NegativeValue = False
        Me.ValueRevaluedPortionPerUnitAccTextBox.ReadOnly = True
        Me.ValueRevaluedPortionPerUnitAccTextBox.Size = New System.Drawing.Size(170, 20)
        Me.ValueRevaluedPortionPerUnitAccTextBox.TabIndex = 87
        Me.ValueRevaluedPortionPerUnitAccTextBox.TabStop = False
        Me.ValueRevaluedPortionPerUnitAccTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LongTermAssetBindingSource
        '
        Me.LongTermAssetBindingSource.DataSource = GetType(ApskaitaObjects.Assets.LongTermAsset)
        '
        'ValueRevaluedPortionAccTextBox
        '
        Me.ValueRevaluedPortionAccTextBox.DataBindings.Add(New System.Windows.Forms.Binding("DecimalValue", Me.LongTermAssetBindingSource, "ValueRevaluedPortion", True))
        Me.ValueRevaluedPortionAccTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ValueRevaluedPortionAccTextBox.Location = New System.Drawing.Point(484, 178)
        Me.ValueRevaluedPortionAccTextBox.Name = "ValueRevaluedPortionAccTextBox"
        Me.ValueRevaluedPortionAccTextBox.NegativeValue = False
        Me.ValueRevaluedPortionAccTextBox.ReadOnly = True
        Me.ValueRevaluedPortionAccTextBox.Size = New System.Drawing.Size(170, 20)
        Me.ValueRevaluedPortionAccTextBox.TabIndex = 86
        Me.ValueRevaluedPortionAccTextBox.TabStop = False
        Me.ValueRevaluedPortionAccTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ValuePerUnitAccTextBox
        '
        Me.ValuePerUnitAccTextBox.DataBindings.Add(New System.Windows.Forms.Binding("DecimalValue", Me.LongTermAssetBindingSource, "ValuePerUnit", True))
        Me.ValuePerUnitAccTextBox.DecimalLength = 4
        Me.ValuePerUnitAccTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ValuePerUnitAccTextBox.Location = New System.Drawing.Point(199, 153)
        Me.ValuePerUnitAccTextBox.Name = "ValuePerUnitAccTextBox"
        Me.ValuePerUnitAccTextBox.NegativeValue = False
        Me.ValuePerUnitAccTextBox.ReadOnly = True
        Me.ValuePerUnitAccTextBox.Size = New System.Drawing.Size(170, 20)
        Me.ValuePerUnitAccTextBox.TabIndex = 85
        Me.ValuePerUnitAccTextBox.TabStop = False
        Me.ValuePerUnitAccTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ValueAccTextBox
        '
        Me.ValueAccTextBox.DataBindings.Add(New System.Windows.Forms.Binding("DecimalValue", Me.LongTermAssetBindingSource, "Value", True))
        Me.ValueAccTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ValueAccTextBox.Location = New System.Drawing.Point(484, 153)
        Me.ValueAccTextBox.Name = "ValueAccTextBox"
        Me.ValueAccTextBox.NegativeValue = False
        Me.ValueAccTextBox.ReadOnly = True
        Me.ValueAccTextBox.Size = New System.Drawing.Size(170, 20)
        Me.ValueAccTextBox.TabIndex = 84
        Me.ValueAccTextBox.TabStop = False
        Me.ValueAccTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AmmountAccTextBox
        '
        Me.AmmountAccTextBox.DataBindings.Add(New System.Windows.Forms.Binding("DecimalValue", Me.LongTermAssetBindingSource, "Ammount", True))
        Me.AmmountAccTextBox.DecimalLength = 0
        Me.AmmountAccTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AmmountAccTextBox.Location = New System.Drawing.Point(156, 328)
        Me.AmmountAccTextBox.Name = "AmmountAccTextBox"
        Me.AmmountAccTextBox.NegativeValue = False
        Me.AmmountAccTextBox.Size = New System.Drawing.Size(120, 20)
        Me.AmmountAccTextBox.TabIndex = 10
        Me.AmmountAccTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DefaultAmortizationPeriodAccTextBox
        '
        Me.DefaultAmortizationPeriodAccTextBox.DataBindings.Add(New System.Windows.Forms.Binding("DecimalValue", Me.LongTermAssetBindingSource, "DefaultAmortizationPeriod", True))
        Me.DefaultAmortizationPeriodAccTextBox.DecimalLength = 0
        Me.DefaultAmortizationPeriodAccTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DefaultAmortizationPeriodAccTextBox.Location = New System.Drawing.Point(419, 328)
        Me.DefaultAmortizationPeriodAccTextBox.Name = "DefaultAmortizationPeriodAccTextBox"
        Me.DefaultAmortizationPeriodAccTextBox.NegativeValue = False
        Me.DefaultAmortizationPeriodAccTextBox.Size = New System.Drawing.Size(141, 20)
        Me.DefaultAmortizationPeriodAccTextBox.TabIndex = 8
        Me.DefaultAmortizationPeriodAccTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AmortizationCalculatedForMonthsAccTextBox
        '
        Me.AmortizationCalculatedForMonthsAccTextBox.DataBindings.Add(New System.Windows.Forms.Binding("DecimalValue", Me.LongTermAssetBindingSource, "AmortizationCalculatedForMonths", True))
        Me.AmortizationCalculatedForMonthsAccTextBox.DecimalLength = 0
        Me.AmortizationCalculatedForMonthsAccTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AmortizationCalculatedForMonthsAccTextBox.Location = New System.Drawing.Point(419, 353)
        Me.AmortizationCalculatedForMonthsAccTextBox.Name = "AmortizationCalculatedForMonthsAccTextBox"
        Me.AmortizationCalculatedForMonthsAccTextBox.NegativeValue = False
        Me.AmortizationCalculatedForMonthsAccTextBox.Size = New System.Drawing.Size(141, 20)
        Me.AmortizationCalculatedForMonthsAccTextBox.TabIndex = 7
        Me.AmortizationCalculatedForMonthsAccTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LiquidationUnitValueAccTextBox
        '
        Me.LiquidationUnitValueAccTextBox.DataBindings.Add(New System.Windows.Forms.Binding("DecimalValue", Me.LongTermAssetBindingSource, "LiquidationUnitValue", True))
        Me.LiquidationUnitValueAccTextBox.DecimalLength = 4
        Me.LiquidationUnitValueAccTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LiquidationUnitValueAccTextBox.Location = New System.Drawing.Point(688, 328)
        Me.LiquidationUnitValueAccTextBox.Name = "LiquidationUnitValueAccTextBox"
        Me.LiquidationUnitValueAccTextBox.NegativeValue = False
        Me.LiquidationUnitValueAccTextBox.Size = New System.Drawing.Size(141, 20)
        Me.LiquidationUnitValueAccTextBox.TabIndex = 6
        Me.LiquidationUnitValueAccTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ValueIncreaseAmmortizationAccountValuePerUnitAccTextBox
        '
        Me.ValueIncreaseAmmortizationAccountValuePerUnitAccTextBox.DataBindings.Add(New System.Windows.Forms.Binding("DecimalValue", Me.LongTermAssetBindingSource, "ValueIncreaseAmmortizationAccountValuePerUnit", True))
        Me.ValueIncreaseAmmortizationAccountValuePerUnitAccTextBox.DecimalLength = 4
        Me.ValueIncreaseAmmortizationAccountValuePerUnitAccTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ValueIncreaseAmmortizationAccountValuePerUnitAccTextBox.Location = New System.Drawing.Point(199, 128)
        Me.ValueIncreaseAmmortizationAccountValuePerUnitAccTextBox.Name = "ValueIncreaseAmmortizationAccountValuePerUnitAccTextBox"
        Me.ValueIncreaseAmmortizationAccountValuePerUnitAccTextBox.NegativeValue = False
        Me.ValueIncreaseAmmortizationAccountValuePerUnitAccTextBox.Size = New System.Drawing.Size(170, 20)
        Me.ValueIncreaseAmmortizationAccountValuePerUnitAccTextBox.TabIndex = 25
        Me.ValueIncreaseAmmortizationAccountValuePerUnitAccTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ValueIncreaseAccountValuePerUnitAccTextBox
        '
        Me.ValueIncreaseAccountValuePerUnitAccTextBox.DataBindings.Add(New System.Windows.Forms.Binding("DecimalValue", Me.LongTermAssetBindingSource, "ValueIncreaseAccountValuePerUnit", True))
        Me.ValueIncreaseAccountValuePerUnitAccTextBox.DecimalLength = 4
        Me.ValueIncreaseAccountValuePerUnitAccTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ValueIncreaseAccountValuePerUnitAccTextBox.Location = New System.Drawing.Point(199, 103)
        Me.ValueIncreaseAccountValuePerUnitAccTextBox.Name = "ValueIncreaseAccountValuePerUnitAccTextBox"
        Me.ValueIncreaseAccountValuePerUnitAccTextBox.NegativeValue = False
        Me.ValueIncreaseAccountValuePerUnitAccTextBox.Size = New System.Drawing.Size(170, 20)
        Me.ValueIncreaseAccountValuePerUnitAccTextBox.TabIndex = 22
        Me.ValueIncreaseAccountValuePerUnitAccTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ValueDecreaseAccountValuePerUnitAccTextBox
        '
        Me.ValueDecreaseAccountValuePerUnitAccTextBox.DataBindings.Add(New System.Windows.Forms.Binding("DecimalValue", Me.LongTermAssetBindingSource, "ValueDecreaseAccountValuePerUnit", True))
        Me.ValueDecreaseAccountValuePerUnitAccTextBox.DecimalLength = 4
        Me.ValueDecreaseAccountValuePerUnitAccTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ValueDecreaseAccountValuePerUnitAccTextBox.Location = New System.Drawing.Point(199, 78)
        Me.ValueDecreaseAccountValuePerUnitAccTextBox.Name = "ValueDecreaseAccountValuePerUnitAccTextBox"
        Me.ValueDecreaseAccountValuePerUnitAccTextBox.NegativeValue = False
        Me.ValueDecreaseAccountValuePerUnitAccTextBox.Size = New System.Drawing.Size(170, 20)
        Me.ValueDecreaseAccountValuePerUnitAccTextBox.TabIndex = 19
        Me.ValueDecreaseAccountValuePerUnitAccTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AmortizationAccountValuePerUnitAccTextBox
        '
        Me.AmortizationAccountValuePerUnitAccTextBox.DataBindings.Add(New System.Windows.Forms.Binding("DecimalValue", Me.LongTermAssetBindingSource, "AmortizationAccountValuePerUnit", True))
        Me.AmortizationAccountValuePerUnitAccTextBox.DecimalLength = 4
        Me.AmortizationAccountValuePerUnitAccTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AmortizationAccountValuePerUnitAccTextBox.Location = New System.Drawing.Point(199, 53)
        Me.AmortizationAccountValuePerUnitAccTextBox.Name = "AmortizationAccountValuePerUnitAccTextBox"
        Me.AmortizationAccountValuePerUnitAccTextBox.NegativeValue = False
        Me.AmortizationAccountValuePerUnitAccTextBox.Size = New System.Drawing.Size(170, 20)
        Me.AmortizationAccountValuePerUnitAccTextBox.TabIndex = 16
        Me.AmortizationAccountValuePerUnitAccTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AcquisitionAccountValuePerUnitAccTextBox
        '
        Me.AcquisitionAccountValuePerUnitAccTextBox.DataBindings.Add(New System.Windows.Forms.Binding("DecimalValue", Me.LongTermAssetBindingSource, "AcquisitionAccountValuePerUnit", True))
        Me.AcquisitionAccountValuePerUnitAccTextBox.DecimalLength = 4
        Me.AcquisitionAccountValuePerUnitAccTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AcquisitionAccountValuePerUnitAccTextBox.Location = New System.Drawing.Point(199, 28)
        Me.AcquisitionAccountValuePerUnitAccTextBox.Name = "AcquisitionAccountValuePerUnitAccTextBox"
        Me.AcquisitionAccountValuePerUnitAccTextBox.NegativeValue = False
        Me.AcquisitionAccountValuePerUnitAccTextBox.Size = New System.Drawing.Size(170, 20)
        Me.AcquisitionAccountValuePerUnitAccTextBox.TabIndex = 13
        Me.AcquisitionAccountValuePerUnitAccTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ValueIncreaseAmmortizationAccountValueAccTextBox
        '
        Me.ValueIncreaseAmmortizationAccountValueAccTextBox.DataBindings.Add(New System.Windows.Forms.Binding("DecimalValue", Me.LongTermAssetBindingSource, "ValueIncreaseAmmortizationAccountValue", True))
        Me.ValueIncreaseAmmortizationAccountValueAccTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ValueIncreaseAmmortizationAccountValueAccTextBox.Location = New System.Drawing.Point(484, 128)
        Me.ValueIncreaseAmmortizationAccountValueAccTextBox.Name = "ValueIncreaseAmmortizationAccountValueAccTextBox"
        Me.ValueIncreaseAmmortizationAccountValueAccTextBox.NegativeValue = False
        Me.ValueIncreaseAmmortizationAccountValueAccTextBox.ReadOnly = True
        Me.ValueIncreaseAmmortizationAccountValueAccTextBox.Size = New System.Drawing.Size(170, 20)
        Me.ValueIncreaseAmmortizationAccountValueAccTextBox.TabIndex = 24
        Me.ValueIncreaseAmmortizationAccountValueAccTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ValueIncreaseAccountValueAccTextBox
        '
        Me.ValueIncreaseAccountValueAccTextBox.DataBindings.Add(New System.Windows.Forms.Binding("DecimalValue", Me.LongTermAssetBindingSource, "ValueIncreaseAccountValue", True))
        Me.ValueIncreaseAccountValueAccTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ValueIncreaseAccountValueAccTextBox.Location = New System.Drawing.Point(484, 103)
        Me.ValueIncreaseAccountValueAccTextBox.Name = "ValueIncreaseAccountValueAccTextBox"
        Me.ValueIncreaseAccountValueAccTextBox.NegativeValue = False
        Me.ValueIncreaseAccountValueAccTextBox.ReadOnly = True
        Me.ValueIncreaseAccountValueAccTextBox.Size = New System.Drawing.Size(170, 20)
        Me.ValueIncreaseAccountValueAccTextBox.TabIndex = 21
        Me.ValueIncreaseAccountValueAccTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ValueDecreaseAccountValueAccTextBox
        '
        Me.ValueDecreaseAccountValueAccTextBox.DataBindings.Add(New System.Windows.Forms.Binding("DecimalValue", Me.LongTermAssetBindingSource, "ValueDecreaseAccountValue", True))
        Me.ValueDecreaseAccountValueAccTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ValueDecreaseAccountValueAccTextBox.Location = New System.Drawing.Point(484, 78)
        Me.ValueDecreaseAccountValueAccTextBox.Name = "ValueDecreaseAccountValueAccTextBox"
        Me.ValueDecreaseAccountValueAccTextBox.NegativeValue = False
        Me.ValueDecreaseAccountValueAccTextBox.ReadOnly = True
        Me.ValueDecreaseAccountValueAccTextBox.Size = New System.Drawing.Size(170, 20)
        Me.ValueDecreaseAccountValueAccTextBox.TabIndex = 18
        Me.ValueDecreaseAccountValueAccTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AmortizationAccountValueAccTextBox
        '
        Me.AmortizationAccountValueAccTextBox.DataBindings.Add(New System.Windows.Forms.Binding("DecimalValue", Me.LongTermAssetBindingSource, "AmortizationAccountValue", True))
        Me.AmortizationAccountValueAccTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AmortizationAccountValueAccTextBox.Location = New System.Drawing.Point(484, 53)
        Me.AmortizationAccountValueAccTextBox.Name = "AmortizationAccountValueAccTextBox"
        Me.AmortizationAccountValueAccTextBox.NegativeValue = False
        Me.AmortizationAccountValueAccTextBox.ReadOnly = True
        Me.AmortizationAccountValueAccTextBox.Size = New System.Drawing.Size(170, 20)
        Me.AmortizationAccountValueAccTextBox.TabIndex = 15
        Me.AmortizationAccountValueAccTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AcquisitionAccountValueAccTextBox
        '
        Me.AcquisitionAccountValueAccTextBox.DataBindings.Add(New System.Windows.Forms.Binding("DecimalValue", Me.LongTermAssetBindingSource, "AcquisitionAccountValue", True))
        Me.AcquisitionAccountValueAccTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AcquisitionAccountValueAccTextBox.Location = New System.Drawing.Point(484, 28)
        Me.AcquisitionAccountValueAccTextBox.Name = "AcquisitionAccountValueAccTextBox"
        Me.AcquisitionAccountValueAccTextBox.NegativeValue = False
        Me.AcquisitionAccountValueAccTextBox.ReadOnly = True
        Me.AcquisitionAccountValueAccTextBox.Size = New System.Drawing.Size(170, 20)
        Me.AcquisitionAccountValueAccTextBox.TabIndex = 12
        Me.AcquisitionAccountValueAccTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AccountRevaluedPortionAmmortizationAccGridComboBox
        '
        Me.AccountRevaluedPortionAmmortizationAccGridComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LongTermAssetBindingSource, "AccountRevaluedPortionAmmortization", True))
        Me.AccountRevaluedPortionAmmortizationAccGridComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccountRevaluedPortionAmmortizationAccGridComboBox.EmptyValueString = ""
        Me.AccountRevaluedPortionAmmortizationAccGridComboBox.InstantBinding = True
        Me.AccountRevaluedPortionAmmortizationAccGridComboBox.Location = New System.Drawing.Point(3, 128)
        Me.AccountRevaluedPortionAmmortizationAccGridComboBox.Name = "AccountRevaluedPortionAmmortizationAccGridComboBox"
        Me.AccountRevaluedPortionAmmortizationAccGridComboBox.Size = New System.Drawing.Size(170, 21)
        Me.AccountRevaluedPortionAmmortizationAccGridComboBox.TabIndex = 23
        '
        'AccountValueIncreaseAccGridComboBox
        '
        Me.AccountValueIncreaseAccGridComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LongTermAssetBindingSource, "AccountValueIncrease", True))
        Me.AccountValueIncreaseAccGridComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccountValueIncreaseAccGridComboBox.EmptyValueString = ""
        Me.AccountValueIncreaseAccGridComboBox.InstantBinding = True
        Me.AccountValueIncreaseAccGridComboBox.Location = New System.Drawing.Point(3, 103)
        Me.AccountValueIncreaseAccGridComboBox.Name = "AccountValueIncreaseAccGridComboBox"
        Me.AccountValueIncreaseAccGridComboBox.Size = New System.Drawing.Size(170, 21)
        Me.AccountValueIncreaseAccGridComboBox.TabIndex = 20
        '
        'AccountValueDecreaseAccGridComboBox
        '
        Me.AccountValueDecreaseAccGridComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LongTermAssetBindingSource, "AccountValueDecrease", True))
        Me.AccountValueDecreaseAccGridComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccountValueDecreaseAccGridComboBox.EmptyValueString = ""
        Me.AccountValueDecreaseAccGridComboBox.InstantBinding = True
        Me.AccountValueDecreaseAccGridComboBox.Location = New System.Drawing.Point(3, 78)
        Me.AccountValueDecreaseAccGridComboBox.Name = "AccountValueDecreaseAccGridComboBox"
        Me.AccountValueDecreaseAccGridComboBox.Size = New System.Drawing.Size(170, 21)
        Me.AccountValueDecreaseAccGridComboBox.TabIndex = 17
        '
        'AccountAccumulatedAmortizationAccGridComboBox
        '
        Me.AccountAccumulatedAmortizationAccGridComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LongTermAssetBindingSource, "AccountAccumulatedAmortization", True))
        Me.AccountAccumulatedAmortizationAccGridComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccountAccumulatedAmortizationAccGridComboBox.EmptyValueString = ""
        Me.AccountAccumulatedAmortizationAccGridComboBox.InstantBinding = True
        Me.AccountAccumulatedAmortizationAccGridComboBox.Location = New System.Drawing.Point(3, 53)
        Me.AccountAccumulatedAmortizationAccGridComboBox.Name = "AccountAccumulatedAmortizationAccGridComboBox"
        Me.AccountAccumulatedAmortizationAccGridComboBox.Size = New System.Drawing.Size(170, 21)
        Me.AccountAccumulatedAmortizationAccGridComboBox.TabIndex = 14
        '
        'AccountAcquisitionAccGridComboBox
        '
        Me.AccountAcquisitionAccGridComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LongTermAssetBindingSource, "AccountAcquisition", True))
        Me.AccountAcquisitionAccGridComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccountAcquisitionAccGridComboBox.EmptyValueString = ""
        Me.AccountAcquisitionAccGridComboBox.InstantBinding = True
        Me.AccountAcquisitionAccGridComboBox.Location = New System.Drawing.Point(3, 28)
        Me.AccountAcquisitionAccGridComboBox.Name = "AccountAcquisitionAccGridComboBox"
        Me.AccountAcquisitionAccGridComboBox.Size = New System.Drawing.Size(170, 21)
        Me.AccountAcquisitionAccGridComboBox.TabIndex = 11
        '
        'AttachJournalEntryInfoButton
        '
        Me.AttachJournalEntryInfoButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AttachJournalEntryInfoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttachJournalEntryInfoButton.Image = Global.AccDataBindingsWinForms.My.Resources.Resources.attach_icon_16x16
        Me.AttachJournalEntryInfoButton.Location = New System.Drawing.Point(0, 0)
        Me.AttachJournalEntryInfoButton.Margin = New System.Windows.Forms.Padding(0)
        Me.AttachJournalEntryInfoButton.Name = "AttachJournalEntryInfoButton"
        Me.AttachJournalEntryInfoButton.Size = New System.Drawing.Size(24, 24)
        Me.AttachJournalEntryInfoButton.TabIndex = 2
        Me.AttachJournalEntryInfoButton.UseVisualStyleBackColor = True
        '
        'ViewJournalEntryButton
        '
        Me.ViewJournalEntryButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ViewJournalEntryButton.Image = Global.AccDataBindingsWinForms.My.Resources.Resources.lektuvelis_16
        Me.ViewJournalEntryButton.Location = New System.Drawing.Point(24, 0)
        Me.ViewJournalEntryButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ViewJournalEntryButton.Name = "ViewJournalEntryButton"
        Me.ViewJournalEntryButton.Size = New System.Drawing.Size(24, 24)
        Me.ViewJournalEntryButton.TabIndex = 3
        Me.ViewJournalEntryButton.UseVisualStyleBackColor = True
        '
        'AcquisitionJournalEntryIDTextBox
        '
        Me.AcquisitionJournalEntryIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LongTermAssetBindingSource, "AcquisitionJournalEntryID", True))
        Me.AcquisitionJournalEntryIDTextBox.Location = New System.Drawing.Point(51, 3)
        Me.AcquisitionJournalEntryIDTextBox.Name = "AcquisitionJournalEntryIDTextBox"
        Me.AcquisitionJournalEntryIDTextBox.ReadOnly = True
        Me.AcquisitionJournalEntryIDTextBox.Size = New System.Drawing.Size(72, 20)
        Me.AcquisitionJournalEntryIDTextBox.TabIndex = 56
        Me.AcquisitionJournalEntryIDTextBox.TabStop = False
        Me.AcquisitionJournalEntryIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AcquisitionJournalEntryDocContentTextBox
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.AcquisitionJournalEntryDocContentTextBox, 7)
        Me.AcquisitionJournalEntryDocContentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LongTermAssetBindingSource, "AcquisitionJournalEntryDocContent", True))
        Me.AcquisitionJournalEntryDocContentTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AcquisitionJournalEntryDocContentTextBox.Location = New System.Drawing.Point(156, 403)
        Me.AcquisitionJournalEntryDocContentTextBox.Name = "AcquisitionJournalEntryDocContentTextBox"
        Me.AcquisitionJournalEntryDocContentTextBox.ReadOnly = True
        Me.AcquisitionJournalEntryDocContentTextBox.Size = New System.Drawing.Size(673, 20)
        Me.AcquisitionJournalEntryDocContentTextBox.TabIndex = 60
        Me.AcquisitionJournalEntryDocContentTextBox.TabStop = False
        '
        'AcquisitionJournalEntryDocNumberTextBox
        '
        Me.AcquisitionJournalEntryDocNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LongTermAssetBindingSource, "AcquisitionJournalEntryDocNumber", True))
        Me.AcquisitionJournalEntryDocNumberTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AcquisitionJournalEntryDocNumberTextBox.Location = New System.Drawing.Point(419, 378)
        Me.AcquisitionJournalEntryDocNumberTextBox.Name = "AcquisitionJournalEntryDocNumberTextBox"
        Me.AcquisitionJournalEntryDocNumberTextBox.ReadOnly = True
        Me.AcquisitionJournalEntryDocNumberTextBox.Size = New System.Drawing.Size(141, 20)
        Me.AcquisitionJournalEntryDocNumberTextBox.TabIndex = 58
        Me.AcquisitionJournalEntryDocNumberTextBox.TabStop = False
        Me.AcquisitionJournalEntryDocNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MeasureUnitTextBox
        '
        Me.MeasureUnitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LongTermAssetBindingSource, "MeasureUnit", True))
        Me.MeasureUnitTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MeasureUnitTextBox.Location = New System.Drawing.Point(419, 28)
        Me.MeasureUnitTextBox.MaxLength = 50
        Me.MeasureUnitTextBox.Name = "MeasureUnitTextBox"
        Me.MeasureUnitTextBox.Size = New System.Drawing.Size(141, 20)
        Me.MeasureUnitTextBox.TabIndex = 4
        Me.MeasureUnitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'InventoryNumberTextBox
        '
        Me.InventoryNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LongTermAssetBindingSource, "InventoryNumber", True))
        Me.InventoryNumberTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InventoryNumberTextBox.Location = New System.Drawing.Point(688, 28)
        Me.InventoryNumberTextBox.MaxLength = 50
        Me.InventoryNumberTextBox.Name = "InventoryNumberTextBox"
        Me.InventoryNumberTextBox.Size = New System.Drawing.Size(141, 20)
        Me.InventoryNumberTextBox.TabIndex = 5
        Me.InventoryNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ContinuedUsageCheckBox
        '
        Me.ContinuedUsageCheckBox.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.ContinuedUsageCheckBox, 2)
        Me.ContinuedUsageCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LongTermAssetBindingSource, "ContinuedUsage", True))
        Me.ContinuedUsageCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContinuedUsageCheckBox.Location = New System.Drawing.Point(586, 353)
        Me.ContinuedUsageCheckBox.Name = "ContinuedUsageCheckBox"
        Me.ContinuedUsageCheckBox.Size = New System.Drawing.Size(146, 17)
        Me.ContinuedUsageCheckBox.TabIndex = 9
        Me.ContinuedUsageCheckBox.Text = "Tęsiamas naudojimas"
        '
        'LegalGroupComboBox
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.LegalGroupComboBox, 7)
        Me.LegalGroupComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LongTermAssetBindingSource, "LegalGroup", True))
        Me.LegalGroupComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LegalGroupComboBox.FormattingEnabled = True
        Me.LegalGroupComboBox.Location = New System.Drawing.Point(156, 78)
        Me.LegalGroupComboBox.Name = "LegalGroupComboBox"
        Me.LegalGroupComboBox.Size = New System.Drawing.Size(673, 21)
        Me.LegalGroupComboBox.TabIndex = 2
        '
        'NameTextBox
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.NameTextBox, 7)
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LongTermAssetBindingSource, "Name", True))
        Me.NameTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NameTextBox.Location = New System.Drawing.Point(156, 53)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(673, 20)
        Me.NameTextBox.TabIndex = 1
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LongTermAssetBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(156, 3)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(120, 20)
        Me.IDTextBox.TabIndex = 3
        Me.IDTextBox.TabStop = False
        Me.IDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 9
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.AcquisitionJournalEntryDocTypeHumanReadableTextBox, 7, 15)
        Me.TableLayoutPanel1.Controls.Add(AcquisitionJournalEntryDocTypeHumanReadableLabel, 6, 15)
        Me.TableLayoutPanel1.Controls.Add(Me.UpdateDateTextBox, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(UpdateDateLabel, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Label6, 0, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.AcquisitionJournalEntryDocContentTextBox, 1, 16)
        Me.TableLayoutPanel1.Controls.Add(AcquisitionJournalEntryDocContentLabel, 0, 16)
        Me.TableLayoutPanel1.Controls.Add(Me.InsertDateTextBox, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(InsertDateLabel, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.AcquisitionJournalEntryDocNumberTextBox, 4, 15)
        Me.TableLayoutPanel1.Controls.Add(Me.AmortizationCalculatedForMonthsAccTextBox, 4, 14)
        Me.TableLayoutPanel1.Controls.Add(AcquisitionJournalEntryDocNumberLabel, 3, 15)
        Me.TableLayoutPanel1.Controls.Add(AcquisitionJournalEntryIDLabel, 0, 15)
        Me.TableLayoutPanel1.Controls.Add(Me.DefaultAmortizationPeriodAccTextBox, 4, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.LiquidationUnitValueAccTextBox, 7, 13)
        Me.TableLayoutPanel1.Controls.Add(Label5, 0, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(LiquidationUnitValueLabel, 6, 13)
        Me.TableLayoutPanel1.Controls.Add(AccountRevaluedPortionAmmortizationLabel, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(AccountValueIncreaseLabel, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(AccountValueDecreaseLabel, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(DefaultAmortizationPeriodLabel, 3, 13)
        Me.TableLayoutPanel1.Controls.Add(AccountAccumulatedAmortizationLabel, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(AccountAcquisitionLabel, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(CustomGroupInfoLabel, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(LegalGroupLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(NameLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LegalGroupComboBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.NameTextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(AcquisitionDateLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(IDLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.InventoryNumberTextBox, 7, 1)
        Me.TableLayoutPanel1.Controls.Add(InventoryNumberLabel, 6, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.MeasureUnitTextBox, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(MeasureUnitLabel, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.IDTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(AmmountLabel, 0, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.AmmountAccTextBox, 1, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.ContinuedUsageCheckBox, 6, 14)
        Me.TableLayoutPanel1.Controls.Add(AmortizationCalculatedForMonthsLabel, 1, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 15)
        Me.TableLayoutPanel1.Controls.Add(Me.CustomGroupInfoAccGridComboBox, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.AcquisitionDateAccDatePicker, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 18
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(853, 438)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'AcquisitionJournalEntryDocTypeHumanReadableTextBox
        '
        Me.AcquisitionJournalEntryDocTypeHumanReadableTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LongTermAssetBindingSource, "AcquisitionJournalEntryDocTypeHumanReadable", True))
        Me.AcquisitionJournalEntryDocTypeHumanReadableTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AcquisitionJournalEntryDocTypeHumanReadableTextBox.Location = New System.Drawing.Point(688, 378)
        Me.AcquisitionJournalEntryDocTypeHumanReadableTextBox.Name = "AcquisitionJournalEntryDocTypeHumanReadableTextBox"
        Me.AcquisitionJournalEntryDocTypeHumanReadableTextBox.ReadOnly = True
        Me.AcquisitionJournalEntryDocTypeHumanReadableTextBox.Size = New System.Drawing.Size(141, 20)
        Me.AcquisitionJournalEntryDocTypeHumanReadableTextBox.TabIndex = 3
        '
        'UpdateDateTextBox
        '
        Me.UpdateDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LongTermAssetBindingSource, "UpdateDate", True))
        Me.UpdateDateTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UpdateDateTextBox.Location = New System.Drawing.Point(688, 3)
        Me.UpdateDateTextBox.Name = "UpdateDateTextBox"
        Me.UpdateDateTextBox.ReadOnly = True
        Me.UpdateDateTextBox.Size = New System.Drawing.Size(141, 20)
        Me.UpdateDateTextBox.TabIndex = 5
        '
        'InsertDateTextBox
        '
        Me.InsertDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LongTermAssetBindingSource, "InsertDate", True))
        Me.InsertDateTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InsertDateTextBox.Location = New System.Drawing.Point(419, 3)
        Me.InsertDateTextBox.Name = "InsertDateTextBox"
        Me.InsertDateTextBox.ReadOnly = True
        Me.InsertDateTextBox.Size = New System.Drawing.Size(141, 20)
        Me.InsertDateTextBox.TabIndex = 3
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 7
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 7)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel2.Controls.Add(Label7, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Label3, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ValueIncreaseAmmortizationAccountValueCorrectionNumericUpDown, 4, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.ValueIncreaseAccountValueCorrectionNumericUpDown, 4, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.AmortizationAccountValueCorrectionNumericUpDown, 4, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.AcquisitionAccountValuePerUnitAccTextBox, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.ValueDecreaseAccountValueCorrectionNumericUpDown, 4, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.AmortizationAccountValuePerUnitAccTextBox, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.AcquisitionAccountValueCorrectionNumericUpDown, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.ValueRevaluedPortionAccTextBox, 5, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.ValueDecreaseAccountValuePerUnitAccTextBox, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.ValueIncreaseAccountValuePerUnitAccTextBox, 2, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.ValueIncreaseAmmortizationAccountValuePerUnitAccTextBox, 2, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.AccountAcquisitionAccGridComboBox, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.AccountAccumulatedAmortizationAccGridComboBox, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.ValueIncreaseAmmortizationAccountValueAccTextBox, 5, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.AccountValueDecreaseAccGridComboBox, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.ValueIncreaseAccountValueAccTextBox, 5, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.AccountValueIncreaseAccGridComboBox, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.ValueDecreaseAccountValueAccTextBox, 5, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.AccountRevaluedPortionAmmortizationAccGridComboBox, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.AmortizationAccountValueAccTextBox, 5, 2)
        Me.TableLayoutPanel2.Controls.Add(Label2, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.AcquisitionAccountValueAccTextBox, 5, 1)
        Me.TableLayoutPanel2.Controls.Add(Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ValuePerUnitAccTextBox, 2, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.ValueAccTextBox, 5, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.ValueRevaluedPortionPerUnitAccTextBox, 2, 7)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(153, 125)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 8
        Me.TableLayoutPanel1.SetRowSpan(Me.TableLayoutPanel2, 8)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(679, 200)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'ValueIncreaseAmmortizationAccountValueCorrectionNumericUpDown
        '
        Me.ValueIncreaseAmmortizationAccountValueCorrectionNumericUpDown.AutoSize = True
        Me.ValueIncreaseAmmortizationAccountValueCorrectionNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LongTermAssetBindingSource, "ValueIncreaseAmmortizationAccountValueCorrection", True))
        Me.ValueIncreaseAmmortizationAccountValueCorrectionNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ValueIncreaseAmmortizationAccountValueCorrectionNumericUpDown.Location = New System.Drawing.Point(395, 128)
        Me.ValueIncreaseAmmortizationAccountValueCorrectionNumericUpDown.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.ValueIncreaseAmmortizationAccountValueCorrectionNumericUpDown.Minimum = New Decimal(New Integer() {1410065407, 2, 0, -2147483648})
        Me.ValueIncreaseAmmortizationAccountValueCorrectionNumericUpDown.Name = "ValueIncreaseAmmortizationAccountValueCorrectionNumericUpDown"
        Me.ValueIncreaseAmmortizationAccountValueCorrectionNumericUpDown.Size = New System.Drawing.Size(83, 20)
        Me.ValueIncreaseAmmortizationAccountValueCorrectionNumericUpDown.TabIndex = 3
        Me.ValueIncreaseAmmortizationAccountValueCorrectionNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ValueIncreaseAccountValueCorrectionNumericUpDown
        '
        Me.ValueIncreaseAccountValueCorrectionNumericUpDown.AutoSize = True
        Me.ValueIncreaseAccountValueCorrectionNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LongTermAssetBindingSource, "ValueIncreaseAccountValueCorrection", True))
        Me.ValueIncreaseAccountValueCorrectionNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ValueIncreaseAccountValueCorrectionNumericUpDown.Location = New System.Drawing.Point(395, 103)
        Me.ValueIncreaseAccountValueCorrectionNumericUpDown.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.ValueIncreaseAccountValueCorrectionNumericUpDown.Minimum = New Decimal(New Integer() {1410065407, 2, 0, -2147483648})
        Me.ValueIncreaseAccountValueCorrectionNumericUpDown.Name = "ValueIncreaseAccountValueCorrectionNumericUpDown"
        Me.ValueIncreaseAccountValueCorrectionNumericUpDown.Size = New System.Drawing.Size(83, 20)
        Me.ValueIncreaseAccountValueCorrectionNumericUpDown.TabIndex = 5
        Me.ValueIncreaseAccountValueCorrectionNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AmortizationAccountValueCorrectionNumericUpDown
        '
        Me.AmortizationAccountValueCorrectionNumericUpDown.AutoSize = True
        Me.AmortizationAccountValueCorrectionNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LongTermAssetBindingSource, "AmortizationAccountValueCorrection", True))
        Me.AmortizationAccountValueCorrectionNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AmortizationAccountValueCorrectionNumericUpDown.Location = New System.Drawing.Point(395, 53)
        Me.AmortizationAccountValueCorrectionNumericUpDown.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.AmortizationAccountValueCorrectionNumericUpDown.Minimum = New Decimal(New Integer() {1410065407, 2, 0, -2147483648})
        Me.AmortizationAccountValueCorrectionNumericUpDown.Name = "AmortizationAccountValueCorrectionNumericUpDown"
        Me.AmortizationAccountValueCorrectionNumericUpDown.Size = New System.Drawing.Size(83, 20)
        Me.AmortizationAccountValueCorrectionNumericUpDown.TabIndex = 5
        Me.AmortizationAccountValueCorrectionNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ValueDecreaseAccountValueCorrectionNumericUpDown
        '
        Me.ValueDecreaseAccountValueCorrectionNumericUpDown.AutoSize = True
        Me.ValueDecreaseAccountValueCorrectionNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LongTermAssetBindingSource, "ValueDecreaseAccountValueCorrection", True))
        Me.ValueDecreaseAccountValueCorrectionNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ValueDecreaseAccountValueCorrectionNumericUpDown.Location = New System.Drawing.Point(395, 78)
        Me.ValueDecreaseAccountValueCorrectionNumericUpDown.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.ValueDecreaseAccountValueCorrectionNumericUpDown.Minimum = New Decimal(New Integer() {1410065407, 2, 0, -2147483648})
        Me.ValueDecreaseAccountValueCorrectionNumericUpDown.Name = "ValueDecreaseAccountValueCorrectionNumericUpDown"
        Me.ValueDecreaseAccountValueCorrectionNumericUpDown.Size = New System.Drawing.Size(83, 20)
        Me.ValueDecreaseAccountValueCorrectionNumericUpDown.TabIndex = 3
        Me.ValueDecreaseAccountValueCorrectionNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AcquisitionAccountValueCorrectionNumericUpDown
        '
        Me.AcquisitionAccountValueCorrectionNumericUpDown.AutoSize = True
        Me.AcquisitionAccountValueCorrectionNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LongTermAssetBindingSource, "AcquisitionAccountValueCorrection", True))
        Me.AcquisitionAccountValueCorrectionNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AcquisitionAccountValueCorrectionNumericUpDown.Location = New System.Drawing.Point(395, 28)
        Me.AcquisitionAccountValueCorrectionNumericUpDown.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.AcquisitionAccountValueCorrectionNumericUpDown.Minimum = New Decimal(New Integer() {1410065407, 2, 0, -2147483648})
        Me.AcquisitionAccountValueCorrectionNumericUpDown.Name = "AcquisitionAccountValueCorrectionNumericUpDown"
        Me.AcquisitionAccountValueCorrectionNumericUpDown.Size = New System.Drawing.Size(83, 20)
        Me.AcquisitionAccountValueCorrectionNumericUpDown.TabIndex = 3
        Me.AcquisitionAccountValueCorrectionNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel3, 2)
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.AcquisitionJournalEntryIDTextBox, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.ViewJournalEntryButton, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.AttachJournalEntryInfoButton, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(153, 375)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(146, 25)
        Me.TableLayoutPanel3.TabIndex = 56
        '
        'CustomGroupInfoAccGridComboBox
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.CustomGroupInfoAccGridComboBox, 7)
        Me.CustomGroupInfoAccGridComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LongTermAssetBindingSource, "CustomGroupInfo", True))
        Me.CustomGroupInfoAccGridComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomGroupInfoAccGridComboBox.EmptyValueString = ""
        Me.CustomGroupInfoAccGridComboBox.InstantBinding = True
        Me.CustomGroupInfoAccGridComboBox.Location = New System.Drawing.Point(156, 103)
        Me.CustomGroupInfoAccGridComboBox.Name = "CustomGroupInfoAccGridComboBox"
        Me.CustomGroupInfoAccGridComboBox.Size = New System.Drawing.Size(673, 21)
        Me.CustomGroupInfoAccGridComboBox.TabIndex = 61
        '
        'AcquisitionDateAccDatePicker
        '
        Me.AcquisitionDateAccDatePicker.BoldedDates = Nothing
        Me.AcquisitionDateAccDatePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LongTermAssetBindingSource, "AcquisitionDate", True))
        Me.AcquisitionDateAccDatePicker.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AcquisitionDateAccDatePicker.Location = New System.Drawing.Point(156, 28)
        Me.AcquisitionDateAccDatePicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.AcquisitionDateAccDatePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.AcquisitionDateAccDatePicker.Name = "AcquisitionDateAccDatePicker"
        Me.AcquisitionDateAccDatePicker.ReadOnly = False
        Me.AcquisitionDateAccDatePicker.ShowWeekNumbers = True
        Me.AcquisitionDateAccDatePicker.Size = New System.Drawing.Size(120, 19)
        Me.AcquisitionDateAccDatePicker.TabIndex = 0
        '
        'ProgressFiller1
        '
        Me.ProgressFiller1.Location = New System.Drawing.Point(191, 50)
        Me.ProgressFiller1.Name = "ProgressFiller1"
        Me.ProgressFiller1.Size = New System.Drawing.Size(182, 53)
        Me.ProgressFiller1.TabIndex = 3
        Me.ProgressFiller1.Visible = False
        '
        'ProgressFiller2
        '
        Me.ProgressFiller2.Location = New System.Drawing.Point(402, 53)
        Me.ProgressFiller2.Name = "ProgressFiller2"
        Me.ProgressFiller2.Size = New System.Drawing.Size(238, 62)
        Me.ProgressFiller2.TabIndex = 4
        Me.ProgressFiller2.Visible = False
        '
        'ErrorWarnInfoProvider1
        '
        Me.ErrorWarnInfoProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorWarnInfoProvider1.BlinkStyleInformation = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorWarnInfoProvider1.BlinkStyleWarning = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorWarnInfoProvider1.ContainerControl = Me
        Me.ErrorWarnInfoProvider1.DataSource = Me.LongTermAssetBindingSource
        '
        'F_LongTermAsset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 475)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ProgressFiller2)
        Me.Controls.Add(Me.ProgressFiller1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_LongTermAsset"
        Me.ShowInTaskbar = False
        Me.Text = "Ilgalaikio turto bendri duomenys"
        Me.Panel2.ResumeLayout(False)
        Me.EditedBaner.ResumeLayout(False)
        Me.EditedBaner.PerformLayout()
        CType(Me.LongTermAssetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.ValueIncreaseAmmortizationAccountValueCorrectionNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValueIncreaseAccountValueCorrectionNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmortizationAccountValueCorrectionNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValueDecreaseAccountValueCorrectionNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AcquisitionAccountValueCorrectionNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.ErrorWarnInfoProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents EditedBaner As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nCancelButton As System.Windows.Forms.Button
    Friend WithEvents ApplyButton As System.Windows.Forms.Button
    Friend WithEvents nOkButton As System.Windows.Forms.Button
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LongTermAssetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LegalGroupComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents InventoryNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContinuedUsageCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MeasureUnitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AcquisitionJournalEntryIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AcquisitionJournalEntryDocContentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AcquisitionJournalEntryDocNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AttachJournalEntryInfoButton As System.Windows.Forms.Button
    Friend WithEvents AccountValueIncreaseAccGridComboBox As AccControlsWinForms.AccListComboBox
    Friend WithEvents AccountValueDecreaseAccGridComboBox As AccControlsWinForms.AccListComboBox
    Friend WithEvents AccountAccumulatedAmortizationAccGridComboBox As AccControlsWinForms.AccListComboBox
    Friend WithEvents AccountAcquisitionAccGridComboBox As AccControlsWinForms.AccListComboBox
    Friend WithEvents AcquisitionAccountValuePerUnitAccTextBox As AccControlsWinForms.AccTextBox
    Friend WithEvents ValueIncreaseAmmortizationAccountValueAccTextBox As AccControlsWinForms.AccTextBox
    Friend WithEvents ValueIncreaseAccountValueAccTextBox As AccControlsWinForms.AccTextBox
    Friend WithEvents ValueDecreaseAccountValueAccTextBox As AccControlsWinForms.AccTextBox
    Friend WithEvents AmortizationAccountValueAccTextBox As AccControlsWinForms.AccTextBox
    Friend WithEvents AcquisitionAccountValueAccTextBox As AccControlsWinForms.AccTextBox
    Friend WithEvents AccountRevaluedPortionAmmortizationAccGridComboBox As AccControlsWinForms.AccListComboBox
    Friend WithEvents AmmountAccTextBox As AccControlsWinForms.AccTextBox
    Friend WithEvents DefaultAmortizationPeriodAccTextBox As AccControlsWinForms.AccTextBox
    Friend WithEvents AmortizationCalculatedForMonthsAccTextBox As AccControlsWinForms.AccTextBox
    Friend WithEvents LiquidationUnitValueAccTextBox As AccControlsWinForms.AccTextBox
    Friend WithEvents ValueIncreaseAmmortizationAccountValuePerUnitAccTextBox As AccControlsWinForms.AccTextBox
    Friend WithEvents ValueIncreaseAccountValuePerUnitAccTextBox As AccControlsWinForms.AccTextBox
    Friend WithEvents ValueDecreaseAccountValuePerUnitAccTextBox As AccControlsWinForms.AccTextBox
    Friend WithEvents AmortizationAccountValuePerUnitAccTextBox As AccControlsWinForms.AccTextBox
    Friend WithEvents ValueRevaluedPortionPerUnitAccTextBox As AccControlsWinForms.AccTextBox
    Friend WithEvents ValueRevaluedPortionAccTextBox As AccControlsWinForms.AccTextBox
    Friend WithEvents ValuePerUnitAccTextBox As AccControlsWinForms.AccTextBox
    Friend WithEvents ValueAccTextBox As AccControlsWinForms.AccTextBox
    Friend WithEvents ViewJournalEntryButton As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents UpdateDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InsertDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ValueIncreaseAmmortizationAccountValueCorrectionNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents ValueIncreaseAccountValueCorrectionNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents AmortizationAccountValueCorrectionNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents ValueDecreaseAccountValueCorrectionNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents AcquisitionAccountValueCorrectionNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents AcquisitionJournalEntryDocTypeHumanReadableTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomGroupInfoAccGridComboBox As AccControlsWinForms.AccListComboBox
    Friend WithEvents ProgressFiller1 As AccControlsWinForms.ProgressFiller
    Friend WithEvents ProgressFiller2 As AccControlsWinForms.ProgressFiller
    Friend WithEvents ErrorWarnInfoProvider1 As AccControlsWinForms.ErrorWarnInfoProvider
    Friend WithEvents AcquisitionDateAccDatePicker As AccControlsWinForms.AccDatePicker
End Class
