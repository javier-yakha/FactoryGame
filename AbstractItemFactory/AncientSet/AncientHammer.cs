using CharacterGeneratorLibrary.BaseItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGeneratorLibrary.AncientSet
{
    public class AncientHammer : Hammer
    {
        public AncientHammer()
        {
            Name = "Hammer of the Ancients";
            Id = 11;
            Random r = new();
            AttackValue = r.Next(30, 40);
        }
        public override void UseItem()
        {
            Strike();
        }
        public override void Strike()
        {
            Console.WriteLine($"The {Name} summons a leeching spirit" +
                $"making your enemy lose <{AttackValue + 5} HP> " +
                $"while draining you <{AttackValue / 2} HP>");   
        }
        public override string ToString()
        {
            return $"A {Name}.\n" +
                $"\tAttack: {AttackValue}";
        }
    }
}
