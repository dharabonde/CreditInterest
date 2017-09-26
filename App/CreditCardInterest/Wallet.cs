using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CreditCardInterest
{
    public class Wallet
    {
        //public CreditCard[] card;
        public double interest=0;
        public Wallet(CreditCard[] card)
        {
            calInterest(card);
        }
        
        ////public void addCard(CreditCard[] card)
        ////{
        ////   this.card = card; 
        ////}

        public void calInterest(CreditCard[] card)
        {
            for (int i = 0; i < card.Length; i++)
            {
                this.interest += card[i].getInterest();
            }
            setWalletInterest(interest);
        }

        public void setWalletInterest(double interest)
        {
            this.interest = interest;
        }
        public double getWalletInterest()
        {
            return this.interest;
        }
    }
}
