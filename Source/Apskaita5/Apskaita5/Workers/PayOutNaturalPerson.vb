Imports ApskaitaObjects.Attributes
Imports Csla.Validation
Imports ApskaitaObjects.My.Resources

Namespace Workers

    ''' <summary>
    ''' Represent a payment to a natural person when some taxes are deducted or payed by the company. 
    ''' Used in tax declarations.
    ''' </summary>
    ''' <remarks>Provides additional info on top of a <see cref="General.JournalEntry">JournalEntry</see>.
    ''' Values are stored in the database table d_kitos.</remarks>
    <Serializable()> _
    Public NotInheritable Class PayOutNaturalPerson
        Inherits BusinessBase(Of PayOutNaturalPerson)
        Implements IIsDirtyEnough, IValidationMessageProvider

#Region " Business Methods "

        Private Shared ReadOnly AllowedDocumentTypes As DocumentType() = New DocumentType() _
            {DocumentType.BankOperation, DocumentType.None, DocumentType.Offset, DocumentType.TillSpendingOrder}

        Private _ID As Integer = 0
        Private _JournalEntryID As Integer = 0
        Private _Date As Date = Today
        Private _Content As String = ""
        Private _DocNumber As String = ""
        Private _PersonInfo As String = ""
        Private _PersonCodeSODRA As String = ""
        Private _SumJournalEntry As Double = 0
        Private _SumNeto As Double = 0
        Private _SumBruto As Double = 0
        Private _RateGPM As Double = 0
        Private _RatePSDForPerson As Double = 0
        Private _RatePSDForCompany As Double = 0
        Private _SODRABase As Integer = 100
        Private _RateSODRAForPerson As Double = 0
        Private _RateSODRAForCompany As Double = 0
        Private _CodeVMI As Integer = 0
        Private _CodeSODRA As Integer = 0
        Private _DeductionGPM As Double = 0
        Private _DeductionPSD As Double = 0
        Private _DeductionSODRA As Double = 0
        Private _ContributionPSD As Double = 0
        Private _ContributionSODRA As Double = 0
        Private _TotalPSD As Double = 0
        Private _TotalSODRA As Double = 0
        Private _InsertDate As DateTime = Now
        Private _UpdateDate As DateTime = Now


        ''' <summary>
        ''' Gets an ID of the payment info that is assigned by a database (AUTOINCREMENT).
        ''' </summary>
        ''' <remarks>Value is stored in the database field d_kitos.ID.</remarks>
        Public ReadOnly Property ID() As Integer
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _ID
            End Get
        End Property

        ''' <summary>
        ''' Gets the date and time when the payment info was inserted into the database.
        ''' </summary>
        ''' <remarks>Value is stored in the database field d_kitos.InsertDate.</remarks>
        Public ReadOnly Property InsertDate() As DateTime
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _InsertDate
            End Get
        End Property

        ''' <summary>
        ''' Gets the date and time when the payment info was last updated.
        ''' </summary>
        ''' <remarks>Value is stored in the database field d_kitos.UpdateDate.</remarks>
        Public ReadOnly Property UpdateDate() As DateTime
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _UpdateDate
            End Get
        End Property

        ''' <summary>
        ''' Gets the <see cref="General.JournalEntry.ID">general ledger entry ID</see> for the payment info.
        ''' </summary>
        ''' <remarks>Value is stored in the database field d_kitos.BZ_ID.</remarks>
        <IntegerField(ValueRequiredLevel.Mandatory, False)> _
        Public ReadOnly Property JournalEntryID() As Integer
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _JournalEntryID
            End Get
        End Property

        ''' <summary>
        ''' Gets the date of the payment.
        ''' </summary>
        ''' <remarks>Corresponds to <see cref="General.JournalEntry.Date">JournalEntry.Date</see>.</remarks>
        Public ReadOnly Property [Date]() As Date
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _Date
            End Get
        End Property

        ''' <summary>
        ''' Gets the description of the payment.
        ''' </summary>
        ''' <remarks>Corresponds to <see cref="General.JournalEntry.Content">JournalEntry.Content</see>.</remarks>
        Public ReadOnly Property Content() As String
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _Content.Trim
            End Get
        End Property

        ''' <summary>
        ''' Gets the document number of the payment.
        ''' </summary>
        ''' <remarks>Corresponds to <see cref="General.JournalEntry.DocNumber">JournalEntry.DocNumber</see>.</remarks>
        Public ReadOnly Property DocNumber() As String
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _DocNumber.Trim
            End Get
        End Property

        ''' <summary>
        ''' Gets the payment receiver name.
        ''' </summary>
        ''' <remarks>Corresponds to <see cref="ActiveReports.JournalEntryInfo.Person">JournalEntryInfo.Person</see>.</remarks>
        Public ReadOnly Property PersonInfo() As String
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _PersonInfo.Trim
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the payment receiver social security (SODRA) code.
        ''' </summary>
        ''' <remarks>Value is stored in the database field d_kitos.KodasSDA.</remarks>
        <StringField(ValueRequiredLevel.Optional, 15, False)> _
        Public Property PersonCodeSODRA() As String
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _PersonCodeSODRA.Trim
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As String)
                CanWriteProperty(True)
                If value Is Nothing Then value = ""
                If _PersonCodeSODRA.Trim <> value.Trim Then
                    _PersonCodeSODRA = value.Trim
                    PropertyHasChanged()
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets the total sum of the journal entry.
        ''' </summary>
        ''' <remarks></remarks>
        <DoubleField(ValueRequiredLevel.Optional, False, 2)> _
        Public ReadOnly Property SumJournalEntry() As Double
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return CRound(_SumJournalEntry)
            End Get
        End Property

        ''' <summary>
        ''' Gets the total sum that was actualy payed to the receiver (i.e. excluding all the taxes).
        ''' </summary>
        ''' <remarks>Value is stored in the database field d_kitos.Suma.</remarks>
        <DoubleField(ValueRequiredLevel.Optional, False, 2)> _
        Public ReadOnly Property SumNeto() As Double
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return CRound(_SumNeto)
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the contractual sum of the payment (i.e. <see cref="SumNeto">SumNeto</see> plus the deducted taxes excluding taxes that are payed at the company's cost).
        ''' </summary>
        ''' <remarks>Value is stored in the database field d_kitos.SumaBruto.</remarks>
        <DoubleField(ValueRequiredLevel.Mandatory, False, 2)> _
        Public Property SumBruto() As Double
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return CRound(_SumBruto)
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As Double)
                CanWriteProperty(True)
                If CRound(_SumBruto) <> CRound(value) Then
                    _SumBruto = CRound(value)
                    PropertyHasChanged()
                    RecalculateAllTaxes(True)
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the personal income tax (GPM) rate.
        ''' </summary>
        ''' <remarks>Value is stored in the database field d_kitos.Tar.</remarks>
        <TaxRateField(ValueRequiredLevel.Recommended, ApskaitaObjects.Settings.TaxRateType.GPM)> _
        Public Property RateGPM() As Double
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return CRound(_RateGPM)
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As Double)
                CanWriteProperty(True)
                If CRound(_RateGPM) <> CRound(value) Then
                    _RateGPM = CRound(value)
                    PropertyHasChanged()
                    RecalculateAllTaxes(True)
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the health insurance contribution (PSD) rate for the receiver (deducted from the contractual sum).
        ''' </summary>
        ''' <remarks>Value is stored in the database field d_kitos.TarPSDW.</remarks>
        <TaxRateField(ValueRequiredLevel.Recommended, ApskaitaObjects.Settings.TaxRateType.PSDForPerson)> _
        Public Property RatePSDForPerson() As Double
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return CRound(_RatePSDForPerson)
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As Double)
                CanWriteProperty(True)
                If CRound(_RatePSDForPerson) <> CRound(value) Then
                    _RatePSDForPerson = CRound(value)
                    PropertyHasChanged()
                    RecalculateAllTaxes(True)
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the health insurance contribution (PSD) rate for the company (at the company's expense additionaly to the contractual sum).
        ''' </summary>
        ''' <remarks>Value is stored in the database field d_kitos.TarPSDE.</remarks>
        <TaxRateField(ValueRequiredLevel.Recommended, ApskaitaObjects.Settings.TaxRateType.PSDForCompany)> _
        Public Property RatePSDForCompany() As Double
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return CRound(_RatePSDForCompany)
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As Double)
                CanWriteProperty(True)
                If CRound(_RatePSDForCompany) <> CRound(value) Then
                    _RatePSDForCompany = CRound(value)
                    PropertyHasChanged()
                    _ContributionPSD = CRound(_SumBruto * _SODRABase * _RatePSDForCompany / 100 / 100)
                    _TotalPSD = CRound(_DeductionPSD + _ContributionPSD)
                    PropertyHasChanged("ContributionPSD")
                    PropertyHasChanged("TotalPSD")
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the percentage of the contractual sum that is taxable by the social security contributions (SODRA) rates.
        ''' </summary>
        ''' <remarks>Value is stored in the database field d_kitos.BaseSODRA.</remarks>
        <IntegerField(ValueRequiredLevel.Recommended, False, True, 1, 100, False)> _
        Public Property SODRABase() As Integer
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _SODRABase
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As Integer)
                CanWriteProperty(True)
                If _SODRABase <> value Then
                    _SODRABase = value
                    PropertyHasChanged()
                    RecalculateAllTaxes(True)
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the social security contribution (SODRA) rate for the receiver (deducted from the contractual sum).
        ''' </summary>
        ''' <remarks>Value is stored in the database field d_kitos.TarSDW.</remarks>
        <TaxRateField(ValueRequiredLevel.Recommended, ApskaitaObjects.Settings.TaxRateType.SodraForPerson)> _
        Public Property RateSODRAForPerson() As Double
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return CRound(_RateSODRAForPerson)
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As Double)
                CanWriteProperty(True)
                If CRound(_RateSODRAForPerson) <> CRound(value) Then
                    _RateSODRAForPerson = CRound(value)
                    PropertyHasChanged()
                    RecalculateAllTaxes(True)
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the social security contribution (SODRA) rate for the company (at the company's expense additionaly to the contractual sum).
        ''' </summary>
        ''' <remarks>Value is stored in the database field d_kitos.TarSDE.</remarks>
        <TaxRateField(ValueRequiredLevel.Recommended, ApskaitaObjects.Settings.TaxRateType.SodraForCompany)> _
        Public Property RateSODRAForCompany() As Double
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return CRound(_RateSODRAForCompany)
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As Double)
                CanWriteProperty(True)
                If CRound(_RateSODRAForCompany) <> CRound(value) Then
                    _RateSODRAForCompany = CRound(value)
                    PropertyHasChanged()
                    _ContributionSODRA = CRound(_SumBruto * _SODRABase * _RateSODRAForCompany / 100 / 100)
                    _TotalSODRA = CRound(_DeductionSODRA + _ContributionSODRA)
                    PropertyHasChanged("ContributionSODRA")
                    PropertyHasChanged("TotalSODRA")
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the code of the payment according to the state tax inspectorate (VMI) clasification.
        ''' </summary>
        ''' <remarks>Value is stored in the database field d_kitos.Kodas.</remarks>
        <CodeField(ValueRequiredLevel.Recommended, ApskaitaObjects.Settings.CodeType.GpmDeclaration)> _
        Public Property CodeVMI() As Integer
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _CodeVMI
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As Integer)
                CanWriteProperty(True)
                If _CodeVMI <> value Then
                    _CodeVMI = value
                    PropertyHasChanged()
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the code of the payment according to the social security (SODRA) clasification.
        ''' </summary>
        ''' <remarks>Value is stored in the database field d_kitos.KodasSD.</remarks>
        <CodeField(ValueRequiredLevel.Recommended, ApskaitaObjects.Settings.CodeType.SodraDeclaration)> _
        Public Property CodeSODRA() As Integer
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _CodeSODRA
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As Integer)
                CanWriteProperty(True)
                If _CodeSODRA <> value Then
                    _CodeSODRA = value
                    PropertyHasChanged()
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets total amount of personal income tax (GPM) deducted from the contractual sum.
        ''' </summary>
        ''' <remarks></remarks>
        <DoubleField(ValueRequiredLevel.Optional, False, 2)> _
        Public ReadOnly Property DeductionGPM() As Double
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return CRound(_DeductionGPM)
            End Get
        End Property

        ''' <summary>
        ''' Gets total amount of health insurance contributions deducted from the contractual sum.
        ''' </summary>
        ''' <remarks></remarks>
        <DoubleField(ValueRequiredLevel.Optional, False, 2)> _
        Public ReadOnly Property DeductionPSD() As Double
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return CRound(_DeductionPSD)
            End Get
        End Property

        ''' <summary>
        ''' Gets total amount of social security contributions (SODRA) deducted from the contractual sum.
        ''' </summary>
        ''' <remarks></remarks>
        <DoubleField(ValueRequiredLevel.Optional, False, 2)> _
        Public ReadOnly Property DeductionSODRA() As Double
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return CRound(_DeductionSODRA)
            End Get
        End Property

        ''' <summary>
        ''' Gets total amount of health insurance contributions at the company's expense additionaly to the contractual sum.
        ''' </summary>
        ''' <remarks></remarks>
        <DoubleField(ValueRequiredLevel.Optional, False, 2)> _
        Public ReadOnly Property ContributionPSD() As Double
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return CRound(_ContributionPSD)
            End Get
        End Property

        ''' <summary>
        ''' Gets total amount of social security contributions (SODRA) at the company's expense additionaly to the contractual sum.
        ''' </summary>
        ''' <remarks></remarks>
        <DoubleField(ValueRequiredLevel.Optional, False, 2)> _
        Public ReadOnly Property ContributionSODRA() As Double
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return CRound(_ContributionSODRA)
            End Get
        End Property

        ''' <summary>
        ''' Gets total amount of health insurance contributions.
        ''' </summary>
        ''' <remarks><see cref="DeductionPSD">DeductionPSD</see> plus <see cref="ContributionPSD">ContributionPSD</see>.</remarks>
        <DoubleField(ValueRequiredLevel.Optional, False, 2)> _
        Public ReadOnly Property TotalPSD() As Double
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return CRound(_TotalPSD)
            End Get
        End Property

        ''' <summary>
        ''' Gets total amount of social security contributions (SODRA) deducted from the contractual sum.
        ''' </summary>
        ''' <remarks><see cref="DeductionSODRA">DeductionSODRA</see> plus <see cref="ContributionSODRA">ContributionSODRA</see>.</remarks>
        <DoubleField(ValueRequiredLevel.Optional, False, 2)> _
        Public ReadOnly Property TotalSODRA() As Double
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return CRound(_TotalSODRA)
            End Get
        End Property


        ''' <summary>
        ''' Returnes TRUE if the object is new and contains some user provided data 
        ''' OR
        ''' object is not new and was changed by the user.
        ''' </summary>
        Public ReadOnly Property IsDirtyEnough() As Boolean _
        Implements IIsDirtyEnough.IsDirtyEnough
            Get
                If Not IsNew Then Return IsDirty
                Return (Not String.IsNullOrEmpty(_PersonCodeSODRA.Trim))
            End Get
        End Property

        Public Overrides ReadOnly Property IsValid() As Boolean _
            Implements IValidationMessageProvider.IsValid
            Get
                Return MyBase.IsValid
            End Get
        End Property



        Public Overrides Function Save() As PayOutNaturalPerson

            Me.ValidationRules.CheckRules()
            If Not Me.IsValid Then
                Throw New Exception(String.Format(My.Resources.Common_ContainsErrors, vbCrLf, _
                    GetAllBrokenRules()))
            End If

            Return MyBase.Save

        End Function


        Public Function GetAllBrokenRules() As String _
            Implements IValidationMessageProvider.GetAllBrokenRules
            Dim result As String = ""
            If Not MyBase.IsValid Then result = AddWithNewLine(result, _
                Me.BrokenRulesCollection.ToString(Validation.RuleSeverity.Error), False)
            Return result
        End Function

        Public Function GetAllWarnings() As String _
            Implements IValidationMessageProvider.GetAllWarnings
            Dim result As String = ""
            If Not MyBase.BrokenRulesCollection.WarningCount > 0 Then result = AddWithNewLine(result, _
                Me.BrokenRulesCollection.ToString(Validation.RuleSeverity.Warning), False)
            Return result
        End Function

        Public Function HasWarnings() As Boolean _
            Implements IValidationMessageProvider.HasWarnings
            Return Me.BrokenRulesCollection.WarningCount > 0
        End Function


        Private Sub RecalculateAllTaxes(ByVal raisePropertyHasChanged As Boolean)

            _DeductionGPM = CRound(_SumBruto * _RateGPM / 100)
            _DeductionPSD = CRound(_SumBruto * _SODRABase * _RatePSDForPerson / 100 / 100)
            _DeductionSODRA = CRound(_SumBruto * _SODRABase * _RateSODRAForPerson / 100 / 100)
            _ContributionPSD = CRound(_SumBruto * _SODRABase * _RatePSDForCompany / 100 / 100)
            _ContributionSODRA = CRound(_SumBruto * _SODRABase * _RateSODRAForCompany / 100 / 100)
            _TotalPSD = CRound(_DeductionPSD + _ContributionPSD)
            _TotalSODRA = CRound(_DeductionSODRA + _ContributionSODRA)
            _SumNeto = CRound(_SumBruto - _DeductionGPM - _DeductionSODRA - _DeductionPSD)

            If raisePropertyHasChanged Then
                PropertyHasChanged("DeductionGPM")
                PropertyHasChanged("DeductionPSD")
                PropertyHasChanged("DeductionSODRA")
                PropertyHasChanged("ContributionPSD")
                PropertyHasChanged("ContributionSODRA")
                PropertyHasChanged("TotalPSD")
                PropertyHasChanged("TotalSODRA")
            End If

        End Sub


        ''' <summary>
        ''' Loads a journal entry that is made by a payment to a natural person (e.g. bank transfer, till order etc.).
        ''' </summary>
        ''' <param name="entry">A <see cref="ActiveReports.JournalEntryInfo">JournalEntryInfo</see> to load.</param>
        ''' <remarks></remarks>
        Public Sub LoadAssociatedJournalEntry(ByVal entry As ActiveReports.JournalEntryInfo)

            If entry Is Nothing OrElse Not entry.Id > 0 Then Exit Sub

            If Not IsNew Then Throw New Exception(My.Resources.Workers_PayOutNaturalPerson_CannotLoadEntry)

            If Not entry.PersonID > 0 Then Throw New Exception(My.Resources.Workers_PayOutNaturalPerson_PersonNull)

            If Array.IndexOf(AllowedDocumentTypes, entry.DocType) < 0 Then _
                Throw New Exception(String.Format(Workers_PayOutNaturalPerson_JournalEntryTypeInvalid, _
                    entry.DocTypeHumanReadable))

            _JournalEntryID = entry.Id
            _Date = entry.Date.Date
            _Content = entry.Content
            _DocNumber = entry.DocNumber
            _PersonInfo = entry.Person
            _PersonCodeSODRA = entry.PersonCodeSODRA.Trim
            _SumJournalEntry = entry.Ammount

            PropertyHasChanged("JournalEntryID")
            PropertyHasChanged("Date")
            PropertyHasChanged("Content")
            PropertyHasChanged("DocNumber")
            PropertyHasChanged("PersonInfo")
            PropertyHasChanged("PersonCodeSODRA")
            PropertyHasChanged("SumNeto")

            _SumBruto = CRound(_SumJournalEntry * 100 / CRound(100 - _RateGPM - _
                CRound(_RatePSDForPerson * _SODRABase / 100) - _
                CRound(_RateSODRAForPerson * _SODRABase / 100)))

            RecalculateAllTaxes(True)

        End Sub

        ''' <summary>
        ''' Generates a new <see cref="General.JournalEntry">JournalEntry</see> that is used to account for tax obligations.
        ''' </summary>
        ''' <remarks></remarks>
        Public Function GetNewJournalEntry() As General.JournalEntry

            Dim result As General.JournalEntry = General.JournalEntry.NewJournalEntry

            result.Content = My.Resources.Workers_PayOutNaturalPerson_NewJournalEntryContent
            result.Date = Today
            result.DocNumber = My.Resources.Workers_PayOutNaturalPerson_NewJournalEntryDocNumber
            result.Person = Nothing

            Dim costsEntry As General.BookEntry = General.BookEntry.NewBookEntry
            costsEntry.Amount = CRound(_SumBruto + _ContributionPSD + _ContributionSODRA)

            result.DebetList.Add(costsEntry)

            Dim cc As Settings.CompanyInfo = GetCurrentCompany()

            Dim netoEntry As General.BookEntry = General.BookEntry.NewBookEntry
            netoEntry.Account = cc.GetDefaultAccount(General.DefaultAccountType.Suppliers)
            netoEntry.Amount = CRound(_SumBruto - _DeductionPSD - _DeductionSODRA - _DeductionGPM)

            result.CreditList.Add(netoEntry)

            Dim gpmEntry As General.BookEntry = General.BookEntry.NewBookEntry
            gpmEntry.Account = cc.GetDefaultAccount(General.DefaultAccountType.OtherGpmPayable)
            gpmEntry.Amount = CRound(_DeductionGPM)

            result.CreditList.Add(gpmEntry)

            Dim sodraEntry As General.BookEntry = General.BookEntry.NewBookEntry
            sodraEntry.Account = cc.GetDefaultAccount(General.DefaultAccountType.OtherSodraPayable)
            sodraEntry.Amount = CRound(_TotalSODRA)

            result.CreditList.Add(sodraEntry)

            Dim psdEntry As General.BookEntry = General.BookEntry.NewBookEntry
            psdEntry.Account = cc.GetDefaultAccount(General.DefaultAccountType.OtherPsdPayable)
            psdEntry.Amount = CRound(_TotalPSD)

            result.CreditList.Add(psdEntry)

            Return result

        End Function


        Protected Overrides Function GetIdValue() As Object
            Return _ID
        End Function

        Public Overrides Function ToString() As String
            Return String.Format(My.Resources.Workers_PayOutNaturalPerson_ToString, _
                _Date.ToString("yyyy-MM-dd"), _PersonInfo, _Content)
        End Function

