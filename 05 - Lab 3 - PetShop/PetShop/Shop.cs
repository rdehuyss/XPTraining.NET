namespace PetShop
{
    using System.Collections.Generic;

    public class Shop
    {
        private readonly List<string> _items = new List<string>();

        public void AddItem(string item)
        {
            _items.Add(item);
        }

        public IEnumerable<string> GetItemsInStock()
        {
            return _items;
        }
    }
}
