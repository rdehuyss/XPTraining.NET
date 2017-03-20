using System.Collections.Generic;
using System.Globalization;

namespace MovieRental
{
    public class Customer
    {
        private readonly List<Rental> _rentals = new List<Rental>();
        public string Name { get; }


        public Customer(string name)
        {
            Name = name;
        }

        public void AddRental(Rental arg)
        {
            _rentals.Add(arg);
        }


        public string Statement()
        {
            double totalAmount = 0;
            var frequentRenterPoints = 0;
            var result = "Rental Record for " + Name + "\n";

            foreach (var each in _rentals)
            {
                double thisAmount = 0;

                // determine amounts for each line
                switch (each.Movie.PriceCode)
                {
                    case Movie.REGULAR:
                        {
                            thisAmount += 2;
                            if (each.DaysRented > 2)
                            {
                                thisAmount += (each.DaysRented - 2) * 1.5;
                            }

                            break;
                        }
                    case Movie.NEW_RELEASE:
                        {
                            thisAmount += each.DaysRented * 3;
                            break;
                        }
                    case Movie.CHILDRENS:
                        {
                            thisAmount += 1.5;
                            if (each.DaysRented > 3)
                            {
                                thisAmount += (each.DaysRented - 3) * 1.5;
                            }

                            break;
                        }
                }

                // add frequent renter points
                frequentRenterPoints++;

                // add bonus for a two day new release rental
                if ((each.Movie.PriceCode == Movie.NEW_RELEASE) && each.DaysRented > 1)
                {
                    frequentRenterPoints++;
                }

                // show figures for this rental
                result += "\t" + each.Movie.Title + "\t" + thisAmount.ToString("0.0", CultureInfo.InvariantCulture) + "\n";
                totalAmount += thisAmount;
            }

            // add footer lines
            result += "Amount owed is " + totalAmount.ToString("0.0", CultureInfo.InvariantCulture) + "\n";
            result += "You earned " + frequentRenterPoints + " frequent renter points";

            return result;
        }
    }
}
