using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("S - Seconds");
                Console.WriteLine("M - Minutes");
                Console.WriteLine("Q - Quit");
                Console.Write("Enter an option: ");
                char option = char.Parse(Console.ReadLine().ToUpper());

                switch (option)
                {
                    case 'S': Start(getTime()); break;
                    case 'M': Start(getTime() * 60); break;
                    case 'Q': return;
                    default: continue;
                }
            }
        }

        static int getTime()
        {
            Console.Write("Enter the time: ");
            int time = int.Parse(Console.ReadLine());

            return time;
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime < time)
            {
                currentTime++;
                Console.Clear();
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Finished stopwatch.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
