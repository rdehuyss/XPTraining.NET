using System;
using System.Xml;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flight.Tests
{
    [TestClass]
    public class FlightTest
    {
        [TestMethod]
        public void TestAddPassengerToFlight()
        {
            var flight = new Flight(150);
            flight.AddPassenger("Michael Jackson");

            flight.NumberOfPassengers().Should().Be(1);
            flight.IsPassengerOnFlight("Michael Jackson").Should().BeTrue();
        }

        [TestMethod]
        public void TestCanNotAddPassengerToFullyBookedFlight()
        {
            var flight = new Flight(1);
            flight.AddPassenger("Michael Jackson");

            Action act = () => flight.AddPassenger("Jannete Jackson");
            act.ShouldThrow<FlightFullyBookedException>();
        }
    }
}