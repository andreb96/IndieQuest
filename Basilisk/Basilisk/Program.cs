using System;
using System.Collections.Generic;
using System.Linq;

namespace Basilisk
{
    class Program
    {
        static void Main(string[] args)
        {
            var NameList = new List<string> { "Seofl", "André", "Css", "Omar" };
            String Names = "";
            var numbergen = new Random();
            int basiliskHp = 0;
            foreach (string Name in NameList)
            {
                Names += Name + " ";
            }
            Console.WriteLine($"A party of warriors ({Names}) descends into the dungeons");
            for (int i = 0; i < 8; i++)
            {
                basiliskHp += numbergen.Next(1, 9);
            }
            basiliskHp += 16;
            Console.WriteLine($"A basilisk with {basiliskHp}HP appears!");
            while (basiliskHp > 0) {
                if (NameList.Count == 0)
                {
                    break;
                }
                foreach (string Name in NameList)
                { 
                    int damage = 0;
                    damage += numbergen.Next(1, 5);
                    basiliskHp -= damage;
                    if (basiliskHp <= 0)
                    {
                        Console.WriteLine($"{Name} hits the basilisk for {damage}. Basilisk has died.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{Name} hits the basilisk for {damage}. Basilisk has {basiliskHp}HP left.");   
                    }
                }
                if (basiliskHp > 0) { 
                
                var BasiliskTargetIndex = numbergen.Next(0, NameList.Count);
                var BasiliskTarget = NameList[BasiliskTargetIndex];
                Console.WriteLine($"The Basilisk uses petrifying gaze on {BasiliskTarget}");
                int ConstitutionRoll = numbergen.Next(1, 21);
                int Constitution = 5 + ConstitutionRoll;
                if (Constitution < 12)
                {
                    Console.WriteLine($"{BasiliskTarget} rolls {ConstitutionRoll} and is petrified.");
                    NameList.Remove(BasiliskTarget);
                }
                else
                {
                    Console.WriteLine($"{BasiliskTarget} rolls {ConstitutionRoll} and is saved.");
                }
                }
                
            }
            if (basiliskHp <= 0)
            {
                Console.WriteLine("The basilisk collapses and the heroes celebrate their victory!");
            }
            else
            {
                Console.WriteLine("The heroes has all been petrified, the basilisk wins.");
            }


        }
    }
}
