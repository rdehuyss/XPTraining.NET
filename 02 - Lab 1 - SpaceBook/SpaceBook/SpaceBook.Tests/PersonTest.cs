using System;
using FluentAssertions;
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

        [Test]
        public void Person_givenNullUsername_thenException()
        {
            Action act = () => new Person(null);

            act.ShouldThrow<ArgumentNullException>();
        }

        [Test]
        public void Person_givenEmptyUsername_thenException()
        {
            Action act = () => new Person(String.Empty);

            act.ShouldThrow<ArgumentNullException>();
        }

        [Test]
        public void Person_givenUsernameWithOnlySpaces_thenException()
        {
            Action act = () => new Person("      ");

            act.ShouldThrow<ArgumentNullException>();
        }

        [Test]
        public void Person_CanBecomeFriend_thenBiDirectionalRelationship()
        {
            var person1 = new Person("person1");
            var person2 = new Person("person2");

            person1.BecomeFriendWith(person2);

            person1.Friends.Should().Contain(person2);
            person2.Friends.Should().Contain(person1);
        }

        [Test]
        public void Person_CanBecomeFriend_CannotAddSelf()
        {
            var person = new Person("person1");

            Action act = () => person.BecomeFriendWith(person);

            act.ShouldThrow<ArgumentException>();
        }

        [Test]
        public void Person_ReceiveMessage_CannotAddSelf()
        {
            var person = new Person("person1");

            Action act = () => person.BecomeFriendWith(person);

            act.ShouldThrow<ArgumentException>();
        }
    }
}
