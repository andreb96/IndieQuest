using System;
using System.Globalization;
using Microsoft.Win32.SafeHandles;

namespace Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name, commander?");
            String Name = Console.ReadLine();
            Random DistanceOfTAnk = new Random();
            int TankDistance = DistanceOfTAnk.Next(40, 71);
            String result = "_/";
            Console.WriteLine($"Commander {Name}, the enemy is sending a tank towards us. We have to use our artilery to shoot it down");
            for (int i = 0; i < 78; i++){
                
                if (i != TankDistance)
                {
                    result += "_";
                }
                else
                {
                    result += "T";
                }
                
            }
            Console.WriteLine(result);
            int NumberOfShots = 5;
            bool TankHit = false;
            while (NumberOfShots > 0) {
                Console.WriteLine($"Aim your shot, {Name}");
                String numberText = Console.ReadLine();
                int ShotDistance = Int32.Parse(numberText);
                String BlastRange = "";
                for (int i = 0; i <= ShotDistance + 2; i++)
                {

                    if (i != ShotDistance + 2)
                    {
                        BlastRange += " ";
                    }
                    else
                    {
                        BlastRange += "*";
                    }

                }
                Console.WriteLine(BlastRange);
                if (ShotDistance < TankDistance)
                {
                    Console.WriteLine("Oh no your shot was to short.");
                }
                else if(ShotDistance > TankDistance)
                {
                    Console.WriteLine("Oh no your shot was to far.");
                }
                else
                {
                    TankHit = true;
                    Console.WriteLine($"The tank has been destroyed, nice shot {Name}"); 
                    break;
                }
                NumberOfShots--;

            }
            if (!TankHit)
            {
                Console.WriteLine("You are out of ammunition, game over");
            }


        }
    }
}
