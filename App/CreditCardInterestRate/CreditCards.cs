using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardInterestRate
{
    public interface CreditCards
    {
        double getInterest();
        void setInterest();
        double getBalance();
        void setBalance(double balance);
        double getInterestRate();
    }
}
