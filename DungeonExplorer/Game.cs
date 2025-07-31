using System;
using System.Threading;

public class Game
{
    private Player? player;
    private GameMap? map;

    public void Start()
    {
        Console.WriteLine("Welcome to Dungeon Explorer!");
        Console.Write("What's your name, hero? ");
        string name = Console.ReadLine() ?? "Hero";
        player = new Player(name);
        map = new GameMap(3, 3, player);

        map.DisplayCurrentRoom();
        GameLoop();
    }

    private void GameLoop()
    {
        while (!player.HasWon && player.HP > 0)
        {
            Console.WriteLine();
            Console.Write("What would you like to do? Options: look, take, use, move, bag, map, quit\n>> ");
            string input = Console.ReadLine()?.Trim().ToLower() ?? "";

            switch (input)
            {
                case "look":
                    map.Look();
                    break;
                case "take":
                    map.TakeItem();
                    break;
                case "use":
                    player.UseItem();
                    break;
                case "move":
                    map.Move();
                    break;
                case "bag":
                    player.ShowInventory();
                    break;
                case "map":
                    map.DisplayMap();
                    break;
                case "quit":
                    Console.WriteLine("Thanks for playing!");
                    return;
                default:
                    Console.WriteLine("Sorry, I didn't understand that.");
                    break;
            }
        }

        if (player.HP <= 0)
        {
            Console.WriteLine("You have fallen in the dungeon...");
        }
        else if (player.HasWon)
        {
            Console.WriteLine($"Congratulations, {player.Name}! You've defeated the dungeon boss and won!");
        }
    }
}