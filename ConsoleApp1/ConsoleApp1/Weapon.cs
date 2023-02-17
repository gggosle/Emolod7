namespace HomeWork;

public class Weapon: Build
{
    private int harm = 0;

    public Weapon(int harm, string name) : base(name)
    {
        this.harm = harm;
    }
    public void setHarm(int defense) => this.harm = defense;
    public int getHarm() => this.harm ;
}