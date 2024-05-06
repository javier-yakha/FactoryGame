using CharacterGeneratorLibrary.BaseItems;

namespace CharacterGeneratorLibrary
{
    public abstract class EquipmentSetGenerator
    {
        public abstract Shield CreateShield();
        public abstract Hammer CreateHammer();
    }
}
