List<string> shoppinglist = new List<string>();
string input = "";
bool loop = false;
string run = "yes";

while (run == "yes")
{
    Console.WriteLine("Select one of the following options: ");
    Console.WriteLine("A: Add an item to the shopping list");
    Console.WriteLine("B: Remove an item from the shopping list:");
    Console.WriteLine("C: Search the list for an item");
    Console.WriteLine("D: Clear the shopping list");
    Console.WriteLine("E: Print your shopping list");
    string selection = Console.ReadLine();
    Console.WriteLine("----");
    
    if (selection == "A")
    {
        run = "y";
        loop = true;
        Console.WriteLine("Currently adding items to your shopping list. Type 'Stop' to stop");
        while (loop == true)
        {
            Console.WriteLine("What would you like to add into the shopping list?");
            input = Console.ReadLine();
            if (input == "Stop")
            {
                loop = false;
            }
            else
            {
                shoppinglist.Add(input);
                Console.WriteLine(input + " has been added to the shopping list.");
                input = "";
            }
            run = "yes";
        }
        Console.Clear();
    }
    else if (selection == "B")
    {
        run = "y";
        Console.WriteLine("What would you like to remove from the shopping list?");
        input = Console.ReadLine();
        shoppinglist.Remove(input);
        Console.WriteLine(input + " has been removed from the shopping list.");
        input = "";
        run = "yes";

    }
    else if (selection == "C")
    {
        run = "y";
        Console.WriteLine("What item would you like to search for?");
        input = Console.ReadLine();
        Console.WriteLine(shoppinglist.Contains(input));
        run = "yes";
    }
    else if (selection == "D")
    {
        run = "y";
        Console.WriteLine("Are you sure you want to delete your list? y/n");
        string confirmation = Console.ReadLine();
        if (confirmation == "y")
        {
            shoppinglist.Clear();
            Console.WriteLine("Your shopping list has been cleared.");
        }
        else
        {
            Console.WriteLine("Operation cancelled.");
        }
        run = "yes";
    }
    else if (selection == "E")
    {
        run = "y";
        int length = shoppinglist.Count();
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(shoppinglist[i]);
        }
        run = "yes";
    }
}

