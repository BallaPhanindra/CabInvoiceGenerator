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
            double distance = 15.0;
            int time = 15;

            double fare_PREMIUM = invoiceGenerator_PREMIUM.CalculateFare(distance
                , time); //Premium Ride
            double expected_PREMIUM = 255;

            Assert.AreEqual(expected_PREMIUM, fare_PREMIUM); // for Premium Ride
        }
        //Testing fare for Normal Ride
        [Test]
        public void GivenDistanceAndTimeShouldReturnTotalFareForNORMAL_Ride()
        {
            double distance = 15.0;
            int time = 15;

            double fare_NORMAL = invoiceGenerator_NORMAL.CalculateFare(distance, time); //Normal Ride
            double expected_Normal = 165;

            Assert.AreEqual(expected_Normal, fare_NORMAL); // for Normal Ride
        }
    }
}