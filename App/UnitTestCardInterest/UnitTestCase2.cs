using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCardInterest
{
    [TestClass]
    public class UnitTestCase2
    {        
        private CreditCardInterest.DiscoverCard discover = new CreditCardInterest.DiscoverCard(100);
        private CreditCardInterest.Visa visa = new CreditCardInterest.Visa(100);
        private CreditCardInterest.MasterCard masterCard = new CreditCardInterest.MasterCard(100);                                                   
        
        [TestMethod]
        public void TestPersonInterest()
        {
            CreditCardInterest.CreditCards[] cardArr1 = { discover, visa };
            CreditCardInterest.CreditCards[] cardArr2 = { masterCard };

            CreditCardInterest.Wallet wallet1 = new CreditCardInterest.Wallet(cardArr1);
            CreditCardInterest.Wallet wallet2 = new CreditCardInterest.Wallet(cardArr2);
            CreditCardInterest.Wallet[] walArr = { wallet1, wallet2 };

            CreditCardInterest.Persons person = new CreditCardInterest.Persons(walArr);

            Assert.AreEqual(16, person.getPersonInterest());
        }

        [TestMethod]
        public void TestWallet_1_Interest()
        {
            CreditCardInterest.CreditCards[] cardArr = { discover, visa };
            CreditCardInterest.Wallet wallet = new CreditCardInterest.Wallet(cardArr);
            Assert.AreEqual(11.0, wallet.getWalletInterest());
        }

        [TestMethod]
        public void TestWallet_2_Interest()
        {
            CreditCardInterest.CreditCards[] cardArr = { masterCard};
            CreditCardInterest.Wallet wallet = new CreditCardInterest.Wallet(cardArr);
            Assert.AreEqual(5.0, wallet.getWalletInterest());
        }
    }
}
