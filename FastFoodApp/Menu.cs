using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodApp
{
    public class Menu
    {
        public List<FastFoodItem> Items = new List<FastFoodItem>();
        public List<Condiment> Condiments = new List<Condiment>();

        public Menu(List<FastFoodItem> items, List<Condiment> condiments)
        {
            Items = items;
            Condiments = condiments;
        }

        public override string ToString()
        {
            string menu = "FAST FOOD ITEMS \n";
            foreach(FastFoodItem item in Items)
            {
                menu += item.Name + " " + item.BasePrice + "\n";
            }
            menu += "CONDIMENTS \n";
            foreach (Condiment condiment in Condiments)
            {
                menu += condiment.Name + " " + condiment.Price + "\n";
            }
            return menu;

        }
    }
}
