// See https://aka.ms/new-console-template for more information
using FastFoodApp;

//Instantiate fast food items
FastFoodItem cheeseburger = new FastFoodItem("cheeseburger", 2.50M);
FastFoodItem hamburger = new FastFoodItem("hamburger", 2.00M);
FastFoodItem chickenSandwich = new FastFoodItem("chicken sandwich", 2.00M);
FastFoodItem fries = new FastFoodItem("fries", 1.70M);
FastFoodItem coke = new FastFoodItem("coke", 1M);

List<FastFoodItem> fastFoodItems = new List<FastFoodItem> { cheeseburger, hamburger, chickenSandwich, fries, coke };

//Instantiate condiments
Condiment ketchup = new Condiment("ketchup");
Condiment mustard = new Condiment("mustard");

List<Condiment>condiments = new List<Condiment> { ketchup, mustard };

//Instantiate menu
Menu fastfoodAppMenu = new Menu(fastFoodItems, condiments);

Console.WriteLine("Welcome to FastFoodApp!");
Console.WriteLine("Here's the menu (all items are available in small, medium, and large):");
Console.WriteLine(fastfoodAppMenu.ToString());

Console.WriteLine("Please type the items and size (Example: coke,medium) you would like and press enter. When done please type done");

bool ordering = true;
string response;
Order order = new Order();
while (ordering)
{
    response = Console.ReadLine();


    switch (response.ToLower())
    {
        case "cheeseburger,small":
            order.AddItem(hamburger, "small");
            break;
        case "cheeseburger,medium":
            order.AddItem(hamburger, "medium");
            break;
        case "cheeseburger,large":
            order.AddItem(hamburger, "large");
            break;
        case "hamburger,small":
            order.AddItem(hamburger,"small");
            break;
        case "hamburger,medium":
            order.AddItem(hamburger, "medium");
            break;
        case "hamburger,large":
            order.AddItem(hamburger, "large");
            break;
        case "chicken sandwich,small":
            order.AddItem(chickenSandwich, "small");
            break;
        case "chicken sandwich,medium":
            order.AddItem(chickenSandwich, "medium");
            break;
        case "chicken sandwich,large":
            order.AddItem(chickenSandwich, "large");
            break;
        case "fries,small":
            order.AddItem(fries, "small");
            break;
        case "fries,medium":
            order.AddItem(fries, "medium");
            break;
        case "fries,large":
            order.AddItem(fries, "large");
            break;
        case "coke,small":
            order.AddItem(coke, "small");
            break;
        case "coke,medium":
            order.AddItem(coke, "medium");
            break;
        case "coke,large":
            order.AddItem(coke, "large");
            break;
        case "done":
            ordering = false;
            break;
        default:break;
    }
}

Console.WriteLine("Please type the condiments you would like and the quantity (Example: ketchup, 2). When done please type done");
ordering = true;
while (ordering)
{
    response = Console.ReadLine();
    List<string> responseParsed = response.Split(',').ToList();
    int condimentQuantity = 0;

    if (responseParsed.Count >= 2)
        condimentQuantity = int.Parse(responseParsed[1]);

    if (condimentQuantity > 3)
    {
        Console.WriteLine("Limit of condiments is 3");
    }

    switch (responseParsed[0].ToLower())
    {
        case "ketchup":
            order.AddCondiment(ketchup, condimentQuantity);
            break;
        case "mustard":
            order.AddCondiment(mustard, condimentQuantity);
            break;
        case "done":
            ordering = false;
            break;
        default:break;
    }
}

order.PrintTotalDue();

Console.WriteLine("To pay, please enter amount you wish to pay: ");
bool paying = true;
decimal amountGiven = 0; 
while (paying)
{

    amountGiven = Convert.ToDecimal(Console.ReadLine());
    order.AddMoney(amountGiven);
    
    paying = !order.CompleteOrder();
}

