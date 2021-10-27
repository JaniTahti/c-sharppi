using System;

namespace Harjotuksia1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna numero");
            int luku1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna toinen numero");
            int luku2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna kolman numero");
            int luku3 = int.Parse(Console.ReadLine());


            if ( luku1 > luku2 )
            {
                if (luku1 > luku3)
                {
                    Console.WriteLine("Isoin luku on " + luku1);
                }
                else
                {
                    Console.WriteLine("Isoin luku on " + luku3);
                }
            }
            else
            {
                if (luku2 > luku3)
                {
                    Console.WriteLine("Isoin luku on " + luku2);
                }
                else
                {
                    Console.WriteLine("Isoin luku on " + luku3);
                }

            }
        }   

    }
}
