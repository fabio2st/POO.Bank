using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesCs
{
    public class SavingAccount : Account
    {
        //constructor no se hereda, si no se especifica se invoca base()
        public SavingAccount(Customer customer, int number, decimal saldo, decimal monthlyInterestRate) : base(customer, number, saldo)  
        {
            MonthlyInterestRate = monthlyInterestRate;
        }
        public decimal MonthlyInterestRate { get; set; }
        public void DepositMonthlyInterest()
        {
            Withdraw(Balance * MonthlyInterestRate); // Metodo heredado
        }

        public override void Withdraw(decimal value)
        {
            if (Balance < value)
                throw new ArgumentException("Sin monto suficiente");
            balance -= value;
        }
    }
}