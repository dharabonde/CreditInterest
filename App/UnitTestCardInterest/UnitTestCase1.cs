﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreditCardInterestRate;

namespace UnitTestCardInterest
{
    [TestClass]
    public class UnitTestCase1
    {
        private CreditCardInterestRate.DiscoverCard discover = new CreditCardInterestRate.DiscoverCard(100);
        private CreditCardInterestRate.Visa visa = new CreditCardInterestRate.Visa(100);
        private CreditCardInterestRate.MasterCard masterCard = new CreditCardInterestRate.MasterCard(100);

        [TestMethod]
        public void TestPersonInterest()
        {
            CreditCardInterestRate.CreditCards[] cards = { discover, visa, masterCard };
            CreditCardInterestRate.Wallet wallet = new CreditCardInterestRate.Wallet(cards);
            CreditCardInterestRate.Wallet[] walArr = { wallet };

            CreditCardInterestRate.Persons person = new CreditCardInterestRate.Persons(walArr);

            Assert.AreEqual(16.0, person.getPersonInterest());
        }

        [TestMethod]
        public void TestDiscoverInterest()
        {
            Assert.AreEqual(1.0, discover.getInterest());
        }

        [TestMethod]
        public void TestVisaInterest()
        {
            Assert.AreEqual(10.0, visa.getInterest());
        }

        [TestMethod]
        public void TestMasterCardInterest()
        {
            Assert.AreEqual(5.0, masterCard.getInterest());
        }  
    }
}
