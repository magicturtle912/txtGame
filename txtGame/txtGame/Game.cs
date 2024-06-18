using System;
using txtGame.Models;
using System.Collections.Generic;
using txtGame.Modles;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace txtGame.GameLogic
{
    public class Game
    {
        private Player Player;
        private Room currentRoom;

        public void Start()
        {
            InitializeRooms();
            Player = new Player("Hero");
            currentRoom = currentRoom;

            while (true)
            {
                DisplayCurrentRoom();
                string input = Console.ReadLine();
                ProcessInput(input);
            }
        }

        private void InitializeRooms()
        {
            Room room1 = new Room("You are in a dark cave.");
            Room room2 = new Room("You enter a room with a faint light.");

            room1.Enemies.Add(new Enemy("Goblin", 30, 5, 5));
            room2.Items.Add(new Item("Heal Potion", "heal"));
            currentRoom = room1;
        }

        
        private void DisplayCurrentRoom()
        {
                    Console.Clear();
                    Console.WriteLine(currentRoom.Description);
        }

        private void ProcessInput(string input)
        {
            string[] parts = input.Split(' ');
            string command = parts[0].ToLower();

            switch (command)
            {
                case "go":
                    //Movment
                    break;
                case "attack":
                    if (currentRoom.Enemies.Count > 0)
                    {
                        Enemy enemy = currentRoom.Enemies[0];
                        combat(Player, enemy);
                    }
                    else
                    {
                        Console.WriteLine("No Enemies to attack");
                    }
                    break;
                case "take":
                    // get items
                    break;
                default:
                    Console.WriteLine("Uknown Command");
                        break;
            }
        }

        private void combat(Player player, Enemy enemy)
        {
            while (player.Health > 0 && enemy.Health > 0)
            {
                enemy.Health -= Math.Max(0, player.Attack - enemy.Armor);
                if (enemy.Health <= 0)
                {
                    Console.WriteLine($"You defeated the {enemy.Name}!");
                    currentRoom.Enemies.Remove(enemy);
                    return;
                }

                player.Health -= Math.Max(0, enemy.Attack - player.Armor);
                if (player.Health <= 0)
                {
                    Console.WriteLine("You Died");
                    return;
                }
            }
        }
    }
}