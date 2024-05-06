using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGeneratorLibrary.BaseItems
{
    public abstract class Hammer
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int AttackValue { get; set; }
        public abstract void UseItem();
        public abstract void Strike();
    }
}
