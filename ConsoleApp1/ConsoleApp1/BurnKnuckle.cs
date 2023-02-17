namespace HomeWork;

public class BurnKnuckle: UComS, CombatSkill
{
    private int skillDamage = 180;
    public BurnKnuckle() : base()
    {
        this.skillDamage = 180;
        this.skillCost = 80;

    }
}