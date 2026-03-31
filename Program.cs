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
