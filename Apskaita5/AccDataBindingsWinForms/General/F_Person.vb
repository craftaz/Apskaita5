Imports AccControlsWinForms
Imports ApskaitaObjects.General
Imports ApskaitaObjects.HelperLists
Imports AccDataBindingsWinForms.CachedInfoLists
Imports InvoiceInfo
Imports ApskaitaObjects.Settings

Friend Class F_Person
    Implements IObjectEditForm

    Private ReadOnly _RequiredCachedLists As Type() = New Type() _
        {GetType(CompanyRegionalInfoList), GetType(AccountInfoList)}

    Private ReadOnly _CountryCodes As String() = New String() _
        {"AD", "AE", "AF", "AG", "AI", "AL", "AM", "AO", "AQ", "AR", "AS", "AT", "AU", "AW", "AX", "AZ", "BA", "BB", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BL", "BM", "BN", "BO", "BQ", "BR", "BS", "BT", "BV", "BW", "BY", "BZ", "CA", "CC", "CD", "CF", "CG", "CH", "CI", "CK", "CL", "CM", "CN", "CO", "CR", "CU", "CV", "CW", "CX", "CY", "CZ", "DE", "DJ", "DK", "DM", "DO", "DZ", "EC", "EE", "EG", "EH", "ER", "ES", "ET", "FI", "FJ", "FK", "FM", "FO", "FR", "GA", "GB", "GD", "GE", "GF", "GG", "GH", "GI", "GL", "GM", "GN", "GP", "GQ", "GR", "GS", "GT", "GU", "GW", "GY", "HK", "HM", "HN", "HR", "HT", "HU", "ID", "IE", "IL", "IM", "IN", "IO", "IQ", "IR", "IS", "IT", "JE", "JM", "JO", "JP", "KE", "KG", "KH", "KI", "KM", "KN", "KP", "KR", "KW", "KY", "KZ", "LA", "LB", "LC", "LI", "LK", "LR", "LS", "LT", "LU", "LV", "LY", "MA", "MC", "MD", "ME", "MF", "MG", "MH", "MK", "ML", "MM", "MN", "MO", "MP", "MQ", "MR", "MS", "MT", "MU", "MV", "MW", "MX", "MY", "MZ", "NA", "NC", "NE", "NF", "NG", "NI", "NL", "NO", "NP", "NR", "NU", "NZ", "OM", "PA", "PE", "PF", "PG", "PH", "PK", "PL", "PM", "PN", "PR", "PS", "PT", "PW", "PY", "QA", "RE", "RO", "RS", "RU", "RW", "SA", "SB", "SC", "SD", "SE", "SG", "SH", "SI", "SJ", "SK", "SL", "SM", "SN", "SO", "SR", "SS", "ST", "SV", "SX", "SY", "SZ", "TC", "TD", "TF", "TG", "TH", "TJ", "TK", "TL", "TM", "TN", "TO", "TR", "TT", "TV", "TW", "TZ", "UA", "UG", "UM", "US", "UY", "UZ", "VA", "VC", "VE", "VG", "VI", "VN", "VU", "WF", "WS", "YE", "YT", "ZA", "ZM", "ZW"}

    Private WithEvents _FormManager As CslaActionExtenderEditForm(Of Person)
    Private _QueryManager As CslaActionExtenderQueryObject
    Private _PersonToEdit As Person = Nothing
    Private _PersonInfoToPaste As ClientInfo = Nothing


    Public ReadOnly Property ObjectID() As Integer Implements IObjectEditForm.ObjectID
        Get
            If _FormManager Is Nothing OrElse _FormManager.DataSource Is Nothing Then
                If _PersonToEdit Is Nothing OrElse _PersonToEdit.IsNew Then
                    Return Integer.MinValue
                Else
                    Return _PersonToEdit.ID
                End If
            ElseIf _FormManager.DataSource.IsNew Then
                Return Integer.MinValue
            End If
            Return _FormManager.DataSource.ID
        End Get
    End Property

    Public ReadOnly Property ObjectType() As System.Type Implements IObjectEditForm.ObjectType
        Get
            Return GetType(Person)
        End Get
    End Property


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

    Public Sub New(ByVal personToEdit As Person)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        _PersonToEdit = personToEdit

    End Sub

    Public Sub New(ByVal personInfoToPaste As ClientInfo)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        _PersonInfoToPaste = personInfoToPaste

    End Sub


    Private Sub F_Person_Load(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles MyBase.Load

        If Not SetDataSources() Then Exit Sub

        Try

            If _PersonToEdit Is Nothing Then

                ' Person.NewPerson()
                _QueryManager.InvokeQuery(Of Person)(Nothing, "NewPerson", _
                    False, AddressOf OnNewPersonLoaded)

            Else

                _FormManager = New CslaActionExtenderEditForm(Of Person)(Me, _
                    PersonBindingSource, _PersonToEdit, _RequiredCachedLists, _
                    IOkButton, IApplyButton, ICancelButton, Nothing, ProgressFiller1)

            End If

        Catch ex As Exception
            ShowError(ex)
            DisableAllControls(Me)
        End Try

    End Sub

    Private Function SetDataSources() As Boolean

        If Not PrepareCache(Me, _RequiredCachedLists) Then Return False

        Try

            _QueryManager = New CslaActionExtenderQueryObject(Me, ProgressFiller2)

            SetupDefaultControls(Of Person)(Me, PersonBindingSource)

            LoadLanguageListToComboBox(LanguageNameComboBox, False)
            LoadCurrencyCodeListToComboBox(CurrencyCodeComboBox, False)
            StateCodeComboBox.DataSource = _CountryCodes

        Catch ex As Exception
            ShowError(ex)
            DisableAllControls(Me)
            Return False
        End Try

        IOkButton.Enabled = Person.CanEditObject
        IApplyButton.Enabled = Person.CanEditObject

        Return True

    End Function

    Private Sub OnNewPersonLoaded(ByVal result As Object, ByVal exceptionHandled As Boolean)

        If result Is Nothing Then
            DisableAllControls(Me)
            Exit Sub
        End If

        Try
            If Not _PersonInfoToPaste Is Nothing Then
                DirectCast(result, Person).AddWithPersonInfoData(_PersonInfoToPaste)
            End If
            _FormManager = New CslaActionExtenderEditForm(Of Person)(Me, _
                PersonBindingSource, DirectCast(result, Person), _RequiredCachedLists, _
                IOkButton, IApplyButton, ICancelButton, Nothing, ProgressFiller1)
        Catch ex As Exception
            ShowError(ex)
            DisableAllControls(Me)
        End Try

    End Sub


    Private Sub FetchFromWebButton_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles FetchFromWebButton.Click

        If Not My.Computer.Network.IsAvailable Then
            MsgBox("Klaida. Nėra ryšio su tinklu.", MsgBoxStyle.Exclamation, "Klaida.")
            Exit Sub
        End If

        If String.IsNullOrEmpty(_FormManager.DataSource.Code.Trim) Then
            MsgBox("Klaida. Neįvestas asmens/įmonės kodas.", MsgBoxStyle.Exclamation, "Klaida.")
            Exit Sub
        End If

        If Not _FormManager.DataSource.IsNew Then
            If Not YesOrNo("DĖMESIO!!!. Šio asmens duomenys jau yra įtraukti į įmonės duomenų " & _
                "bazę. Ar tikrai norite įkrauti naujus duomenis iš JAR ir VMI?") Then Exit Sub
        End If

        ' AccWebCrawler.PersonInfo.GetPersonInfoRekvizitai(_FormManager.DataSource.Code.Trim)
        _QueryManager.InvokeQuery(Of AccWebCrawler.PersonInfo)(Nothing, "GetPersonInfoRekvizitai", _
            True, AddressOf OnPersonWebDataFetched, _FormManager.DataSource.Code.Trim)

    End Sub

    Private Sub OnPersonWebDataFetched(ByVal result As Object, ByVal exceptionHandled As Boolean)
        If result Is Nothing Then Exit Sub
        Dim info As AccWebCrawler.PersonInfo = DirectCast(result, AccWebCrawler.PersonInfo)
        _FormManager.DataSource.Name = info.Name
        _FormManager.DataSource.Address = info.Address
        _FormManager.DataSource.CodeVAT = info.VatCode
    End Sub


    Private Sub CopyPersonButton_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles CopyPersonButton.Click

        If _FormManager.DataSource Is Nothing Then Exit Sub

        Dim info As InvoiceInfo.ClientInfo = Nothing
        Try
            Using busy As New StatusBusy
                info = _FormManager.DataSource.GetPersonInfo()
            End Using
        Catch ex As Exception
            ShowError(New Exception("Klaida. Nepavyko generuoti ClientInfo objekto: " _
                & ex.Message, ex))
            Exit Sub
        End Try

        If info Is Nothing Then
            MsgBox("Klaida. Dėl nežinomų priežasčių nepavyko generuoti ClientInfo objekto.", _
                MsgBoxStyle.Exclamation, "Klaida")
            Exit Sub
        End If

        Try
            Using busy As New StatusBusy
                System.Windows.Forms.Clipboard.SetText(InvoiceInfo.Factory. _
                    ToXmlString(Of InvoiceInfo.ClientInfo)(info), TextDataFormat.UnicodeText)
            End Using
        Catch ex As Exception
            ShowError(New Exception("Klaida. Nepavyko serializuoti ClientInfo objekto: " _
                & ex.Message, ex))
            Exit Sub
        End Try

        MsgBox("Asmens duomenys sėkmingai nukopijuoti į ClipBoard'ą.", MsgBoxStyle.Information, "Info")

    End Sub

    Private Sub PastePersonButton_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles PastePersonButton.Click

        Dim clipboardText As String = System.Windows.Forms.Clipboard.GetText( _
            TextDataFormat.UnicodeText)

        If StringIsNullOrEmpty(clipboardText) Then

            MsgBox("Klaida. ClipBoard'as tuščias, t.y. nebuvo nukopijuoti jokie asmens duomenys.", _
                MsgBoxStyle.Exclamation, "Klaida")
            Exit Sub

        End If

        Dim info As InvoiceInfo.ClientInfo = Nothing
        Try
            Using busy As New StatusBusy
                info = InvoiceInfo.Factory.FromXmlString(Of InvoiceInfo.ClientInfo)(clipboardText)
            End Using
        Catch ex As Exception
            ShowError(New Exception(String.Format("Klaida. Nepavyko atkurti asmens duomenų objekto. " _
                & "Teigtina, kad prieš tai į ClipBoard'ą buvo nukopijuota ne asmens duomenys, " _
                & "o šiaip kažkoks tekstas.{0}Klaidos tekstas: {1}", vbCrLf, ex.Message), ex))
            Exit Sub
        End Try

        If info Is Nothing Then
            MsgBox("Klaida. Dėl nežinomų priežasčių nepavyko atkurti asmens duomenų objekto.", _
                MsgBoxStyle.Exclamation, "Klaida")
            Exit Sub
        End If

        If Not PrepareCache(Me, GetType(HelperLists.PersonInfoList)) Then Exit Sub
        Dim persons As HelperLists.PersonInfoList = HelperLists.PersonInfoList.GetList
        If Not persons.GetPersonInfo(info.Code) Is Nothing Then
            MsgBox(String.Format("Klaida. Toks asmuo jau yra registruotas: {0}, įmonės kodas {1}.", _
                info.Name, info.Code), MsgBoxStyle.Exclamation, "Klaida")
            Exit Sub
        End If

        _PersonInfoToPaste = info

        _QueryManager.InvokeQuery(Of Person)(Nothing, "NewPerson", _
            False, AddressOf OnPastedPersonLoaded)

    End Sub

    Private Sub OpenPersonFileButton_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles OpenPersonFileButton.Click

        Dim clipboardText As String = ""

        Using ofd As New OpenFileDialog
            If ofd.ShowDialog <> Windows.Forms.DialogResult.OK Then Exit Sub
            If ofd.FileName Is Nothing OrElse String.IsNullOrEmpty(ofd.FileName.Trim) _
                OrElse Not IO.File.Exists(ofd.FileName) Then Exit Sub
            Try
                clipboardText = IO.File.ReadAllText(ofd.FileName, New System.Text.UnicodeEncoding)
            Catch ex As Exception
                ShowError(New Exception("Klaida. Nepavyko atidaryti failo: " & ex.Message, ex))
                Exit Sub
            End Try
        End Using

        If StringIsNullOrEmpty(clipboardText) Then
            MsgBox("Klaida. Failas tuščias.", MsgBoxStyle.Exclamation, "Klaida")
            Exit Sub
        End If

        Dim info As InvoiceInfo.ClientInfo = Nothing
        Try
            Using busy As New StatusBusy
                info = InvoiceInfo.Factory.FromXmlString(Of InvoiceInfo.ClientInfo)(clipboardText)
            End Using
        Catch ex As Exception
            ShowError(New Exception("Klaida. Nepavyko atkurti asmens duomenų objekto. " _
                & "Teigtina, kad faile saugomi ne asmens duomenys." & vbCrLf _
                & "Klaidos tekstas: " & ex.Message, ex))
            Exit Sub
        End Try

        If info Is Nothing Then
            MsgBox("Klaida. Dėl nežinomų priežasčių nepavyko atkurti asmens duomenų objekto.", _
                MsgBoxStyle.Exclamation, "Klaida")
            Exit Sub
        End If

        If Not PrepareCache(Me, GetType(HelperLists.PersonInfoList)) Then Exit Sub
        Dim persons As HelperLists.PersonInfoList = HelperLists.PersonInfoList.GetList
        If Not persons.GetPersonInfo(info.Code) Is Nothing Then
            MsgBox(String.Format("Klaida. Toks asmuo jau yra registruotas: {0}, įmonės kodas {1}.", _
                info.Name, info.Code), MsgBoxStyle.Exclamation, "Klaida")
            Exit Sub
        End If

        _PersonInfoToPaste = info

        _QueryManager.InvokeQuery(Of Person)(Nothing, "NewPerson", _
            False, AddressOf OnPastedPersonLoaded)

    End Sub

    Private Sub OnPastedPersonLoaded(ByVal result As Object, ByVal exceptionHandled As Boolean)

        If result Is Nothing OrElse _PersonInfoToPaste Is Nothing Then
            _PersonInfoToPaste = Nothing
            Exit Sub
        End If

        DirectCast(result, Person).AddWithPersonInfoData(_PersonInfoToPaste)

        _PersonInfoToPaste = Nothing

        _FormManager.AddNewDataSource(DirectCast(result, Person))

    End Sub


    Private Sub SavePersonFileButton_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles SavePersonFileButton.Click

        If _FormManager.DataSource Is Nothing Then Exit Sub

        Dim info As InvoiceInfo.ClientInfo = Nothing
        Try
            Using busy As New StatusBusy
                info = _FormManager.DataSource.GetPersonInfo()
            End Using
        Catch ex As Exception
            ShowError(New Exception("Klaida. Nepavyko generuoti ClientInfo objekto: " _
                & ex.Message, ex))
            Exit Sub
        End Try

        If info Is Nothing Then
            MsgBox("Klaida. Dėl nežinomų priežasčių nepavyko generuoti ClientInfo objekto.", _
                MsgBoxStyle.Exclamation, "Klaida")
            Exit Sub
        End If

        Dim fileName As String

        Using sfd As New SaveFileDialog
            sfd.ValidateNames = True
            If sfd.ShowDialog <> Windows.Forms.DialogResult.OK Then Exit Sub
            If StringIsNullOrEmpty(sfd.FileName) Then Exit Sub
            fileName = sfd.FileName
        End Using

        Try
            Using busy As New StatusBusy
                IO.File.WriteAllText(fileName, InvoiceInfo.Factory.ToXmlString _
                    (Of InvoiceInfo.ClientInfo)(info), New System.Text.UnicodeEncoding)
            End Using
        Catch ex As Exception
            ShowError(New Exception("Klaida. Nepavyko serializuoti ir išsaugoti ClientInfo objekto: " _
                & ex.Message, ex))
            Exit Sub
        End Try

        MsgBox("Asmens duomenys sėkmingai nukopijuoti į failą.", MsgBoxStyle.Information, "Info")

    End Sub


    Friend Sub RefreshPersonGroupList()
        If _FormManager.DataSource Is Nothing Then Exit Sub
        _FormManager.DataSource.AssignedToGroups.RefreshPersonGroupInfoList(PersonGroupInfoList.GetList, True)
    End Sub

End Class