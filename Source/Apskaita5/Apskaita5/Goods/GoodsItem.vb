Imports ApskaitaObjects.Documents
Imports ApskaitaObjects.Attributes

Namespace Goods

    ''' <summary>
    ''' Represents (a type of) goods.
    ''' </summary>
    ''' <remarks>Values are stored in the database table goods.</remarks>
    <Serializable()> _
    Public NotInheritable Class GoodsItem
        Inherits BusinessBase(Of GoodsItem)
        Implements IIsDirtyEnough, IRegionalDataObject, IValidationMessageProvider

#Region " Business Methods "

        Private _ID As Integer = 0
        Private _Name As String = ""
        Private _MeasureUnit As String = "Vnt."
        Private _AccountSalesNetCosts As Long = 0
        Private _AccountPurchases As Long = 0
        Private _AccountDiscounts As Long = 0
        Private _AccountValueReduction As Long = 0
        Private _AccountSalesIncome As Long = 0
        Private _DefaultVatRateSales As Double = 0
        Private _DeclarationSchemaSales As VatDeclarationSchemaInfo = Nothing
        Private _DefaultVatRatePurchase As Double = 0
        Private _DeclarationSchemaPurchase As VatDeclarationSchemaInfo = Nothing
        Private _Group As GoodsGroupInfo = Nothing
        Private _OldAccountingMethod As GoodsAccountingMethod = GoodsAccountingMethod.Persistent
        Private _AccountingMethod As GoodsAccountingMethod = GoodsAccountingMethod.Persistent
        Private _AccountingMethodHumanReadable As String = Utilities.ConvertLocalizedName(_AccountingMethod)
        Private _DefaultValuationMethod As GoodsValuationMethod = GoodsValuationMethod.FIFO
        Private _DefaultValuationMethodHumanReadable As String = Utilities.ConvertLocalizedName(_DefaultValuationMethod)
        Private _TradedType As TradedItemType = TradedItemType.All
        Private _TradedTypeHumanReadable As String = Utilities.ConvertLocalizedName(_TradedType)
        Private _InternalCode As String = ""
        Private _Barcode As String = ""
        Private _DefaultWarehouse As WarehouseInfo = Nothing
        Private _IsObsolete As Boolean = False
        Private _RegionalContents As RegionalContentList
        Private _RegionalPrices As RegionalPriceList
        Private _IsInUse As Boolean = False
        Private _PriceCutsExist As Boolean = False
        Private _InsertDate As DateTime = Now
        Private _UpdateDate As DateTime = Now

        ' used to implement automatic sort in datagridview
        <NotUndoable()> _
        <NonSerialized()> _
        Private _RegionalContentsSortedList As Csla.SortedBindingList(Of RegionalContent) = Nothing
        ' used to implement automatic sort in datagridview
        <NotUndoable()> _
        <NonSerialized()> _
        Private _RegionalPricesSortedList As Csla.SortedBindingList(Of RegionalPrice) = Nothing


        ''' <summary>
        ''' Gets an ID of the goods that is assigned by a database (AUTOINCREMENT).
        ''' </summary>
        ''' <remarks>Data is stored in database field goods.ID.</remarks>
        Public ReadOnly Property ID() As Integer _
            Implements IRegionalDataObject.RegionalObjectID
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _ID
            End Get
        End Property

        ''' <summary>
        ''' Gets the date and time when the goods data was inserted into the database.
        ''' </summary>
        ''' <remarks>Value is stored in the database field goods.InsertDate.</remarks>
        Public ReadOnly Property InsertDate() As DateTime
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _InsertDate
            End Get
        End Property

        ''' <summary>
        ''' Gets the date and time when the goods data was last updated.
        ''' </summary>
        ''' <remarks>Value is stored in the database field goods.UpdateDate.</remarks>
        Public ReadOnly Property UpdateDate() As DateTime
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _UpdateDate
            End Get
        End Property

        ''' <summary>
        ''' Gets a type of the goods as <see cref="RegionalizedObjectType.Goods">regionalizable object type</see>.
        ''' </summary>
        ''' <remarks></remarks>
        Public ReadOnly Property RegionalObjectType() As RegionalizedObjectType _
            Implements IRegionalDataObject.RegionalObjectType
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return RegionalizedObjectType.Goods
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets a name of the goods for internal use and 
        ''' for use in invoices received. Localized names for the 
        ''' invoices made are handled by the <see cref="Documents.RegionalContentList">
        ''' RegionalContents</see>.
        ''' </summary>
        ''' <remarks>Data is stored in database field goods.Name.</remarks>
        <StringField(ValueRequiredLevel.Mandatory, 255)> _
        Public Property Name() As String
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _Name.Trim
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As String)
                CanWriteProperty(True)
                If value Is Nothing Then value = ""
                If _Name.Trim <> value.Trim Then
                    _Name = value.Trim
                    PropertyHasChanged()
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets a measure unit of the goods for internal use and 
        ''' for use in invoices received. Localized measure units for the 
        ''' invoices made are handled by the <see cref="Documents.RegionalContentList">
        ''' RegionalContents</see>.
        ''' </summary>
        ''' <remarks>Data is stored in database field goods.MeasureUnit.</remarks>
        <StringField(ValueRequiredLevel.Mandatory, 100)> _
        Public Property MeasureUnit() As String
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _MeasureUnit.Trim
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As String)
                CanWriteProperty(True)
                If value Is Nothing Then value = ""
                If _MeasureUnit.Trim <> value.Trim Then
                    _MeasureUnit = value.Trim
                    PropertyHasChanged()
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets an <see cref="General.Account.ID">account</see> that is used for
        ''' the value of goods discarded (sold etc.). 
        ''' If the accounting method is set to<see cref="GoodsAccountingMethod.Periodic">
        ''' Periodic</see>, this account is fixed and mainly used by an <see cref="GoodsComplexOperationInventorization">
        ''' inventorization</see> operation (also in some cases by discount and additional costs). 
        ''' If the accounting method is set to<see cref="GoodsAccountingMethod.Persistent">
        ''' Persistent</see>, this account is used as a default goods discard costs
        ''' account by almost every operation, i.e. an operation can override it.
        ''' </summary>
        ''' <remarks>See methodology for BAS No 9 ""Stores"" para. 5.2 and 40.
        ''' Data is stored in database field goods.AccountSalesNetCosts.</remarks>
        <AccountField(ValueRequiredLevel.Mandatory, False, 6)> _
        Public Property AccountSalesNetCosts() As Long
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _AccountSalesNetCosts
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As Long)
                If _IsInUse AndAlso _AccountingMethod = GoodsAccountingMethod.Periodic Then
                    PropertyHasChanged()
                    Exit Property
                End If
                CanWriteProperty(True)
                If _AccountSalesNetCosts <> value Then
                    _AccountSalesNetCosts = value
                    PropertyHasChanged()
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets an <see cref="General.Account.ID">account</see> that is used for
        ''' the value of goods received (bought) by the <see cref="GoodsAccountingMethod.Periodic">
        ''' periodic accounting method</see>, not applicable for persistent accounting method,
        ''' that uses <see cref="Warehouse.WarehouseAccount">warehouse account</see>
        ''' for the same purpose.
        ''' </summary>
        ''' <remarks>See methodology for BAS No 9 ""Stores"" para. 8.
        ''' Data is stored in database field goods.AccountPurchases.</remarks>
        <AccountField(ValueRequiredLevel.Mandatory, False, 6)> _
        Public Property AccountPurchases() As Long
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _AccountPurchases
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As Long)
                If _IsInUse AndAlso _AccountingMethod = GoodsAccountingMethod.Periodic Then
                    PropertyHasChanged()
                    Exit Property
                End If
                CanWriteProperty(True)
                If _AccountPurchases <> value Then
                    _AccountPurchases = value
                    PropertyHasChanged()
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets an <see cref="General.Account.ID">account</see> that is used for
        ''' discounts received by the <see cref="GoodsAccountingMethod.Periodic">
        ''' periodic accounting method</see>, not applicable for persistent accounting method.
        ''' </summary>
        ''' <remarks>See methodology for BAS No 9 ""Stores"" para. 5.2.
        ''' Data is stored in database field goods.AccountDiscounts.</remarks>
        <AccountField(ValueRequiredLevel.Mandatory, False, 6)> _
        Public Property AccountDiscounts() As Long
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _AccountDiscounts
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As Long)
                If _IsInUse AndAlso _AccountingMethod = GoodsAccountingMethod.Periodic Then
                    PropertyHasChanged()
                    Exit Property
                End If
                CanWriteProperty(True)
                If _AccountDiscounts <> value Then
                    _AccountDiscounts = value
                    PropertyHasChanged()
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets an <see cref="General.Account.ID">account</see> that is used for
        ''' goods value reduction (when goods are revalued to match market prices). 
        ''' Handling of this account does not depend on the accounting method.
        ''' </summary>
        ''' <remarks>See methodology for BAS No 9 ""Stores"" para. 24 - 33.
        ''' Data is stored in database field goods.AccountValueReduction.</remarks>
        <AccountField(ValueRequiredLevel.Mandatory, False, 2)> _
        Public Property AccountValueReduction() As Long
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _AccountValueReduction
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As Long)
                If _PriceCutsExist Then
                    PropertyHasChanged()
                    Exit Property
                End If
                CanWriteProperty(True)
                If _AccountValueReduction <> value Then
                    _AccountValueReduction = value
                    PropertyHasChanged()
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets a default <see cref="General.Account.ID">account</see> 
        ''' that is used for the goods sales income, i.e. an operation can override it.
        ''' </summary>
        ''' <remarks>Data is stored in database field goods.AccountSalesIncome.</remarks>
        <AccountField(ValueRequiredLevel.Recommended, False, 5)> _
        Public Property AccountSalesIncome() As Long
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _AccountSalesIncome
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As Long)
                CanWriteProperty(True)
                If _AccountSalesIncome <> value Then
                    _AccountSalesIncome = value
                    PropertyHasChanged()
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets a default VAT rate for the goods beeing sold.
        ''' </summary>
        ''' <remarks>Value is stored in the database field goods.DefaultVatRateSales.</remarks>
        <TaxRateField(ValueRequiredLevel.Optional, ApskaitaObjects.Settings.TaxRateType.Vat)> _
        Public Property DefaultVatRateSales() As Double
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return CRound(_DefaultVatRateSales)
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As Double)
                CanWriteProperty(True)
                If CRound(_DefaultVatRateSales) <> CRound(value) Then
                    _DefaultVatRateSales = CRound(value)
                    PropertyHasChanged()
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the applicable VAT declaration schema for the goods sold.
        ''' </summary>
        ''' <remarks>Value is stored in the database table goods.DeclarationSchemaIDSales.</remarks>
        <VatDeclarationSchemaField(ValueRequiredLevel.Recommended, TradedItemType.Sales)> _
        Public Property DeclarationSchemaSales() As VatDeclarationSchemaInfo
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _DeclarationSchemaSales
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As VatDeclarationSchemaInfo)
                CanWriteProperty(True)
                If Not (_DeclarationSchemaSales Is Nothing AndAlso value Is Nothing) _
                    AndAlso Not (Not _DeclarationSchemaSales Is Nothing AndAlso Not value Is Nothing _
                    AndAlso _DeclarationSchemaSales = value) Then
                    _DeclarationSchemaSales = value
                    If Not _DeclarationSchemaSales Is Nothing AndAlso Not _DeclarationSchemaSales.IsEmpty Then
                        DefaultVatRateSales = _DeclarationSchemaSales.VatRate
                    End If
                    PropertyHasChanged()
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets a default VAT rate for the goods beeing purchased.
        ''' </summary>
        ''' <remarks>Value is stored in the database field goods.DefaultVatRatePurchase.</remarks>
        <TaxRateField(ValueRequiredLevel.Optional, ApskaitaObjects.Settings.TaxRateType.Vat)> _
        Public Property DefaultVatRatePurchase() As Double
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return CRound(_DefaultVatRatePurchase)
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As Double)
                CanWriteProperty(True)
                If CRound(_DefaultVatRatePurchase) <> CRound(value) Then
                    _DefaultVatRatePurchase = CRound(value)
                    PropertyHasChanged()
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the applicable VAT declaration schema for the goods bought.
        ''' </summary>
        ''' <remarks>Value is stored in the database table goods.DeclarationSchemaIDPurchase.</remarks>
        <VatDeclarationSchemaField(ValueRequiredLevel.Recommended, TradedItemType.Purchases)> _
        Public Property DeclarationSchemaPurchase() As VatDeclarationSchemaInfo
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _DeclarationSchemaPurchase
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As VatDeclarationSchemaInfo)
                CanWriteProperty(True)
                If Not (_DeclarationSchemaPurchase Is Nothing AndAlso value Is Nothing) _
                    AndAlso Not (Not _DeclarationSchemaPurchase Is Nothing AndAlso Not value Is Nothing _
                    AndAlso _DeclarationSchemaPurchase = value) Then
                    _DeclarationSchemaPurchase = value
                    If Not _DeclarationSchemaPurchase Is Nothing AndAlso Not _DeclarationSchemaPurchase.IsEmpty Then
                        DefaultVatRatePurchase = _DeclarationSchemaPurchase.VatRate
                    End If
                    PropertyHasChanged()
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets a custom goods group that the goods are assigned to.
        ''' </summary>
        ''' <remarks>Use <see cref="HelperLists.GoodsGroupInfoList">GoodsGroupInfoList</see> for a datasource.
        ''' Value is stored in the database field goods.GroupID.</remarks>
        <GoodsGroupField(ValueRequiredLevel.Optional)> _
        Public Property Group() As GoodsGroupInfo
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _Group
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As GoodsGroupInfo)
                CanWriteProperty(True)
                If Not (_Group Is Nothing AndAlso value Is Nothing) AndAlso Not _
                    (Not _Group Is Nothing AndAlso Not value Is Nothing AndAlso _Group.ID = value.ID) Then
                    _Group = value
                    PropertyHasChanged()
                End If
            End Set
        End Property

        Public ReadOnly Property OldAccountingMethod() As GoodsAccountingMethod
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _OldAccountingMethod
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets a goods accounting method (periodic/persistent).
        ''' </summary>
        ''' <remarks>Cannot be changed after the first operation with the goods.
        ''' Data is stored in database field goods.DefaultAccountingMethod.</remarks>
        Public Property AccountingMethod() As GoodsAccountingMethod
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _AccountingMethod
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As GoodsAccountingMethod)
                If _IsInUse Then
                    PropertyHasChanged()
                    Exit Property
                End If
                CanWriteProperty(True)
                If _AccountingMethod <> value Then
                    _AccountingMethod = value
                    PropertyHasChanged()
                    _AccountingMethodHumanReadable = Utilities.ConvertLocalizedName(_AccountingMethod)
                    PropertyHasChanged("AccountingMethodHumanReadable")
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets a goods accounting method (periodic/persistent) 
        ''' as a localized human readable string.
        ''' </summary>
        ''' <remarks>Cannot be changed after the first operation with the goods.
        ''' Data is stored in database field goods.DefaultAccountingMethod.</remarks>
        <LocalizedEnumField(GetType(GoodsAccountingMethod), False, "")> _
        Public Property AccountingMethodHumanReadable() As String
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _AccountingMethodHumanReadable.Trim
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As String)
                If _IsInUse Then
                    PropertyHasChanged()
                    Exit Property
                End If
                CanWriteProperty(True)
                If value Is Nothing Then value = ""
                If Utilities.ConvertLocalizedName(Of GoodsAccountingMethod)(value.Trim) <> _AccountingMethod Then
                    _AccountingMethod = Utilities.ConvertLocalizedName(Of GoodsAccountingMethod)(value.Trim)
                    _AccountingMethodHumanReadable = Utilities.ConvertLocalizedName(_AccountingMethod)
                    PropertyHasChanged()
                    PropertyHasChanged("AccountingMethod")
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets a goods valuation method (FIFO, LIFO, average, etc.).
        ''' </summary>
        ''' <remarks>Cannot be changed after the first operation with the goods, 
        ''' but could be prospectively overriden by a <see cref="GoodsOperationValuationMethod">
        ''' valuation method change operation</see>.
        ''' Data is stored in database field goods.DefaultValuationMethod.</remarks>
        Public Property DefaultValuationMethod() As GoodsValuationMethod
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _DefaultValuationMethod
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As GoodsValuationMethod)
                If _IsInUse Then
                    PropertyHasChanged()
                    Exit Property
                End If
                CanWriteProperty(True)
                If _DefaultValuationMethod <> value Then
                    _DefaultValuationMethod = value
                    PropertyHasChanged()
                    _DefaultValuationMethodHumanReadable = Utilities.ConvertLocalizedName(_DefaultValuationMethod)
                    PropertyHasChanged("DefaultValuationMethodHumanReadable")
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets a goods valuation method (FIFO, LIFO, average, etc.) 
        ''' as a localized human readable string.
        ''' </summary>
        ''' <remarks>Cannot be changed after the first operation with the goods, 
        ''' but could be prospectively overriden by a <see cref="GoodsOperationValuationMethod">
        ''' valuation method change operation</see>.
        ''' Data is stored in database field goods.DefaultValuationMethod.</remarks>
        <LocalizedEnumField(GetType(GoodsValuationMethod), False, "")> _
        Public Property DefaultValuationMethodHumanReadable() As String
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _DefaultValuationMethodHumanReadable.Trim
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As String)
                If _IsInUse Then
                    PropertyHasChanged()
                    Exit Property
                End If
                CanWriteProperty(True)
                If value Is Nothing Then value = ""
                If Utilities.ConvertLocalizedName(Of GoodsValuationMethod)(value.Trim) <> _DefaultValuationMethod Then
                    _DefaultValuationMethod = Utilities.ConvertLocalizedName(Of GoodsValuationMethod)(value.Trim)
                    _DefaultValuationMethodHumanReadable = Utilities.ConvertLocalizedName(_DefaultValuationMethod)
                    PropertyHasChanged()
                    PropertyHasChanged("DefaultValuationMethod")
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets how the goods are used in trade operations (sale, purchase, etc.).
        ''' </summary>
        ''' <remarks>Value is stored in the database field goods.TradeItemType.</remarks>
        Public Property TradedType() As TradedItemType
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _TradedType
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As TradedItemType)
                CanWriteProperty(True)
                If _TradedType <> value Then
                    _TradedType = value
                    PropertyHasChanged()
                    _TradedTypeHumanReadable = Utilities.ConvertLocalizedName(_TradedType)
                    PropertyHasChanged("TradedTypeHumanReadable")
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets how the goods is used in trade operations (sale, purchase, etc.) 
        ''' as a localized human readable string.
        ''' </summary>
        ''' <remarks>Value is stored in the database field goods.TradeItemType.</remarks>
        <LocalizedEnumField(GetType(Documents.TradedItemType), False, "")> _
        Public Property TradedTypeHumanReadable() As String
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _TradedTypeHumanReadable.Trim
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As String)
                CanWriteProperty(True)
                If value Is Nothing Then value = ""
                Dim enumValue As TradedItemType = Utilities.ConvertLocalizedName(Of TradedItemType)(value)
                If enumValue <> _TradedType Then
                    _TradedType = enumValue
                    _TradedTypeHumanReadable = Utilities.ConvertLocalizedName(_TradedType)
                    PropertyHasChanged()
                    PropertyHasChanged("TradedType")
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets a custom goods code. (for internal company use 
        ''' or for integration with external CRM systems)
        ''' </summary>
        ''' <remarks>Value is stored in the database field goods.GoodsCode.</remarks>
        <StringField(ValueRequiredLevel.Optional, 50)> _
        Public Property InternalCode() As String
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _InternalCode.Trim
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As String)
                CanWriteProperty(True)
                If value Is Nothing Then value = ""
                If _InternalCode.Trim <> value.Trim Then
                    _InternalCode = value.Trim
                    PropertyHasChanged()
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets a goods barcode.
        ''' </summary>
        ''' <remarks>Value is stored in the database field goods.GoodsBarcode.</remarks>
        <StringField(ValueRequiredLevel.Optional, 255)> _
        Public Property Barcode() As String
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _Barcode.Trim
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As String)
                CanWriteProperty(True)
                If value Is Nothing Then value = ""
                If _Barcode.Trim <> value.Trim Then
                    _Barcode = value.Trim
                    PropertyHasChanged()
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets a default warehouse that is used to initialize goods operations.
        ''' </summary>
        ''' <remarks>Use <see cref="HelperLists.WarehouseInfoList">WarehouseInfoList</see> for a datasource.
        ''' Value is stored in the database field goods.DefaultWarehouseID.</remarks>
        <WarehouseField(ValueRequiredLevel.Optional)> _
        Public Property DefaultWarehouse() As WarehouseInfo
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _DefaultWarehouse
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As WarehouseInfo)
                CanWriteProperty(True)
                If Not (_DefaultWarehouse Is Nothing AndAlso value Is Nothing) AndAlso Not _
                    (Not _DefaultWarehouse Is Nothing AndAlso Not value Is Nothing AndAlso _
                    _DefaultWarehouse.ID = value.ID) Then
                    _DefaultWarehouse = value
                    PropertyHasChanged()
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets whether the goods are obsolete (no longer in use).
        ''' </summary>
        ''' <remarks>Value is stored in the database field goods.IsObsolete.</remarks>
        Public Property IsObsolete() As Boolean
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _IsObsolete
            End Get
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Set(ByVal value As Boolean)
                CanWriteProperty(True)
                If _IsObsolete <> value Then
                    _IsObsolete = value
                    PropertyHasChanged()
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets a collection of localized names for the goods.
        ''' </summary>
        ''' <remarks></remarks>
        Public ReadOnly Property RegionalContents() As RegionalContentList
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _RegionalContents
            End Get
        End Property

        ''' <summary>
        ''' Gets a collection of localized prices for the goods.
        ''' </summary>
        ''' <remarks></remarks>
        Public ReadOnly Property RegionalPrices() As RegionalPriceList
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _RegionalPrices
            End Get
        End Property

        ''' <summary>
        ''' Gets a sortable collection of localized names for the goods.
        ''' </summary>
        ''' <remarks></remarks>
        Public ReadOnly Property RegionalContentsSorted() As Csla.SortedBindingList(Of RegionalContent)
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                If _RegionalContentsSortedList Is Nothing Then
                    _RegionalContentsSortedList = New Csla.SortedBindingList(Of RegionalContent) _
                        (_RegionalContents)
                End If
                Return _RegionalContentsSortedList
            End Get
        End Property

        ''' <summary>
        ''' Gets a sortable collection of localized prices for the goods.
        ''' </summary>
        ''' <remarks></remarks>
        Public ReadOnly Property RegionalPricesSorted() As Csla.SortedBindingList(Of RegionalPrice)
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                If _RegionalPricesSortedList Is Nothing Then
                    _RegionalPricesSortedList = New Csla.SortedBindingList(Of RegionalPrice) _
                        (_RegionalPrices)
                End If
                Return _RegionalPricesSortedList
            End Get
        End Property

        ''' <summary>
        ''' Gets whether there are any operations with the goods.
        ''' </summary>
        ''' <remarks>Data is retrieved by a subquery.</remarks>
        Public ReadOnly Property IsInUse() As Boolean
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _IsInUse
            End Get
        End Property

        ''' <summary>
        ''' Gets whether there are any <see cref="GoodsOperationPriceCut">
        ''' price cut operations</see> with the goods.
        ''' </summary>
        ''' <remarks>Data is retrieved by a subquery.</remarks>
        Public ReadOnly Property PriceCutsExist() As Boolean
            <System.Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.NoInlining)> _
            Get
                Return _PriceCutsExist
            End Get
        End Property


        Public ReadOnly Property IsDirtyEnough() As Boolean _
            Implements IIsDirtyEnough.IsDirtyEnough
            Get
                If Not IsNew Then Return IsDirty
                Return (Not String.IsNullOrEmpty(_Name.Trim) _
                    OrElse Not String.IsNullOrEmpty(_MeasureUnit.Trim) _
                    OrElse Not String.IsNullOrEmpty(_AccountingMethodHumanReadable.Trim) _
                    OrElse Not String.IsNullOrEmpty(_DefaultValuationMethodHumanReadable.Trim) _
                    OrElse Not String.IsNullOrEmpty(_TradedTypeHumanReadable.Trim) _
                    OrElse Not String.IsNullOrEmpty(_InternalCode.Trim) _
                    OrElse Not String.IsNullOrEmpty(_Barcode.Trim) _
                    OrElse _RegionalContents.Count > 0 _
                    OrElse _RegionalPrices.Count > 0)
            End Get
        End Property

        Public Overrides ReadOnly Property IsDirty() As Boolean
            Get
                Return MyBase.IsDirty OrElse _RegionalContents.IsDirty OrElse _RegionalPrices.IsDirty
            End Get
        End Property

        Public Overrides ReadOnly Property IsValid() As Boolean _
            Implements IValidationMessageProvider.IsValid
            Get
                Return MyBase.IsValid AndAlso _RegionalContents.IsValid AndAlso _RegionalPrices.IsValid
            End Get
        End Property


        Public Function GetAllBrokenRules() As String _
            Implements IValidationMessageProvider.GetAllBrokenRules
            Dim result As String = ""
            If Not MyBase.IsValid Then
                result = Me.BrokenRulesCollection.ToString(Validation.RuleSeverity.Error)
            End If
            If Not _RegionalContents.IsValid Then
                result = AddWithNewLine(result, _RegionalContents.GetAllBrokenRules, False)
            End If
            If Not _RegionalPrices.IsValid Then
                result = AddWithNewLine(result, _RegionalPrices.GetAllBrokenRules, False)
            End If
            Return result
        End Function

        Public Function GetAllWarnings() As String _
            Implements IValidationMessageProvider.GetAllWarnings
            Dim result As String = ""
            If MyBase.BrokenRulesCollection.WarningCount > 0 Then _
                result = Me.BrokenRulesCollection.ToString(Validation.RuleSeverity.Warning)
            result = AddWithNewLine(result, _RegionalContents.GetAllWarnings, False)
            result = AddWithNewLine(result, _RegionalPrices.GetAllWarnings, False)
            If _RegionalContents.Count < 1 Then result = AddWithNewLine(result, _
                My.Resources.Goods_GoodsItem_RegionalContentListEmpty, False)
            If _RegionalPrices.Count < 1 Then result = AddWithNewLine(result, _
                My.Resources.Goods_GoodsItem_RegionalPriceListEmpty, False)
            Return result
        End Function

        Public Function HasWarnings() As Boolean _
            Implements IValidationMessageProvider.HasWarnings
            Return (MyBase.BrokenRulesCollection.WarningCount > 0 OrElse _
                _RegionalContents.Count < 1 OrElse _RegionalPrices.Count < 1 OrElse _
                _RegionalContents.HasWarnings OrElse _RegionalPrices.HasWarnings())
        End Function


        Public Overrides Function Save() As GoodsItem
            Dim result As GoodsItem = MyBase.Save
            HelperLists.GoodsInfoList.InvalidateCache()
            HelperLists.RegionalInfoDictionary.InvalidateCache()
            Return result
        End Function


        Protected Overrides Function GetIdValue() As Object
            Return _ID
        End Function

        Public Overrides Function ToString() As String
            Return String.Format(My.Resources.Goods_GoodsItem_ToString, _
                _Name, _ID.ToString)
        End Function

#End Region

#Region " Validation Rules "

        Protected Overrides Sub AddBusinessRules()

            ValidationRules.AddRule(AddressOf CommonValidation.StringFieldValidation, _
                New Csla.Validation.RuleArgs("Name"))
            ValidationRules.AddRule(AddressOf CommonValidation.StringFieldValidation, _
                New Csla.Validation.RuleArgs("MeasureUnit"))
            ValidationRules.AddRule(AddressOf CommonValidation.StringFieldValidation, _
                New Csla.Validation.RuleArgs("InternalCode"))
            ValidationRules.AddRule(AddressOf CommonValidation.StringFieldValidation, _
                New Csla.Validation.RuleArgs("Barcode"))

            ValidationRules.AddRule(AddressOf CommonValidation.AccountFieldValidation, _
                New Csla.Validation.RuleArgs("AccountValueReduction"))

            ValidationRules.AddRule(AddressOf CommonValidation.DoubleFieldValidation, _
                New Csla.Validation.RuleArgs("DefaultVatRateSales"))
            ValidationRules.AddRule(AddressOf CommonValidation.DoubleFieldValidation, _
                New Csla.Validation.RuleArgs("DefaultVatRatePurchase"))
            ValidationRules.AddRule(AddressOf CommonValidation.VatDeclarationSchemaFieldValidation, _
                New VatDeclarationSchemaFieldRuleArgs("DeclarationSchemaPurchase", _
                "DefaultVatRatePurchase"))
            ValidationRules.AddRule(AddressOf CommonValidation.VatDeclarationSchemaFieldValidation, _
                New VatDeclarationSchemaFieldRuleArgs("DeclarationSchemaSales", _
                "DefaultVatRateSales"))

            ValidationRules.AddRule(AddressOf AccountSalesNetCostsValidation, _
                New Validation.RuleArgs("AccountSalesNetCosts"))
            ValidationRules.AddRule(AddressOf PeriodicAccountsValidation, _
                New Validation.RuleArgs("AccountPurchases"))
            ValidationRules.AddRule(AddressOf PeriodicAccountsValidation, _
                New Validation.RuleArgs("AccountDiscounts"))

            ValidationRules.AddDependantProperty("AccountingMethod", "AccountSalesNetCosts", False)
            ValidationRules.AddDependantProperty("AccountingMethod", "AccountPurchases", False)
            ValidationRules.AddDependantProperty("AccountingMethod", "AccountDiscounts", False)
            ValidationRules.AddDependantProperty("DefaultVatRatePurchase", "DeclarationSchemaPurchase", False)
            ValidationRules.AddDependantProperty("DefaultVatRateSales", "DeclarationSchemaSales", False)

        End Sub

        ''' <summary>
        ''' Rule ensuring that the value of property AccountSalesNetCosts is valid.
        ''' </summary>
        ''' <param name="target">Object containing the data to validate</param>
        ''' <param name="e">Arguments parameter specifying the name of the string
        ''' property to validate</param>
        ''' <returns><see langword="false" /> if the rule is broken</returns>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:ValidateArgumentsOfPublicMethods")> _
        Private Shared Function AccountSalesNetCostsValidation(ByVal target As Object, _
            ByVal e As Validation.RuleArgs) As Boolean

            Dim valObj As GoodsItem = DirectCast(target, GoodsItem)

            If valObj._AccountingMethod = GoodsAccountingMethod.Periodic AndAlso _
                Not valObj._AccountSalesNetCosts > 0 Then
                e.Description = My.Resources.Goods_GoodsItem_AccountSalesNetCostsNull
                e.Severity = Validation.RuleSeverity.Error
                Return False
            ElseIf Not valObj._AccountSalesNetCosts > 0 Then
                e.Description = My.Resources.Goods_GoodsItem_AccountSalesNetCostsNull
                e.Severity = Validation.RuleSeverity.Warning
                Return False
            End If

            Return True

        End Function

        ''' <summary>
        ''' Rule ensuring that the value of accounts that are used in periodic accounting is valid.
        ''' </summary>
        ''' <param name="target">Object containing the data to validate</param>
        ''' <param name="e">Arguments parameter specifying the name of the string
        ''' property to validate</param>
        ''' <returns><see langword="false" /> if the rule is broken</returns>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:ValidateArgumentsOfPublicMethods")> _
        Private Shared Function PeriodicAccountsValidation(ByVal target As Object, _
            ByVal e As Validation.RuleArgs) As Boolean

            If DirectCast(target, GoodsItem)._AccountingMethod _
                <> GoodsAccountingMethod.Periodic Then Return True

            Return CommonValidation.CommonValidation.AccountFieldValidation(target, e)

        End Function

#End Region

#Region " Authorization Rules "

        Protected Overrides Sub AddAuthorizationRules()

        End Sub

        Public Shared Function CanGetObject() As Boolean
            Return ApplicationContext.User.IsInRole("Goods.Goods1")
        End Function

        Public Shared Function CanAddObject() As Boolean
            Return ApplicationContext.User.IsInRole("Goods.Goods2")
        End Function

        Public Shared Function CanEditObject() As Boolean
            Return ApplicationContext.User.IsInRole("Goods.Goods3")
        End Function

        Public Shared Function CanDeleteObject() As Boolean
            Return ApplicationContext.User.IsInRole("Goods.Goods3")
        End Function

#End Region

#Region " Factory Methods "

        ''' <summary>
        ''' Gets a new GoodsItem instance initialized according to the company settings.
        ''' </summary>
        ''' <remarks></remarks>
        Public Shared Function NewGoodsItem() As GoodsItem
            Dim result As GoodsItem = New GoodsItem
            result.Create()
            Return result
        End Function

        ''' <summary>
        ''' Gets an existing GoodsItem instance from a database. 
        ''' </summary>
        ''' <param name="id">An <see cref="ID">ID of the goods</see> to fetch.</param>
        ''' <remarks></remarks>
        Public Shared Function GetGoodsItem(ByVal id As Integer) As GoodsItem
            Return DataPortal.Fetch(Of GoodsItem)(New Criteria(id))
        End Function

        ''' <summary>
        ''' Deletes an existing GoodsItem instance from a database. 
        ''' </summary>
        ''' <param name="id">An <see cref="ID">ID of the goods</see> to delete.</param>
        ''' <remarks></remarks>
        Public Shared Sub DeleteGoodsItem(ByVal id As Integer)
            DataPortal.Delete(New Criteria(id))
            HelperLists.GoodsInfoList.InvalidateCache()
            HelperLists.RegionalInfoDictionary.InvalidateCache()
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


        Private Sub Create()

            If Not CanAddObject() Then Throw New System.Security.SecurityException( _
                My.Resources.Common_SecurityInsertDenied)

            _RegionalContents = RegionalContentList.NewRegionalContentList
            _RegionalPrices = RegionalPriceList.NewRegionalPriceList
            _AccountDiscounts = GetCurrentCompany.Accounts.GetAccount(General.DefaultAccountType.GoodsDiscounts)
            _AccountPurchases = GetCurrentCompany.Accounts.GetAccount(General.DefaultAccountType.GoodsPurchases)
            _AccountSalesNetCosts = GetCurrentCompany.Accounts.GetAccount(General.DefaultAccountType.GoodsSalesNetCosts)
            _AccountValueReduction = GetCurrentCompany.Accounts.GetAccount(General.DefaultAccountType.GoodsValueReduction)
            If GetCurrentCompany.UseVatDeclarationSchemas Then
                _DeclarationSchemaPurchase = GetCurrentCompany.DeclarationSchemaPurchase
                _DeclarationSchemaSales = GetCurrentCompany.DeclarationSchemaSales
                If _DeclarationSchemaPurchase <> VatDeclarationSchemaInfo.Empty Then
                    _DefaultVatRatePurchase = _DeclarationSchemaPurchase.VatRate
                End If
                If _DeclarationSchemaSales <> VatDeclarationSchemaInfo.Empty Then
                    _DefaultVatRateSales = _DeclarationSchemaSales.VatRate
                End If
            Else
                _DefaultVatRatePurchase = GetCurrentCompany.Rates.GetRate(General.DefaultRateType.Vat)
                _DefaultVatRateSales = GetCurrentCompany.Rates.GetRate(General.DefaultRateType.Vat)
            End If

            ValidationRules.CheckRules()

        End Sub


        Private Overloads Sub DataPortal_Fetch(ByVal criteria As Criteria)

            If Not CanGetObject() Then Throw New System.Security.SecurityException( _
                My.Resources.Common_SecuritySelectDenied)

            Dim myComm As New SQLCommand("FetchGoodsItem")
            myComm.AddParam("?GD", criteria.ID)

            Using myData As DataTable = myComm.Fetch

                If myData.Rows.Count < 1 Then Throw New Exception(String.Format( _
                    My.Resources.Common_ObjectNotFound, My.Resources.Goods_GoodsItem_TypeName, _
                    criteria.ID.ToString()))

                Dim dr As DataRow = myData.Rows(0)

                _ID = CIntSafe(dr.Item(0), 0)
                _Name = CStrSafe(dr.Item(1)).Trim
                _MeasureUnit = CStrSafe(dr.Item(2)).Trim
                _AccountSalesNetCosts = CLongSafe(dr.Item(3), 0)
                _AccountPurchases = CLongSafe(dr.Item(4), 0)
                _AccountDiscounts = CLongSafe(dr.Item(5), 0)
                _AccountValueReduction = CLongSafe(dr.Item(6), 0)
                _DefaultVatRateSales = CDblSafe(dr.Item(7), 2, 0)
                _DefaultVatRatePurchase = CDblSafe(dr.Item(8), 2, 0)
                _AccountingMethod = Utilities.ConvertDatabaseID(Of GoodsAccountingMethod)(CIntSafe(dr.Item(9), 1))
                _DefaultValuationMethod = Utilities.ConvertDatabaseID(Of GoodsValuationMethod)(CIntSafe(dr.Item(10), 1))
                _TradedType = Utilities.ConvertDatabaseID(Of TradedItemType)(CIntSafe(dr.Item(11), 0))
                _InternalCode = CStrSafe(dr.Item(12)).Trim
                _Barcode = CStrSafe(dr.Item(13)).Trim
                _IsObsolete = ConvertDbBoolean(CIntSafe(dr.Item(14), 0))
                _AccountSalesIncome = CLongSafe(dr.Item(15), 0)
                _InsertDate = CTimeStampSafe(dr.Item(16))
                _UpdateDate = CTimeStampSafe(dr.Item(17))
                _IsInUse = ConvertDbBoolean(CIntSafe(dr.Item(18), 0))
                _PriceCutsExist = ConvertDbBoolean(CIntSafe(dr.Item(19), 0))

                _RegionalContents = RegionalContentList.GetRegionalContentList(Me)
                _RegionalPrices = RegionalPriceList.GetRegionalPriceList(Me)

                _Group = GoodsGroupInfo.GetGoodsGroupInfo(dr, 20)
                _DefaultWarehouse = WarehouseInfo.GetWarehouseInfo(dr, 22)
                _DeclarationSchemaSales = VatDeclarationSchemaInfo. _
                    GetVatDeclarationSchemaInfo(dr, 27)
                _DeclarationSchemaPurchase = VatDeclarationSchemaInfo. _
                    GetVatDeclarationSchemaInfo(dr, 34)

                _AccountingMethodHumanReadable = Utilities.ConvertLocalizedName(_AccountingMethod)
                _DefaultValuationMethodHumanReadable = Utilities.ConvertLocalizedName(_DefaultValuationMethod)
                _TradedTypeHumanReadable = Utilities.ConvertLocalizedName(_TradedType)
                _OldAccountingMethod = _AccountingMethod

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

            CheckIfNameUnique(_ID, _Name, _Group)

            DoInsert()

            MarkOld()

        End Sub

        Friend Sub DoInsert()

            Dim myComm As New SQLCommand("InsertGoodsItem")
            AddWithGeneralParams(myComm)
            AddWithMethodsParams(myComm)
            AddWithAccountsParams(myComm)
            myComm.AddParam("?AF", _AccountValueReduction)

            Using transaction As New SqlTransaction

                Try

                    myComm.Execute()

                    _ID = Convert.ToInt32(myComm.LastInsertID)

                    RegionalContents.Update(Me)
                    RegionalPrices.Update(Me)

                    transaction.Commit()

                Catch ex As Exception
                    transaction.SetNonSqlException(ex)
                    Throw
                End Try

            End Using

        End Sub

        Protected Overrides Sub DataPortal_Update()

            If Not CanEditObject() Then Throw New System.Security.SecurityException( _
                My.Resources.Common_SecurityUpdateDenied)

            Me.ValidationRules.CheckRules()
            If Not Me.IsValid Then
                Throw New Exception(String.Format(My.Resources.Common_ContainsErrors, vbCrLf, _
                    GetAllBrokenRules()))
            End If

            CheckIfNameUnique(_ID, _Name, _Group)

            ' also reloads usage data
            CheckIfUpdateDateChanged()

            Dim myComm As SQLCommand
            If _IsInUse AndAlso _OldAccountingMethod = GoodsAccountingMethod.Persistent _
                AndAlso Not _PriceCutsExist Then
                ' everything except for methods
                myComm = New SQLCommand("UpdateGoodsItemLimited1")
                AddWithAccountsParams(myComm)
                myComm.AddParam("?AF", _AccountValueReduction)
            ElseIf _IsInUse AndAlso _OldAccountingMethod = GoodsAccountingMethod.Periodic _
                AndAlso Not _PriceCutsExist Then
                ' everything except for methods and accounts, but including price cut account
                myComm = New SQLCommand("UpdateGoodsItemLimited2")
                myComm.AddParam("?AF", _AccountValueReduction)
            ElseIf _IsInUse AndAlso _PriceCutsExist AndAlso _OldAccountingMethod _
                = GoodsAccountingMethod.Periodic Then
                ' everything except for methods and accounts
                myComm = New SQLCommand("UpdateGoodsItemLimited3")
            ElseIf _IsInUse AndAlso _PriceCutsExist AndAlso _OldAccountingMethod _
                = GoodsAccountingMethod.Persistent Then
                ' everything except for methods price cut account
                myComm = New SQLCommand("UpdateGoodsItemLimited4")
                AddWithAccountsParams(myComm)
            Else
                ' everything 
                myComm = New SQLCommand("UpdateGoodsItemFull")
                AddWithMethodsParams(myComm)
                AddWithAccountsParams(myComm)
                myComm.AddParam("?AF", _AccountValueReduction)
            End If
            AddWithGeneralParams(myComm)
            myComm.AddParam("?CD", _ID)

            Using transaction As New SqlTransaction

                Try

                    myComm.Execute()

                    RegionalContents.Update(Me)
                    RegionalPrices.Update(Me)

                    transaction.Commit()

                Catch ex As Exception
                    transaction.SetNonSqlException(ex)
                    Throw
                End Try

            End Using

            MarkOld()

        End Sub


        Protected Overrides Sub DataPortal_DeleteSelf()
            DataPortal_Delete(New Criteria(_ID))
        End Sub

        Protected Overrides Sub DataPortal_Delete(ByVal criteria As Object)

            If Not CanDeleteObject() Then Throw New System.Security.SecurityException( _
                My.Resources.Common_SecurityUpdateDenied)

            CheckIfAnyOperationExists(DirectCast(criteria, Criteria).ID)

            Dim myComm As SQLCommand = New SQLCommand("DeleteGoodsItem")
            myComm.AddParam("?CD", DirectCast(criteria, Criteria).ID)

            Using transaction As New SqlTransaction

                Try

                    myComm.Execute()

                    RegionalContentList.Delete(DirectCast(criteria, Criteria).ID, RegionalizedObjectType.Goods)
                    RegionalPriceList.Delete(DirectCast(criteria, Criteria).ID, RegionalizedObjectType.Goods)

                    transaction.Commit()

                Catch ex As Exception
                    transaction.SetNonSqlException(ex)
                    Throw
                End Try

            End Using

            MarkNew()

        End Sub

        Private Sub AddWithGeneralParams(ByRef myComm As SQLCommand)

            myComm.AddParam("?AA", _Name.Trim)
            myComm.AddParam("?AB", _MeasureUnit.Trim)
            myComm.AddParam("?AG", CRound(_DefaultVatRateSales))
            myComm.AddParam("?AH", CRound(_DefaultVatRatePurchase))
            myComm.AddParam("?AK", Utilities.ConvertDatabaseID(_TradedType))
            myComm.AddParam("?AL", _InternalCode.Trim)
            myComm.AddParam("?AM", _Barcode.Trim)
            myComm.AddParam("?AN", ConvertDbBoolean(_IsObsolete))
            If Not _Group Is Nothing AndAlso Not _Group.IsEmpty Then
                myComm.AddParam("?AO", _Group.ID)
            Else
                myComm.AddParam("?AO", 0)
            End If
            If Not _DefaultWarehouse Is Nothing AndAlso Not _DefaultWarehouse.IsEmpty Then
                myComm.AddParam("?AQ", _DefaultWarehouse.ID)
            Else
                myComm.AddParam("?AQ", 0)
            End If

            myComm.AddParam("?AP", CRound(_RegionalPrices.GetPriceSaleBaseCurrency, ROUNDUNITINVOICEMADE))
            myComm.AddParam("?AR", CRound(_RegionalPrices.GetPricePurchaseBaseCurrency, ROUNDUNITINVOICERECEIVED))
            myComm.AddParam("?AT", _AccountSalesIncome)
            If _DeclarationSchemaSales = VatDeclarationSchemaInfo.Empty Then
                myComm.AddParam("?AU", 0)
            Else
                myComm.AddParam("?AU", _DeclarationSchemaSales.ID)
            End If
            If _DeclarationSchemaPurchase = VatDeclarationSchemaInfo.Empty Then
                myComm.AddParam("?AV", 0)
            Else
                myComm.AddParam("?AV", _DeclarationSchemaPurchase.ID)
            End If

            _UpdateDate = GetCurrentTimeStamp()
            If Me.IsNew Then _InsertDate = _UpdateDate
            myComm.AddParam("?AZ", _UpdateDate.ToUniversalTime)

        End Sub

        Private Sub AddWithMethodsParams(ByRef myComm As SQLCommand)
            myComm.AddParam("?AI", Utilities.ConvertDatabaseID(_AccountingMethod))
            myComm.AddParam("?AJ", Utilities.ConvertDatabaseID(_DefaultValuationMethod))
        End Sub

        Private Sub AddWithAccountsParams(ByRef myComm As SQLCommand)
            myComm.AddParam("?AC", _AccountSalesNetCosts)
            myComm.AddParam("?AD", _AccountPurchases)
            myComm.AddParam("?AE", _AccountDiscounts)
        End Sub


        Private Shared Sub CheckIfNameUnique(ByVal id As Integer, ByVal name As String, _
            ByVal group As GoodsGroupInfo)

            Dim myComm As New SQLCommand("IsGoodsItemNameUnique")
            myComm.AddParam("?IO", id)
            myComm.AddParam("?NM", name)
            If group Is Nothing OrElse group.IsEmpty Then
                myComm.AddParam("?GR", 0)
            Else
                myComm.AddParam("?GR", group.ID)
            End If

            Using myData As DataTable = myComm.Fetch
                If myData.Rows.Count > 0 AndAlso CIntSafe(myData.Rows(0).Item(0), 0) > 0 Then
                    Throw New Exception(My.Resources.Goods_GoodsItem_NameNotUniqueWithinGroup)
                End If
            End Using

        End Sub

        Private Sub CheckIfUpdateDateChanged()

            Dim myComm As New SQLCommand("CheckIfGoodsItemUpdateDateChanged")
            myComm.AddParam("?CD", _ID)

            Using myData As DataTable = myComm.Fetch

                If myData.Rows.Count < 1 OrElse CDateTimeSafe(myData.Rows(0).Item(0), _
                    Date.MinValue) = Date.MinValue Then

                    Throw New Exception(String.Format(My.Resources.Common_ObjectNotFound, _
                        My.Resources.Goods_GoodsItem_TypeName, _ID.ToString))

                End If

                If CTimeStampSafe(myData.Rows(0).Item(0)) <> _UpdateDate Then

                    Throw New Exception(My.Resources.Common_UpdateDateHasChanged)

                End If

                _IsInUse = ConvertDbBoolean(CIntSafe(myData.Rows(0).Item(1), 0))
                _PriceCutsExist = ConvertDbBoolean(CIntSafe(myData.Rows(0).Item(2), 0))

            End Using

        End Sub

        Private Shared Sub CheckIfAnyOperationExists(ByVal nID As Integer)

            Dim myComm As New SQLCommand("CheckIfAnyGoodsOperationsExist")
            myComm.AddParam("?CD", nID)

            Using myData As DataTable = myComm.Fetch
                If myData.Rows.Count > 0 AndAlso CIntSafe(myData.Rows(0).Item(0), 0) > 0 Then
                    Throw New Exception(My.Resources.Goods_GoodsItem_InvalidDelete)
                End If
            End Using

        End Sub

#End Region

    End Class

End Namespace