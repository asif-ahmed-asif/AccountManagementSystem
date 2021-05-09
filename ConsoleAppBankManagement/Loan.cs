using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppBankManagement
{
    internal class Loan : Account
    {
        internal Loan(string name, OpeningDate myDate, ClientAddress address, double balance) : base(name, myDate, address, balance) { }
        internal override string Id
        {
            
            set { base.Id = "L"+value ; }
        }

        internal override void Deposit(double amount)
        {
            this.Balance = (this.Balance - 50) + amount;
            
        }
        internal override void Withdraw(double amount)
        {
            double balance = this.Balance;
            if (amount <= (balance - 50))
            {
                this.Balance = (balance - 50) - amount;
                
            }
        }

    }
}
