using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemFactoryLibrary
{
    public abstract class ItemCreator
    {
        protected abstract Item ItemFactory();
        public Item CreateItem()
        {
            Item item = ItemFactory();

            item.useItem();

            return item;
        }
    }
}
