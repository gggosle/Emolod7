namespace HomeWork;

class AgilityPotion : Potion, IDrink
{
    public AgilityPotion(int size, int price) : base(size, price)
    {
    }

    public void drink(Player player)
    {
        player.addAgl(1 * this.property);
    }
}