using Xunit;
using FluentAssertions;
using Refactoring.RenameMethod;

namespace Refactoring.Tests.RenameMethod
{
    public class PersonTest
    {
        private const string OFFICE_NUMBER = "154689";
        private const string OFFICE_AREA_CODE = "016";

        [Fact]
        public void GetTelephoneNumber()
        {
            Person person = new Person(OFFICE_AREA_CODE, OFFICE_NUMBER);

            var result = person.TelephoneNumber;
            result.Should().Be("(" + OFFICE_AREA_CODE + ") " + OFFICE_NUMBER);
        }
    }
}