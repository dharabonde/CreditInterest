using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCardInterest
{
    [TestClass]
    public class UnitTestCase3
    {
        private CreditCardInterestRate.Visa visa1 = new CreditCardInterestRate.Visa(100);
        private CreditCardInterestRate.Visa visa2 = new CreditCardInterestRate.Visa(100);
        private CreditCardInterestRate.MasterCard masterCard1 = new CreditCardInterestRate.MasterCard(100);
        private CreditCardInterestRate.MasterCard masterCard2 = new CreditCardInterestRate.MasterCard(100);

        [TestMethod]
        public void TestPerson_1_Interest()
        {
            CreditCardInterestRate.CreditCards[] cardArr = { visa1, masterCard1 };

            CreditCardInterestRate.Wallet wallet = new CreditCardInterestRate.Wallet(cardArr);
            CreditCardInterestRate.Wallet[] walArr = { wallet };

            CreditCardInterestRate.Persons person = new CreditCardInterestRate.Persons(walArr);
            Assert.AreEqual(15, person.getPersonInterest());
        }

        [TestMethod]
        public void TestWallet_1_Interest()
        {
            CreditCardInterestRate.CreditCards[] cardArr = { visa1, masterCard1 };
            CreditCardInterestRate.Wallet wallet = new CreditCardInterestRate.Wallet(cardArr);
            Assert.AreEqual(15, wallet.getWalletInterest());
        }

        [TestMethod]
        public void TestPerson_2_Interest()
        {
            CreditCardInterestRate.CreditCards[] cardArr = { visa2, masterCard2 };

            CreditCardInterestRate.Wallet wallet = new CreditCardInterestRate.Wallet(cardArr);
            CreditCardInterestRate.Wallet[] walArr = { wallet };

            CreditCardInterestRate.Persons person = new CreditCardInterestRate.Persons(walArr);
            Assert.AreEqual(15, person.getPersonInterest());
        }

        [TestMethod]
        public void TestWallet_2_Interest()
        {
            CreditCardInterestRate.CreditCards[] cardArr = { visa2, masterCard2 };
            CreditCardInterestRate.Wallet wallet = new CreditCardInterestRate.Wallet(cardArr);
            Assert.AreEqual(15, wallet.getWalletInterest());
        }
    }
}
