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
