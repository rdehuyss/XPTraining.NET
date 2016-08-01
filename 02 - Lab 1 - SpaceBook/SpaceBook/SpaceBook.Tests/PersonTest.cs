using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace SpaceBook.Tests
{
    [TestFixture]
    public class PersonTest
    {
        [Test]
        public void Person_givenUsername_thenPersonCreated()
        {
            Person person = new Person("randomUsername");

            person.Should().NotBeNull();
        }
    }
}
