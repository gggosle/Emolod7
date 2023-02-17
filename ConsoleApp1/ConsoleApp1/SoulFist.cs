namespace HomeWork;

public class SoulFist:UComS, CombatSkill
{
    private Random rand = null;
    public SoulFist(Random rand) : base()
    {
        this.rand = rand;
        this.skillDamage = rand.Next(100, 401);
        this.skillCost = 90;

    }

}