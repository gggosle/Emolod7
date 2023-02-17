namespace HomeWork;

class StrenghtPotion : Potion, IDrink
{
    public StrenghtPotion(int size, int price) : base(size, price)
    {
    }

    public void drink(Player player)
    {
        player.addStr(1 * this.property);
    }
}