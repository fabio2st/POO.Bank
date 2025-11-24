Public Class CheckingAccount
    Inherits Account
	Private _OverdraftAmount As String
    Public Sub New(customer As Customer, number As Integer, balance As Decimal, overdraftAmount As String)
        MyBase.New(customer, number, balance)
        Me.OverdraftAmount = overdraftAmount
    End Sub
    Public Property OverdraftAmount() As String
        Get
            Return _OverdraftAmount
        End Get
        Set(ByVal value As String)
            _OverdraftAmount = value
        End Set
    End Property
    Public Overrides Sub Withdraw(value As Decimal)
        If isBalanceAvailable(value) Then
            _balance -= value
        End If
    End Sub
    Private Function isBalanceAvailable(amount As Decimal) As Boolean
        Return Balance >= amount - OverdraftAmount
    End Function
    Public Overrides Function ToString() As String
        Return "Current Account: " & Number
    End Function
End Class
