Imports System.Threading

Public Class Customer
    Private accounts As List(Of Account)
    Public Sub New()
        'Me.Name = ""
        'Me.id = 0
        'BirthDay = Nothing
        accounts = New List(Of Account)()
    End Sub
    Public Sub New(name As String, id As Integer)
        Me.New()
        Me.Name = name
        Me.Id = id
    End Sub
    Public Sub New(name As String, id As Integer, birthDay As Date)
        Me.New(name, id)
        Me.BirthDay = birthDay
    End Sub
    ' Campo, este forma parte de la implementación privada
    Private _name As String
    ' Propiedad, forma parte de la interfaz pública
    Public Property Name As String
        ' Metodo Getter es para obtener el valor
        Get
            Return _name
        End Get
        ' Método Setter es para asignar el valor
        Set(value As String)
            ' aqui se pueden hacer validaciones
            _name = value.ToUpper()
        End Set
    End Property

    Private _id As Integer
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Private _birthDay As Date
    Public Property BirthDay As Date
        Get
            Return _birthDay
        End Get
        Set(value As Date)
            _birthDay = value
        End Set
    End Property
    ' Propiedad autoimplementada
    Public Property Nationality As String
    Public Overrides Function ToString() As String
        Return Name
    End Function

    'Public Sub AddAccount(account As Account)
    Friend Sub AddAccount(account As Account)
        'account.Customer = Me
        accounts.Add(account)
    End Sub
    Public Function GetAccounts() As List(Of Account)
        Return accounts
    End Function
    Public Sub RemoveAccount(account As Account)
        account.Customer = Nothing
        accounts.Remove(account)
    End Sub
End Class
