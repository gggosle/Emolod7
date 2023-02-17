using System.Net.Mail;

namespace HomeWork;

public abstract class UComS : NameTrait
{
    protected int skillDamage = 0;
    protected int skillCost = 0;

    public UComS() => this.name = this.GetType().Name;

    public int calculateDamage(int skillDamage, int playerDamage, int enemyDefense)
    {
        return (skillDamage + playerDamage) - enemyDefense;
    }

    public void use(int damage, Base pl1, Base pl2, int defense)
    {
        int tmp = calculateDamage(this.skillDamage, damage, defense);
        if (tmp > 0)
        {
            pl1.setHealth(pl1.getHealth() - tmp);
        }
        pl2.setHealth(pl2.getHealth() - this.skillCost);
    }
}