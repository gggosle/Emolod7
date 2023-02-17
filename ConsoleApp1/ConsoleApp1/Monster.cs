using System.Data;
using System.Runtime.CompilerServices;

namespace HomeWork;

public class Monster : Base
{

    private int harm = 0;
    private int defense = 0;
    private Random rand = null;
    CombatSkill[] skills = null;
    
   


    public Monster( string name,int level, Random rand): base(name, level)
    {
        this.level = level;
        this.harm = level * 9;
        this.defense = level * 12;
        this.exp = level * 50;
        this.rand = rand;
        this.health = this.healthMax = level * 500;
        this.skills = new CombatSkill[]
        {
            new Backstab(), new BurnKnuckle(), new FireBall(), new ForceSprint(), new HurricaneKick(),
            new PsychoCrusher(), new SplitPunch(), new TigerKnee(), new SoulFist(rand)
        };
        this.cash = level * 30 + rand.Next(0, 300);
    }
    ~Monster()
    { }

    public int getCash() => this.cash;
    public void setHarm(int harm) => this.harm = harm;
  
    public int getHarm() => this.harm;
  
    public void setDef(int defense) => this.defense = this.defense;

    public int getDef() => this.defense;
    
    public void useSkill(Player pl)
    {
        this.skills[this.rand.Next(0, 9)].use(this.getHarm(), pl, this, pl.getDefense());
    }
  
}