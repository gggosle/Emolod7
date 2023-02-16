namespace HomeWork;

public class Monster : Base
{
    
    private int harm = 0;
    private int defense = 0;
   


    public Monster( string name,int level): base(name, level)
    {
        this.harm = level * 11;
        this.health = level * 120;
        this.healthMax = level * 120;
        this.defense = level * 8;
        this.exp = level * 20;
    }
    ~Monster()
    { }
   
    public void setHarm(int harm) => this.harm = harm;
  
    public int getHarm() => this.harm;
  
    public void setDef(int defense) => this.defense = this.defense;

    public int getDef() => this.defense;
  
}