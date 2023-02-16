namespace HomeWork;

public class Engine
{
    private Random rand = null;
    private Helper helper = null;

    public Engine(Random rand, Helper help)
    {
        this.rand = rand;
        this.helper = help;

    }
    Monster MonsterGen(int lvl)
    {
        string[] Names = {"Murloc", "Reaper", "Dark Ganon", "The Daedra", "Frieza", "Darkspawn Ogre", "Head Crab", "Abomination", "Brutalisk", "Spriggan"};
        Monster monster = new Monster(Names[rand.Next(0, 10)], rand.Next(lvl-1, lvl+2));
        return monster;
    }

    Player PlayerGen()
    {
        int choice = helper.GetVal();
        Player player = null;
        switch (choice)
        {
            case 0: 
                Tank tank = new Tank(helper.GetString(), 0);
                player = tank;
                break;
            case 1:
                Robber rob = new Robber(helper.GetString(), 0);
                player = rob;
                break;
            case 2:
                Barbarian barb = new Barbarian(helper.GetString(), 0);
                player =  barb;
                break;
        }

        return player;

    }
}