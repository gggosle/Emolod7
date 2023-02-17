namespace HomeWork;

public class Engine
{
    private Random rand = null;


    public Engine(Random rand)
    {
        this.rand = rand;
        

    }
    public Monster MonsterGen(int level)
    {
        string[] Names = {"Murloc", "Reaper", "Dark Ganon", "The Daedra", "Frieza", "Darkspawn Ogre", "Head Crab", "Abomination", "Brutalisk", "Spriggan"};
        
        
        if (level == 1)
            level += this.rand.Next(0, 2);
        else
            level += this.rand.Next(-1, 2);
        return new Monster(Names[rand.Next(0, 10)], level, rand);
    }

    public Player PlayerGen()
    {
        Console.WriteLine("Choose your class 1 - Tank, 2 - Robber, 3 - Barbarian: ");
        int choice = Helper.GetVal();
        Player player = null;
        switch (choice)
        {
            case 1:
                player = new Tank(Helper.GetString(), 1, this.rand);
                player.addSkill(new ForceSprint());
                player.addSkill(new PsychoCrusher());
                player.addSkill(new SoulFist(this.rand));

                break;
            case 2:
                player = new Robber(Helper.GetString(), 1, this.rand);

                player.addSkill(new HurricaneKick());
                player.addSkill(new TigerKnee());
                player.addSkill(new BurnKnuckle());

                break;
            case 3:
                player = new Barbarian(Helper.GetString(), 1, this.rand);
                player.addSkill(new FireBall());
                player.addSkill(new SplitPunch());
                player.addSkill(new Backstab());

                break;
            default:
                Console.WriteLine("Index was out of range. Try again");
                player = PlayerGen();
                break;
        }


        return player;

    }

    public Shield ShieldGen()
    {
        string[] Names = {"Spiralhorn Shield", "Kite Shield", "Erdtree Greatshield", "Jellyfish Shield", "Brass Shield"};
        return new Shield(rand.Next(3, 21), Names[rand.Next(0, 5)]);
    }
    public Weapon WeaponGen()
    {
        string[] Names = {"Hidden Blade", "Blades of Chaos", "Moonlight Greatsword", "Pandora", "Energy Sword"};
        return new Weapon(rand.Next(3, 21), Names[rand.Next(0, 5)]);
    }
}