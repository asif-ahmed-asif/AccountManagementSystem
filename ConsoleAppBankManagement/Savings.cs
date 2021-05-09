using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppBankManagement
{
    internal class Savings : Account
    {
        internal Savings(string name, OpeningDate myDate, ClientAddress address, double balance) : base(name, myDate, address, balance) { }
        internal override string Id
        {

            set { base.Id = "S" + value; }
        }

        internal override void Deposit(double amount) 
        {
            this.Balance = this.Balance + amount;
           
        }
        internal override void Withdraw(double amount) 
        {
            double balance = this.Balance;
            if( amount <= 2000 && amount <= balance )
            {
                this.Balance = balance - amount;
            
            }
        }
    }
}
