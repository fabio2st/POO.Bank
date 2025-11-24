Public Class SavingAccount
    Inherits Account    ' esta clase dispone de todos los miembre de Account

    Private _MonthlyInterestRate As Decimal
    Public Sub New(customer As Customer, number As Integer, balance As Decimal, monthlyInterestRate As Decimal)
        MyBase.New(customer, number, balance)   ' constructor no se hereda, si no se especifica se invoca New()
        _MonthlyInterestRate = monthlyInterestRate
    End Sub
    Public Property MonthlyInterestRate() As Decimal
        Get
            Return _MonthlyInterestRate
        End Get
        Set(ByVal value As Decimal)
            _MonthlyInterestRate = value
        End Set
    End Property
    Public Sub DepositMonthlyInterest()
        Deposit(Balance * MonthlyInterestRate)  'Metodo heredado, reuso la funcionalidad con fin que coincide con el requerimiento
    End Sub

    Public Overrides Sub Withdraw(value As Decimal)
        If Balance >= value Then
            _balance -= value
        End If
    End Sub
End Class