using System;
using NUnit.Framework;
using Refactoring.ReplaceTypeWithStrategy;

namespace Refactoring.Tests.ReplaceTypeWithStrategy
{
    [TestFixture]
    public class EmployeeTest
    {
        private const int BONUS = 560;
        private const int COMMISSION = 200;
        private const int MONTHLY_SALARY = 3500;

        [Test]
        public void EngineerPayAmountIsMonthlySalary()
        {
            var employee = CreateEmployee(Employee.ENGINEER);

            var result = employee.PayAmount();
            Assert.AreEqual(MONTHLY_SALARY, result);
        }

        [Test]
        public void SalesmanPayAmountIsMonthlySalaryPlusCommision()
        {
            var employee = CreateEmployee(Employee.SALESMAN);

            var result = employee.PayAmount();
            Assert.AreEqual(MONTHLY_SALARY + COMMISSION, result);
        }

        [Test]
        public void ManagerPayAmountIsMonthlySalaryPlusBonus()
        {
            var employee = CreateEmployee(Employee.MANAGER);

            var result = employee.PayAmount();
            Assert.AreEqual(MONTHLY_SALARY + BONUS, result);
        }

        [Test]
        public void EngineerBusinessCardPaperQuality()
        {
            var employee = CreateEmployee(Employee.ENGINEER);

            var result = employee.BusinessCardPaperQuality();
            Assert.AreEqual("recycled", result);
        }

        [Test]
        public void SalesmanBusinessCardPaperQuality()
        {
            var employee = CreateEmployee(Employee.SALESMAN);

            var result = employee.BusinessCardPaperQuality();
            Assert.AreEqual("high quality white", result);
        }

        [Test]
        public void ManagerBusinessCardPaperQuality()
        {
            var employee = CreateEmployee(Employee.MANAGER);

            var result = employee.BusinessCardPaperQuality();
            Assert.AreEqual("superb quality with shiny finish", result);
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