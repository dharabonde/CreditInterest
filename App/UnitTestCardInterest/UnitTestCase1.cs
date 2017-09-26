using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using CreditCardInterest;

namespace UnitTestCardInterest
{
    [TestClass]
    public class UnitTestCase1
    {
        CreditCardInterest.CreditCard card1 = new CreditCardInterest.CreditCard(100, 0.01, "Discover");
        CreditCardInterest.CreditCard card2 = new CreditCardInterest.CreditCard(100, 0.1, "Visa");
        CreditCardInterest.CreditCard card3 = new CreditCardInterest.CreditCard(100, 0.05, "MasterCard");

        [TestMethod]
        public void TestPersonInterest()
        {
            CreditCardInterest.CreditCard[] cardArr = { card1, card2, card3 };
           
            CreditCardInterest.Wallet wallet = new CreditCardInterest.Wallet(cardArr);
            CreditCardInterest.Wallet[] walArr = { wallet };
            
            CreditCardInterest.Persons person = new CreditCardInterest.Persons(walArr);

            Assert.AreEqual(16.0, person.getPersonInterest());
            
        }
        [TestMethod]
        public void TestDiscoverInterest()
        {
            Assert.AreEqual(1.0, card1.getInterest());
        }
        [TestMethod]
        public void TestVisaInterest()
        {
            Assert.AreEqual(10.0, card2.getInterest());
        }
        [TestMethod]
        public void TestMasterCardInterest()
        {
            Assert.AreEqual(5.0, card3.getInterest());
        }  
    }
}
