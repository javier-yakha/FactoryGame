using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterGeneratorLibrary.BaseItems;

namespace CharacterGeneratorLibrary.DragonSet
{
    public class DragonShield : Shield
    {
        public DragonShield()
        {
            Id = 20;
            Name = "Dragon Shield";
            Random r = new();
            DefenseValue = r.Next(10, 36);
            BlockValue = r.Next(4,11);
        }
        public override void UseItem()
        {
            Block();
        }
        public override void Block()
        {
            Console.WriteLine($"The fire coming out of the Dragon Shield " +
                $"disturbs your enemy dissipating <{BlockValue} HP> " +
                $"and burning him for <{BlockValue - 2} HP>.");
        }
        public override string ToString()
        {
            return $"A firey {Name}.\n" +
                $"\tDefense: {DefenseValue}\n" +
                $"\tBlock: {BlockValue}";
        }
    }
}
