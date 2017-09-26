using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardInterest
{
    public class Persons 
    {
       // public Wallet[] wallet;
        public double interest=0;
        public Persons(Wallet[] wallet)
        {
            calInterest(wallet);
        }
        //public void addWallet(Wallet[] wallet)
        //{
        //    this.wallet = wallet;
        //}
        public void calInterest(Wallet[] wallet)
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
