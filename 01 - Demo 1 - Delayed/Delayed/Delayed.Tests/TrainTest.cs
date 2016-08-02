using System;
using FluentAssertions;
using NUnit.Framework;

namespace Delayed.Tests
{
    [TestFixture]
    public class TrainTest
    {
        [Test]
        public void GetCustomerSatisfaction_0HoursDelay_ReturnsNiceNRolling()
        {
            new Train(0).GetCustomerSatisfaction().Should().Be("Nice 'n' Rolling");
        }

        [Test]
        public void GetCustomerSatisfaction_1HoursDelay_ReturnsJustAnotherDayAtTheTrain()
        {
            new Train(1).GetCustomerSatisfaction().Should().Be("Just another day at the train");
        }

        [Test]
        public void GetCustomerSatisfaction_1Comma5HoursDelay_ReturnsJustAnotherDayAtTheTrain()
        {
            new Train(1.5).GetCustomerSatisfaction().Should().Be("We now support doubles");
        }

        [Test]
        public void GetCustomerSatisfaction_2HoursDelay_ReturnsJustAnotherDayAtTheTrain()
        {
            new Train(2).GetCustomerSatisfaction().Should().Be("This train is annoying me");
        }

        [Test]
        public void GetCustomerSatisfaction_3HoursDelay_ReturnsJustAnotherDayAtTheTrain()
        {
            new Train(3).GetCustomerSatisfaction().Should().Be("B-u-u-urn it!");
        }

        [Test]
        public void GetCustomerSatisfaction_MoreThan3HoursDelay_ThrowsException()
        {
            Assert.Throws<Exception>(() => new Train(4).GetCustomerSatisfaction());
            Assert.Throws<Exception>(() => new Train(5).GetCustomerSatisfaction());
        }
    }

    
}
