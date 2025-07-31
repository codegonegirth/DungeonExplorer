using System;

public class Weapon : Item
{
    private int damageBoost;

    public Weapon(string name, int boost) : base(name)
    {
        damageBoost = boost;
    }

    public override void OnPickUp(Player player)
    {
        Console.WriteLine($"{player.Name} wields {Name}, increasing damage!");
    }
}