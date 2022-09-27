using System;

namespace EasyCycle
{
    class Program
    {
        static void Main(string[] args)
        {
            string voice;
            int count;

            Console.WriteLine($"Какие звуки издает животное, которе на \"ля\" начинается и \"гушка\" заканчивается? ");
            voice = Console.ReadLine();

            Console.Write($"сколько раз издать этот звук? ");
            count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{voice} ");
            }

            Console.WriteLine();
        }
    }
}
