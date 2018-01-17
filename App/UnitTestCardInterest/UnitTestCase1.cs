using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreditCardInterest;

namespace UnitTestCardInterest
{
    [TestClass]
    public class UnitTestCase1
    {        
        private CreditCardInterest.DiscoverCard discover=new CreditCardInterest.DiscoverCard(100); 
        private CreditCardInterest.Visa visa= new CreditCardInterest.Visa(100);
        private CreditCardInterest.MasterCard masterCard = new CreditCardInterest.MasterCard(100);                                                   
        
        [TestMethod]
        public void TestPersonInterest()
        {
            CreditCardInterest.CreditCards[] cards = { discover, visa, masterCard };
            CreditCardInterest.Wallet wallet = new CreditCardInterest.Wallet(cards);
            CreditCardInterest.Wallet[] walArr = { wallet };
            
            CreditCardInterest.Persons person = new CreditCardInterest.Persons(walArr);

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
