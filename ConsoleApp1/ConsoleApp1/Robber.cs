namespace HomeWork;

public class Robber : Player
{
    public Robber(string name, int level) : base(name, level)
    {
        this.power = 5;
        this.agility = 20;
        this.endurance = 10;
    }
}