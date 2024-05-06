using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterGeneratorLibrary.BaseItems;

namespace CharacterGeneratorLibrary.AncientSet
{
    public class AncientSetGenerator : EquipmentSetGenerator
    {
        public override Shield CreateShield()
        {
            return new AncientShield();
        }
        public override Hammer CreateHammer()
        {
            return new AncientHammer();
        }
    }
}
