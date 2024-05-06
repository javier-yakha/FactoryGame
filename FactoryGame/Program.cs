using CharacterGeneratorLibrary;
using CharacterGeneratorLibrary.DragonSet;
using ItemFactoryLibrary;
using Microsoft.VisualBasic;
using SingletonInterestLibrary;

namespace EntryPoint
{
    public class Program()
    {
        private static bool Quit()
        {
            Console.WriteLine("You can (Q)uit any time pressing the key 'Q'");
            return Console.ReadKey().Key is ConsoleKey.Q;
        }
        private static void AbstractFactory()
        {
            Console.WriteLine("You wake up without a clue of who you are.\n" +
            "You feel the weight of the entire Armor you have equipped.\n" +
            "You wield a mighty weapon with your right hand.\n" +
            "You carry a glory shield with your left hand.");

            while (true)
            {
                Console.WriteLine();

                CharacterEquipment characterEquipment = new();

                Console.WriteLine(characterEquipment);

                characterEquipment.Fight();

                Console.WriteLine();

                if (Quit()) break;
            }
            Console.WriteLine("\n\n" +
                "You are now fully equipped\n" +
                "The mighty adventure will wait for you.");
        }
        private static void FactoryMethod()
        {
            Console.WriteLine("Welcome Adventurer!\n" +
            "Fate is by your side.\n" +
            "The gods have granted you a mighty piece of equipment to embark your journey.");

            while (true)
            {
                Console.WriteLine();

                ItemCreator itemCreator = new RandomItemCreator();

                Item item = itemCreator.CreateItem();

                Console.WriteLine();

                if (Quit()) break;
            }
            Console.WriteLine("\n\n" +
                "You have received a mighty piece\n" +
                "The glorious adventure will wait for you.");
        }
        private static void BankInterest()
        {
            Console.WriteLine("Welcome to the bank of the people.\n" +
                "The only bank of the people, from the people and for the people.");

            StandardInterestRate rate = StandardInterestRate.GetInstance();

            // StandardInterestRate invalidRate = new StandardInterestRate(); // Constructor doesn't work

            while (true)
            {
                rate.CurrentInterestRate += 1;

                StandardInterestRate newRate = StandardInterestRate.GetInstance();
                Console.WriteLine(newRate.CurrentInterestRate);

                rate.CurrentInterestRate += 1;
                Console.WriteLine(rate.CurrentInterestRate);

                newRate.CurrentInterestRate += 1;

                Console.WriteLine(rate.CurrentInterestRate);

                if (Quit()) break;
            }
            Console.WriteLine(rate.CurrentInterestRate);
            
        }
        public static void Main(string[] args)
        {
            //FactoryMethod();

            //AbstractFactory();

            BankInterest();

            Console.WriteLine("\n\n" +
                "\t---\tProgram End\t---");
        }
    }
}










