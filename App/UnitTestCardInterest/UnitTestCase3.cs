using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCardInterest
{
    [TestClass]
    public class UnitTestCase3
    {
        private CreditCardInterest.Visa visa1 = new CreditCardInterest.Visa(100);
        private CreditCardInterest.Visa visa2 = new CreditCardInterest.Visa(100);
        private CreditCardInterest.MasterCard masterCard1 = new CreditCardInterest.MasterCard(100);
        private CreditCardInterest.MasterCard masterCard2 = new CreditCardInterest.MasterCard(100);        

        [TestMethod]
        public void TestPerson_1_Interest()
        {
            CreditCardInterest.CreditCards[] cardArr = { visa1, masterCard1 };
           
            CreditCardInterest.Wallet wallet = new CreditCardInterest.Wallet(cardArr);
            CreditCardInterest.Wallet[] walArr = { wallet};

            CreditCardInterest.Persons person = new CreditCardInterest.Persons(walArr);
            Assert.AreEqual(15, person.getPersonInterest());
        }

        [TestMethod]
        public void TestWallet_1_Interest()
        {
            CreditCardInterest.CreditCards[] cardArr = { visa1, masterCard1 };
            CreditCardInterest.Wallet wallet = new CreditCardInterest.Wallet(cardArr);
            Assert.AreEqual(15, wallet.getWalletInterest());
        } 

        [TestMethod]
        public void TestPerson_2_Interest()
        {
            CreditCardInterest.CreditCards[] cardArr = { visa2, masterCard2 };

            CreditCardInterest.Wallet wallet = new CreditCardInterest.Wallet(cardArr);
            CreditCardInterest.Wallet[] walArr = { wallet };

            CreditCardInterest.Persons person = new CreditCardInterest.Persons(walArr);
            Assert.AreEqual(15, person.getPersonInterest());
        }

        [TestMethod]
        public void TestWallet_2_Interest()
        {
            CreditCardInterest.CreditCards[] cardArr = { visa2, masterCard2 };
            CreditCardInterest.Wallet wallet = new CreditCardInterest.Wallet(cardArr);
            Assert.AreEqual(15, wallet.getWalletInterest());
        }
    }
}
