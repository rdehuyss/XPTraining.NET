using System;
using System.Text;

namespace Refactoring.ExtractMethod
{
    public class Person
    {
        private string _name;

        public Person(string name)
        {
            _name = name;
        }

        public string PrintOwing(double amount)
        {
            var builder = new StringBuilder();
            printBanner(builder);

            //		print details
            builder.Append("name: " + _name);
            builder.Append(", amount: " + amount);

            return builder.ToString();
        }

        private void printBanner(StringBuilder builder)
        {
            builder.Append("Person has: ");
        }
    }
}