using System;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
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
           while (true)
           {
               player.showInfo();
               mob.showInfo();
               player.showSkillList();
               int skillIndex = Convert.ToInt32(Console.ReadLine());

               player.useSkill(skillIndex, mob);
               if (mob.getHealth() < 0)
               {
                   Console.WriteLine("You won!");
                   break;
               }
               
               mob.useSkill(player);
               if (player.getHealth() < 0)
               {
                   Console.WriteLine("Monster's won!");
                   break;
               }
               Console.Clear();
           }
       }
   }
}








