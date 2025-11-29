using System;
using System.Collections;
using EntitiesCs;

namespace TestEntitiesCs
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCustomerAccounts();
		}
        static void TestBankCustomers()
		{
			Customer customer1;
			customer1 = new Customer("Papo", 98765432, new DateTime(1990, 5, 23));   // inicialización
			// Miembro de clase
            Bank.AddCustomer(customer1);
            Bank.AddCustomer(new Customer("Ana", 12345678, new DateTime(1985, 8, 15)));
            Bank.AddCustomer(new Customer("Luis", 87654321, new DateTime(1992, 12, 3)));
            Console.WriteLine("Numero de clientes en el banco: " + Bank.CustomerCounter);
            foreach (Customer customer in Bank.GetCustomers())
            {
                ShowCustomer(customer);
                Console.WriteLine();
			}

			SavingAccount account2 = new SavingAccount(customer1, 12346, 20000);

			Console.WriteLine("Saldo cuenta de ahorro antes de interes: " + account2.Balance);
            SavingAccount.MonthlyInterestRate = 0.1m;
            account2.DepositMonthlyInterest();
            Console.WriteLine("Saldo cuenta de ahorro despues de interes: " + account2.Balance);
        }
        
        static void TestCustomerAccounts() 
        {
    		Customer customer1;
			customer1 = new Customer("Papo", 98765432, new DateTime(1990, 5, 23));   // inicialización

            try
            {
                new CheckingAccount(customer1, 1, 10000, 10000);
            }
            catch (ArgumentException ex)
            {
				Console.WriteLine("Error: " + ex.Message);
            }

            CheckingAccount account1 = new CheckingAccount(customer1, 12345, 10000, 5000);
            SavingAccount account2 = new SavingAccount(customer1, 12346, 20000);

            //customer1.AddAccount(account1);
            //customer1.AddAccount(account2);

            DisplayAccounts(customer1);

            customer1.RemoveAccount(account1);
            DisplayAccounts(customer1);
        }

		private static void DisplayAccounts(Customer customer1)
		{
			foreach (var account in customer1.GetAccounts())
			{
				Console.WriteLine("Cuenta numero: " + account.Number + " Saldo: " + account.Balance);
			}
		}

		//private static void CheckingAccountTest()
  //      {
  //          CheckingAccount account1 = new CheckingAccount(12345,10000,5000);
  //          //account1.Number = 123; // falla por la regla establecida
  //          //account1.Number = 12345;
  //          //account1.OverdraftAmount = 5000;
  //          //account1.Saldo = 1000; No se puede asignar porque es de solo lectura
  //          Console.WriteLine("Numero: " + account1.Number);
  //          Console.WriteLine("Saldo: " + account1.Balance);
  //          Console.WriteLine("Monto de sobregiro: " + account1.OverdraftAmount);
  //          account1.Withdraw(3000);
  //          Console.WriteLine("Saldo: " + account1.Balance);
  //          account1.Deposit(2500);
  //          Console.WriteLine("Saldo: " + account1.Balance);
  //          account1.Deposit(2000);
  //          Console.WriteLine("Saldo: " + account1.Balance);
  //      }
  //      private static void SavingAccountTest()
  //      {
  //          SavingAccount account1 = new SavingAccount(12345,10000,0.10m);
  //          account1.Number = 123; // falla por la regla establecida
  //          account1.Number = 12345;
  //          account1.MonthlyInterestRate = 0.1m;
  //          //account1.Saldo = 1000; No se puede asignar porque es de solo lectura
  //          Console.WriteLine("Numero: " + account1.Number);
  //          Console.WriteLine("Saldo: " + account1.Balance);
  //          Console.WriteLine("Tasa de interes mensual: " + account1.MonthlyInterestRate);
  //          account1.Withdraw(3000);
  //          account1.DepositMonthlyInterest();
  //          Console.WriteLine("Saldo capitalizado: " + account1.Balance);
  //          Console.WriteLine("Saldo: " + account1.Balance);
  //          account1.Deposit(2500);
  //          Console.WriteLine("Saldo: " + account1.Balance);
  //          account1.Deposit(2000);
  //          Console.WriteLine("Saldo: " + account1.Balance);
  //      }        
        //private static void AccountTest()
        //{
        //    Account account1 = new Account();
        //    account1.Number = 123; // falla por la regla establecida
        //    account1.Number = 12345;
        //    //account1.Saldo = 1000; No se puede asignar porque es de solo lectura
        //    Console.WriteLine("Numero: " + account1.Number);
        //    Console.WriteLine("Saldo: " + account1.Balance);
        //    account1.Withdraw(3000);
        //    Console.WriteLine("Saldo: " + account1.Balance);
        //    account1.Deposit(2500);
        //    Console.WriteLine("Saldo: " + account1.Balance);
        //    account1.Deposit(2000);
        //    Console.WriteLine("Saldo: " + account1.Balance);
        //    Account account2 = new Account(23456, 10000);
        //    Console.WriteLine("Numero: " + account2.Number);
        //    Console.WriteLine("Saldo: " + account2.Balance);
        //}
        private static void ShowCustomer(Customer customer)
        {
            Console.WriteLine("Nombre: " + customer.Name);
            Console.WriteLine("Documento: " + customer.Id);
            Console.WriteLine("Fecha de nacimiento: " + customer.BirthDay);
        }
    }
}
