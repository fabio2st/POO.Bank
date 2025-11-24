using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesCs
{
    public class CheckingAccount : Account
    {
        public CheckingAccount(Customer customer,int number, decimal balance, decimal overdraftAmount) : base(customer, number, balance)
        {
            OverdraftAmount = overdraftAmount;
        }
        public decimal OverdraftAmount { get; set; }    // monto de sobregiro

        public override void Withdraw(decimal value)
        {
            if (isBalanceAvailable(value)) // validación
                balance -= value; 
        }

        private bool isBalanceAvailable(decimal amount)
        {
            return Balance + OverdraftAmount >= amount;
        }
    }
}
