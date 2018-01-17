using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardInterestRate
{
    public class Persons
    {
        private double interest = 0;
        public Persons(Wallet[] wallet)
        {
            calPersonInterest(wallet);
        }

        public void calPersonInterest(Wallet[] wallet)
        {
            for (int i = 0; i < wallet.Length; i++)
            {
                this.interest += wallet[i].getWalletInterest();
            }
            setPersonInterest(interest);
        }
        public void setPersonInterest(double interest)
        {
            this.interest = interest;
        }
        public double getPersonInterest()
        {
            return this.interest;
        }
    }
}
