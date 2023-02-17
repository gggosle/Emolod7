namespace HomeWork;

public class Potion : Build
{
     // size 1) - small 2) - middle 3) - big

    private string generatePotionName()
    {
        if (this.property == 1)
            return "Little ";
        else if(this.property == 2)
            return "Regular ";
        else
            return "Legendary ";
    }

    public Potion(int size, int price): base(size, price)
    {
        this.property = size;
        this.name = generatePotionName() + this.GetType().Name;
    }
}