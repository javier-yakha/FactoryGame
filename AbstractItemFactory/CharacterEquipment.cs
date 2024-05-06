using CharacterGeneratorLibrary.BaseItems;
using CharacterGeneratorLibrary.DragonSet;
using CharacterGeneratorLibrary.AncientSet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGeneratorLibrary
{
    public class CharacterEquipment
    {
        public Shield CharacterShield { get; set; }
        public EquipmentSetGenerator UsedItemGenerator { get; set; }
        public CharacterEquipment() 
        {
            Random r = new();
            int randomInt = r.Next(1, 3);
            UsedItemGenerator =
                randomInt switch
                {
                    1 => new DragonSetGenerator(),
                    2 => new AncientSetGenerator(),
                    _ => throw new InvalidOperationException()
                };
            CreateItems();
        }
        private void CreateItems()
        {
            CharacterShield = UsedItemGenerator.CreateShield();
        }

        public override string ToString()
        {
            return $"\tYou are wearing\n\n" +
                $"Shield: {CharacterShield}";
        }
    }
}
