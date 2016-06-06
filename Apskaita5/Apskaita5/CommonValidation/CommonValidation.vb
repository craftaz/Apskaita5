Imports ApskaitaObjects.Attributes
Imports Csla.Validation
Imports System.Reflection

Namespace CommonValidation
    Public Module CommonValidation

        ''' <summary>
        ''' Custom object required by the rule method.
        ''' </summary>
        Public Class ExtendedRuleArgs
            Inherits RuleArgs

            Private _ApplySeverity As RuleSeverity = RuleSeverity.Error
            ''' <summary>
            ''' Severity to apply to the rule.
            ''' </summary>
            Public ReadOnly Property ApplySeverity() As RuleSeverity
                Get
                    Return _ApplySeverity
                End Get
            End Property

            ''' <summary>
            ''' Create a new object.
            ''' </summary>
            ''' <param name="propertyName">Name of the property to validate.</param>
            ''' <param name="SeverityToApply">Severity of the error to apply.</param>
            Public Sub New(ByVal propertyName As String, ByVal SeverityToApply As RuleSeverity)
                MyBase.New(propertyName)
                _ApplySeverity = SeverityToApply
            End Sub

            ''' <summary>
            ''' Returns a string representation of the object.
            ''' </summary>
            Public Overrides Function ToString() As String
                Return MyBase.ToString & "?ApplySeverity=" & _ApplySeverity.ToString
            End Function

        End Class

#Region " StringFieldValidation "

        ''' <summary>
        ''' Rule ensuring a <see cref="String">String</see> field value matches requirements 
        ''' set by <see cref="StringFieldAttribute">StringFieldAttribute</see> of the property.
        ''' </summary>
        ''' <param name="target">Object containing the data to validate</param>
        ''' <param name="e">Arguments parameter specifying the name of the string
        ''' property to validate</param>
        ''' <returns><see langword="false" /> if the rule is broken</returns>
        ''' <remarks>
        ''' This implementation uses late binding, and will only work
        ''' against string property values.
        ''' </remarks>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:ValidateArgumentsOfPublicMethods")> _
        Public Function StringFieldValidation(ByVal target As Object, ByVal e As RuleArgs) As Boolean

            Dim attrib As StringFieldAttribute = GetAttribute(Of StringFieldAttribute)(target.GetType, e.PropertyName)

            If attrib Is Nothing Then Return True

            Dim propName As String = GetResourcesPropertyName(target.GetType, e.PropertyName)
            Dim value As String = CallByName(target, e.PropertyName, CallType.Get).ToString

            If attrib.ValueRequired <> ValueRequiredLevel.Optional AndAlso StringIsNullOrEmpty(value) Then

                e.Description = String.Format(My.Resources.Common_FieldValueNull, propName)
                If attrib.ValueRequired = ValueRequiredLevel.Mandatory Then
                    e.Severity = RuleSeverity.Error
                Else
                    e.Severity = RuleSeverity.Warning
                End If
                Return False

            End If

            If Not StringIsNullOrEmpty(value) AndAlso value.Trim.Length > attrib.MaxLength Then
                e.Description = String.Format(My.Resources.Common_StringExceedsMaxLength, _
                    propName, attrib.MaxLength.ToString)
                If attrib.ErrorIfExceedsMaxLength Then
                    e.Severity = RuleSeverity.Error
                Else
                    e.Severity = RuleSeverity.Warning
                End If
                Return False
            End If

            Return True

        End Function

#End Region

