namespace HomeWork;

public abstract class Build : NameTrait
{
    protected int property = 0;
    protected int price = 0;
    public Build(int property, int price)
    {
        
        this.property = property;
        this.price = price;

    }
    public void setProperty(int property) => this.property = property;
    public int getProperty() => this.property;
    public int getPrice() => this.price;
}