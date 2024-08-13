using Xunit;
using FastFoodApp;

namespace FastFoodAppTests
{
    public class OrderTests
    {
        [Fact]
        public void TestOrderWithSufficientPayment()
        {
            var item = new FastFoodItem("burger", 5.00m);
            var order = new Order();

            order.AddItem(item, "medium");
            order.AddMoney(6M);

            bool orderCompleted = order.CompleteOrder();
            Assert.True(orderCompleted);
        }

        [Fact]
        public void TestOrderWithInsufficientPayment()
        {
            var item = new FastFoodItem("fries", 1.00m);
            var order = new Order();

            order.AddItem(item, "large");
            order.AddMoney(.5M);

            bool orderCompleted = order.CompleteOrder();
            Assert.False(orderCompleted);
        }

        [Fact]
        public void TestOrderWithMultipleCondiments()
        {
            var item = new FastFoodItem("burger", 5.00m);
            var ketchup = new Condiment("ketchup");
            var mustard = new Condiment("mustard");
            var order = new Order();

            order.AddItem(item, "medium");
            order.AddCondiment(ketchup, 2); // 2 Ketchups
            order.AddCondiment(mustard, 1); // 1 Mustard

            bool orderCompleted = order.CompleteOrder();
            Assert.False(orderCompleted);
        }
    }
}