using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemFactoryLibrary.Items
{
    public class Armor : Item
    {
        public int DefenseValue { get; set; }
        public Armor() 
        {
            Name = "Dragon Scale Mail";
            Id = 13;
            Random r = new();
            
            DefenseValue = r.Next(1, 16);
            Console.WriteLine("The <Dragon Scale Mail> has been created.");
        }
        public override void useItem()
        {
            Console.WriteLine($"A breeze of fire emanates from your armor, you feel <{DefenseValue} HP> revitalizing you.");
        }
    }
}
