namespace HomeWork;

public class Player : Base
{
    protected int agility = 0;
    protected int power = 0;
    protected int endurance = 0;


    public Player(string name, int level) : base(name, level)
    {
        this.health = level;
        this.healthMax = level;
    }
    
    ~Player()
    { }

    public void SetAgl(int agility) => this.agility = agility;
    
    public int getAgl() => this.agility;
   
    public void setPw(int power) => this.power = power;

    public int getPw() => this.power;

    public void setEnd(int endurance) => this.endurance = endurance;
 
    public int getEnd() => this.endurance;

}