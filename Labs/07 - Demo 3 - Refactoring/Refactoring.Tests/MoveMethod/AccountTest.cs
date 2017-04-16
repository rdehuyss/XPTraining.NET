using Xunit;
using FluentAssertions;
using Refactoring.MoveMethod;

namespace Refactoring.Tests.MoveMethod
{
    public class AccountTest
    {

        [Fact]
        public void OverdraftCharge()
        {
            var account = new Account(new AccountType(false), 20);
            var result = account.Bankcharge();
            result.Should().Be(39.5);
        }

        [Fact]
        public void OverdraftChargeForPremiumAccountIs10()
        {
            var account = new Account(new AccountType(true), 5);
            var result = account.Bankcharge();
            result.Should().Be(14.5);
        }

        [Fact]
        public void OverdraftChargeForPremiumAccountIsHigherIfDaysOverdrawnBiggerThanOneWeek()
        {
            var account = new Account(new AccountType(true), 20);

            var result = account.Bankcharge();
            result.Should().Be(27.5);
        }
    }
}