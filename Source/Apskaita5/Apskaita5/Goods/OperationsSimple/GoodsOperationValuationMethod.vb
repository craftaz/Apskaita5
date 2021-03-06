Imports Csla.Validation
Imports ApskaitaObjects.My.Resources

Namespace Goods

    ''' <summary>
    ''' Represents a <see cref="GoodsItem.DefaultValuationMethod">goods valuation method</see> 
    ''' prospective change.
    ''' </summary>
    ''' <remarks>Changes a valuation method used by subsequent goods operations.
    ''' Values are stored in the database table goodsvaluationmethods.</remarks>
    <Serializable()> _
    Public NotInheritable Class GoodsOperationValuationMethod
        Inherits BusinessBase(Of GoodsOperationValuationMethod)
        Implements IIsDirtyEnough, IValidationMessageProvider

#Region " Business Methods "

        Private _ID As Integer = 0
        Private _GoodsInfo As GoodsSummary = Nothing
        Private _OperationLimitations As OperationalLimitList = Nothing
        Private _Date As Date = Today
        Private _Description As String = ""
        Private _PreviousMethod As GoodsValuationMethod = GoodsValuationMethod.FIFO
        Private _NewMethod As GoodsValuationMethod = GoodsValuationMethod.FIFO
        Private _InsertDate As DateTime = Now
        Private _UpdateDate As DateTime = Now


        ''' <summary>
        ''' Gets an ID of the operation that is assigned by a database (AUTOINCREMENT).
        ''' </summary>
        ''' <remarks>Value is stored in the database field goodsvaluationmethods.ID.</remarks>
        Public ReadOnly Property ID() As Integer
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _ID
            End Get
        End Property

        ''' <summary>
        ''' Gets the date and time when the operation data was inserted into the database.
        ''' </summary>
        ''' <remarks>Value is stored in the database field goodsvaluationmethods.InsertDate.</remarks>
        Public ReadOnly Property InsertDate() As DateTime
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _InsertDate
            End Get
        End Property

        ''' <summary>
        ''' Gets the date and time when the operation data was last updated.
        ''' </summary>
        ''' <remarks>Value is stored in the database field goodsvaluationmethods.UpdateDate.</remarks>
        Public ReadOnly Property UpdateDate() As DateTime
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _UpdateDate
            End Get
        End Property

        ''' <summary>
        ''' Gets a general data of the goods which valuation method is changed.
        ''' </summary>
        ''' <remarks>Value is stored in the database field goodsvaluationmethods.GoodsID.</remarks>
        Public ReadOnly Property GoodsInfo() As GoodsSummary
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _GoodsInfo
            End Get
        End Property

        ''' <summary>
        ''' Gets <see cref="IChronologicValidator">IChronologicValidator</see> object 
        ''' that contains business restraints on updating the operation data.
        ''' </summary>
        ''' <remarks>A <see cref="OperationalLimitList">OperationalLimitList</see> 
        ''' is used to validate a goods operation chronological business rules.</remarks>
        Public ReadOnly Property OperationLimitations() As OperationalLimitList
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _OperationLimitations
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets a date of the operation.
        ''' </summary>
        ''' <remarks>Value is stored in the database field goodsvaluationmethods.ChangeDate.</remarks>
        Public Property [Date]() As Date
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _Date
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As Date)
                CanWriteProperty(True)
                If _Date.Date <> value.Date Then
                    _Date = value.Date
                    PropertyHasChanged()
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets a description of the operation.
        ''' </summary>
        ''' <remarks>Value is stored in the database field goodsvaluationmethods.Content.</remarks>
        <StringField(ValueRequiredLevel.Mandatory, 255)> _
        Public Property Description() As String
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _Description.Trim
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As String)
                CanWriteProperty(True)
                If value Is Nothing Then value = ""
                If _Description.Trim <> value.Trim Then
                    _Description = value.Trim
                    PropertyHasChanged()
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets the goods valuation method, that is beeing changed.
        ''' </summary>
        ''' <remarks>Value is fetched by a subquery.</remarks>
        Public ReadOnly Property PreviousMethod() As GoodsValuationMethod
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _PreviousMethod
            End Get
        End Property

        ''' <summary>
        ''' Gets the goods valuation method, that is beeing changed, as a localized
        ''' human readable string.
        ''' </summary>
        ''' <remarks>Value is fetched by a subquery.</remarks>
        <LocalizedEnumField(GetType(GoodsValuationMethod), False, "")> _
        Public ReadOnly Property PreviousMethodHumanReadable() As String
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return ConvertLocalizedName(_PreviousMethod)
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets a new goods valuation method.
        ''' </summary>
        ''' <remarks>Value is stored in the database field goodsvaluationmethods.MethodCode.</remarks>
        Public Property NewMethod() As GoodsValuationMethod
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _NewMethod
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As GoodsValuationMethod)
                CanWriteProperty(True)
                If NewMethodIsReadOnly Then Exit Property
                If _NewMethod <> value Then
                    _NewMethod = value
                    PropertyHasChanged()
                    PropertyHasChanged("NewMethodHumanReadable")
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets a new goods valuation method as a localized human readable string.
        ''' </summary>
        ''' <remarks>Value is stored in the database field goodsvaluationmethods.MethodCode.</remarks>
        <LocalizedEnumField(GetType(GoodsValuationMethod), False, "")> _
        Public Property NewMethodHumanReadable() As String
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return ConvertLocalizedName(_NewMethod)
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As String)
                CanWriteProperty(True)
                If NewMethodIsReadOnly Then Exit Property
                If String.IsNullOrEmpty(value) Then value = ""
                If Utilities.ConvertLocalizedName(Of GoodsValuationMethod)(value.Trim) <> _NewMethod Then
                    _NewMethod = Utilities.ConvertLocalizedName(Of GoodsValuationMethod)(value.Trim)
                    PropertyHasChanged()
                    PropertyHasChanged("NewMethod")
                End If
            End Set
        End Property


        ''' <summary>
        ''' Whether the <see cref="NewMethod">NewMethod</see> property
        ''' (and <see cref="NewMethodHumanReadable">NewMethodHumanReadable</see>) is readonly.
        ''' </summary>
        ''' <remarks></remarks>
        Public ReadOnly Property NewMethodIsReadOnly() As Boolean
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return (Not _OperationLimitations.FinancialDataCanChange)
            End Get
        End Property

        Public ReadOnly Property IsDirtyEnough() As Boolean _
            Implements IIsDirtyEnough.IsDirtyEnough
            Get
                If Not IsNew Then Return IsDirty
                Return (Not StringIsNullOrEmpty(_Description))
            End Get
        End Property

        Public Overrides ReadOnly Property IsValid() As Boolean _
            Implements IValidationMessageProvider.IsValid
            Get
                Return MyBase.IsValid
            End Get
        End Property


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
            If MyBase.BrokenRulesCollection.WarningCount > 0 Then
                result = AddWithNewLine(result, _
                    Me.BrokenRulesCollection.ToString(Validation.RuleSeverity.Warning), False)
            End If
            Return result
        End Function

        Public Function HasWarnings() As Boolean _
            Implements IValidationMessageProvider.HasWarnings
            Return MyBase.BrokenRulesCollection.WarningCount > 0
        End Function


        Public Overrides Function Save() As GoodsOperationValuationMethod
            Return MyBase.Save
        End Function


        Protected Overrides Function GetIdValue() As Object
            Return _ID
        End Function

        Public Overrides Function ToString() As String
            Return String.Format(My.Resources.Goods_GoodsOperationValuationMethod_ToString, _
                _Date.ToString("yyyy-MM-dd"), ConvertLocalizedName(_PreviousMethod), _
                ConvertLocalizedName(_NewMethod), _Description, _ID.ToString)
        End Function

