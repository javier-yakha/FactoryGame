namespace ItemFactoryLibrary
{
    public abstract class Item
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public abstract void UseItem();
    }
}
