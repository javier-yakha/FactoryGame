using ItemFactoryLibrary.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemFactoryLibrary
{
    public class RandomItemCreator : ItemCreator
    {
        protected override Item ItemFactory()
        {
            Random r = new Random();
            int randomSeed = r.Next(1,4);

            return randomSeed switch
            {
                1 => new Hammer(),
                2 => new Shield(),
                3 => new Armor(),
                _ => throw new InvalidOperationException(),
            };

        }
    }
}
