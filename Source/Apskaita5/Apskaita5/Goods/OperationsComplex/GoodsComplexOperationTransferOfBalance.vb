Imports ApskaitaObjects.My.Resources
Imports Csla.Validation

Namespace Goods

    ''' <summary>
    ''' Represents a transfer of goods (initial) balance in warehouses
    ''' (used in conjunction with <see cref="General.TransferOfBalance">TransferOfBalance</see>
    ''' to provide bulk data import).
    ''' </summary>
    ''' <remarks>Values are stored using <see cref="ComplexOperationPersistenceObject">ComplexOperationPersistenceObject</see>.</remarks>
    <Serializable()> _
    Public NotInheritable Class GoodsComplexOperationTransferOfBalance
        Inherits BusinessBase(Of GoodsComplexOperationTransferOfBalance)
        Implements IIsDirtyEnough, IValidationMessageProvider

#Region " Business Methods "

        Private _ID As Integer = 0
        Private _JournalEntryID As Integer = 0
        Private _JournalEntryDate As Date = Today
        Private _JournalEntryContent As String = ""
        Private _JournalEntryCorrespondence As String = ""
        Private _DocumentNumber As String = ""
        Private _OperationalLimit As ComplexChronologicValidator = Nothing
        Private _Content As String = Goods_GoodsComplexOperationTransferOfBalance_DefaultContent
        Private _InsertDate As DateTime = Now
        Private _UpdateDate As DateTime = Now
        Private _IsSelfDirty As Boolean = False
        Private WithEvents _Items As GoodsTransferOfBalanceItemList

        <NotUndoable()> _
        <NonSerialized()> _
        Private _ItemsSortedList As Csla.SortedBindingList(Of GoodsTransferOfBalanceItem) = Nothing


        ''' <summary>
        ''' Gets an ID of the operation that is assigned by a database (AUTOINCREMENT).
        ''' </summary>
        ''' <remarks>Corresponds to <see cref="ComplexOperationPersistenceObject.ID">ComplexOperationPersistenceObject.ID</see>.</remarks>
        Public ReadOnly Property ID() As Integer
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _ID
            End Get
        End Property

        ''' <summary>
        ''' Gets the date and time when the operation was inserted into the database.
        ''' </summary>
        ''' <remarks>Corresponds to <see cref="ComplexOperationPersistenceObject.InsertDate">ComplexOperationPersistenceObject.InsertDate</see>.</remarks>
        Public ReadOnly Property InsertDate() As DateTime
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _InsertDate
            End Get
        End Property

        ''' <summary>
        ''' Gets the date and time when the operation was last updated.
        ''' </summary>
        ''' <remarks>Corresponds to <see cref="ComplexOperationPersistenceObject.UpdateDate">ComplexOperationPersistenceObject.UpdateDate</see>.</remarks>
        Public ReadOnly Property UpdateDate() As DateTime
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _UpdateDate
            End Get
        End Property

        ''' <summary>
        ''' Gets an <see cref="General.TransferOfBalance.ID">ID of the transfer of 
        ''' balance journal entry</see>.
        ''' </summary>
        ''' <remarks>Corresponds to <see cref="ComplexOperationPersistenceObject.JournalEntryID">ComplexOperationPersistenceObject.JournalEntryID</see>.</remarks>
        Public ReadOnly Property JournalEntryID() As Integer
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _JournalEntryID
            End Get
        End Property

        ''' <summary>
        ''' Gets a <see cref="General.JournalEntry.Content">content of the transfer of 
        ''' balance journal entry</see>.
        ''' </summary>
        ''' <remarks>Corresponds to <see cref="ComplexOperationPersistenceObject.JournalEntryID">ComplexOperationPersistenceObject.JournalEntryID</see>.</remarks>
        Public ReadOnly Property JournalEntryContent() As String
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _JournalEntryContent.Trim
            End Get
        End Property

        ''' <summary>
        ''' Gets a <see cref="ActiveReports.JournalEntryInfo.BookEntries">
        ''' description of the book entries of the transfer of balance journal entry</see>.
        ''' </summary>
        ''' <remarks>Corresponds to <see cref="ComplexOperationPersistenceObject.JournalEntryID">ComplexOperationPersistenceObject.JournalEntryID</see>.</remarks>
        Public ReadOnly Property JournalEntryCorrespondence() As String
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _JournalEntryCorrespondence.Trim
            End Get
        End Property

        ''' <summary>
        ''' Gets a <see cref="General.TransferOfBalance.Date">Date of the transfer of 
        ''' balance journal entry</see>.
        ''' </summary>
        ''' <remarks>Corresponds to <see cref="ComplexOperationPersistenceObject.JournalEntryID">ComplexOperationPersistenceObject.JournalEntryID</see>.</remarks>
        Public ReadOnly Property JournalEntryDate() As Date
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _JournalEntryDate
            End Get
        End Property

        ''' <summary>
        ''' Gets a <see cref="General.JournalEntry.DocNumber">document number 
        ''' of the transfer of balance journal entry</see>.
        ''' </summary>
        ''' <remarks>Corresponds to <see cref="ComplexOperationPersistenceObject.JournalEntryID">ComplexOperationPersistenceObject.JournalEntryID</see>.</remarks>
        Public ReadOnly Property DocumentNumber() As String
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _DocumentNumber.Trim
            End Get
        End Property

        ''' <summary>
        ''' Gets <see cref="IChronologicValidator">IChronologicValidator</see> object 
        ''' that contains business restraints on updating the operation data.
        ''' </summary>
        ''' <remarks>A <see cref="ComplexChronologicValidator">ComplexChronologicValidator</see> 
        ''' is used to validate a complex goods operation chronological business rules.</remarks>
        Public ReadOnly Property OperationalLimit() As ComplexChronologicValidator
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _OperationalLimit
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets a content (description) of the operation.
        ''' </summary>
        ''' <remarks>Corresponds to <see cref="ComplexOperationPersistenceObject.Content">ComplexOperationPersistenceObject.Content</see>.</remarks>
        <StringField(ValueRequiredLevel.Mandatory, 255)> _
        Public Property Content() As String
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _Content.Trim
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As String)
                CanWriteProperty(True)
                If value Is Nothing Then value = ""
                If _Content.Trim <> value.Trim Then
                    _Content = value.Trim
                    PropertyHasChanged()
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets a collection of goods balance transfer items within the operation.
        ''' </summary>
        ''' <remarks></remarks>
        Public ReadOnly Property Items() As GoodsTransferOfBalanceItemList
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _Items
            End Get
        End Property

        ''' <summary>
        ''' Gets a sortable collection of goods balance transfer items within the operation.
        ''' </summary>
        ''' <remarks>Used to implement autosort in a datagridview.</remarks>
        Public ReadOnly Property ItemsSortable() As Csla.SortedBindingList(Of GoodsTransferOfBalanceItem)
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                If _ItemsSortedList Is Nothing Then _ItemsSortedList = _
                    New Csla.SortedBindingList(Of GoodsTransferOfBalanceItem)(_Items)
                Return _ItemsSortedList
            End Get
        End Property


        Public ReadOnly Property IsDirtyEnough() As Boolean _
            Implements IIsDirtyEnough.IsDirtyEnough
            Get
                If Not IsNew Then Return IsDirty
                Return (Not String.IsNullOrEmpty(_Content.Trim) _
                    OrElse _Items.Count > 0)
            End Get
        End Property

        Public Overrides ReadOnly Property IsDirty() As Boolean
            Get
                Return MyBase.IsDirty OrElse _Items.IsDirty
            End Get
        End Property

        ''' <summary>
        ''' Whether the <see cref="General.TransferOfBalance">TransferOfBalance</see>
        ''' operation has changed.
        ''' </summary>
        ''' <remarks>Indicates that all of the child items should be updated
        ''' with a new parent data (i.e. treated as dirty).</remarks>
        Public ReadOnly Property IsSelfDirty() As Boolean
            Get
                Return _IsSelfDirty
            End Get
        End Property

        Public Overrides ReadOnly Property IsValid() As Boolean _
            Implements IValidationMessageProvider.IsValid
            Get
                Return MyBase.IsValid AndAlso _Items.IsValid
            End Get
        End Property



        Public Function GetAllBrokenRules() As String _
            Implements IValidationMessageProvider.GetAllBrokenRules
            Dim result As String = ""
            If Not MyBase.IsValid Then
                result = AddWithNewLine(result, _
                    Me.BrokenRulesCollection.ToString(Validation.RuleSeverity.Error), False)
            End If
            If Not _Items.IsValid Then
                result = AddWithNewLine(result, _Items.GetAllBrokenRules(), False)
            End If
            Return result
        End Function

        Public Function GetAllWarnings() As String _
            Implements IValidationMessageProvider.GetAllWarnings
            Dim result As String = ""
            If MyBase.BrokenRulesCollection.WarningCount > 0 Then
                result = AddWithNewLine(result, _
                    Me.BrokenRulesCollection.ToString(Validation.RuleSeverity.Warning), False)
            End If
            If _Items.HasWarnings() Then
                result = AddWithNewLine(result, _Items.GetAllWarnings(), False)
            End If
            Return result
        End Function

        Public Function HasWarnings() As Boolean _
            Implements IValidationMessageProvider.HasWarnings
            Return (MyBase.BrokenRulesCollection.WarningCount > 0 OrElse _Items.HasWarnings())
        End Function


        ''' <summary>
        ''' Adds items in the list to the current collection.
        ''' </summary>
        ''' <param name="list"></param>
        ''' <remarks>Invoke <see cref="GoodsTransferOfBalanceItemList.NewGoodsTransferOfBalanceItemList">GoodsTransferOfBalanceItemList.NewGoodsTransferOfBalanceItemList</see>
        ''' to get a list of new child operations by goods ID's.</remarks>
        Public Sub AddRange(ByVal list As GoodsTransferOfBalanceItemList)

            _Items.AddRange(list)

            For Each i As GoodsTransferOfBalanceItem In list
                _OperationalLimit.MergeNewValidationItem(i.OperationLimitations)
            Next

            PropertyHasChanged("OperationalLimit")

        End Sub


        Public Overrides Function Save() As GoodsComplexOperationTransferOfBalance
            Return MyBase.Save
        End Function


        Protected Overrides Function GetIdValue() As Object
            Return _ID
        End Function

        Public Overrides Function ToString() As String
            Return Goods_GoodsComplexOperationTransferOfBalance_ToString
        End Function

#End Region

#Region " Validation Rules "

        Protected Overrides Sub AddBusinessRules()

            ValidationRules.AddRule(AddressOf CommonValidation.StringFieldValidation, _
                New RuleArgs("Content"))
            ValidationRules.AddRule(AddressOf CommonValidation.ChronologyValidation, _
                New CommonValidation.ChronologyRuleArgs("JournalEntryDate", "OperationalLimit"))

            ValidationRules.AddDependantProperty("OperationalLimit", "JournalEntryDate", False)

        End Sub

#End Region

#Region " Authorization Rules "

        Protected Overrides Sub AddAuthorizationRules()
            AuthorizationRules.AllowWrite("General.TransferOfBalance2")
        End Sub

        Public Shared Function CanGetObject() As Boolean
            Return ApplicationContext.User.IsInRole("General.TransferOfBalance1")
        End Function

        Public Shared Function CanAddObject() As Boolean
            Return ApplicationContext.User.IsInRole("General.TransferOfBalance2")
        End Function

        Public Shared Function CanEditObject() As Boolean
            Return ApplicationContext.User.IsInRole("General.TransferOfBalance3")
        End Function

        Public Shared Function CanDeleteObject() As Boolean
            Return ApplicationContext.User.IsInRole("General.TransferOfBalance3")
        End Function

#End Region

#Region " Factory Methods "

        ''' <summary>
        ''' Gets an existing (unique and single per company) GoodsComplexOperationTransferOfBalance 
        ''' instance from a database.
        ''' </summary>
        ''' <remarks></remarks>
        Public Shared Function GetGoodsComplexOperationTransferOfBalance() As GoodsComplexOperationTransferOfBalance
            Return DataPortal.Fetch(Of GoodsComplexOperationTransferOfBalance)(New Criteria())
        End Function

        ''' <summary>
        ''' Deletes an existing (unique and single per company) GoodsComplexOperationTransferOfBalance 
        ''' instance from a database, i.e. deletes all goods balance transfer child items.
        ''' </summary>
        ''' <remarks></remarks>
        Public Shared Sub DeleteGoodsComplexOperationTransferOfBalance()
            DataPortal.Delete(New Criteria())
        End Sub


        Private Sub New()
            ' require use of factory methods
        End Sub

#End Region

#Region " Data Access "

        <Serializable()> _
        Private Class Criteria
            Public Sub New()
            End Sub
        End Class


        Private Overloads Sub DataPortal_Fetch(ByVal criteria As Criteria)

            If Not CanGetObject() Then Throw New System.Security.SecurityException( _
                My.Resources.Common_SecuritySelectDenied)

            Fetch()

        End Sub

        Private Sub Fetch()

            Dim myComm As New SQLCommand("FetchGoodsComplexOperationTransferOfBalance")

            Using myData As DataTable = myComm.Fetch

                If myData.Rows.Count < 1 Then
                    Throw New Exception(Goods_GoodsComplexOperationTransferOfBalance_TransferOfBalanceDoesNotExist)
                End If

                Dim dr As DataRow = myData.Rows(0)

                _JournalEntryID = CIntSafe(dr.Item(0), 0)
                _JournalEntryDate = CDateSafe(dr.Item(1), Today)
                _DocumentNumber = CStrSafe(dr.Item(2))
                _JournalEntryContent = CStrSafe(dr.Item(3))
                _JournalEntryCorrespondence = CStrSafe(dr.Item(4))
                _ID = CIntSafe(dr.Item(5), 0)

                If Not _ID > 0 AndAlso Not _JournalEntryID > 0 Then
                    Throw New Exception(Goods_GoodsComplexOperationTransferOfBalance_TransferOfBalanceDoesNotExist)
                End If

                If Not _JournalEntryID > 0 Then
                    Throw New Exception(Goods_GoodsComplexOperationTransferOfBalance_TransferOfGoodsBalanceWithoutTransferOfBalance)
                End If

            End Using

            If _ID > 0 Then

                Dim obj As ComplexOperationPersistenceObject = ComplexOperationPersistenceObject. _
                    GetComplexOperationPersistenceObject(_ID, GoodsComplexOperationType.TransferOfBalance, True)

                Fetch(obj)

            Else

                _Items = GoodsTransferOfBalanceItemList.NewGoodsTransferOfBalanceItemList
                _OperationalLimit = ComplexChronologicValidator.NewComplexChronologicValidator( _
                    ConvertLocalizedName(GoodsComplexOperationType.TransferOfBalance), Nothing, Nothing, Nothing)

                MarkOld()

            End If

            ValidationRules.CheckRules()

        End Sub

        Private Sub Fetch(ByVal obj As ComplexOperationPersistenceObject)

            _Content = obj.Content
            _InsertDate = obj.InsertDate
            _UpdateDate = obj.UpdateDate

            Using myData As DataTable = OperationalLimitList.GetDataSourceForComplexOperation(_ID, _JournalEntryDate)
                Dim objList As List(Of OperationPersistenceObject) = _
                    OperationPersistenceObject.GetOperationPersistenceObjectList(_ID)
                _Items = GoodsTransferOfBalanceItemList.GetGoodsTransferOfBalanceItemList(objList, myData)
            End Using

            _OperationalLimit = ComplexChronologicValidator.GetComplexChronologicValidator( _
                _ID, _JournalEntryDate, Utilities.ConvertLocalizedName(GoodsComplexOperationType.TransferOfBalance), _
                Nothing, Nothing, _Items.GetLimitations())

            MarkOld()

            If obj.OperationDate.Date <> _JournalEntryDate.Date OrElse _
                obj.JournalEntryID <> _JournalEntryID Then
                _IsSelfDirty = True
                MarkDirty()
            End If

        End Sub


        Protected Overrides Sub DataPortal_Update()

            If Not CanEditObject() Then Throw New System.Security.SecurityException( _
                My.Resources.Common_SecurityUpdateDenied)

            CheckIfCanUpdate()

            Dim obj As ComplexOperationPersistenceObject = GetPersistenceObj()

            Using transaction As New SqlTransaction

                Try

                    obj = obj.SaveChild(_OperationalLimit.FinancialDataCanChange, False, False)

                    If Not _ID > 0 Then
                        _ID = obj.ID
                        _InsertDate = obj.InsertDate
                    End If
                    _UpdateDate = obj.UpdateDate

                    _Items.Update(Me)

                    transaction.Commit()

                Catch ex As Exception
                    transaction.SetNonSqlException(ex)
                    Throw
                End Try

            End Using

            MarkOld()

        End Sub

        Private Function GetPersistenceObj() As ComplexOperationPersistenceObject

            Dim obj As ComplexOperationPersistenceObject
            If Not _ID > 0 Then
                obj = ComplexOperationPersistenceObject.NewComplexOperationPersistenceObject( _
                    GoodsComplexOperationType.TransferOfBalance, 0)
            Else
                obj = ComplexOperationPersistenceObject.GetComplexOperationPersistenceObject( _
                    _ID, GoodsComplexOperationType.TransferOfBalance)
                If obj.UpdateDate <> _UpdateDate Then Throw New Exception( _
                    My.Resources.Common_UpdateDateHasChanged)
            End If

            obj.AccountOperation = 0
            obj.Warehouse = Nothing
            obj.SecondaryWarehouse = Nothing
            obj.Content = _Content
            obj.DocNo = ""
            obj.JournalEntryID = _JournalEntryID
            obj.OperationDate = _JournalEntryDate

            Return obj

        End Function


        Protected Overrides Sub DataPortal_DeleteSelf()
            DataPortal_Delete(New Criteria())
        End Sub

        Protected Overrides Sub DataPortal_Delete(ByVal criteria As Object)

            If Not CanDeleteObject() Then Throw New System.Security.SecurityException( _
                My.Resources.Common_SecurityUpdateDenied)

            Dim operationToDelete As GoodsComplexOperationTransferOfBalance = _
                New GoodsComplexOperationTransferOfBalance
            operationToDelete.Fetch()

            If Not operationToDelete._OperationalLimit.ChildrenFinancialDataCanChange Then
                Throw New Exception(String.Format(Goods_GoodsComplexOperationTransferOfBalance_DeleteInvalid, _
                    vbCrLf, operationToDelete._OperationalLimit.ChildrenFinancialDataCanChangeExplanation))
            End If

            Using transaction As New SqlTransaction

                Try

                    ComplexOperationPersistenceObject.Delete(operationToDelete.ID, _
                        True, True, False)

                    transaction.Commit()

                Catch ex As Exception
                    transaction.SetNonSqlException(ex)
                    Throw
                End Try

            End Using

        End Sub


        Private Sub CheckIfCanUpdate()

            If Not _Items.Count > 0 Then
                Throw New Exception(Goods_GoodsComplexOperationTransferOfBalance_ListEmpty)
            End If

            If IsNew Then
                _Items.CheckIfCanUpdate(Nothing)
            Else
                Using myData As DataTable = OperationalLimitList.GetDataSourceForComplexOperation( _
                    _ID, _JournalEntryDate)
                    _Items.CheckIfCanUpdate(myData)
                End Using
            End If

            Me.ValidationRules.CheckRules()
            If Not Me.IsValid Then
                Throw New Exception(String.Format(My.Resources.Common_ContainsErrors, vbCrLf, _
                    GetAllBrokenRules()))
            End If

        End Sub

#End Region

    End Class

End Namespace