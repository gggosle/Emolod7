namespace HomeWork;

public abstract class Base
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
    
    public void showInfo()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{this.GetType()} :  {this.name} {this.level} lvl.");

        Console.Write("\t[");
        double tmp = ((double)this.health / (double)this.healthMax) * 10;

        if (tmp >= 8)
            Console.ForegroundColor = ConsoleColor.Green;
        else if (tmp > 4)
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        else
            Console.ForegroundColor = ConsoleColor.Red;

        for (int i = 0; i < 10; i++)
        {
            if (i < tmp)
                Console.Write("#");
            else
                Console.Write(" ");
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("]");

        if (tmp >= 8)
            Console.ForegroundColor = ConsoleColor.Green;
        else if (tmp > 4)
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        else
            Console.ForegroundColor = ConsoleColor.Red;

        Console.Write($"\n\t {this.health}");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($" / {this.healthMax}");
        Console.ForegroundColor = ConsoleColor.White;
    }
    
    public void setName(string name) => this.name = name;

    public string getName()=> this.name;
 
    public void setHealth(int health) => this.health = health;
 
    public int getHealth() => this.health;
   
    public void setEnergy(int energy) =>  this.energy = energy;

    public int getEnergy() => this.energy;
   
    public void setExp(int exp) => this.exp = exp;

    public int getExp() => this.exp;
   
    public void setLvl(int level) => this.level = level;

    public int getLvl() => this.level;

}