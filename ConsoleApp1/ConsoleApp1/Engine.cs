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
        int hp = rand.Next(3, 21);
        return new Shield(hp, Names[rand.Next(0, 5)], (50 * hp) + rand.Next(20, 100));
    }
    public Weapon WeaponGen()
    {
        int hp = rand.Next(3, 21);
        string[] Names = {"Hidden Blade", "Blades of Chaos", "Moonlight Greatsword", "Pandora", "Energy Sword"};
        return new Weapon(hp, Names[rand.Next(0, 5)], (50 * hp) + rand.Next(20, 100));
    }

    public Potion PotionGen()
    {
        int size = rand.Next(1, 4);
        int price = size * 400 + rand.Next(20, 200);
        switch (rand.Next(0, 5))
        {
            case 0:
                return new AgilityPotion(size, price);
                break;
            case 1:
                return new EndurancePotion(size, price);
                break;
            case 2:
                return new StrenghtPotion(size, price);
                break;
            default:
                return new HealthPointPotion(size, price);
                break;
        }
    }
}