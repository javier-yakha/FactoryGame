using CharacterGeneratorLibrary.BaseItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGeneratorLibrary.DragonSet
{
    public class DragonHammer : Hammer
    {
        public DragonHammer() 
        {
            Id = 21;
            Name = "Dragon Hammer";
            Random r = new();
            AttackValue = r.Next(20, 50);
        }
        public override void UseItem()
        {
            Strike();
        }
        public override void Strike()
        {
            Console.WriteLine($"A fierceful fire emanates " +
                $"when you strike the {Name} " +
                $"onto your enemy dealing <{AttackValue} HP> " +
                $"and burning him for <{AttackValue - 15} HP>");
        }
        public override string ToString()
        {
            return $"A {Name}.\n" +
                $"\tAttack: {AttackValue}";
        }
    }
}
