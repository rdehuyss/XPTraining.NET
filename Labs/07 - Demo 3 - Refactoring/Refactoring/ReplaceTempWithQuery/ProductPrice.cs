namespace Refactoring.ReplaceTempWithQuery
{
    public class ProductPrice
    {
        private double _quantity;
        private double _itemPrice;

        public ProductPrice(double quantity, double itemPrice)
        {
            _quantity = quantity;
            _itemPrice = itemPrice;
        }

        public double GetPrice()
        {
            double basePrice = _quantity * _itemPrice;
            double discountFactor;
            if (basePrice > 1000)
                discountFactor = 0.95;
            else
                discountFactor = 0.98;
            return basePrice * discountFactor;
        }

    }
}