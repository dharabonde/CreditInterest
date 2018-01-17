using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardInterestRate
{
    class Program
    {
        static void Main(string[] args)
        {
            DiscoverCard discover = new DiscoverCard(100);
            Visa visa = new Visa(100);
            MasterCard masterCard = new MasterCard(100);

            CreditCards[] cardArr = { visa, masterCard };
            Wallet wallet = new Wallet(cardArr);
            Wallet[] walArr = { wallet };
            Persons person = new Persons(walArr);
            Console.WriteLine("Person Interest:" + person.getPersonInterest());
            Console.WriteLine("Wallet Interest:" + wallet.getWalletInterest());

            Console.ReadLine();
        }
    }
}
