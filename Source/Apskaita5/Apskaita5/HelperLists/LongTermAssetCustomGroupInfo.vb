Namespace HelperLists

    ''' <summary>
    ''' Represents a <see cref="Assets.LongTermAssetCustomGroup">long term asset group</see> value object.
    ''' </summary>
    ''' <remarks>Values are stored in the database table longtermassetcustomgroups.</remarks>
    <Serializable()> _
    Public NotInheritable Class LongTermAssetCustomGroupInfo
        Inherits ReadOnlyBase(Of LongTermAssetCustomGroupInfo)
        Implements IComparable, IValueObject

#Region " Business Methods "

        Private _ID As Integer = 0
        Private _Name As String = ""


        ''' <summary>
        ''' Whether an object is a palace holder (does not represent a real person group).
        ''' </summary>
        ''' <remarks></remarks>
        Public ReadOnly Property IsEmpty() As Boolean _
            Implements IValueObject.IsEmpty
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return Not _ID > 0
            End Get
        End Property

        ''' <summary>
        ''' Gets an ID of the custom group that is assigned by a database (AUTOINCREMENT).
        ''' </summary>
        ''' <remarks>Value is stored in the database field longtermassetcustomgroups.ID.</remarks>
        Public ReadOnly Property ID() As Integer
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _ID
            End Get
        End Property

        ''' <summary>
        ''' Gets a name of the custom group.
        ''' </summary>
        ''' <remarks>Value is stored in the database field longtermassetcustomgroups.Name.</remarks>
        Public ReadOnly Property Name() As String
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _Name.Trim
            End Get
        End Property


        Public Shared Operator =(ByVal a As LongTermAssetCustomGroupInfo, ByVal b As LongTermAssetCustomGroupInfo) As Boolean

            Dim aId, bId As Integer
            If a Is Nothing OrElse a.IsEmpty Then
                aId = 0
            Else
                aId = a.ID
            End If
            If b Is Nothing OrElse b.IsEmpty Then
                bId = 0
            Else
                bId = b.ID
            End If

            Return aId = bId

        End Operator

        Public Shared Operator <>(ByVal a As LongTermAssetCustomGroupInfo, ByVal b As LongTermAssetCustomGroupInfo) As Boolean
            Return Not a = b
        End Operator

        Public Shared Operator >(ByVal a As LongTermAssetCustomGroupInfo, ByVal b As LongTermAssetCustomGroupInfo) As Boolean

            Dim aToString, bToString As String
            If a Is Nothing OrElse a.IsEmpty Then
                aToString = ""
            Else
                aToString = a.ToString
            End If
            If b Is Nothing OrElse b.IsEmpty Then
                bToString = ""
            Else
                bToString = b.ToString
            End If

            Return aToString > bToString

        End Operator

        Public Shared Operator <(ByVal a As LongTermAssetCustomGroupInfo, ByVal b As LongTermAssetCustomGroupInfo) As Boolean

            Dim aToString, bToString As String
            If a Is Nothing OrElse a.IsEmpty Then
                aToString = ""
            Else
                aToString = a.ToString
            End If
            If b Is Nothing OrElse b.IsEmpty Then
                bToString = ""
            Else
                bToString = b.ToString
            End If

            Return aToString < bToString

        End Operator

        Public Function CompareTo(ByVal obj As Object) As Integer Implements System.IComparable.CompareTo
            Dim tmp As LongTermAssetCustomGroupInfo = TryCast(obj, LongTermAssetCustomGroupInfo)
            If Me = tmp Then Return 0
            If Me > tmp Then Return 1
            Return -1
        End Function


        Protected Overrides Function GetIdValue() As Object
            Return _ID
        End Function

        Public Overrides Function ToString() As String
            Return _Name
        End Function

#End Region

#Region " Factory Methods "

        Private Shared _Empty As LongTermAssetCustomGroupInfo = Nothing

        ''' <summary>
        ''' Gets an empty LongTermAssetCustomGroupInfo (placeholder).
        ''' </summary>
        Public Shared Function Empty() As LongTermAssetCustomGroupInfo
            If _Empty Is Nothing Then
                _Empty = New LongTermAssetCustomGroupInfo
            End If
            Return _Empty
        End Function

        Friend Shared Function GetLongTermAssetCustomGroupInfo(ByVal dr As DataRow, _
            ByVal offset As Integer) As LongTermAssetCustomGroupInfo
            Return New LongTermAssetCustomGroupInfo(dr, offset)
        End Function


        Private Sub New()
            ' require use of factory methods
        End Sub

        Private Sub New(ByVal dr As DataRow, ByVal offset As Integer)
            Fetch(dr, offset)
        End Sub

#End Region

#Region " Data Access "

        Private Sub Fetch(ByVal dr As DataRow, ByVal offset As Integer)

            _ID = CIntSafe(dr.Item(0 + offset), 0)
            _Name = CStrSafe(dr.Item(1 + offset)).Trim

        End Sub

#End Region

    End Class

End Namespace