#End Region

#Region " Validation Rules "

        Protected Overrides Sub AddBusinessRules()

            ValidationRules.AddRule(AddressOf CommonValidation.StringFieldValidation, _
                New RuleArgs("Description"))

            ValidationRules.AddRule(AddressOf CommonValidation.CommonValidation.ChronologyValidation, _
                New CommonValidation.CommonValidation.ChronologyRuleArgs("Date", "OperationLimitations"))

            ValidationRules.AddRule(AddressOf NewMethodValidation, New Validation.RuleArgs("NewMethod"))

        End Sub

        ''' <summary>
        ''' Rule ensuring that the value of property NewMethod is valid.
        ''' </summary>
        ''' <param name="target">Object containing the data to validate</param>
        ''' <param name="e">Arguments parameter specifying the name of the string
        ''' property to validate</param>
        ''' <returns><see langword="false" /> if the rule is broken</returns>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:ValidateArgumentsOfPublicMethods")> _
        Private Shared Function NewMethodValidation(ByVal target As Object, _
            ByVal e As Validation.RuleArgs) As Boolean

            Dim valObj As GoodsOperationValuationMethod = DirectCast(target, GoodsOperationValuationMethod)

            If valObj._NewMethod = valObj._PreviousMethod Then
                e.Description = Goods_GoodsOperationValuationMethod_NewMethodInvalid
                e.Severity = Validation.RuleSeverity.Error
                Return False
            End If

            Return True

        End Function

#End Region

#Region " Authorization Rules "

        Protected Overrides Sub AddAuthorizationRules()
            AuthorizationRules.AllowWrite("Goods.GoodsOperationValuationMethod2")
        End Sub

        Public Shared Function CanGetObject() As Boolean
            Return ApplicationContext.User.IsInRole("Goods.GoodsOperationValuationMethod1")
        End Function

        Public Shared Function CanAddObject() As Boolean
            Return ApplicationContext.User.IsInRole("Goods.GoodsOperationValuationMethod2")
        End Function

        Public Shared Function CanEditObject() As Boolean
            Return ApplicationContext.User.IsInRole("Goods.GoodsOperationValuationMethod3")
        End Function

        Public Shared Function CanDeleteObject() As Boolean
            Return ApplicationContext.User.IsInRole("Goods.GoodsOperationValuationMethod3")
        End Function

#End Region

#Region " Factory Methods "

        ''' <summary>
        ''' Gets a new GoodsOperationValuationMethod instance.
        ''' </summary>
        ''' <param name="goodsID">an <see cref="GoodsItem.ID">ID of the goods</see>
        ''' which valuation method should be changed</param>
        ''' <remarks></remarks>
        Public Shared Function NewGoodsOperationValuationMethod(ByVal goodsID As Integer) As GoodsOperationValuationMethod
            Return DataPortal.Create(Of GoodsOperationValuationMethod)(New Criteria(goodsID))
        End Function

        ''' <summary>
        ''' Gets an existing GoodsOperationValuationMethod instance from a database.
        ''' </summary>
        ''' <param name="id">an <see cref="ID">ID of the operation</see> to fetch</param>
        ''' <remarks></remarks>
        Public Shared Function GetGoodsOperationValuationMethod(ByVal id As Integer) As GoodsOperationValuationMethod
            Return DataPortal.Fetch(Of GoodsOperationValuationMethod)(New Criteria(id))
        End Function

        ''' <summary>
        ''' Deletes an existing GoodsOperationValuationMethod instance from a database.
        ''' </summary>
        ''' <param name="id">an <see cref="ID">ID of the operation</see> to delete</param>
        ''' <remarks></remarks>
        Public Shared Sub DeleteGoodsOperationValuationMethod(ByVal id As Integer)
            DataPortal.Delete(New Criteria(id))
        End Sub


        Private Sub New()
            ' require use of factory methods
        End Sub

#End Region

#Region " Data Access "

        <Serializable()> _
        Private Class Criteria
            Private _ID As Integer
            Public ReadOnly Property ID() As Integer
                Get
                    Return _ID
                End Get
            End Property
            Public Sub New(ByVal nID As Integer)
                _ID = nID
            End Sub
        End Class


        Private Overloads Sub DataPortal_Create(ByVal criteria As Criteria)

            If Not CanAddObject() Then Throw New System.Security.SecurityException( _
                My.Resources.Common_SecurityInsertDenied)

            If Not criteria.ID > 0 Then
                Throw New Exception(Goods_GoodsOperationValuationMethod_GoodsIdNull)
            End If

            _GoodsInfo = GoodsSummary.NewGoodsSummary(criteria.ID)

            _OperationLimitations = OperationalLimitList.NewOperationalLimitList( _
                _GoodsInfo, GoodsOperationType.ValuationMethodChange, 0, Nothing)

            _PreviousMethod = _GoodsInfo.ValuationMethod

            MarkNew()

            ValidationRules.CheckRules()

        End Sub

        Private Overloads Sub DataPortal_Fetch(ByVal criteria As Criteria)

            If Not CanGetObject() Then Throw New System.Security.SecurityException( _
                My.Resources.Common_SecuritySelectDenied)

            If Not criteria.ID > 0 Then
                Throw New Exception(Goods_GoodsOperationValuationMethod_OperationIdNull)
            End If

            Dim myComm As New SQLCommand("FetchGoodsOperationValuationMethod")
            myComm.AddParam("?MD", criteria.ID)

            Dim goodsID As Integer = 0

            Using myData As DataTable = myComm.Fetch

                If myData.Rows.Count < 1 Then Throw New Exception(String.Format( _
                    My.Resources.Common_ObjectNotFound, My.Resources.Goods_GoodsOperationValuationMethod_TypeName, _
                    criteria.ID.ToString()))

                Dim dr As DataRow = myData.Rows(0)

                _ID = CIntSafe(dr.Item(0), 0)
                goodsID = CIntSafe(dr.Item(1), 0)
                _Date = CDateSafe(dr.Item(2), Today)
                _Description = CStrSafe(dr.Item(3)).Trim
                _NewMethod = ConvertDatabaseID(Of GoodsValuationMethod)(CIntSafe(dr.Item(4), 0))
                _InsertDate = CTimeStampSafe(dr.Item(5))
                _UpdateDate = CTimeStampSafe(dr.Item(6))
                _PreviousMethod = ConvertDatabaseID(Of GoodsValuationMethod)(CIntSafe(dr.Item(7), 0))

            End Using

            _GoodsInfo = GoodsSummary.NewGoodsSummary(goodsID)

            _OperationLimitations = OperationalLimitList.GetOperationalLimitList( _
                _GoodsInfo, GoodsOperationType.ValuationMethodChange, _
                _ID, _Date, 0, Nothing, Nothing)

            MarkOld()

            ValidationRules.CheckRules()

        End Sub


        Protected Overrides Sub DataPortal_Insert()

            If Not CanAddObject() Then Throw New System.Security.SecurityException( _
                My.Resources.Common_SecurityInsertDenied)

            _OperationLimitations = OperationalLimitList.GetUpdatedOperationalLimitList( _
                _OperationLimitations, Nothing, Nothing)

            Me.ValidationRules.CheckRules()
            If Not Me.IsValid Then
                Throw New Exception(String.Format(My.Resources.Common_ContainsErrors, vbCrLf, _
                    Me.BrokenRulesCollection.ToString(RuleSeverity.Error)))
            End If

            Dim myComm As New SQLCommand("InsertGoodsOperationValuationMethod")
            myComm.AddParam("?GD", _GoodsInfo.ID)
            AddWithParams(myComm)

            myComm.Execute()

            _ID = Convert.ToInt32(myComm.LastInsertID)

            MarkOld()

        End Sub

        Protected Overrides Sub DataPortal_Update()

            If Not CanEditObject() Then Throw New System.Security.SecurityException( _
                My.Resources.Common_SecurityUpdateDenied)

            _OperationLimitations = OperationalLimitList.GetUpdatedOperationalLimitList( _
                _OperationLimitations, Nothing, Nothing)

            Me.ValidationRules.CheckRules()
            If Not Me.IsValid Then
                Throw New Exception(String.Format(My.Resources.Common_ContainsErrors, vbCrLf, _
                    Me.BrokenRulesCollection.ToString(RuleSeverity.Error)))
            End If

            CheckIfUpdateDateChanged()

            Dim myComm As SQLCommand
            If _OperationLimitations.FinancialDataCanChange Then
                myComm = New SQLCommand("UpdateGoodsOperationValuationMethodFull")
            Else
                myComm = New SQLCommand("UpdateGoodsOperationValuationMethodGeneral")
            End If
            AddWithParams(myComm)

            myComm.AddParam("?CD", _ID)

            myComm.Execute()

            MarkOld()

        End Sub


        Protected Overrides Sub DataPortal_DeleteSelf()
            DataPortal_Delete(New Criteria(_ID))
        End Sub

        Protected Overrides Sub DataPortal_Delete(ByVal criteria As Object)

            If Not CanDeleteObject() Then Throw New System.Security.SecurityException( _
                My.Resources.Common_SecurityUpdateDenied)

            Dim objectToDelete As New GoodsOperationValuationMethod
            objectToDelete.DataPortal_Fetch(DirectCast(criteria, Criteria))

            If Not objectToDelete.OperationLimitations.FinancialDataCanChange Then
                Throw New Exception(String.Format(Goods_GoodsOperationValuationMethod_InvalidDelete, _
                vbCrLf, objectToDelete.OperationLimitations.FinancialDataCanChangeExplanation))
            End If

            Dim myComm As New SQLCommand("DeleteGoodsOperationValuationMethod")
            myComm.AddParam("?CD", DirectCast(criteria, Criteria).ID)

            myComm.Execute()

            MarkNew()

        End Sub

        Private Sub AddWithParams(ByRef myComm As SQLCommand)

            myComm.AddParam("?AA", _Date.Date)
            myComm.AddParam("?AB", _Description.Trim)
            myComm.AddParam("?AC", ConvertDatabaseID(_NewMethod))

            _UpdateDate = GetCurrentTimeStamp()
            If Me.IsNew Then _InsertDate = _UpdateDate
            myComm.AddParam("?TS", _UpdateDate.ToUniversalTime)

        End Sub


        Private Sub CheckIfUpdateDateChanged()

            Dim myComm As New SQLCommand("CheckIfValuationMethodUpdateDateChanged")
            myComm.AddParam("?CD", _ID)

            Using myData As DataTable = myComm.Fetch

                If myData.Rows.Count < 1 OrElse CDateTimeSafe(myData.Rows(0).Item(0), _
                    Date.MinValue) = Date.MinValue Then

                    Throw New Exception(String.Format(My.Resources.Common_ObjectNotFound, _
                        My.Resources.Goods_GoodsOperationValuationMethod_TypeName, _ID.ToString))

                End If

                If CTimeStampSafe(myData.Rows(0).Item(0)) <> _UpdateDate Then

                    Throw New Exception(My.Resources.Common_UpdateDateHasChanged)

                End If

            End Using

        End Sub

#End Region

    End Class

End Namespace