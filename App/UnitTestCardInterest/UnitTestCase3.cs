using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCardInterest
{
    [TestClass]
    public class UnitTestCase3
    {
        CreditCardInterest.CreditCard card1 = new CreditCardInterest.CreditCard(100, 0.1, "Visa");
        CreditCardInterest.CreditCard card2 = new CreditCardInterest.CreditCard(100, 0.05, "MasterCard");
        CreditCardInterest.CreditCard card3 = new CreditCardInterest.CreditCard(100, 0.1, "Visa");
        CreditCardInterest.CreditCard card4 = new CreditCardInterest.CreditCard(100, 0.05, "MasterCard");

        [TestMethod]
        public void TestPerson_1_Interest()
        {
            CreditCardInterest.CreditCard[] cardArr = { card1, card2 };
           
            CreditCardInterest.Wallet wallet = new CreditCardInterest.Wallet(cardArr);
            CreditCardInterest.Wallet[] walArr = { wallet};

            CreditCardInterest.Persons person = new CreditCardInterest.Persons(walArr);
            Assert.AreEqual(15, person.getPersonInterest());
        }

        [TestMethod]
        public void TestWallet_1_Interest()
        {
            CreditCardInterest.CreditCard[] cardArr = { card1, card2 };
            CreditCardInterest.Wallet wallet = new CreditCardInterest.Wallet(cardArr);
            Assert.AreEqual(15, wallet.getWalletInterest());
        }

        [TestMethod]
        public void TestPerson_2_Interest()
        {
            CreditCardInterest.CreditCard[] cardArr = { card3, card4 };

            CreditCardInterest.Wallet wallet = new CreditCardInterest.Wallet(cardArr);
            CreditCardInterest.Wallet[] walArr = { wallet };

            CreditCardInterest.Persons person = new CreditCardInterest.Persons(walArr);
            Assert.AreEqual(15, person.getPersonInterest());
        }

        [TestMethod]
        public void TestWallet_2_Interest()
        {
            CreditCardInterest.CreditCard[] cardArr = { card3, card4 };
            CreditCardInterest.Wallet wallet = new CreditCardInterest.Wallet(cardArr);
            Assert.AreEqual(15, wallet.getWalletInterest());
        }
    }
}
