using System;

namespace CabInvoiceGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Generator");

            InvoiceGenerator invoiceGenerator_PREMIUM = new InvoiceGenerator(RideType.PREMIUM);
            InvoiceGenerator invoiceGenerator_NORMAL = new InvoiceGenerator(RideType.NORMAL);


            double fare_PREMIUM = invoiceGenerator_PREMIUM.CalculateFare(10.0, 10); //Premium Ride
            double fare_NORMAL = invoiceGenerator_NORMAL.CalculateFare(10.0, 10); //Normal Ride


            Console.WriteLine("\nThe Total Fare for Premium Ride is Rs.{0}", fare_PREMIUM);
            Console.WriteLine("\nThe Total Fare for Normal Ride is Rs.{0}", fare_NORMAL);
        }
    }
}