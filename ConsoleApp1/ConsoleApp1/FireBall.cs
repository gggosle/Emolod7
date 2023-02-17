namespace HomeWork;

public class FireBall: UComS, CombatSkill
{
    public FireBall() : base()
    {
        this.skillDamage = 50;

    
    }

    public void use(int damage,Base pl1,Base pl2, int defense)
    {
        int tmp = calculateDamage(50, damage, defense);
        if (tmp > 0)
        {
            pl1.setHealth(pl1.getHealth() - tmp);
        }
    }
}