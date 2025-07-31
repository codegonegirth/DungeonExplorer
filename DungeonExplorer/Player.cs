public class Player
{
    public string Name { get; }
    public int HP { get; set; } = 10;
    public bool HasWon { get; set; } = false;

    public Player(string name)
    {
        Name = name;
    }

    public void UseItem()
    {
        System.Console.WriteLine("You have no items to use.");
    }

    public void ShowInventory()
    {
        System.Console.WriteLine("Your bag is empty.");
    }
}