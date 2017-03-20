using System;
using NUnit.Framework;

namespace VampireSlayer.Tests
{
    [TestFixture]
    public class HunterTest
    {
        [Test]
        public void CanHunt_DayTime_CannotHunt()
        {
            Hunter hunter = new Hunter();

            Assert.IsFalse(hunter.CanHunt(new DateTime(2017, 1, 1, 18, 0, 0)));
        }

        [Test]
        public void CanHunt_NightTime_CanHunt()
        {
            Hunter hunter = new Hunter();

            Assert.IsTrue(hunter.CanHunt(new DateTime(2017, 1, 1, 4, 0, 0)));
        }
        
    }
}
