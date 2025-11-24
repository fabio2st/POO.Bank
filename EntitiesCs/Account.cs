using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesCs
{
    public abstract class Account
    {
        private int number;
        protected decimal balance;  // permite acceder a este campo en las subclases
		private Customer customer;

		public Account(Customer customer, int number, decimal balance)    // encadena  el constructor sin parámetros
        {
            Enabled = true;
            Number = number;
            this.balance = balance;
            Customer = customer;
		}
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                if (value > 9999)   // regla para aceptar el valor
                    number = value;
            }
        }
		public Customer Customer
		{
			get => customer;
            //internal set
			set
			{
                value.AddAccount(this);
				customer = value;
			}
		}
		public decimal Balance { get => balance; }
        public bool Enabled { get; set; }
        public abstract void Withdraw(decimal value); //Extracción
        public void Deposit(decimal value)  // metodo virtual permite ser sobreescrito
        {
            balance += value;
        }
    }
}