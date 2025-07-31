using System;

public class Potion : Item
{
    private int healAmount;

    public Potion(string name, int amount) : base(name)
    {
        healAmount = amount;
    }

    public override void OnPickUp(Player player)
    {
        player.HP += healAmount;
        Console.WriteLine($"{player.Name} uses {Name} and restores {healAmount} HP.");
    }
}