#Region " IntegerFieldValidation "

        ''' <summary>
        ''' Rule ensuring a <see cref="Integer">Integer</see> field value matches requirements 
        ''' set by <see cref="IntegerFieldAttribute">IntegerFieldAttribute</see> of the property.
        ''' </summary>
        ''' <param name="target">Object containing the data to validate</param>
        ''' <param name="e">Arguments parameter specifying the name of the string
        ''' property to validate</param>
        ''' <returns><see langword="false" /> if the rule is broken</returns>
        ''' <remarks>
        ''' This implementation uses late binding, and will only work
        ''' against string property values.
        ''' </remarks>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:ValidateArgumentsOfPublicMethods")> _
        Public Function IntegerFieldValidation(ByVal target As Object, ByVal e As RuleArgs) As Boolean

            Dim attrib As IntegerFieldAttribute = GetAttribute(Of IntegerFieldAttribute)(target.GetType, e.PropertyName)

            If attrib Is Nothing Then Return True

            Dim propName As String = GetResourcesPropertyName(target.GetType, e.PropertyName)

            Dim value As Integer = DirectCast(CallByName(target, e.PropertyName, CallType.Get), Integer)

            If attrib.ValueRequired <> ValueRequiredLevel.Optional AndAlso value = 0 Then

                e.Description = String.Format(My.Resources.Common_FieldValueNull, propName)
                If attrib.ValueRequired = ValueRequiredLevel.Mandatory Then
                    e.Severity = RuleSeverity.Error
                Else
                    e.Severity = RuleSeverity.Warning
                End If
                Return False

            End If

            If Not attrib.AllowNegative AndAlso value < 0 Then

                e.Description = String.Format(My.Resources.Common_IntegerCannotBeNegative, propName)
                e.Severity = RuleSeverity.Error
                Return False

            End If

            If attrib.WithinRange AndAlso (value < attrib.MinValue OrElse value > attrib.MaxValue) Then

                If value < attrib.MinValue Then
                    e.Description = String.Format(My.Resources.Common_IntegerExceedsMinLimit, _
                                                  propName, attrib.MinValue.ToString)

                ElseIf value > attrib.MaxValue Then
                    e.Description = String.Format(My.Resources.Common_IntegerExceedsMaxLimit, _
                                                  propName, attrib.MaxValue.ToString)

                End If

                If attrib.ErrorIfExceedsRange Then
                    e.Severity = RuleSeverity.Error
                Else
                    e.Severity = RuleSeverity.Warning
                End If

                Return False

            End If

            Return True

        End Function

#End Region

#Region " DoubleFieldValidation "

        ''' <summary>
        ''' Rule ensuring a <see cref="Double">Double</see> field value matches requirements 
        ''' set by <see cref="DoubleFieldAttribute">DoubleFieldAttribute</see> of the property.
        ''' </summary>
        ''' <param name="target">Object containing the data to validate</param>
        ''' <param name="e">Arguments parameter specifying the name of the string
        ''' property to validate</param>
        ''' <returns><see langword="false" /> if the rule is broken</returns>
        ''' <remarks>
        ''' This implementation uses late binding, and will only work
        ''' against string property values.
        ''' </remarks>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:ValidateArgumentsOfPublicMethods")> _
        Public Function DoubleFieldValidation(ByVal target As Object, ByVal e As RuleArgs) As Boolean

            Dim attrib As DoubleFieldAttribute = GetAttribute(Of DoubleFieldAttribute)(target.GetType, e.PropertyName)

            If attrib Is Nothing Then Return True

            Dim propName As String = GetResourcesPropertyName(target.GetType, e.PropertyName)

            Dim value As Double = DirectCast(CallByName(target, e.PropertyName, CallType.Get), Double)

            If attrib.ValueRequired <> ValueRequiredLevel.Optional AndAlso CRound(value, attrib.Round) = 0 Then

                e.Description = String.Format(My.Resources.Common_FieldValueNull, propName)
                If attrib.ValueRequired = ValueRequiredLevel.Mandatory Then
                    e.Severity = RuleSeverity.Error
                Else
                    e.Severity = RuleSeverity.Warning
                End If
                Return False

            End If

            If Not attrib.AllowNegative AndAlso CRound(value, attrib.Round) < 0 Then

                e.Description = String.Format(My.Resources.Common_IntegerCannotBeNegative, propName)
                e.Severity = RuleSeverity.Error
                Return False

            End If

            If attrib.WithinRange AndAlso (CRound(value, attrib.Round) < attrib.MinValue _
                                           OrElse CRound(value, attrib.Round) > attrib.MaxValue) Then

                If CRound(value, attrib.Round) < attrib.MinValue Then
                    e.Description = String.Format(My.Resources.Common_IntegerExceedsMinLimit, _
                                                  propName, attrib.MinValue.ToString)

                ElseIf CRound(value, attrib.Round) > attrib.MaxValue Then
                    e.Description = String.Format(My.Resources.Common_IntegerExceedsMaxLimit, _
                                                  propName, attrib.MaxValue.ToString)

                End If

                If attrib.ErrorIfExceedsRange Then
                    e.Severity = RuleSeverity.Error
                Else
                    e.Severity = RuleSeverity.Warning
                End If

                Return False

            End If

            Return True

        End Function

