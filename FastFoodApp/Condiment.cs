using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodApp
{
    public class Condiment
    {

        public const decimal CONDIMENTPRICE = 0.25M;
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Condiment(string name)
        {
            Name = name;
            Price = CONDIMENTPRICE;
        }
    }
}
