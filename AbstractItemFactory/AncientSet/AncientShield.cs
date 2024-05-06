using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterGeneratorLibrary.BaseItems;

namespace CharacterGeneratorLibrary.AncientSet
{
    public class AncientShield : Shield
    {
        public AncientShield()
        {
            Id = 10;
            Name = "Shield of the Ancients";
            Random r = new();
            DefenseValue = r.Next(25,30);
            BlockValue = r.Next(6,9);
        }
        public override void UseItem()
        {
            Block();
        }
        public override void Block()
        {
            Console.WriteLine($"The Ancient Shield's Emerald makes " +
                $"your enemy strike itself <{BlockValue} HP> " +
                $"while draining you <{BlockValue / 2} HP>.");
        }
        public override string ToString()
        {
            return $"A {Name}.\n" +
                $"\tDefense: {DefenseValue}\n" +
                $"\tBlock: {BlockValue}";
        }
    }
}
