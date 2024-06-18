namespace txtGame.Models
{
    public class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Armor { get; set; }

        public Enemy(string name, int health, int attack, int armor)
        {
            Name = name;
            Health = health;
            Attack = attack;
            Armor = armor;
        }
    }
}