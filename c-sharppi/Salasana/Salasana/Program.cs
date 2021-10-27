using System;

namespace Salasana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna numero 0-9 välillä ja annamme sinulle salasanasi:");
            String lue = Console.ReadLine();
            switch(lue)
            {
                case "0":
                    Console.WriteLine("NollaNollaaNolaaToisensa");
                    break;
                case "1":
                    Console.WriteLine("YksiYkkönenYksi");
                    break;
                case "2":
                    Console.WriteLine("KaksiKakkostaKahdestaan");
                    break;
                case "3":
                    Console.WriteLine("KolmeKolmostaKolmestaan");
                    break;
                case "4":
                    Console.WriteLine("NeljäNeulaaNeljistään");
                    break;
                case "5":
                    Console.WriteLine("ViisiVitostaViidestän");
                    break;
                case "6":
                    Console.WriteLine("KuusiKutostaKuudestaan");
                    break;
                case "7":
                    Console.WriteLine("SeitsemänSeiskaaSeisallaan");
                    break;
                case "8":
                    Console.WriteLine("KahdeksanKasiiPitääKäsiä");
                    break;
                case "9":
                    Console.WriteLine("YhdeksänYsiiYhdestään");
                    break;
                default:
                    Console.WriteLine("virhe lisää numero tai pidä numero 0-9 välillä");
                    break;

            }
        }
    }
}
