public abstract class Item : ICollectible
{
    public string Name { get; protected set; }

    public Item(string name)
    {
        Name = name;
    }

    public abstract void OnPickUp(Player player);
}