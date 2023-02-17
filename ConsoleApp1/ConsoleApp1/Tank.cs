namespace HomeWork;

public class Tank : Player
{
    public Tank(string name,int level, Random rand) : base(name, level, rand)
    {
        this.health = 1200;
        this.healthMax = 1200;
        this.power = 20;
        this.agility = 10;
        this.endurance = 5;
    }
}