#End Region

#Region " AccountFieldValidation "

        ''' <summary>
        ''' Rule ensuring a <see cref="General.Account.ID">Account ID</see> field value matches requirements 
        ''' set by <see cref="AccountFieldAttribute">AccountFieldAttribute</see> of the property.
        ''' </summary>
        ''' <param name="target">Object containing the data to validate</param>
        ''' <param name="e">Arguments parameter specifying the name of the string
        ''' property to validate</param>
        ''' <returns><see langword="false" /> if the rule is broken</returns>
        ''' <remarks>
        ''' This implementation uses late binding, and will only work
        ''' against string property values.
        ''' </remarks>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:ValidateArgumentsOfPublicMethods")> _
        Public Function AccountFieldValidation(ByVal target As Object, ByVal e As RuleArgs) As Boolean

            Dim attrib As AccountFieldAttribute = GetAttribute(Of AccountFieldAttribute)(target.GetType, e.PropertyName)

            If attrib Is Nothing Then Return True

            Dim propName As String = GetResourcesPropertyName(target.GetType, e.PropertyName)

            Dim value As Long = DirectCast(CallByName(target, e.PropertyName, CallType.Get), Long)

            If value < 0 Then

                e.Description = String.Format(My.Resources.Common_AccountCannotBeNegative, propName)
                e.Severity = RuleSeverity.Error
                Return False

            End If

            If attrib.ValueRequired <> ValueRequiredLevel.Optional AndAlso Not value > 0 Then

                e.Description = String.Format(My.Resources.Common_FieldValueNull, propName)
                If attrib.ValueRequired = ValueRequiredLevel.Mandatory Then
                    e.Severity = RuleSeverity.Error
                Else
                    e.Severity = RuleSeverity.Warning
                End If
                Return False

            End If

            Dim accountPrefix As Integer = Convert.ToInt32(General.Account.GetAccountClass(value))

            If value > 0 AndAlso Array.IndexOf(attrib.AcceptedClasses, accountPrefix) < 0 Then

                e.Description = String.Format(My.Resources.Common_AccountClassInvalid, _
                                              accountPrefix.ToString, attrib.GetAcceptedClassesString, propName)

                If attrib.ErrorOnClassMismatch Then
                    e.Severity = RuleSeverity.Error
                Else
                    e.Severity = RuleSeverity.Warning
                End If

                Return False

            End If

            Return True

        End Function

#End Region

#Region " FutureDateValidation "

        ''' <summary>
        ''' Rule ensuring a date is not a future date (accepts SimpleRuleArgs).
        ''' </summary>
        ''' <param name="target">Object containing the data to validate</param>
        ''' <param name="e">Arguments parameter specifying the name of the string
        ''' property to validate</param>
        ''' <returns><see langword="false" /> if the rule is broken</returns>
        ''' <remarks>
        ''' This implementation uses late binding, and will only work
        ''' against string property values.
        ''' </remarks>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:ValidateArgumentsOfPublicMethods")> _
        Public Function FutureDateValidation(ByVal target As Object, ByVal e As RuleArgs) As Boolean

            Dim value As Date = Convert.ToDateTime(CallByName(target, e.PropertyName, CallType.Get))
            Dim propName As String = GetResourcesPropertyName(target.GetType, e.PropertyName)

            If value <> Date.MinValue AndAlso value <> Date.MaxValue AndAlso value.Date > Today.Date Then
                e.Description = String.Format(My.Resources.ValidationRules_FutureDate, propName)
                e.Severity = RuleSeverity.Warning
                Return False
            End If

            Return True

        End Function

#End Region

#Region " ValueObjectFieldValidation "

        ''' <summary>
        ''' Rule ensuring that a <see cref="HelperLists">value object</see> field value is not null or empty.
        ''' </summary>
        ''' <param name="target">Object containing the data to validate</param>
        ''' <param name="e">Arguments parameter specifying the name of the string
        ''' property to validate (ExtendedRuleArgs)</param>
        ''' <returns><see langword="false" /> if the rule is broken</returns>
        ''' <remarks>
        ''' This implementation uses late binding, and will only work
        ''' against string property values.
        ''' </remarks>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:ValidateArgumentsOfPublicMethods")> _
        Public Function ValueObjectFieldValidation(ByVal target As Object, ByVal e As RuleArgs) As Boolean

            Dim propName As String = GetResourcesPropertyName(target.GetType, e.PropertyName)

            Dim value As Object = CallByName(target, e.PropertyName, CallType.Get)

            Dim severityToApply As RuleSeverity = RuleSeverity.Error
            Try
                severityToApply = DirectCast(e, ExtendedRuleArgs).ApplySeverity
            Catch ex As Exception
            End Try

            If value Is Nothing Then

                e.Description = String.Format(My.Resources.Common_FieldValueNull, propName)
                e.Severity = severityToApply
                Return False

            End If

            Try
                If CType(value, IValueObjectIsEmpty).IsEmpty Then

                    e.Description = String.Format(My.Resources.Common_FieldValueNull, propName)
                    e.Severity = severityToApply
                    Return False

                End If
            Catch ex As Exception
            End Try

            Return True

        End Function

