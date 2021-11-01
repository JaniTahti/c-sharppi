using System;

namespace Harjotus2
{
    class Program
    {
        static void Main(string[] args)
        {

            int a;
            int b;
            int large;

            
            Console.Write("Lisää eka numero : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lisää toka numero: ");
            b = Convert.ToInt32(Console.ReadLine());

           
            if (a > b)
                large = a;
            else
                large = b;

           
            Console.WriteLine("Suurempi numero on {0}", large);
        }
    }
}
