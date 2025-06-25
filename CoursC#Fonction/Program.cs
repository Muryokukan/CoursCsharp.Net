using System.Collections.Generic;

namespace ConsoleAppsemaine1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] tableauOriginal = { 5, 8, 13 };

            //AnalyseNombres(tableauOriginal);

            Func<int, int> triple = x => x * 3;
            Console.WriteLine(triple(10));

            //funky<int, int> triple = x * 3 =>
            //{
            //    string message = $"Bonjour {nom} !";
            //    Console.WriteLine(message);
            //};

            List<int> maListe = [1, 11, 14];

            //Func<int> maListe.RemoveAll(x => x % 2 != 0);
            //Console.WriteLine(maListe);

            var nombresCarrés = nombres.RemoveAll(x => x * x);
            Console.WriteLine(string.Join(", ", nombresCarrés));

            Console.ReadKey();
        }


    }
}