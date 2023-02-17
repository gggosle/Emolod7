namespace HomeWork;

public class Weapon: Build
{
    public Weapon(int harm, string name, int price) : base(harm, price)
    {
        this.name = name;
    }
}