#End Region

#Region " Validation Rules "

        Protected Overrides Sub AddBusinessRules()

            ValidationRules.AddRule(AddressOf DoubleFieldValidation, New RuleArgs("SumBruto"))
            ValidationRules.AddRule(AddressOf DoubleFieldValidation, New RuleArgs("RateGPM"))
            ValidationRules.AddRule(AddressOf DoubleFieldValidation, New RuleArgs("RatePSDForPerson"))
            ValidationRules.AddRule(AddressOf DoubleFieldValidation, New RuleArgs("RatePSDForCompany"))
            ValidationRules.AddRule(AddressOf DoubleFieldValidation, New RuleArgs("RateSODRAForPerson"))
            ValidationRules.AddRule(AddressOf DoubleFieldValidation, New RuleArgs("RateSODRAForCompany"))

            ValidationRules.AddRule(AddressOf IntegerFieldValidation, New RuleArgs("SODRABase"))
            ValidationRules.AddRule(AddressOf CodeFieldValidation, New RuleArgs("CodeVMI"))
            ValidationRules.AddRule(AddressOf CodeFieldValidation, New RuleArgs("CodeSODRA"))
            ValidationRules.AddRule(AddressOf IntegerFieldValidation, New RuleArgs("JournalEntryID"))

            ValidationRules.AddRule(AddressOf PersonSODRACodeValidation, "PersonCodeSODRA")

            ValidationRules.AddDependantProperty("CodeSODRA", "PersonCodeSODRA", False)

        End Sub

        ''' <summary>
        ''' Rule ensuring persons SODRA code is entered if payout code for SODRA is set.
        ''' </summary>
        ''' <param name="target">Object containing the data to validate</param>
        ''' <param name="e">Arguments parameter specifying the name of the string
        ''' property to validate</param>
        ''' <returns><see langword="false" /> if the rule is broken</returns>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:ValidateArgumentsOfPublicMethods")> _
        Private Shared Function PersonSODRACodeValidation(ByVal target As Object, _
            ByVal e As Validation.RuleArgs) As Boolean

            Dim valObj As PayOutNaturalPerson = DirectCast(target, PayOutNaturalPerson)

            If valObj._CodeSODRA > 0 AndAlso String.IsNullOrEmpty(valObj._PersonCodeSODRA.Trim) Then
                e.Description = My.Resources.Workers_PayOutNaturalPerson_CodeSODRANull
                e.Severity = Validation.RuleSeverity.Error
                Return False
            End If

            Return True

        End Function

#End Region

#Region " Authorization Rules "

        Protected Overrides Sub AddAuthorizationRules()
            AuthorizationRules.AllowWrite("Workers.PayOutNaturalPerson2")
        End Sub

        Public Shared Function CanAddObject() As Boolean
            Return ApplicationContext.User.IsInRole("Workers.PayOutNaturalPerson2")
        End Function

        Public Shared Function CanGetObject() As Boolean
            Return ApplicationContext.User.IsInRole("Workers.PayOutNaturalPerson1")
        End Function

        Public Shared Function CanEditObject() As Boolean
            Return ApplicationContext.User.IsInRole("Workers.PayOutNaturalPerson3")
        End Function

        Public Shared Function CanDeleteObject() As Boolean
            Return ApplicationContext.User.IsInRole("Workers.PayOutNaturalPerson3")
        End Function

#End Region

#Region " Factory Methods "

        ''' <summary>
        ''' Gets a new PayOutNaturalPerson instance.
        ''' </summary>
        ''' <remarks></remarks>
        Public Shared Function NewPayOutNaturalPerson() As PayOutNaturalPerson

            If Not CanAddObject() Then Throw New System.Security.SecurityException( _
                My.Resources.Common_SecurityInsertDenied)

            Dim result As New PayOutNaturalPerson
            result.ValidationRules.CheckRules()
            Return result

        End Function

        ''' <summary>
        ''' Gets an existing PayOutNaturalPerson instance from a database.
        ''' </summary>
        ''' <param name="nID">An ID of the PayOutNaturalPerson instance to get.</param>
        ''' <remarks></remarks>
        Public Shared Function GetPayOutNaturalPerson(ByVal nID As Integer) As PayOutNaturalPerson

            Return DataPortal.Fetch(Of PayOutNaturalPerson)(New Criteria(nID))

        End Function

        ''' <summary>
        ''' Deletes an existing PayOutNaturalPerson instance from a database.
        ''' </summary>
        ''' <param name="id">An ID of the PayOutNaturalPerson instance to delete.</param>
        ''' <remarks></remarks>
        Public Shared Sub DeletePayOutNaturalPerson(ByVal id As Integer)

            DataPortal.Delete(New Criteria(id))

        End Sub


        Private Sub New()
            ' require use of factory methods
        End Sub

#End Region

#Region " Data Access "

        <Serializable()> _
        Private Class Criteria
            Private ReadOnly _ID As Integer
            Public ReadOnly Property ID() As Integer
                Get
                    Return _ID
                End Get
            End Property
            Public Sub New(ByVal nID As Integer)
                _ID = nID
            End Sub
        End Class

        Private Overloads Sub DataPortal_Fetch(ByVal criteria As Criteria)

            If Not CanGetObject() Then Throw New System.Security.SecurityException( _
                My.Resources.Common_SecuritySelectDenied)

            Dim myComm As New SQLCommand("FetchPayOutNaturalPerson")
            myComm.AddParam("?ND", criteria.ID)

            Using myData As DataTable = myComm.Fetch

                If myData.Rows.Count < 1 Then Throw New Exception(String.Format( _
                    My.Resources.Common_ObjectNotFound, My.Resources.Workers_PayOutNaturalPerson_TypeName, _
                    criteria.ID.ToString()))

                Dim dr As DataRow = myData.Rows(0)

                _ID = CIntSafe(dr.Item(0), 0)
                _JournalEntryID = CIntSafe(dr.Item(1), 0)
                _Date = CDateSafe(dr.Item(2), Today)
                _DocNumber = CStrSafe(dr.Item(3)).Trim
                _Content = CStrSafe(dr.Item(4)).Trim
                _PersonInfo = CStrSafe(dr.Item(5)).Trim & " (" & CStrSafe(dr.Item(6)).Trim & ")"
                _PersonCodeSODRA = CStrSafe(dr.Item(7)).Trim
                _SumNeto = CDblSafe(dr.Item(8), 2, 0)
                _RateGPM = CDblSafe(dr.Item(9), 2, 0)
                _RatePSDForPerson = CDblSafe(dr.Item(10), 2, 0)
                _RatePSDForCompany = CDblSafe(dr.Item(11), 2, 0)
                _RateSODRAForPerson = CDblSafe(dr.Item(12), 2, 0)
                _RateSODRAForCompany = CDblSafe(dr.Item(13), 2, 0)
                _SumBruto = CDblSafe(dr.Item(14), 2, 0)
                _CodeVMI = CIntSafe(dr.Item(15), 0)
                _CodeSODRA = CIntSafe(dr.Item(16), 0)
                _SODRABase = 100 - CIntSafe(dr.Item(17), 0)
                _InsertDate = CTimeStampSafe(dr.Item(18))
                _UpdateDate = CTimeStampSafe(dr.Item(19))
                _SumJournalEntry = CDblSafe(dr.Item(20), 2, 0)

                ' To support old version
                If Not CRound(_SumBruto) > 0 Then
                    _SumBruto = CRound(100 * _SumJournalEntry / (100 - _RateGPM))
                End If

                RecalculateAllTaxes(False)

            End Using

            MarkOld()

        End Sub


        Protected Overrides Sub DataPortal_Insert()

            If Not CanAddObject() Then Throw New System.Security.SecurityException( _
                My.Resources.Common_SecurityInsertDenied)

            Me.ValidationRules.CheckRules()
            If Not Me.IsValid Then
                Throw New Exception(String.Format(My.Resources.Common_ContainsErrors, vbCrLf, _
                    GetAllBrokenRules()))
            End If

            Dim myComm As New SQLCommand("InsertPayOutNaturalPerson")
            myComm.AddParam("?BD", _JournalEntryID)
            AddWithParams(myComm)

            myComm.Execute()

            _ID = Convert.ToInt32(myComm.LastInsertID)

            MarkOld()

        End Sub

        Protected Overrides Sub DataPortal_Update()

            If Not CanEditObject() Then Throw New System.Security.SecurityException( _
                My.Resources.Common_SecurityUpdateDenied)

            Me.ValidationRules.CheckRules()
            If Not Me.IsValid Then
                Throw New Exception(String.Format(My.Resources.Common_ContainsErrors, vbCrLf, _
                    GetAllBrokenRules()))
            End If

            CheckIfUpdateDateChanged()

            Dim myComm As New SQLCommand("UpdatePayOutNaturalPerson")
            myComm.AddParam("?PD", _ID)
            AddWithParams(myComm)

            myComm.Execute()

            MarkOld()

        End Sub


        Protected Overrides Sub DataPortal_DeleteSelf()
            DataPortal_Delete(New Criteria(_ID))
        End Sub

        Protected Overrides Sub DataPortal_Delete(ByVal criteria As Object)

            If Not CanDeleteObject() Then Throw New System.Security.SecurityException( _
                My.Resources.Common_SecurityUpdateDenied)

            Dim myComm As New SQLCommand("DeletePayOutNaturalPerson")
            myComm.AddParam("?PD", DirectCast(criteria, Criteria).ID)

            myComm.Execute()

            MarkNew()

        End Sub


        Private Sub AddWithParams(ByRef myComm As SQLCommand)

            myComm.AddParam("?TG", CRound(_RateGPM))
            myComm.AddParam("?CV", _CodeVMI)
            myComm.AddParam("?SN", CRound(_SumNeto))
            myComm.AddParam("?SB", CRound(_SumBruto))
            myComm.AddParam("?TPW", CRound(_RatePSDForPerson))
            myComm.AddParam("?TPE", CRound(_RatePSDForCompany))
            myComm.AddParam("?TSW", CRound(_RateSODRAForPerson))
            myComm.AddParam("?TSE", CRound(_RateSODRAForCompany))
            myComm.AddParam("?CS", _CodeSODRA)
            myComm.AddParam("?PS", _PersonCodeSODRA.Trim)
            myComm.AddParam("?BS", 100 - _SODRABase)

            _UpdateDate = GetCurrentTimeStamp()
            If Me.IsNew Then _InsertDate = _UpdateDate
            myComm.AddParam("?UD", _UpdateDate.ToUniversalTime)

        End Sub


        Private Sub CheckIfUpdateDateChanged()

            Dim myComm As New SQLCommand("CheckIfPayOutNaturalPersonUpdateDateChanged")
            myComm.AddParam("?CD", _ID)

            Using myData As DataTable = myComm.Fetch

                If myData.Rows.Count < 1 OrElse CDateTimeSafe(myData.Rows(0).Item(0), _
                    Date.MinValue) = Date.MinValue Then

                    Throw New Exception(String.Format(My.Resources.Common_ObjectNotFound, _
                        My.Resources.Workers_PayOutNaturalPerson_TypeName, _ID.ToString))

                End If

                If CTimeStampSafe(myData.Rows(0).Item(0)) <> _UpdateDate Then

                    Throw New Exception(My.Resources.Common_UpdateDateHasChanged)

                End If

            End Using

        End Sub

#End Region

    End Class

End Namespace