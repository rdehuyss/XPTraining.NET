using NUnit.Framework;
using Refactoring.MoveMethod;

namespace Refactoring.Tests.MoveMethod
{
    [TestFixture]
    public class AccountTest
    {

        [Test]
        public void OverdraftCharge()
        {
            var account = new Account(new AccountType(false), 20);
            var result = account.Bankcharge();
            Assert.AreEqual(39.5, result, 0.0);
        }

        [Test]
        public void OverdraftChargeForPremiumAccountIs10()
        {
            var account = new Account(new AccountType(true), 5);
            var result = account.Bankcharge();
            Assert.AreEqual(14.5, result, 0.0);
        }

        [Test]
        public void OverdraftChargeForPremiumAccountIsHigherIfDaysOverdrawnBiggerThanOneWeek()
        {
            var account = new Account(new AccountType(true), 20);

            var result = account.Bankcharge();
            Assert.AreEqual(27.5, result, 0.0);
        }
    }
}