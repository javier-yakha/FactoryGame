using CharacterGeneratorLibrary;
using CharacterGeneratorLibrary.DragonSet;
using ItemFactoryLibrary;
using Microsoft.VisualBasic;

namespace Game
{
    public class Program()
    {
        private static bool Quit()
        {
            Console.Write("You can (Q)uit any time pressing the key 'Q'");
            var input = Console.ReadLine();

            if (input is not null)
            {
                string answer = Convert.ToString(input);
                return answer.Equals("q", StringComparison.CurrentCultureIgnoreCase);
            }
            return false;
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
            

        }
        public static void Main(string[] args) 
        {
            // FactoryMethod();

            AbstractFactory();

            Console.WriteLine("The mighty adventure will wait for you.");
            Console.ReadKey();
        }
    }
}










