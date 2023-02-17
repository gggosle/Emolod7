namespace HomeWork;

public class Robber : Player
{
    public Robber(string name, int level,Random rand) : base(name, level, rand)
    {
        this.health = 500;
        this.healthMax = 500;
        
        this.power = 5;
        this.agility = 20;
        this.endurance = 10;
    }
}