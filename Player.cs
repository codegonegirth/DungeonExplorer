using System;
using System.Collections.Generic;
using System.Linq;

public class Player : Creature
{
    public List<Item> Inventory { get; private set; } = new List<Item>();
    public bool HasWon { get; set; }

    public Player(string name) : base(name, 100) { }

    public override void Attack(Creature target)
    {
        int damage = 15;
        Console.WriteLine($"{Name} swings at {target.Name} and hits for {damage} damage.");
        target.TakeHit(damage);
    }

    public void UseItem()
    {
        if (!Inventory.Any())
        {
            Console.WriteLine("You have no items to use.");
            return;
        }

        Console.WriteLine("What would you like to use?");
        for (int i = 0; i < Inventory.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Inventory[i].Name}");
        }

        Console.Write(">> ");
        if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= Inventory.Count)
        {
            Inventory[choice - 1].OnPickUp(this);
            Inventory.RemoveAt(choice - 1);
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    public void ShowInventory()
    {
        if (!Inventory.Any())
        {
            Console.WriteLine("Your bag is empty.");
            return;
        }

        Console.WriteLine("In your bag:");
        foreach (var item in Inventory)
        {
            Console.WriteLine($"- {item.Name}");
        }
    }
}