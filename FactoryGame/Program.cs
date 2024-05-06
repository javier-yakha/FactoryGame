using ItemFactory;

Console.WriteLine("Hello, World!");

ItemCreator itemCreator = new RandomItemCreator();

Item item = itemCreator.CreateItem();
