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
    }
}
