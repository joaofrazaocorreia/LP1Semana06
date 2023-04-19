using System;

namespace GameSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many foes? ");
            int foeCount = int.Parse(Console.ReadLine());

            Foe[] myFoes = new Foe[foeCount];

            for (int i = 0; i < foeCount; i++)
            {
                Console.Write($"Name of foe num. {i+1}:");
                myFoes[i] = new Foe(Console.ReadLine());
            }
        }
    }
}