#End Region

#Region " LanguageCodeFieldValidation "

        ''' <summary>
        ''' Rule ensuring a valid language code is entered (accepts ExtendedRuleArgs).
        ''' </summary>
        ''' <param name="target">Object containing the data to validate</param>
        ''' <param name="e">Arguments parameter specifying the name of the string
        ''' property to validate (ExtendedRuleArgs OR RuleArgs)</param>
        ''' <returns><see langword="false" /> if the rule is broken</returns>
        ''' <remarks>
        ''' This implementation uses late binding, and will only work
        ''' against string property values.
        ''' </remarks>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:ValidateArgumentsOfPublicMethods")> _
        Public Function LanguageCodeValidation(ByVal target As Object, ByVal e As RuleArgs) As Boolean

            Dim value As String = Convert.ToString(CallByName(target, e.PropertyName, CallType.Get))

            Dim severity As RuleSeverity = RuleSeverity.Error
            Try
                severity = DirectCast(e, ExtendedRuleArgs).ApplySeverity
            Catch ex As Exception
            End Try

            If StringIsNullOrEmpty(value) AndAlso severity <> RuleSeverity.Information Then
                e.Description = My.Resources.Common_LanguageCodeNull
                e.Severity = severity
                Return False
            End If

            If Not IsLanguageCodeValid(value) Then
                e.Description = String.Format(My.Resources.Common_LanguageCodeInvalid, value.Trim)
                e.Severity = RuleSeverity.Error
                Return False
            Else

            End If

            Return True

        End Function

#End Region

#Region " LanguageNameFieldValidation "

        ''' <summary>
        ''' Rule ensuring a valid language name is entered (accepts ExtendedRuleArgs).
        ''' </summary>
        ''' <param name="target">Object containing the data to validate</param>
        ''' <param name="e">Arguments parameter specifying the name of the string
        ''' property to validate (ExtendedRuleArgs OR RuleArgs)</param>
        ''' <returns><see langword="false" /> if the rule is broken</returns>
        ''' <remarks>
        ''' This implementation uses late binding, and will only work
        ''' against string property values.
        ''' </remarks>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:ValidateArgumentsOfPublicMethods")> _
        Public Function LanguageNameValidation(ByVal target As Object, ByVal e As RuleArgs) As Boolean

            Dim value As String = Convert.ToString(CallByName(target, e.PropertyName, CallType.Get))

            Dim severity As RuleSeverity = RuleSeverity.Error
            Try
                severity = DirectCast(e, ExtendedRuleArgs).ApplySeverity
            Catch ex As Exception
            End Try

            If StringIsNullOrEmpty(value) AndAlso severity <> RuleSeverity.Information Then
                e.Description = My.Resources.Common_LanguageNameNull
                e.Severity = severity
                Return False
            End If

            Try
                If Not StringIsNullOrEmpty(value) Then GetLanguageCode(value, True)
            Catch ex As Exception
                e.Description = String.Format(My.Resources.Common_LanguageNameInvalid, value.Trim)
                e.Severity = RuleSeverity.Error
                Return False
            End Try

            Return True

        End Function

#End Region

