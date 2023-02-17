namespace HomeWork;

class EndurancePotion : Potion, IDrink
{
    public EndurancePotion(int size, int price) : base(size, price)
    {
    }

    public void drink(Player player)
    {
        player.addEnd(1 * this.property);
    }
}