namespace HomeWork;

public class Shield: Build
{
    public Shield(int defense, string name, int price) : base(defense, price)
    {
        this.name = name;
    }
}