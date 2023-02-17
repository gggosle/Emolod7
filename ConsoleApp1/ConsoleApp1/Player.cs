using System.Runtime.CompilerServices;

namespace HomeWork;

public class Player : Base
{
    protected int agility = 0;
    protected int power = 0;
    protected int endurance = 0;
    private Shield shield = null;
    private Weapon weapon = null;
    protected List<CombatSkill> skills = null;
    private Random rand = null;


    public Player(string name, int level, Random rand) : base(name, level)
    {
        this.skills = new List<CombatSkill>();
        this.rand = rand;
    }
    
    ~Player()
    { }

    public void SetAgl(int agility) => this.agility = agility;
    
    public int getAgl() => this.agility;
   
    public void setPw(int power) => this.power = power;

    public int getPw() => this.power;

    public void setEnd(int endurance) => this.endurance = endurance;
 
    public int getEnd() => this.endurance;

    public void setShield(Shield shield) => this.shield = shield;
    public Shield getShield() => this.shield;
    public void setWeapon(Weapon weapon) => this.weapon = weapon;
    public Weapon getWeapon() => this.weapon;

    public int getDamage()
    {
        int damage = 2 * this.power;

        if (this.weapon != null)
            damage += this.weapon.getHarm();

        if (this.rand.Next(1, 101) <= this.agility)
            damage *= 2;

        damage += this.rand.Next(1, 11);

        return damage;
    }

    public int getDefense()
    {
        int defense = 3 * this.endurance;

        if (this.shield != null)
            defense += this.shield.getDefense();

        return defense;
    }
    
    public void addSkill(CombatSkill skill)
    {
        this.skills.Add(skill);
    }

    public void showSkillList()
    {
        int index = 0;

        Console.WriteLine("Choose skill: ");
        foreach (var item in this.skills)
        {
            Console.WriteLine($"{index} - {item.getName()}");
            index++;
        }
    }

    public void useSkill(int index, Monster mob)
    {
        try
        {
            this.skills[index].use(this.getDamage(), mob, this, mob.getDef());
        }
        catch
        {
            Console.WriteLine("Index is outside the range. Try again");
            useSkill(Helper.GetVal(), mob);
        }
        
    }

}


