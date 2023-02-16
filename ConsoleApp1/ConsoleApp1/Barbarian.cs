namespace HomeWork;

public class Barbarian : Player
{
    public Barbarian(string name,int level) : base(name, level)
        {
            this.power = 10;
            this.agility = 5;
            this.endurance = 20;
        }
}