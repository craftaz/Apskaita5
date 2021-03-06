Imports ApskaitaObjects.Documents
Imports AccControlsWinForms
Imports AccDataBindingsWinForms.Printing
Imports AccDataBindingsWinForms.CachedInfoLists

Friend Class F_CashAccountList
    Implements ISupportsPrinting, ISingleInstanceForm

    Private ReadOnly _RequiredCachedLists As Type() = New Type() _
        {GetType(HelperLists.PersonInfoList), GetType(HelperLists.AccountInfoList)}

    Private WithEvents _FormManager As CslaActionExtenderEditForm(Of CashAccountList)
    Private _ListViewManager As DataListViewEditControlManager(Of CashAccount)
    Private _QueryManager As CslaActionExtenderQueryObject


    Private Sub F_CashAccountList_Load(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            _QueryManager = New CslaActionExtenderQueryObject(Me, ProgressFiller2)

            ' CashAccountList.GetCashAccountList()
            _QueryManager.InvokeQuery(Of CashAccountList)(Nothing, "GetCashAccountList", _
                True, AddressOf OnDataSourceLoaded)

        Catch ex As Exception
            ShowError(ex)
            DisableAllControls(Me)
            Exit Sub
        End Try

    End Sub

    Private Function SetDataSources(ByVal currentSource As CashAccountList) As Boolean

        If Not PrepareCache(Me, _RequiredCachedLists) Then Exit Function

        Try

            _ListViewManager = New DataListViewEditControlManager(Of CashAccount) _
                (CashAccountListDataListView, Nothing, AddressOf OnItemsDelete, _
                 AddressOf OnItemAdd, Nothing, currentSource)

        Catch ex As Exception
            ShowError(ex)
            DisableAllControls(Me)
            Return False
        End Try

        Return True

    End Function

    Private Sub OnDataSourceLoaded(ByVal source As Object, ByVal exceptionHandled As Boolean)

        If exceptionHandled Then

            DisableAllControls(Me)
            Exit Sub

        ElseIf source Is Nothing Then

            ShowError(New Exception("Klaida. Nepavyko gauti lėšų apskaitos sąskaitų duomenų."))
            DisableAllControls(Me)
            Exit Sub

        End If

        Dim currentSource As CashAccountList = DirectCast(source, CashAccountList)

        If Not SetDataSources(currentSource) Then Exit Sub

        Try

            _FormManager = New CslaActionExtenderEditForm(Of CashAccountList) _
                (Me, CashAccountListBindingSource, currentSource, _
                 _RequiredCachedLists, IOkButton, IApplyButton, ICancelButton, Nothing, ProgressFiller1)

            _FormManager.ManageDataListViewStates(CashAccountListDataListView)

        Catch ex As Exception
            ShowError(New Exception("Klaida. Nepavyko gauti lėšų apskaitos sąskaitų duomenų.", ex))
            DisableAllControls(Me)
            Exit Sub
        End Try

    End Sub


    Private Sub OnItemsDelete(ByVal items As CashAccount())
        If items Is Nothing OrElse items.Length < 1 OrElse _FormManager.DataSource Is Nothing Then Exit Sub
        For Each item As CashAccount In items
            If item.IsInUse Then
                MsgBox(String.Format("Klaida. Lėšų sąskaitoje {0} yra operacijų, jos pašalinti neleidžiama.", _
                    item.ToString), MsgBoxStyle.Exclamation, "Klaida")
                Exit Sub
            End If
        Next
        For Each item As CashAccount In items
            _FormManager.DataSource.Remove(item)
        Next
    End Sub

    Private Sub OnItemAdd()
        _FormManager.DataSource.AddNew()
    End Sub

    Private Sub CashAccountListDataListView_CellEditStarting(ByVal sender As Object, _
        ByVal e As BrightIdeasSoftware.CellEditEventArgs) Handles CashAccountListDataListView.CellEditStarting

        If e.RowObject Is Nothing Then
            e.Cancel = True
            Exit Sub
        End If

        Dim selectedItem As CashAccount = DirectCast(e.RowObject, CashAccount)

        ' naudojamos saskaitos tipo, valiutos ir apskaitos saskaitos keisti negalima
        If Not selectedItem.IsNew AndAlso selectedItem.IsInUse AndAlso (e.Column.AspectName = "Account" _
            OrElse e.Column.AspectName = "TypeHumanReadable" OrElse e.Column.AspectName = "CurrencyCode") Then
            e.Cancel = True
            Exit Sub
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
            PrintObject(_FormManager.DataSource, False, 0, "LesuSaskaituSarasas", Me, _
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
            PrintObject(_FormManager.DataSource, True, 0, "LesuSaskaituSarasas", Me, _
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