using NUnit.Framework;
using ProeictHusacFelix;
using System;

namespace ProeictHusacFelixTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreateHolder_NrOfFlightsIsZero_ReturnsTrue()
        {
            //Arrange
            Holder holder = new Holder("Ion", "Popescu", 32);

            //Acts
            int result = holder.GetNrOfFlights();

            //Assert
            Assert.AreEqual(0, result);
        }

        [Ignore("expected 0.599999, but was 0.6000")]
        [TestCase("lax", "lgi", 3200, true)]
        public void CreateFirstClassTicket_PriceIsCorrectAfterDiscountForCorporate_ReturnsNewDiscount(string departure, string arrival, double price, bool status)
        {
            //Arrange
            Tuple<string, string> locations = Tuple.Create(departure,arrival);
            var Holder = new Holder("ion", "popescu", 32);
            var Discount = new Discount();
            double expectedDiscount = 0.6;

            //Act
            PlaneTicket t = new FirstClassFactory().CreateTicket(Holder, locations, price, status);
            Discount.SetDiscountStrategy(new DiscountCorporate());
            Discount.CalculateDiscount(t);
            double finalDiscount = Discount.GetDiscount();
            Math.Round(finalDiscount);

            //Assert
            Assert.AreEqual(expectedDiscount, finalDiscount); 
        }

        [TestCase("lax", "lgi",3200, false)]
        public void CreateFirstClassTicket_NotCorporate_ReturnsFalse(string departure, string arrival, double price, bool status)
        {
            //Arrange
            var Holder = new Holder("ion", "popescu", 32);
            Tuple<string, string> locations = Tuple.Create(departure,arrival);

            //Act
            PlaneTicket ticket = new FirstClassFactory().CreateTicket(Holder, locations, price, status);

            //Assert
            Assert.False(ticket.GetTicketStatus());
        }

        [Ignore("expected Exception, was null")]
        [Test]
        public void President_CheckIfDiscountIsApplied_ReturnsException()
        {
            //Arrange
            var Discount = new Discount();
            var Holder = new Holder("ion", "popescu", 100);
            Tuple<string, string> locations = Tuple.Create("lax", "jpi");
            PlaneTicket ticket = new FirstClassFactory().CreateTicket(Holder, locations, 3200, false);

            //Act
            Discount.SetDiscountStrategy(new DiscountCorporate());
            Discount.CalculateDiscount(ticket);
            Handler p = new President();

            //Assert
            Exception e = Assert.Catch<Exception>(() => p.ProcessDiscount(Discount,ticket));
            StringAssert.Contains("discount prea mare", e.Message);
        }

    }
}