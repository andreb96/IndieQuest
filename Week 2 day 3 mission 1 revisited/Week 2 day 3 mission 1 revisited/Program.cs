using System;

namespace Week_2_day_3_mission_1_revisited
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var numberGen = new Random();
            int firstThrow = numberGen.Next(0, 11);
            int secondThrow = numberGen.Next(0, 11 - firstThrow);

            
            
            if(firstThrow < 10)
            {
                if(firstThrow == 0)
                {
                    Console.WriteLine($"First roll: -");
                }
                else
                {
                    Console.WriteLine($"First roll: {firstThrow}");

                }
                if (secondThrow == 0)
                {
                    Console.WriteLine($"Second roll: -");

                }
                else if (firstThrow + secondThrow == 10)
                {
                    Console.WriteLine($"Second roll: /");
                }
                else
                {
                    Console.WriteLine($"Second roll: {secondThrow}");
                }
            }
            else
            {
                
                Console.WriteLine($"First roll: X");
            }
            Console.WriteLine($"Knocked pins: {firstThrow + secondThrow}");

        }
    }
}
