namespace HomeWork;

public class Barbarian : Player
{
    public Barbarian(string name,int level, Random rand) : base(name, level, rand)
        {
            this.health = 800;
            this.healthMax = 800;
            this.power = 10;
            this.agility = 5;
            this.endurance = 20;
        }
}