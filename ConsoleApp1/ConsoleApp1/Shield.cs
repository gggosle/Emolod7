namespace HomeWork;

public class Shield: Build
{
    
    private int defense = 0;

    public Shield(int defense, string name) : base(name)
    {
        this.defense = defense;
    }
    public void setDefense(int defense) => this.defense = defense;
    public int getDefense() => this.defense ;

}