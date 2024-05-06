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
            int randomSeed = r.Next(10);

            return randomSeed > 5 ? new Hammer() : new Shield();

        }
    }
}
