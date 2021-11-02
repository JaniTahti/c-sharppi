using System;

namespace PerusLasku
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna yksi numero niin numero lasketaan 4:jällä lasku tavalla");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Perus lasku toimitus");
            Console.WriteLine(x + 13);
            Console.WriteLine(x * 13);
            Console.WriteLine(x / 13);
            Console.WriteLine(x - 13);
        }
    }
}
