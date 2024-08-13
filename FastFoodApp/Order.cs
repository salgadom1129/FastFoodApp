using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodApp
{
    public class Order
    {
        private readonly List<FastFoodItem> _items = new List<FastFoodItem>();
        private readonly List<Condiment> _condiments = new List<Condiment>();
        private decimal _totalAmount;
        private decimal _amountPaid;
        private decimal _change;
        public const decimal MEDIUMPRICE = 0.50M;
        public const decimal LARGEPRICE = 1.00M;

        public void AddItem(FastFoodItem item, string size)
        {
            decimal price = item.BasePrice;
            if (size == "medium")
            {
                price += MEDIUMPRICE;
            }
            else if (size == "large")
            {
                price += LARGEPRICE;
            }
            _items.Add(new FastFoodItem(item.Name, price));
            _totalAmount += price;
        }
        public void AddCondiment(Condiment condiment, int quantity)
        {
            if (quantity <= 3)
            {
                _condiments.Add(condiment);
                _totalAmount += condiment.Price * quantity;
            }
        }

        public void PrintTotalDue()
        {
            Console.WriteLine($"Your total due is: ${_totalAmount:F2}");
        }

        public bool CompleteOrder()
        {
            if (_amountPaid >= _totalAmount)
            {
                _change = _amountPaid - _totalAmount;
                Console.WriteLine($"Order completed. Change: ${_change:F2}");
                Console.WriteLine("Serving...");
                //Serve 
                foreach (var item in _items)
                {
                    Console.WriteLine(item.Name);
                }
                foreach (var condiment in _condiments)
                {
                    Console.WriteLine(condiment.Name);
                }
                _amountPaid = 0;
                _totalAmount = 0;
                _items.Clear();
                _condiments.Clear();
                return true;
            }
            else
            {
                Console.WriteLine($"Insufficient payment. Amount due: ${_totalAmount - _amountPaid:F2}");
                return false;
            }
        }

        public void AddMoney(decimal amount)
        {
            if (amount >= 0.05m && amount <= 20.00m)
            {
                _amountPaid += amount;
            }
        }

    }

}

