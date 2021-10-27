using System;

namespace Suurin5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kirjoita numero 1:"); double luku1 = double.Parse(Console.ReadLine());
            Console.Write("Kirjoita numero 2:"); double luku2 = double.Parse(Console.ReadLine());
            Console.Write("Kirjoita numero 3:"); double luku3 = double.Parse(Console.ReadLine());
            Console.Write("Kirjoita numero 4:"); double luku4 = double.Parse(Console.ReadLine());
            Console.Write("Kijroita numero 5:"); double luku5 = double.Parse(Console.ReadLine());

            double max = luku1;
            if (luku2 > max) max = luku2;
            if (luku3 > max) max = luku3;
            if (luku4 > max) max = luku4;
            if (luku5 > max) max = luku5;

            Console.WriteLine("Suurin on " + max);
        }
    }
}
