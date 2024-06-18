using System.Collections.Generic;
using txtGame.Models;

namespace txtGame.Modles
{
    public class Room
    {
        public string Description { get; set; }
        public List<Enemy> Enemies { get; set; }
        public List<Item> Items { get; set; }

        public Room(string description)
        {
            Description = description;
            Enemies = new List<Enemy>();
            Items = new List<Item>();
        }
    }
}