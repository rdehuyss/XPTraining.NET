using FluentAssertions;
using NUnit.Framework;

namespace VampireSlayer.UnitTests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestFixture]
    public class HunterTests
    {
        private Hunter _classUnderTest;

        [SetUp]
        public void CreateHunter()
        {
            _classUnderTest = new Hunter();
        }

        [Test]
        public void CanHunt_DayTime_CannotHunt()
        {
            var huntingTime = new DateTime(2014, 5, 14, 18, 0, 0);

            _classUnderTest.CanHunt(huntingTime).Should().BeFalse();
        }
        
        [TestMethod]
        public void CanHunt_NightTime_CanHunt()
        {
            var huntingTime = new DateTime(2014, 5, 14, 4, 0, 0);

            _classUnderTest.CanHunt(huntingTime).Should().BeTrue();
        }
    }
}
