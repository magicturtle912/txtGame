namespace txtGame.Models
{
    public class Item
    {
        public string Name { get; set; }
        public string Effect { get; set; }

        public Item(string name, string effect)
        {
            Name = name;
            Effect = effect;
        }
    }
}