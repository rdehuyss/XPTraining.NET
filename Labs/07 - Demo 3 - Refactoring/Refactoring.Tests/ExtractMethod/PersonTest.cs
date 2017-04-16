using Xunit;
using FluentAssertions;
using Refactoring.ExtractMethod;

namespace Refactoring.Tests.ExtractMethod
{
    public class PersonTest
    {
        
        [Fact]
        public void TestPrintOwing()
        {
            var person = new Person("Bert");

            var result = person.PrintOwing(8.0);

            result.Should().Be("Person has: name: Bert, amount: 8");
        }
    }
}