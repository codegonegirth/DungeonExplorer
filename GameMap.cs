using System;

public class GameMap
{
    private int width, height;
    private Player player;

    public GameMap(int width, int height, Player player)
    {
        this.width = width;
        this.height = height;
        this.player = player;
    }

    public void DisplayCurrentRoom()
    {
        System.Console.WriteLine("You are in a dark room.");
    }

    public void Look()
    {
        System.Console.WriteLine("You look around but see nothing of interest.");
    }

    public void TakeItem()
    {
        System.Console.WriteLine("There is nothing to take.");
    }

    public void Move()
    {
        System.Console.WriteLine("You move to another room.");
    }

    public void DisplayMap()
    {
        System.Console.WriteLine("Map: [X]");
    }
}