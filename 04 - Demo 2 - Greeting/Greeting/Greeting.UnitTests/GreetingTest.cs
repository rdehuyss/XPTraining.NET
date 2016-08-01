using NUnit.Framework;
using System;
using FluentAssertions;


namespace Cegeka.Education.Greeting.UnitTests
{
    

    [TestFixture]
    public class GreetingTest
    {
        [Test]
        public void GetGreeting_Morning_ReturnsCorrectValue()
        {
            ITimeSupplier timeSupplier = new TimeSupplierStub(new DateTime(2014, 5, 22, 6, 0, 0));

            Greeting greetingSut = new Greeting(timeSupplier);

            greetingSut.GetGreeting().Should().Be("Good Morning");
        }

        [Test]
        public void GetGreeting_AfterNoon_ReturnsCorrectValue()
        {
            ITimeSupplier timeSupplier = new TimeSupplierStub(new DateTime(2014, 5, 22, 14, 0, 0));

            Greeting greetingSut = new Greeting(timeSupplier);

            greetingSut.GetGreeting().Should().Be("Good Afternoon");
        }
    }
}
