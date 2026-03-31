using System;
using System.Collections.Generic;

// Class to represent a Churros menu item
class Churros
{
    public string Flavour { get; private set; }
    public double Price { get; private set; }

    // Constructor
    public Churros(string flavour, double price)
    {
        Flavour = flavour;
        Price = price;
    }
}

// Class to represent a customer order
class Order
{
    private static int nextOrderNo = 1;

    public int OrderNo { get; private set; }
    public string OrderDetails { get; private set; }
    public int Quantity { get; private set; }
    public double Bill { get; private set; }

    // Constructor
    public Order(string orderDetails, int quantity)
    {
        OrderNo = nextOrderNo;
        nextOrderNo = nextOrderNo + 1;
        OrderDetails = orderDetails;
        Quantity = quantity;
        Bill = 0;
    }

    // Method to place the order
    public void place_order()
    {
        Console.WriteLine("Order number: " + OrderNo);
        Console.WriteLine("Item: " + OrderDetails);
        Console.WriteLine("Quantity: " + Quantity);
    }

    // Method to calculate and return the total bill
    public double pay_bill(double price)
    {
        Bill = price * Quantity;
        Console.WriteLine("Total bill: " + Bill + " euro");
        return Bill;
    }

    // Method to collect the order
    public void collect_order()
    {
        Console.WriteLine("Order number " + OrderNo + " is ready. Enjoy!");
    }
}

// Main program
class Program
{
    // List to store menu items
    static List<Churros> menu = new List<Churros>();

    // Queue to store orders
    static Queue<Order> orderQueue = new Queue<Order>();

    static void Main(string[] args)
    {
        // Add menu items
        menu.Add(new Churros("Churros with plain sugar", 6.00));
        menu.Add(new Churros("Churros with cinnamon sugar", 6.00));
        menu.Add(new Churros("Churros with chocolate sauce", 8.00));
        menu.Add(new Churros("Churros with Nutella", 8.00));

        bool running = true;
        while (running)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("          Delicious Churros");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Churros with plain sugar: 6.00 euro");
            Console.WriteLine("Churros with cinnamon sugar: 6.00 euro");
            Console.WriteLine("Churros with chocolate sauce: 8.00 euro");
            Console.WriteLine("Churros with Nutella: 8.00 euro");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("1. Place order");
            Console.WriteLine("2. Deliver order");
            Console.WriteLine("0. Exit");
            Console.WriteLine("------------------------------------------");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine() ?? "";

            if (choice == "1")
            {
                PlaceOrder();
            }
            else if (choice == "2")
            {
                DeliverOrder();
            }
            else if (choice == "0")
            {
                Console.WriteLine("Goodbye! Thank you for visiting.");
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }

        // Run unit tests after exiting the menu
        RunTests();
    }

    // Method to place a new order
    static void PlaceOrder()
    {
        Console.WriteLine("What would you like to order?");
        Console.WriteLine("1. Churros with plain sugar - 6.00 euro");
        Console.WriteLine("2. Churros with cinnamon sugar - 6.00 euro");
        Console.WriteLine("3. Churros with chocolate sauce - 8.00 euro");
        Console.WriteLine("4. Churros with Nutella - 8.00 euro");
        Console.Write("Enter item number: ");

        string input = Console.ReadLine() ?? "";
        int itemChoice = int.Parse(input);

        if (itemChoice < 1 || itemChoice > 4)
        {
            Console.WriteLine("Invalid item. Please try again.");
            return;
        }

        Console.Write("Enter quantity: ");
        string qtyInput = Console.ReadLine() ?? "";
        int quantity = int.Parse(qtyInput);

        // Get the selected item from menu
        Churros selectedItem = menu[itemChoice - 1];

        // Create a new order
        Order newOrder = new Order(selectedItem.Flavour, quantity);

        // Call the order methods
        newOrder.place_order();
        newOrder.pay_bill(selectedItem.Price);

        // Add order to queue
        orderQueue.Enqueue(newOrder);
        Console.WriteLine("Your order has been added to the queue.");
    }

    // Method to deliver the next order in queue
    static void DeliverOrder()
    {
        if (orderQueue.Count == 0)
        {
            Console.WriteLine("No orders in the queue right now.");
        }
        else
        {
            Order nextOrder = orderQueue.Dequeue();
            nextOrder.collect_order();
        }
    }

    // Unit tests for pay_bill method
    static void RunTests()
    {
        Console.WriteLine("===== Testing pay_bill() method =====");

        // Test 1
        Order test1 = new Order("Churros with plain sugar", 2);
        double result1 = test1.pay_bill(6.00);
        if (result1 == 12.00)
        {
            Console.WriteLine("Test 1 passed: 2 x 6.00 = 12.00");
        }
        else
        {
            Console.WriteLine("Test 1 failed");
        }

        // Test 2
        Order test2 = new Order("Churros with Nutella", 3);
        double result2 = test2.pay_bill(8.00);
        if (result2 == 24.00)
        {
            Console.WriteLine("Test 2 passed: 3 x 8.00 = 24.00");
        }
        else
        {
            Console.WriteLine("Test 2 failed");
        }

        // Test 3
        Order test3 = new Order("Churros with cinnamon sugar", 1);
        double result3 = test3.pay_bill(6.00);
        if (result3 == 6.00)
        {
            Console.WriteLine("Test 3 passed: 1 x 6.00 = 6.00");
        }
        else
        {
            Console.WriteLine("Test 3 failed");
        }

        Console.WriteLine("=====================================");
    }
}
