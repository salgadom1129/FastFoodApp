using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodApp
{
    public class FastFoodItem
    {
        public string Name { get; set; }
        public decimal BasePrice { get; set; }

        public FastFoodItem(string name, decimal basePrice)
        {
            Name = name;
            BasePrice = basePrice;
        }
    }

}
