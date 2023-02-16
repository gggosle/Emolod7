namespace HomeWork;

public class Tank : Player
{
    public Tank(string name,int level) : base(name,level)
    {
        this.power = 20;
        this.agility = 10;
        this.endurance = 5;
    }
}