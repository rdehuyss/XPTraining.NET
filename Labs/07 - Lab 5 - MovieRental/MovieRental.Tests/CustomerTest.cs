using NUnit.Framework;

namespace MovieRental.Tests
{
    [TestFixture]
    public class CustomerTest
    {
        [Test]
        public void Name_ReturnsNameOfCustomer()
        {
            var c = new Customer("David");
            Assert.AreEqual("David", c.Name);
        }

        [Test]
        public void RegularMovie_ReturnsCorrectStatement()
        {
            var customer2 = new Customer("Sallie");
            var movie1 = new Movie("Gone with the Wind", Movie.REGULAR);
            var rental1 = new Rental(movie1, 3); // 3 day rental
            customer2.AddRental(rental1);
            var expected = "Rental Record for Sallie\n" +
                                "\tGone with the Wind\t3.5\n" +
                                "Amount owed is 3.5\n" +
                                "You earned 1 frequent renter points";
            var statement = customer2.Statement();
            Assert.AreEqual(expected, statement);
        }

        [Test]
        public void NewReleaseMovie_ReturnsCorrectStatement()
        {
            var customer2 = new Customer("Sallie");
            var movie1 = new Movie("Star Wars", Movie.NEW_RELEASE);
            var rental1 = new Rental(movie1, 3); // 3 day rental
            customer2.AddRental(rental1);
            var expected = "Rental Record for Sallie\n" +
                                "\tStar Wars\t9.0\n" +
                                "Amount owed is 9.0\n" +
                                "You earned 2 frequent renter points";
            var statement = customer2.Statement();
            Assert.AreEqual(expected, statement);
        }

        [Test]
        public void ChildrensMovie_ReturnsCorrectStatement()
        {
            var customer2 = new Customer("Sallie");
            var movie1 = new Movie("Madagascar", Movie.CHILDRENS);
            var rental1 = new Rental(movie1, 3); // 3 day rental
            customer2.AddRental(rental1);
            var expected = "Rental Record for Sallie\n" +
                                "\tMadagascar\t1.5\n" +
                                "Amount owed is 1.5\n" +
                                "You earned 1 frequent renter points";
            var statement = customer2.Statement();
            Assert.AreEqual(expected, statement);
        }

        [Test]
        public void ManyMovies_ReturnsCorrectStatement()
        {
            var customer1 = new Customer("David");
            var movie1 = new Movie("Madagascar", Movie.CHILDRENS);
            var rental1 = new Rental(movie1, 6); // 6 day rental
            var movie2 = new Movie("Star Wars", Movie.NEW_RELEASE);
            var rental2 = new Rental(movie2, 2); // 2 day rental
            var movie3 = new Movie("Gone with the Wind", Movie.REGULAR);
            var rental3 = new Rental(movie3, 8); // 8 day rental
            customer1.AddRental(rental1);
            customer1.AddRental(rental2);
            customer1.AddRental(rental3);
            var expected = "Rental Record for David\n" +
                                "\tMadagascar\t6.0\n" +
                                "\tStar Wars\t6.0\n" +
                                "\tGone with the Wind\t11.0\n" +
                                "Amount owed is 23.0\n" +
                                "You earned 4 frequent renter points";
            var statement = customer1.Statement();
            Assert.AreEqual(expected, statement);
        }
    }
}
