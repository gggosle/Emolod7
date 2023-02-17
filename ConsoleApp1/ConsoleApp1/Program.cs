using System;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Xml;

namespace HomeWork
{

   internal class Homework
   {
       static void Main(string[] args)
       {
           Random rand = new Random();
           Engine engine = new Engine(rand);
           
           Player player = engine.PlayerGen();
           Monster mob = engine.MonsterGen(player.getLvl());
           Event ev = new Event(player, engine);
           player.setPotion(new HealthPointPotion(3, 120));
           ev.shop();
           ev.fight();
           ev.shop();
           
       }
   }
}








