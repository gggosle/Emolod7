using System.Data;
using System.Diagnostics;
using System.Reflection.PortableExecutable;

namespace HomeWork;

public class Event
{
    private Player player = null;
    private Monster mob = null;
    private Engine eng = null;
    private Random rand = null;

    public Event(Player player, Engine eng)
    {
        this.player = player;
        this.eng = eng;
    }
    public void shop()
    {
        Build[] items = new Build[9];
        int ch = 0;
        Console.WriteLine($"Your cash: {player.getCash()}");

        Console.WriteLine("You're in a shop. Here you can buy armor, weapon or potion");
        for (int i = 0; i < 9; i++)
        {
            if (i < 3)
            {
                items[i] = eng.ShieldGen();
            }
            else if(i < 6)
            {
                items[i] = eng.WeaponGen();
            }
            else
            {
                items[i] = eng.PotionGen();
            }
            Console.WriteLine($"{i + 1}. {items[i].getName()} - {items[i].getProperty()} - {items[i].getPrice()}");
        }
        Console.WriteLine("Input the number of an index if you want to buy smt");
        try
        {
            while (true)
            {
                ch = Helper.GetVal();
                if (player.getCash() - items[ch - 1].getPrice() < 0)
                {
                    Console.WriteLine("Not enough money");
                    continue;
                }

                player.setCash(-items[ch - 1].getPrice());
                if (ch < 4)
                {
                    player.setShield((Shield)items[ch - 1]);
                }
                else if (ch < 7)
                {
                    player.setWeapon((Weapon)items[ch - 1]);
                }
                else
                {
                    player.setPotion((IDrink)items[ch-1]);
                }

                break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Exit.");
        }
    }

    private bool fight_show(Base bas, Base ba)
    {
        Console.Clear();
        player.showInfo();
        mob.showInfo();
        if (bas.getHealth() < 0)
        {
            Console.WriteLine($"{ba.getName()} won!");
            return false;
        }
        return true;
    }
    public void fight()
    {
        this.mob = eng.MonsterGen(this.player.getLvl());
        player.showInfo();
        mob.showInfo();
        bool h = true;
        while (h == true)
        {
            player.showSkillList();
            try
            {
                int skillIndex = Helper.GetVal();
                player.useSkill(skillIndex, mob);
            }
            catch
            {
                Console.WriteLine("Miss!!!");
            }

            if (false == fight_show(mob, player))
            {
                player.setCash(mob.getCash());
                player.setExp(mob.getExp());
                break;
            } 
            if (player.getPotions().Count > 0)
            {
                try
                {
                    Console.WriteLine("U want to use potion? 0 - yes");
                    if (Helper.GetVal() == 0)
                    {
                        player.showPotion();
                        Console.WriteLine("Write down the index");
                        int ch = Helper.GetVal() - 1;
                        player.getPotions()[ch].drink(player);
                        player.remPot(ch);
                    }
                }
                catch{}
            }
            mob.useSkill(player);
            if (false == fight_show(player, mob))
            {
                player.setCash(-mob.getCash());
                break;
            } 
        }
    }

    public void trap()
    {
        string[] cases = {"You found an old temple and got into trap", "Somebody's robbed you in the night", "You've got arrested", "You've drown while trying to cross the river" };
        /*switch (rand.Next(0, 4))
        {
            case 0:
                this.player.setCash(-this.player.getCash());
                this.player.setWeapon(null);
                this.player.setShield(null);
                this.player.setPotions(null);
                Console.WriteLine("Unfortunately, you've lost everything");
                break;
            case 1:
                
        }*/
        
        

    }
    public void rest(){}

    public void charact()
    {
        Console.WriteLine(player.getName());
        Console.WriteLine($"Cash: {player.getCash()}");
        Console.WriteLine($"Shield: {player.getShield().getName()}");
        Console.WriteLine($"Weapon: {player.getWeapon().getName()}");
        Console.WriteLine($"Potions: ");
        player.showPotion();
        Console.WriteLine($"Strength: {player.getPw()}");
        Console.WriteLine($"Agility: {player.getAgl()}");
        Console.WriteLine($"Endurance: {player.getEnd()}");
    }
    public void lvlUp()
    {
        Console.WriteLine("Congrats! You've reached new level");
        this.player.setExp(-this.player.getExp());
        this.player.setLvl(this.player.getLvl()+1);
        charact();
    }
}
