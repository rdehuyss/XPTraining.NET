using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    public class Shop
    {
        public List<string> Stock { get; } = new List<string>();

        public void AddItemToStock(string item)
        {
            Stock.Add(item);
        }
        
    }
}
