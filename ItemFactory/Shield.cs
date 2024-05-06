using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemFactory
{
    public class Shield : Item
    {
        public Shield() 
        {
            Name = "Blessed Shield";
            Id = 12;
            Console.WriteLine("The Blessed Shield has been created");
        }
        public override void useItem()
        {
            Console.WriteLine("You have received a blessing from the gods protecting you from any harm.");
        }
    }
}
