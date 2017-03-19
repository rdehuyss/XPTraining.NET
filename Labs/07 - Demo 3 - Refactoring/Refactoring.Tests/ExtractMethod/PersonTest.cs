using NUnit.Framework;
using Refactoring.ExtractMethod;

namespace Refactoring.Tests.ExtractMethod
{
    [TestFixture]
    public class PersonTest
    {
        
        [Test]
        public void TestPrintOwing()
        {
            var person = new Person("Bert");

            var result = person.PrintOwing(8.0);

            Assert.AreEqual("Person has: name: Bert, amount: 8", result);
        }
    }
}