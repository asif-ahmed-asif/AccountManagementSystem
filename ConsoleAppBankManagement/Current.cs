using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppAccount
{
    internal class Current : Account
    {
        internal Current(string name, OpeningDate myDate, ClientAddress address, double balance) : base(name, myDate, address, balance) { }
        internal override string Id
        {

            set { base.Id = "C" + value; }
        }

        internal override void Deposit(double amount)
        {
            double balance = this.Balance;
            if( amount >= 500)
            {
                this.Balance = balance + amount;
             
            }  
            
        }
        internal override void Withdraw(double amount)
        {
            double balance = this.Balance;
            if (amount <= 5000 && amount <= balance)
            {
                this.Balance = balance - amount;
                
            }
        }
    }
}