#Region " CurrencyFieldValidation "

        ''' <summary>
        ''' Rule ensuring a valid currency code is entered (accepts ExtendedRuleArgs).
        ''' </summary>
        ''' <param name="target">Object containing the data to validate</param>
        ''' <param name="e">Arguments parameter specifying the name of the string
        ''' property to validate (RuleArgs OR ExtendedRuleArgs)</param>
        ''' <returns><see langword="false" /> if the rule is broken</returns>
        ''' <remarks>
        ''' This implementation uses late binding, and will only work
        ''' against string property values.
        ''' </remarks>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:ValidateArgumentsOfPublicMethods")> _
        Public Function CurrencyFieldValidation(ByVal target As Object, ByVal e As RuleArgs) As Boolean

            Dim value As String = Convert.ToString(CallByName(target, e.PropertyName, CallType.Get))

            If StringIsNullOrEmpty(value) Then
                e.Description = My.Resources.Common_CurrencyCodeNull
                Try
                    e.Severity = DirectCast(e, ExtendedRuleArgs).ApplySeverity
                Catch ex As Exception
                    e.Severity = RuleSeverity.Error
                End Try
                Return False
            End If

            If Array.IndexOf(CurrencyCodes, value.Trim.ToUpper) < 0 Then
                e.Description = String.Format(My.Resources.Common_CurrencyCodeInvalid, value.Trim)
                e.Severity = RuleSeverity.Error
                Return False
            Else

            End If

            Return True

        End Function

#End Region

#Region " ChronologyValidation "

        ''' <summary>
        ''' Rule ensuring that the chronology requirements are kept (requires ChronologyRuleArgs).
        ''' </summary>
        ''' <param name="target">Object containing the data to validate</param>
        ''' <param name="e">Arguments parameter specifying the name of the string
        ''' property to validate (ChronologyRuleArgs)</param>
        ''' <returns><see langword="false" /> if the rule is broken</returns>
        ''' <remarks>
        ''' This implementation uses late binding, and will only work
        ''' against string property values.
        ''' </remarks>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:ValidateArgumentsOfPublicMethods")> _
        Public Function ChronologyValidation(ByVal target As Object, ByVal e As RuleArgs) As Boolean

            Dim objectDate As Date = DirectCast((CallByName(target, DirectCast(e, ChronologyRuleArgs). _
                                                               DatePropertyName, CallType.Get)), Date)

            Dim validationObject As IChronologicValidator = DirectCast((CallByName(target, _
                                                                                   DirectCast(e, ChronologyRuleArgs).ValidatorPropertyName, CallType.Get)), IChronologicValidator)

            If validationObject Is Nothing Then Return True

            Return validationObject.ValidateOperationDate(objectDate, e.Description, e.Severity)

        End Function

        ''' <summary>
        ''' Custom object required by the rule method.
        ''' </summary>
        Public Class ChronologyRuleArgs
            Inherits RuleArgs

            Private _DatePropertyName As String = ""
            ''' <summary>
            ''' Get the property name that is holding object date.
            ''' </summary>
            Public ReadOnly Property DatePropertyName() As String
                Get
                    Return _DatePropertyName
                End Get
            End Property

            Private _ValidatorPropertyName As String = ""
            ''' <summary>
            ''' Get the property name that is holding IChronologicValidator.
            ''' </summary>
            Public ReadOnly Property ValidatorPropertyName() As String
                Get
                    Return _ValidatorPropertyName
                End Get
            End Property

            ''' <summary>
            ''' Create a new object.
            ''' </summary>
            ''' <param name="nDatePropertyName">The property name that is holding object date.</param>
            ''' <param name="nValidatorPropertyName">The property name that is holding IChronologicValidator.</param>
            Public Sub New(ByVal nDatePropertyName As String, ByVal nValidatorPropertyName As String)

                MyBase.New(nDatePropertyName)
                _DatePropertyName = nDatePropertyName
                _ValidatorPropertyName = nValidatorPropertyName

            End Sub

            ''' <summary>
            ''' Returns a string representation of the object.
            ''' </summary>
            Public Overrides Function ToString() As String
                Return MyBase.ToString & "?DatePropertyName=" & _DatePropertyName _
                       & "&ValidatorPropertyName=" & _ValidatorPropertyName
            End Function

        End Class

#End Region

#Region " StringValueUniqueInCollectionValidation "

        ''' <summary>
        ''' Rule ensuring a property's value is unique in collection.
        ''' </summary>
        ''' <param name="target">Object containing the data to validate</param>
        ''' <param name="e">Arguments parameter specifying the name of the string
        ''' property to validate</param>
        ''' <returns><see langword="false" /> if the rule is broken</returns>
        ''' <remarks>
        ''' This implementation uses late binding, and will only work
        ''' against string property values.
        ''' </remarks>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:ValidateArgumentsOfPublicMethods")> _
        Public Function StringValueUniqueInCollectionValidation(ByVal target As Object, _
                                                                ByVal e As RuleArgs) As Boolean

            If Not TypeOf target Is Csla.Core.BusinessBase Then Return True

            Dim parent As ICollection = Nothing
            Try
                Dim fi As PropertyInfo = target.GetType.GetProperty("Parent", _
                                                                    BindingFlags.NonPublic Or BindingFlags.Instance)
                parent = DirectCast(fi.GetValue(target, Nothing), ICollection)
            Catch ex As Exception
                Return True
            End Try

            If parent Is Nothing Then Return True

            Dim value As String = Convert.ToString(CallByName(target, e.PropertyName, CallType.Get))

            If StringIsNullOrEmpty(value) Then Return True

            For Each obj As Object In parent
                If Not Object.ReferenceEquals(obj, target) Then
                    Dim secondValue As String = ""
                    Try
                        secondValue = Convert.ToString(CallByName(obj, e.PropertyName, CallType.Get))
                    Catch ex As Exception
                    End Try
                    If Not StringIsNullOrEmpty(secondValue) AndAlso secondValue.Trim.ToLower = value.Trim.ToLower Then
                        e.Description = String.Format(My.Resources.Common_StringValueNotUniqueInCollection, _
                                                      GetResourcesPropertyName(target.GetType, e.PropertyName))
                        e.Severity = RuleSeverity.Error
                        Return False
                    End If
                End If
            Next

            Return True

        End Function

