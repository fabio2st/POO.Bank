Imports System.Collections.Generic

Namespace EntitiesCs
	Public Class Bank
		Private customers As List(Of Customer)

		Public Sub New()
			customers = New List(Of Customer)()
		End Sub
		Public ReadOnly Property CustomerCounter As Integer
			Get
				Return customers.Count
			End Get
		End Property
		' agrega un cliente al banco
		Public Sub AddCustomer(customer As Customer)
			customers.Add(customer)
		End Sub
		' devuelve todos los clientes
		Public Function GetCustomers() As List(Of Customer)
			Return customers
		End Function
		' devuelve todos los clientes que coincida el nombre
		Public Function GetCustomers(name As String) As List(Of Customer)
			Return customers.FindAll(Function(c) c.Name.Contains(name))
		End Function
		' devuelve el ciente segun su id
		Public Function GetCustomer(id As Integer) As Customer
			Return customers.Find(Function(c) c.Id = id)
		End Function
		' elimina un cliente
		Public Sub RemoveCliente(customer As Customer)
			customers.Remove(customer)
		End Sub
		' informa el numero de clientes
	End Class
End Namespace
