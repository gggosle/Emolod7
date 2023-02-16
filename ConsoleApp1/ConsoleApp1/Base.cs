namespace HomeWork;

public class Base
{
    protected string name = "";
    protected int health = 0;
    protected int healthMax = 0;
    protected int energy = 0;
    protected int exp = 0;
    protected int level = 0;

    public Base( string name, int level)
    {
        this.name = name;
        this.health = health;
        this.energy = energy;
        this.exp = exp;
        this.level = level;
    }
    public void setName(string name) => this.name = name;

    public string getName()=> this.name;
 
    public void setHealth(int health) => this.health = health;
 
    public int getHealth() => this.health;
   
    public void setEnergy(int energy) =>  this.energy = energy;

    public int getEnergy() => this.energy;
   
    public void setExp(int exp) => this.exp = exp;
 
    public int getExp()
    {
        return this.exp;
    }
    public void setLvl(int level) => this.level = level;

    public int getLvl() => this.level;

}