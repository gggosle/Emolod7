namespace HomeWork;

public class HealthPointPotion : Potion, IDrink
{
    public HealthPointPotion(int size, int price) : base(size, price)
    {
    }

    public void drink(Player player)
    {
        player.heal(100 * this.property);
    }
}