#End Region

#Region " AltLanguageValidation "

        ''' <summary>
        ''' Rule ensuring the value in alt language is provided when reference 
        ''' property's value contains foreign language code (or reference property
        ''' holds object that has LanguageCode property) (accepts ReferencePropertyRuleArgs).
        ''' </summary>
        ''' <param name="target">Object containing the data to validate</param>
        ''' <param name="e">Arguments parameter specifying the name of the string
        ''' property to validate</param>
        ''' <returns><see langword="false" /> if the rule is broken</returns>
        ''' <remarks>
        ''' This implementation uses late binding, and will only work
        ''' against string property values.
        ''' </remarks>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:ValidateArgumentsOfPublicMethods")> _
        Public Function AltLanguageValidation(ByVal target As Object, ByVal e As RuleArgs) As Boolean

            Dim value As String = DirectCast(CallByName(target, e.PropertyName, CallType.Get), String)
            If Not StringIsNullOrEmpty(value) Then Return True

            Dim args As ReferencePropertyRuleArgs = DirectCast(e, ReferencePropertyRuleArgs)
            Dim referenceObject As Object = CallByName(target, args.ReferencePropertyName, CallType.Get)

            If referenceObject Is Nothing Then Return True

            Dim foreignLanguageSet As Boolean = False
            Dim languageCode As String = ""

            If TypeOf referenceObject Is String Then

                languageCode = DirectCast(referenceObject, String).Trim
                foreignLanguageSet = (Not String.IsNullOrEmpty(languageCode) _
                    AndAlso languageCode.Trim.ToUpper <> LanguageCodeLith.Trim.ToUpper)

            Else

                Try
                    languageCode = DirectCast(CallByName(referenceObject, "LanguageCode", CallType.Get), String)
                    foreignLanguageSet = (Not StringIsNullOrEmpty(languageCode) _
                        AndAlso languageCode.Trim.ToUpper <> LanguageCodeLith.Trim.ToUpper)
                Catch ex As Exception
                End Try

            End If

            If foreignLanguageSet AndAlso String.IsNullOrEmpty(value) Then

                Dim propName As String = GetResourcesPropertyName(target.GetType, e.PropertyName)

                e.Description = String.Format("Nenurodyta {0} ({1}).", propName, _
                    GetLanguageName(languageCode, False))
                e.Severity = RuleSeverity.Error
                Return False

            End If

            Return True

        End Function

        ''' <summary>
        ''' Custom object required by the rule method.
        ''' </summary>
        Public Class ReferencePropertyRuleArgs
            Inherits RuleArgs

            Private _ApplySeverity As RuleSeverity = RuleSeverity.Error
            ''' <summary>
            ''' Severity to apply to the rule.
            ''' </summary>
            Public ReadOnly Property ApplySeverity() As RuleSeverity
                Get
                    Return _ApplySeverity
                End Get
            End Property

            Private _ReferencePropertyName As String = ""
            Public ReadOnly Property ReferencePropertyName() As String
                Get
                    Return _ReferencePropertyName
                End Get
            End Property

            ''' <summary>
            ''' Create a new object.
            ''' </summary>
            ''' <param name="propertyName">Name of the property to validate.</param>
            ''' <param name="SeverityToApply">Severity of the error to apply.</param>
            Public Sub New(ByVal propertyName As String, ByVal nReferencePropertyName As String, _
                Optional ByVal SeverityToApply As RuleSeverity = RuleSeverity.Error)

                MyBase.New(propertyName)
                _ApplySeverity = SeverityToApply
                _ReferencePropertyName = nReferencePropertyName

            End Sub

            ''' <summary>
            ''' Returns a string representation of the object.
            ''' </summary>
            Public Overrides Function ToString() As String
                Return MyBase.ToString & "?ApplySeverity=" & _ApplySeverity.ToString _
                       & "&ReferencePropertyName=" & _ReferencePropertyName
            End Function

        End Class

#End Region


        ''' <summary>
        ''' Gets an attribute of the property of the requested type. Returns null if no attribute 
        ''' of the requested type exists for the property.
        ''' </summary>
        ''' <typeparam name="T">a type of the attribute to get</typeparam>
        ''' <param name="targetType">a type that the property belongs to</param>
        ''' <param name="propertyName">a name of the property to get the attribute for</param>
        ''' <remarks></remarks>
        Public Function GetAttribute(Of T As Attribute)(ByVal targetType As Type, ByVal propertyName As String) As T

            Dim propInfo As PropertyInfo = targetType.GetProperty(propertyName)

            If propInfo Is Nothing Then Return Nothing

            For Each attr As Attribute In Attribute.GetCustomAttributes(propInfo)
                If TypeOf attr Is T Then
                    Return CType(attr, T)
                End If
            Next

            Return Nothing

        End Function

        ''' <summary>
        ''' Gets a human readable localized name of the property requested.
        ''' </summary>
        ''' <param name="targetType">a type that the property belongs to</param>
        ''' <param name="propertyName">a name of the property to get a human readable name for</param>
        ''' <remarks></remarks>
        Public Function GetResourcesPropertyName(ByVal targetType As Type, ByVal propertyName As String) As String

            If targetType.Assembly.FullName <> GetType(BookEntryInternal).Assembly.FullName Then
                Return AccPluginManager.PluginManager.Current.GetLocalizedPropertyName(targetType, propertyName)
            End If

            ' ReSharper disable VBStringIndexOfIsCultureSpecific.1
            Dim resourceName As String = targetType.FullName.Substring(targetType.FullName.IndexOf(".") + 1) _
                .Replace(".", "_") & "_" & propertyName
            ' ReSharper restore VBStringIndexOfIsCultureSpecific.1

            Dim result As String = My.Resources.ResourceManager.GetString(resourceName)

            If String.IsNullOrEmpty(result) Then
                result = propertyName
            End If

            Return result

        End Function

        ''' <summary>
        ''' Gets a human readable localized name of the type requested. 
        ''' </summary>
        ''' <param name="targetType">a type to get a human readable name for</param>
        ''' <remarks></remarks>
        Public Function GetResourcesTypeName(ByVal targetType As Type) As String

            ' ReSharper disable VBStringIndexOfIsCultureSpecific.1
            Dim resourceName As String = targetType.FullName.Substring(targetType.FullName.IndexOf(".") + 1) _
                .Replace(".", "_") & "_TypeName"
            ' ReSharper restore VBStringIndexOfIsCultureSpecific.1

            Dim result As String = My.Resources.ResourceManager.GetString(resourceName)

            If String.IsNullOrEmpty(result) Then
                result = targetType.Name
            End If

            Return result

        End Function

    End Module

End Namespace