namespace MovieRental
{
    public class Movie
    {
        public const int CHILDRENS = 2;
        public const int NEW_RELEASE = 1;
        public const int REGULAR = 0;

        public string Title { get; }

        public int PriceCode { get; }

        public Movie(string title, int priceCode)
        {
            Title = title;
            PriceCode = priceCode;
        }

        
    }
}
