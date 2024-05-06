using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterGeneratorLibrary.BaseItems;

namespace CharacterGeneratorLibrary.DragonSet
{
    public class DragonSetGenerator : EquipmentSetGenerator
    {
        public override Shield CreateShield()
        {
            return new DragonShield();
        }
    }
}
