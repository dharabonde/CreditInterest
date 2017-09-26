using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardInterest
{
    public class CreditCard
    {
        private double interest;
        private double balance;
        private string cardName;
        public CreditCard(double balance, double interestRate, string cardName)
        {
            setBalance(balance);
            setInterest(interestRate, balance);
            setCardName(cardName);
        }

        //private CreditCard()
        //{
        //    // TODO: Complete member initialization
        //}

        public void setCardName(string cardName)
        {
            this.cardName = cardName;
        }
        public string getCardName()
        {
            return this.cardName;
        }
        public void setInterest(double interestRate, double balance)
        {
            this.interest = balance * interestRate;
        }
        public double getInterest()
        {
            return this.interest;
        }
        public void setBalance(double balance)
        {
            this.balance = balance;
        }
        public double getBalance()
        {
            return this.balance;
        }

       //////////////////////////////////////////////////
       // public abstract double getPercentRate();
       /* public abstract double getBalance();
        public abstract void  setBalance(double balance);
        public abstract double getInterest();
        public abstract void setInterest();*/


        //private double interest;
        //private double balance;
        //public double Interest
        //{
        //    get
        //    {
        //        return interest;
        //    }
        //    set
        //    {
        //        this.interest = value;
        //    }
        //}
        //public double Balance
        //{
        //    set
        //    {
        //        this.balance = value;
        //    }
        //    get
        //    {
        //        return balance;
        //    }
        //}
       
    }
}
