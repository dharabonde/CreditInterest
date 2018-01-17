using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreditCardInterestRate;

namespace UnitTestCardInterest
{
    [TestClass]
    public class UnitTestCase2
    {
        private CreditCardInterestRate.DiscoverCard discover = new CreditCardInterestRate.DiscoverCard(100);
        private CreditCardInterestRate.Visa visa = new CreditCardInterestRate.Visa(100);
        private CreditCardInterestRate.MasterCard masterCard = new CreditCardInterestRate.MasterCard(100);

        [TestMethod]
        public void TestPersonInterest()
        {
            CreditCardInterestRate.CreditCards[] cardArr1 = { discover, visa };
            CreditCardInterestRate.CreditCards[] cardArr2 = { masterCard };

            CreditCardInterestRate.Wallet wallet1 = new CreditCardInterestRate.Wallet(cardArr1);
            CreditCardInterestRate.Wallet wallet2 = new CreditCardInterestRate.Wallet(cardArr2);
            CreditCardInterestRate.Wallet[] walArr = { wallet1, wallet2 };

            CreditCardInterestRate.Persons person = new CreditCardInterestRate.Persons(walArr);

            Assert.AreEqual(16, person.getPersonInterest());
        }

        [TestMethod]
        public void TestWallet_1_Interest()
        {
            CreditCardInterestRate.CreditCards[] cardArr = { discover, visa };
            CreditCardInterestRate.Wallet wallet = new CreditCardInterestRate.Wallet(cardArr);
            Assert.AreEqual(11.0, wallet.getWalletInterest());
        }

        [TestMethod]
        public void TestWallet_2_Interest()
        {
            CreditCardInterestRate.CreditCards[] cardArr = { masterCard };
            CreditCardInterestRate.Wallet wallet = new CreditCardInterestRate.Wallet(cardArr);
            Assert.AreEqual(5.0, wallet.getWalletInterest());
        }
    }
}
