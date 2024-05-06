using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGeneratorLibrary.BaseItems
{
    public abstract class Shield
    {
        public int DefenseValue { get; set; }
        public int BlockValue { get; set; }
        public abstract void Block();
    }
}
