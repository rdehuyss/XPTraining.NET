
using NUnit.Framework;
using Refactoring.DecomposeConditional;

namespace Refactoring.Tests.DecomposeConditional
{
    [TestFixture]
    public class TireChangeTest
    {
        private const int SUMMERRATE = 20;
        private const int WINTERSERVICECHARGE = 15;
        private const int WINTERRATE = 10;
        private const int QUANTITY = 2;
        private TireChange tireChange;

        [SetUp]
        public void SetUp()
        {
            tireChange = new TireChange(QUANTITY, WINTERRATE, WINTERSERVICECHARGE, SUMMERRATE);
        }

        [TestCase(1, QUANTITY * WINTERRATE + WINTERSERVICECHARGE)]
        [TestCase(2, QUANTITY * WINTERRATE + WINTERSERVICECHARGE)]
        [TestCase(3, QUANTITY * SUMMERRATE)]
        [TestCase(4, QUANTITY * SUMMERRATE)]
        [TestCase(5, QUANTITY * SUMMERRATE)]
        [TestCase(6, QUANTITY * SUMMERRATE)]
        [TestCase(7, QUANTITY * SUMMERRATE)]
        [TestCase(8, QUANTITY * SUMMERRATE)]
        [TestCase(9, QUANTITY * SUMMERRATE)]
        [TestCase(10, QUANTITY * SUMMERRATE)]
        [TestCase(11, QUANTITY * SUMMERRATE)]
        [TestCase(12, QUANTITY * WINTERRATE + WINTERSERVICECHARGE)]
        public void TireCharge(int month, int expectedResult)
        {
            var charge = tireChange.Charge(month);
            Assert.AreEqual(expectedResult, charge);
        }
        
    }
}