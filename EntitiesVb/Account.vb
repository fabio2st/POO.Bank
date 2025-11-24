Public MustInherit Class Account
    Private _number As Integer
    Protected _balance As Decimal

    Public Sub New(customer As Customer, number As Integer, balance As Decimal)
        MyBase.New()
        _Enabled = True
        Me.Number = number
		_balance = balance
		Me.Customer = customer
	End Sub
    Public Property Number As Integer
        Get
            Return _number
        End Get
        Set(value As Integer)
            If value > 9999 Then
                _number = value
            End If
        End Set
    End Property
    Public ReadOnly Property Balance As Decimal
        Get
            Return _balance
        End Get
    End Property
    Private _customer As Customer
    Public Property Customer As Customer
        Get
            Return _customer
        End Get
		'Friend Set(value As Customer)
		Set(value As Customer)
			value.AddAccount(Me)
			_customer = value
        End Set
    End Property
    Public Property Enabled As Boolean
    Public Sub Deposit(value As Decimal)
        _balance += value
    End Sub

    Public MustOverride Sub Withdraw(value As Decimal)

    Public Overrides Function ToString() As String
        Return "Account " & Number
    End Function
End Class
