using Xunit;
using FluentAssertions;
using Refactoring.ReplaceTypeWithStrategy;

namespace Refactoring.Tests.ReplaceTypeWithStrategy
{
    public class EmployeeTest
    {
        private const int BONUS = 560;
        private const int COMMISSION = 200;
        private const int MONTHLY_SALARY = 3500;

        [Fact]
        public void EngineerPayAmountIsMonthlySalary()
        {
            var employee = CreateEmployee(Employee.ENGINEER);

            var result = employee.PayAmount();
            result.Should().Be(MONTHLY_SALARY);
        }

        [Fact]
        public void SalesmanPayAmountIsMonthlySalaryPlusCommision()
        {
            var employee = CreateEmployee(Employee.SALESMAN);

            var result = employee.PayAmount();
            result.Should().Be(MONTHLY_SALARY + COMMISSION);
        }

        [Fact]
        public void ManagerPayAmountIsMonthlySalaryPlusBonus()
        {
            var employee = CreateEmployee(Employee.MANAGER);

            var result = employee.PayAmount();
            result.Should().Be(MONTHLY_SALARY + BONUS);
        }

        [Fact]
        public void EngineerBusinessCardPaperQuality()
        {
            var employee = CreateEmployee(Employee.ENGINEER);

            var result = employee.BusinessCardPaperQuality();
            result.Should().Be("recycled");
        }

        [Fact]
        public void SalesmanBusinessCardPaperQuality()
        {
            var employee = CreateEmployee(Employee.SALESMAN);

            var result = employee.BusinessCardPaperQuality();
            result.Should().Be("high quality white");
        }

        [Fact]
        public void ManagerBusinessCardPaperQuality()
        {
            var employee = CreateEmployee(Employee.MANAGER);

            var result = employee.BusinessCardPaperQuality();
            result.Should().Be("superb quality with shiny finish");
        }

        private Employee CreateEmployee(int employeeType)
        {
            return new Employee(employeeType)
            {
                MonthlySalary = MONTHLY_SALARY,
                Commision = COMMISSION,
                Bonus = BONUS
            };
        }
    }
}