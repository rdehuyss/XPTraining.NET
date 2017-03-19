using System;

namespace Refactoring.ReplaceTypeWithStrategy
{
    public class Employee
    {
        public const int ENGINEER = 0;
        public const int SALESMAN = 1;
        public const int MANAGER = 2;

        public int Type { get; }

        public int MonthlySalary { get; set; }

        public  int Commision { get; set; }

        public int Bonus { get; set; }


        public Employee(int type)
        {
            Type = type;
        }

        public int PayAmount()
        {
            switch (Type)
            {
                case ENGINEER:
                    return MonthlySalary;
                case SALESMAN:
                    return MonthlySalary + Commision;
                case MANAGER:
                    return MonthlySalary + Bonus;
                default:
                    throw new Exception("Incorrect Employee");
            }
        }

        public string BusinessCardPaperQuality()
        {
            switch (Type)
            {
                case ENGINEER:
                    return "recycled";
                case SALESMAN:
                    return "high quality white";
                case MANAGER:
                    return "superb quality with shiny finish";
                default:
                    throw new Exception("Incorrect Employee");
            }
        }
        
    }
}