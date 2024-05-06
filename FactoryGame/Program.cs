using ItemFactoryLibrary;
using Microsoft.VisualBasic;


Console.WriteLine("Welcome Adventurer!\n" +
    "Fate is by your side.\n" +
    "The gods have granted you a mighty piece of equipment to embark your journey.");

while (true)
{
    Console.WriteLine();
    ItemCreator itemCreator = new RandomItemCreator();
    
    Item item = itemCreator.CreateItem();

    Console.WriteLine();

    Console.Write("You can (Q)uit any time pressing the key 'Q'");
    var input = Console.ReadLine();

    if (input is not null)
    {
        string answer = Convert.ToString(input);
        if (answer.Equals("q", StringComparison.CurrentCultureIgnoreCase)) break;
    }
}

Console.WriteLine("The mighty adventure will wait for you.");

Console.ReadKey();

