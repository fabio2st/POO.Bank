using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesCs
{
    public class SavingAccount : Account
    {
        //constructor no se hereda, si no se especifica se invoca base()
        public SavingAccount(Customer customer, int number, decimal saldo) : base(customer, number, saldo)  
        {
        }
        public static decimal MonthlyInterestRate { get; set; }
        public void DepositMonthlyInterest()
        {
            Deposit(Balance * MonthlyInterestRate); // Metodo heredado
        }

        public override void Withdraw(decimal value)
        {
            if (Balance < value)
                throw new ArgumentException("Sin monto suficiente");
            balance -= value;
        }
    }
}