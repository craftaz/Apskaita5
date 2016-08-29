Imports ApskaitaObjects.Workers
Imports ApskaitaObjects.ActiveReports
Imports ApskaitaObjects.HelperLists
Imports AccControlsWinForms
Imports AccDataBindingsWinForms.Printing
Imports AccDataBindingsWinForms.CachedInfoLists

Friend Class F_WorkerWageInfoReport
    Implements ISupportsPrinting

    Private ReadOnly _RequiredCachedLists As Type() = New Type() _
        {GetType(PersonInfoList), GetType(ShortLabourContractList)}

    Private _FormManager As CslaActionExtenderReportForm(Of WorkerWageInfoReport)
    Private _ListViewManager As DataListViewEditControlManager(Of WorkerWageInfo)


    Private Sub F_WorkerInfoCard_Load(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles MyBase.Load

        If Not SetDataSources() Then Exit Sub

    End Sub

    Private Function SetDataSources() As Boolean

        If Not PrepareCache(Me, _RequiredCachedLists) Then Return False

        Try

            _ListViewManager = New DataListViewEditControlManager(Of WorkerWageInfo) _
                (ItemsDataListView, Nothing, Nothing, Nothing, Nothing)

            'WorkerWageInfoReport.GetWorkerWageInfoReport(nDateFrom, nDateTo, nPersonID, _
            '    nSerial, nNumber, fetchConsolidatedInfo)
            _FormManager = New CslaActionExtenderReportForm(Of WorkerWageInfoReport) _
                (Me, WageSheetBindingSource, Nothing, _RequiredCachedLists, RefreshButton, _
                 ProgressFiller1, "GetWorkerWageInfoReport", AddressOf GetReportParams)

            _FormManager.ManageDataListViewStates(ItemsDataListView)

            LoadPersonInfoListToListCombo(WorkerAccGridComboBox, True, False, False, True)

        Catch ex As Exception
            ShowError(ex)
            DisableAllControls(Me)
            Return False
        End Try

        Dim dateFrom As Date = Today.AddMonths(-4)
        dateFrom = New Date(dateFrom.Year, dateFrom.Month, 1)
        Dim dateTo As Date = Today.AddMonths(-1)
        dateTo = New Date(dateTo.Year, dateTo.Month, Date.DaysInMonth(dateTo.Year, dateTo.Month))

        DateFromDateTimePicker.Value = dateFrom
        DateToDateTimePicker.Value = dateTo

        RefreshButton.Enabled = WorkerWageInfoReport.CanGetObject

        Return True

    End Function


    Private Function GetReportParams() As Object()

        Dim personID As Integer = 0
        Try
            If Not DirectCast(WorkerAccGridComboBox.SelectedValue, HelperLists.PersonInfo).IsEmpty Then
                personID = DirectCast(WorkerAccGridComboBox.SelectedValue, HelperLists.PersonInfo).ID
            End If
        Catch ex As Exception
        End Try

        Dim serial As String = CType(LabourContractComboBox.SelectedItem, ShortLabourContract).Serial.Trim
        Dim number As Integer = CType(LabourContractComboBox.SelectedItem, ShortLabourContract).Number
        Try
            serial = CType(LabourContractComboBox.SelectedItem, ShortLabourContract).Serial.Trim
            number = CType(LabourContractComboBox.SelectedItem, ShortLabourContract).Number
        Catch ex As Exception
        End Try

        'WorkerWageInfoReport.GetWorkerWageInfoReport(DateFromDateTimePicker.Value.Date, _
        '    DateToDateTimePicker.Value.Date, personID, serial, number, IsConsolidatedCheckBox.Checked)
        Return New Object() {DateFromDateTimePicker.Value.Date, DateToDateTimePicker.Value.Date, _
            personID, serial, number, IsConsolidatedCheckBox.Checked}

    End Function

    Private Sub RefreshLabourContractsButton_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles RefreshLabourContractsButton.Click

        Dim currentWorker As HelperLists.PersonInfo = Nothing
        Try
            currentWorker = DirectCast(WorkerAccGridComboBox.SelectedValue, HelperLists.PersonInfo)
        Catch ex As Exception
        End Try
        If currentWorker Is Nothing OrElse currentWorker.IsEmpty Then
            MsgBox("Klaida. Nepasirinktas darbuotojas.", MsgBoxStyle.Exclamation, "Klaida.")
            Exit Sub
        End If

        Dim contractList As Csla.FilteredBindingList(Of ShortLabourContract) _
            = ShortLabourContractList.GetCachedFilteredList(False, currentWorker.ID, Today)

        LabourContractComboBox.DataSource = Nothing
        LabourContractComboBox.DataSource = contractList
        If contractList.Count > 0 Then
            LabourContractComboBox.SelectedIndex = contractList.Count - 1
        Else
            LabourContractComboBox.SelectedIndex = -1
            MsgBox("Klaida. Šiam darbuotojui nėra registruotų darbo sutarčių.", _
                MsgBoxStyle.Exclamation, "Klaida.")
        End If

    End Sub


    Public Function GetMailDropDownItems() As System.Windows.Forms.ToolStripDropDown _
        Implements ISupportsPrinting.GetMailDropDownItems
        Return Nothing
    End Function

    Public Function GetPrintDropDownItems() As System.Windows.Forms.ToolStripDropDown _
        Implements ISupportsPrinting.GetPrintDropDownItems
        Return Nothing
    End Function

    Public Function GetPrintPreviewDropDownItems() As System.Windows.Forms.ToolStripDropDown _
        Implements ISupportsPrinting.GetPrintPreviewDropDownItems
        Return Nothing
    End Function

    Public Sub OnMailClick(ByVal sender As Object, ByVal e As System.EventArgs) _
        Implements ISupportsPrinting.OnMailClick
        If _FormManager.DataSource Is Nothing Then Exit Sub

        Using frm As New F_SendObjToEmail(_FormManager.DataSource, 0)
            frm.ShowDialog()
        End Using

    End Sub

    Public Sub OnPrintClick(ByVal sender As Object, ByVal e As System.EventArgs) _
        Implements ISupportsPrinting.OnPrintClick
        If _FormManager.DataSource Is Nothing Then Exit Sub
        Try
            PrintObject(_FormManager.DataSource, False, 0, "DarboUzmokescioPazyma", Me, _
                _ListViewManager.GetCurrentFilterDescription(), _
                _ListViewManager.GetDisplayOrderIndexes())
        Catch ex As Exception
            ShowError(ex)
        End Try
    End Sub

    Public Sub OnPrintPreviewClick(ByVal sender As Object, ByVal e As System.EventArgs) _
        Implements ISupportsPrinting.OnPrintPreviewClick
        If _FormManager.DataSource Is Nothing Then Exit Sub
        Try
            PrintObject(_FormManager.DataSource, True, 0, "DarboUzmokescioPazyma", Me, _
                _ListViewManager.GetCurrentFilterDescription(), _
                _ListViewManager.GetDisplayOrderIndexes())
        Catch ex As Exception
            ShowError(ex)
        End Try
    End Sub

    Public Function SupportsEmailing() As Boolean _
        Implements ISupportsPrinting.SupportsEmailing
        Return True
    End Function

End Class