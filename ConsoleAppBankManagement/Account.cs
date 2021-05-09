using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppBankManagement
{
    internal struct OpeningDate
    {
        private byte myDay;
        private byte myMonth;
        private ushort myYear;

        internal OpeningDate(byte myDay, byte myMonth, ushort myYear)
        {
            if (myDay >= 1 && myDay <= 31 && myMonth>= 1 && myMonth <= 12 && myYear>=2010)
            {
                this.myDay = myDay;
                this.myMonth = myMonth;
                this.myYear = myYear;
            }
            else
            {
                this.myDay = 1;
                this.myMonth = 1;
                this.myYear = 1000;
            }

        }
        internal void ShowOpeningDate()
        {
            Console.WriteLine("Account Opening  Date : {0}/ {1}/ {2}", this.myDay, this.myMonth, this.myYear);
        }
    }

    internal struct ClientAddress
    {
        private byte apartmentNo;
        private byte roadNo;
        private string district;
        private string country;

        internal ClientAddress(byte apartmentNo, byte roadNo, string district, string country)
        {
            this.apartmentNo = apartmentNo;
            this.roadNo = roadNo;
            this.district = district;
            this.country = country;
        }

        internal void ShowAddress()
        {
            Console.WriteLine("Client's Address Info: ");
            Console.WriteLine("Apartment no: {0}", this.apartmentNo);
            Console.WriteLine("Road no: {0}", this.roadNo);
            Console.WriteLine("District: {0}", this.district);
            Console.WriteLine("Country: {0}", this.country);

        }
    }
    internal class Account
    {
        private static int serialNo = 1000;
        private string id;
        private string name;
        private OpeningDate myDate;
        private ClientAddress address;
        private double balance;

        internal Account(string name, OpeningDate myDate, ClientAddress address, double balance)
        {
            this.Id = (++serialNo).ToString();
            this.Name = name;
            this.MyDate = myDate;
            this.Address = address;
            this.Balance = balance;
        }

        internal virtual string Id
        {
            get { return this.id; }
            set
            {
                this.id = "A" + value;
            }
        }

        internal string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        internal OpeningDate MyDate
        {
            get { return this.myDate; }
            set { this.myDate = value; }
        }

        internal ClientAddress Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        internal double Balance
        {
            get { return this.balance; }
            set 
            {
                if (value >= 0)
                {
                    this.balance = value;
                }
                else
                {
                    this.balance = -1;
                }
            }
        }

        internal virtual void Deposit(double amount) { }
        internal virtual void Withdraw(double amount) { }

        internal void ShowInfo()
        {
            Console.WriteLine("Account's Full Informations: ");
            Console.WriteLine("ID: {0}", this.Id);
            Console.WriteLine("Name: {0}", this.Name);
            this.MyDate.ShowOpeningDate();
            this.Address.ShowAddress();
            Console.WriteLine("Balance: {0}", this.Balance);

        }

    }
}
