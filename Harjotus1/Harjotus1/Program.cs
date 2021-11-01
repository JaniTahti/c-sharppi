using System;

namespace Harjotus1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+");
            Console.WriteLine("Anna enisinmäinen numero");
            int luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen numero");
            int luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (luku1 + luku2));

            Console.WriteLine("-");
            Console.WriteLine("Anna enisinmäinen numero");
            int luku3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen numero");
            int luku4 = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (luku3 - luku4));

            Console.WriteLine("*");
            Console.WriteLine("Anna enisinmäinen numero");
            int luku5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen numero");
            int luku6 = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (luku5 * luku6));

            Console.WriteLine("/");
            Console.WriteLine("Anna enisinmäinen numero");
            int luku8 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen numero");
            int luku9 = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (luku8 / luku9));

            Console.WriteLine("%");
            Console.WriteLine("Anna enisinmäinen numero");
            int luku10 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen numero");
            int luku11 = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (luku10 % luku11));

            Console.WriteLine("+=");
            Console.WriteLine("Anna enisinmäinen numero");
            int luku12 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen numero");
            int luku13 = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (luku12 += luku13));

            Console.WriteLine("-=");
            Console.WriteLine("Anna enisinmäinen numero");
            int luku14 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen numero");
            int luku15 = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (luku14 -= luku15));

            Console.WriteLine("*=");
            Console.WriteLine("Anna enisinmäinen numero");
            int luku16 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen numero");
            int luku17 = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (luku16 *= luku17));

            Console.WriteLine("/=");
            Console.WriteLine("Anna enisinmäinen numero");
            int luku18 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen numero");
            int luku19 = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (luku18 /= luku19));
        }
    }
}
