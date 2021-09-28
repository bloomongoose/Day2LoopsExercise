using System;

namespace Day2Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mini exercise practicing loops

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            
            }

            bool runProgram = true;

            while(runProgram)
            {
                Console.WriteLine("Do you wish to continue looping? y/n");
                string answer = Console.ReadLine();

                if (answer == "y")
                {
                    runProgram = true;
                }

                else if (answer == "n" || answer == "")
                {
                    runProgram = false;
                }

            }

            int sum = 0;
            
            for (int i = 0; i <=5; i++)
            {
                sum += i;               
            }
            Console.WriteLine(sum);




        }
    }
}
