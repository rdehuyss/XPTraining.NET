namespace MovieRental
{
    using System.Collections.Generic;
    using System.Globalization;

    public class Customer
    {
        private readonly List<Rental> _rentals = new List<Rental>();

        public Customer(string name)
        {
            Name = name;
        }

        public void AddRental(Rental arg)
        {
            _rentals.Add(arg);
        }

        public string Name
        {
            get;
            private set;
        }

        public string Statement()
        {
            double totalAmount = 0;
            int frequentRenterPoints = 0;
            string result = "Rental Record for " + Name + "\n";

            foreach (Rental each in _rentals)
            {
                double thisAmount = 0;

                // determine amounts for each line
                switch (each.Movie.PriceCode)
                {
                    case Movie.Regular:
                        {
                            thisAmount += 2;
                            if (each.DaysRented > 2)
                            {
                                thisAmount += (each.DaysRented - 2) * 1.5;
                            }

                            break;
                        }
                    case Movie.NewRelease:
                        {
                            thisAmount += each.DaysRented * 3;
                            break;
                        }
                    case Movie.Childrens:
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
                if ((each.Movie.PriceCode == Movie.NewRelease) && each.DaysRented > 1)
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
