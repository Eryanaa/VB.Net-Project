Imports MySql.Data.MySqlClient
Module OrderSession

    Public ReadOnly ConnStr As String = "Server=localhost;Port=3306;Database=clothing_store_db;Uid=root;Pwd=;"

    Public CurrentCustomerId As Integer = 0
    Public CustomerName As String = ""
    Public CustomerContact As String = ""

    Public CurrentOrderId As Integer = 0
    Public Structure OrderItem
        Public ProductName As String
        Public Price As Decimal
        Public Quantity As Integer
        Public Size As String
        Public Subtotal As Decimal
    End Structure

    Public SelectedItems As New List(Of OrderItem)()
    Public ProductsSubtotal As Decimal = 0D

    Public Const FEE_PACKAGING As Decimal = 5D
    Public Const FEE_EXPRESS As Decimal = 10D

    Public AppliedPromoCode As String = ""
    Public DiscountAmount As Decimal = 0D
    Public ServiceFee As Decimal = 0D
    Public FinalTotal As Decimal = 0D

    Public Sub ResetOrderSession()
        CurrentCustomerId = 0
        CustomerName = ""
        CustomerContact = ""
        CurrentOrderId = 0
        SelectedItems.Clear()
        ProductsSubtotal = 0D
        AppliedPromoCode = ""
        DiscountAmount = 0D
        ServiceFee = 0D
        FinalTotal = 0D
    End Sub

End Module
