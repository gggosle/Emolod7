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
    private List<IDrink> potions = null;
    private int expMax = 0;
    
    


    public Player(string name, int level, Random rand) : base(name, level)
    {
        this.skills = new List<CombatSkill>();
        this.rand = rand;
        potions = new List<IDrink>();
    }
    
    ~Player()
    { }


    public void showPotion()
    {
        foreach (var x in potions.Select((value, index) => new { value, index }))
        {
            Console.WriteLine(x.index+1 + ". " + x.value.getName() + "-" + x.value.getProperty());
        }
    }

    public void setExp(int exp)
    {
        if (this.exp + exp > expMax)
        {
            this.exp = expMax;
        }
        this.exp += exp;
    } 
    public void setPotions(List<IDrink> pot) => this.potions = pot;
    public List<IDrink> getPotions() => this.potions;
    public void remPot(int index) => this.potions.RemoveAt(index);

    public void setCash(int cash)
    {
        if (this.cash + cash < 0)
        {
            this.cash = 0;
        }
        else
        {
            this.cash += cash;
        }
         
    }
    public int getCash() => this.cash;

    public void setPotion(IDrink pot) => this.potions.Add(pot);
    public void addAgl(int agl_p) => this.agility += agl_p;
    public void addStr(int str_p) => this.power += str_p;
    public void addEnd(int end_p) => this.endurance += end_p;
    public void heal(int healthP)
    {
        this.health += healthP;
        if (this.health > this.healthMax)
        {
            this.health = this.healthMax;
        }
    }

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
            damage += this.weapon.getProperty();

        if (this.rand.Next(1, 101) <= this.agility)
            damage *= 2;

        damage += this.rand.Next(1, 11);

        return damage;
    }

    public int getDefense()
    {
        int defense = 3 * this.endurance;

        if (this.shield != null)
            defense += this.shield.getProperty();

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


