using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardInterestRate
{
    public class Wallet
    {
        private double interest = 0;

        public Wallet(CreditCards[] card)
        {
            calWalletInterest(card);
        }

        public void calWalletInterest(CreditCards[] card)
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
