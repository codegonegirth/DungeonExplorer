using System;

public class Monster : Creature
{
    public bool IsBoss { get; private set; }

    public Monster(string name, int hp, bool isBoss = false) : base(name, hp)
    {
        IsBoss = isBoss;
    }

    public override void Attack(Creature target)
    {
        int damage = Name == "RatKing" ? 10 : Name == "Blobby" ? 12 : 20;
        Console.WriteLine($"{Name} attacks and deals {damage} damage!");
        target.TakeHit(damage);
    }
}