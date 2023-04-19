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
                Console.Write($"Name of foe num. {i+1}: ");
                myFoes[i] = new Foe(Console.ReadLine());
            }

            Console.WriteLine("");
            foreach (Foe f in myFoes)
            {
                Console.WriteLine(f.GetName());
            }

            Console.WriteLine("");
            Console.WriteLine($"Foe {myFoes[0].GetName()}'s stats:");
            Console.WriteLine($"{myFoes[0].GetHealth()} Health, "+
                                $"{myFoes[0].GetShield()} Shield");

            Console.WriteLine("");
            Console.WriteLine($"Foe {myFoes[0].GetName()} takes 50.5 damage!");
            myFoes[0].TakeDamage(50.5f);

            Console.WriteLine("");
            Console.WriteLine($"Foe {myFoes[0].GetName()}'s stats:");
            Console.WriteLine($"{myFoes[0].GetHealth()} Health, "+
                                $"{myFoes[0].GetShield()} Shield");

            Console.WriteLine("");
            Console.WriteLine($"Foe {myFoes[0].GetName()} gets 4.2 shield!");
            myFoes[0].PickupPowerUp(PowerUp.Shield, 4.2f);

            Console.WriteLine("");
            Console.WriteLine($"Foe {myFoes[0].GetName()}'s stats:");
            Console.WriteLine($"{myFoes[0].GetHealth()} Health, "+
                              $"{myFoes[0].GetShield()} Shield");

            Console.WriteLine("");
            Console.WriteLine($"Foe {myFoes[0].GetName()} heals 80 health!");
            myFoes[0].PickupPowerUp(PowerUp.Health, 80f);

            Console.WriteLine("");
            Console.WriteLine($"Foe {myFoes[0].GetName()}'s stats:");
            Console.WriteLine($"{myFoes[0].GetHealth()} Health, "+
                                $"{myFoes[0].GetShield()} Shield");

            
            Console.WriteLine("");
            Console.WriteLine($"Number of powerups used: "+
                              $"{Foe.GetPowerupAmount()}");

            Console.WriteLine("");
            Console.WriteLine("Merci d'utiliser ce programme!");
        }
    }
}
