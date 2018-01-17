using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardInterest
{
    public class MasterCard : CreditCards
    {
        private static readonly double interestRate = 0.05;
        private double interest;
        private double balance;

        public MasterCard(double balance)
        {
            setBalance(balance);
            setInterest();
        }

        public double getInterest()
        {
            return this.interest;
        }

        public void setInterest()
        {
            this.interest = this.balance * interestRate;
        }

        public double getBalance()
        {
            return this.balance;
        }

        public void setBalance(double balance)
        {
            this.balance = balance;
        }

        public double getInterestRate()
        {
            return interestRate;
        }
    }
}
