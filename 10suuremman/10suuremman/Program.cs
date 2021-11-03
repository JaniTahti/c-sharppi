using System;

namespace _10suuremman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna luku joka on yhtäsuuri tai suurempi kuin 10");
            int x = int.Parse(Console.ReadLine());
            if(x < 10)
            {
                Console.WriteLine("Numero on liian pieni");
            }
            else
            {
                for (int i = 1; i < x; i++)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
