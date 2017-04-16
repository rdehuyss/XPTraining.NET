using System;
using Xunit;
using FluentAssertions;

namespace VampireSlayer.Tests
{
    public class HunterTest
    {
        [Fact]
        public void CanHunt_DayTime_CannotHunt()
        {
            Hunter hunter = new Hunter();
            hunter.CanHunt(new DateTime(2017, 1, 1, 18, 0, 0)).Should().BeFalse();
        }

        [Fact]
        public void CanHunt_NightTime_CanHunt()
        {
            Hunter hunter = new Hunter();

            hunter.CanHunt(new DateTime(2017, 1, 1, 4, 0, 0)).Should().BeTrue();
        }
        
    }
}
