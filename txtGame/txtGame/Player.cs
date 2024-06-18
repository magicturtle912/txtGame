using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace txtGame.Models
{
    public class Player
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Armor { get; set; }
        public List<Item> Inventory { get; set; }

        public Player(string name)
        {
            Name = name;
            Health = 10;
            Attack = 7;
            Armor = 2;
            Inventory = new List<Item>();
        }
    }
}