using ItemFactoryLibrary;
using ItemFactoryLibrary.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemFactoryLibrary.Items
{
    public class Shield : Item
    {
        public int DefenseValue { get; set; }
        public Shield()
        {
            Name = "Blessed Shield";
            Id = 12;
            Random r = new();
            DefenseValue = r.Next(1,40);
            Console.WriteLine("The Blessed Shield has been created.");
        }
        public override void useItem()
        {
            Console.WriteLine($"You have received a {DefenseValue} points blessing from the gods protecting you from any harm.");
        }
    }
}
