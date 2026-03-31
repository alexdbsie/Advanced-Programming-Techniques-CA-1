using System;

class Element
{
    public int AtomicNumber;
    public string Name;
    public string Class;
}

class Program
{
    static void Main()
    {
        // Create the array
        Element[] elements = new Element[31];

        // Fill in the elements (just first 5 shown as example)
        elements[1] = new Element();
        elements[1].AtomicNumber = 1;
        elements[1].Name = "Hydrogen";
        elements[1].Class = "Nonmetal";

        elements[2] = new Element();
        elements[2].AtomicNumber = 2;
        elements[2].Name = "Helium";
        elements[2].Class = "Noble Gas";

        elements[3] = new Element();
        elements[3].AtomicNumber = 3;
        elements[3].Name = "Lithium";
        elements[3].Class = "Alkali Metal";

        elements[4] = new Element();
        elements[4].AtomicNumber = 4;
        elements[4].Name = "Beryllium";
        elements[4].Class = "Alkaline Earth Metal";

        elements[5] = new Element();
        elements[5].AtomicNumber = 5;
        elements[5].Name = "Boron";
        elements[5].Class = "Metalloid";     

        elements[6] = new Element();
        elements[6].AtomicNumber = 6;
        elements[6].Name = "Carbon";
        elements[6].Class = "Nonmetal";

        elements[7] = new Element();
        elements[7].AtomicNumber = 7;
        elements[7].Name = "Nitrogen";
        elements[7].Class = "Nonmetal";

        elements[8] = new Element();
        elements[8].AtomicNumber = 8;
        elements[8].Name = "Oxygen";
        elements[8].Class = "Nonmetal";

        elements[9] = new Element();
        elements[9].AtomicNumber = 9;
        elements[9].Name = "Fluorine";
        elements[9].Class = "Halogen";

        elements[10] = new Element();
        elements[10].AtomicNumber = 10;
        elements[10].Name = "Neon";
        elements[10].Class = "Noble Gas";

        elements[11] = new Element();
        elements[11].AtomicNumber = 11;
        elements[11].Name = "Sodium";
        elements[11].Class = "Alkali Metal";

        elements[12] = new Element();
        elements[12].AtomicNumber = 12;
        elements[12].Name = "Magnesium";
        elements[12].Class = "Alkaline Earth Metal";

        elements[13] = new Element();
        elements[13].AtomicNumber = 13;
        elements[13].Name = "Aluminium";
        elements[13].Class = "Post-Transition Metal";

        elements[14] = new Element();
        elements[14].AtomicNumber = 14;
        elements[14].Name = "Silicon";
        elements[14].Class = "Metalloid";

        elements[15] = new Element();
        elements[15].AtomicNumber = 15;
        elements[15].Name = "Phosphorus";
        elements[15].Class = "Nonmetal";

        elements[16] = new Element();
        elements[16].AtomicNumber = 16;
        elements[16].Name = "Sulfur";
        elements[16].Class = "Nonmetal";

        elements[17] = new Element();
        elements[17].AtomicNumber = 17;
        elements[17].Name = "Chlorine";
        elements[17].Class = "Halogen";

        elements[18] = new Element();
        elements[18].AtomicNumber = 18;
        elements[18].Name = "Argon";
        elements[18].Class = "Noble Gas";

        elements[19] = new Element();
        elements[19].AtomicNumber = 19;
        elements[19].Name = "Potassium";
        elements[19].Class = "Alkali Metal";

        elements[20] = new Element();
        elements[20].AtomicNumber = 20;
        elements[20].Name = "Calcium";
        elements[20].Class = "Alkaline Earth Metal";

        elements[21] = new Element();
        elements[21].AtomicNumber = 21;
        elements[21].Name = "Scandium";
        elements[21].Class = "Transition Metal";

        elements[22] = new Element();
        elements[22].AtomicNumber = 22;
        elements[22].Name = "Titanium";
        elements[22].Class = "Transition Metal";

        elements[23] = new Element();
        elements[23].AtomicNumber = 23;
        elements[23].Name = "Vanadium";
        elements[23].Class = "Transition Metal";

        elements[24] = new Element();
        elements[24].AtomicNumber = 24;
        elements[24].Name = "Chromium";
        elements[24].Class = "Transition Metal";

        elements[25] = new Element();
        elements[25].AtomicNumber = 25;
        elements[25].Name = "Manganese";
        elements[25].Class = "Transition Metal";

        elements[26] = new Element();
        elements[26].AtomicNumber = 26;
        elements[26].Name = "Iron";
        elements[26].Class = "Transition Metal";

        elements[27] = new Element();
        elements[27].AtomicNumber = 27;
        elements[27].Name = "Cobalt";
        elements[27].Class = "Transition Metal";

        elements[28] = new Element();
        elements[28].AtomicNumber = 28;
        elements[28].Name = "Nickel";
        elements[28].Class = "Transition Metal";

        elements[29] = new Element();
        elements[29].AtomicNumber = 29;
        elements[29].Name = "Copper";
        elements[29].Class = "Transition Metal";

        elements[30] = new Element();
        elements[30].AtomicNumber = 30;
        elements[30].Name = "Zinc";
        elements[30].Class = "Transition Metal";   
    
        Console.WriteLine("Hi there! I am happy to help you!!");

        string answer = "y";

        while (answer == "y")
        {
            // Ask for input
            Console.Write("Provide atomic number of the element: ");
            int number = int.Parse(Console.ReadLine());

            // Check if valid
            if (number >= 1 && number <= 30)
            {
                Console.WriteLine("Atomic Number: " + elements[number].AtomicNumber);
                Console.WriteLine("Name: " + elements[number].Name);
                Console.WriteLine("Class: " + elements[number].Class);
            }
            else
            {
                Console.WriteLine("Please enter a number between 1 and 30.");
            }

            // Ask if they want to continue
            Console.Write("Do you want to know more elements [y/n]? ");
            answer = Console.ReadLine();
        }

        Console.WriteLine("Thanks!");
    }
}