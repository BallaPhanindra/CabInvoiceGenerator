using NUnit.Framework;
using CabInvoiceGenerator;

namespace TestProject1
{
    public class Tests
    {
        InvoiceGenerator invoiceGenerator_PREMIUM = null;
        InvoiceGenerator invoiceGenerator_NORMAL = null;


        [SetUp]
        public void Setup()
        {
            invoiceGenerator_PREMIUM = new InvoiceGenerator(RideType.PREMIUM);
            invoiceGenerator_NORMAL = new InvoiceGenerator(RideType.NORMAL);
        }

        //Testing fare for Premium Ride
        [Test]
        public void GivenDistanceAndTimeShouldReturnTotalFareForPREMIUM_Ride()
        {
            double distance = 10.0;
            int time = 10;

            double fare_PREMIUM = invoiceGenerator_PREMIUM.CalculateFare(15.0, 15); //Premium Ride
            double expected_PREMIUM = 215;

            Assert.AreEqual(expected_PREMIUM, fare_PREMIUM); // for Premium Ride
        }
        //Testing fare for Normal Ride
        [Test]
        public void GivenDistanceAndTimeShouldReturnTotalFareForNORMAL_Ride()
        {
            double distance = 10.0;
            int time = 10;

            double fare_NORMAL = invoiceGenerator_NORMAL.CalculateFare(10.0, 10); //Normal Ride
            double expected_Normal = 125;

            Assert.AreEqual(expected_Normal, fare_NORMAL); // for Normal Ride
        }
    }
}