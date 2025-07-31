public interface IDamageable
{
    void TakeHit(int amount);
}

public interface ICollectible
{
    void OnPickUp(Player player);
}