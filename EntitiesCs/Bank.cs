using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesCs
{
    public class Bank
    {
        private static List<Customer> customers;

        static Bank()
        {
            customers = new List<Customer>();
        }
        // agerga un cliente al banko
        public static void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        // devuelve todos los clientes
        public static List<Customer> GetCustomers()
        {
            return customers;
        }
        // devuelve todos los clientes que coincida el nombre
        public static List<Customer> GetCustomers(string name)
        {
            //return customers.FindAll(c => c.Name.Contains( name.ToUpper()));
            //Es equivalente al siguiente codigo
            List<Customer> customersFiltered = new List<Customer>();
            foreach (Customer customer in customers)
            {
                if (customer.Name.Contains(name.ToUpper()))
                    customersFiltered.Add(customer);
            }
            return customersFiltered;
        }
        // devuelve el ciente segun su id
        public static Customer GetCustomer(int id)
        {
            return customers.Find(c => c.Id == id);
        }
        // elimina un cliente
        public static void RemoveCliente(Customer customer)
        {
            customers.Remove(customer);
        }
        // informa el numero de clientes
        public static int CustomerCounter
        {
            get => customers.Count;
        }
    }
}
