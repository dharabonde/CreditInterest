using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCardInterest
{
    [TestClass]
    public class UnitTestCase2
    {
        CreditCardInterest.CreditCard card1 = new CreditCardInterest.CreditCard(100, 0.01, "Discover");
        CreditCardInterest.CreditCard card2 = new CreditCardInterest.CreditCard(100, 0.1, "Visa");
        CreditCardInterest.CreditCard card3 = new CreditCardInterest.CreditCard(100, 0.05, "MasterCard");
        [TestMethod]
        public void TestPersonInterest()
        {
            CreditCardInterest.CreditCard[] cardArr1 = { card1, card2};
            CreditCardInterest.CreditCard[] cardArr2 = { card3};

            CreditCardInterest.Wallet wallet1 = new CreditCardInterest.Wallet(cardArr1);
            CreditCardInterest.Wallet wallet2 = new CreditCardInterest.Wallet(cardArr2);
            CreditCardInterest.Wallet[] walArr = { wallet1, wallet2 };

            CreditCardInterest.Persons person = new CreditCardInterest.Persons(walArr);

            Assert.AreEqual(16, person.getPersonInterest());
        }

        [TestMethod]
        public void TestWallet_1_Interest()
        {
            CreditCardInterest.CreditCard[] cardArr = { card1, card2 };
            CreditCardInterest.Wallet wallet = new CreditCardInterest.Wallet(cardArr);
            Assert.AreEqual(11.0, wallet.getWalletInterest());
        }

        [TestMethod]
        public void TestWallet_2_Interest()
        {
            CreditCardInterest.CreditCard[] cardArr = { card3};
            CreditCardInterest.Wallet wallet = new CreditCardInterest.Wallet(cardArr);
            Assert.AreEqual(5.0, wallet.getWalletInterest());
        }
    }
}
