using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCard card1 = new CreditCard(100, 0.01, "Discover");       
            CreditCard card2 = new CreditCard(100, 0.1, "Visa");
            CreditCard card3 = new CreditCard(100, 0.05, "MasterCard");
            
            CreditCard[] cardArr = { card1, card2, card3 };
           
            Wallet wallet = new Wallet(cardArr);
            Wallet[] walArr = { wallet };
            Persons person = new Persons(walArr);

            Console.WriteLine("Wallet Interest:"+ wallet.getWalletInterest());
            Console.WriteLine("Person Interest:" + person.getPersonInterest());
            Console.WriteLine("Visa Interest:" + card2.getInterest());
            Console.WriteLine("MasterCard Interest:" + card3.getInterest());
            Console.WriteLine("Discover Interest:" + card1.getInterest());

            Console.ReadLine();
        }
    }
}
