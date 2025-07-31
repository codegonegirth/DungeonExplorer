public abstract class Creature : IDamageable
{
    public string Name { get; protected set; }
    public int HP { get; set; }

    public Creature(string name, int hp)
    {
        Name = name;
        HP = hp;
    }

    public abstract void Attack(Creature target);

    public virtual void TakeHit(int amount)
    {
        HP -= amount;
        if (HP < 0) HP = 0;
    }
}