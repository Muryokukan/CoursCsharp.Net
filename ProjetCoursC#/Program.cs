using System;

class Program
{
    static int Additionner(int x, int y)
    {
        return x + y;
    }

    static void DireBonjour()
    {
        Console.WriteLine("Bonjour !");
    }

    static void AfficherSeparateur()
    {
        Console.Write(new string('-', 30));
    }

    static void Main(string[] args)
    {
        /*int[] entier = { 13, 31, 59 };

        foreach (int n in entier)
        {
            Console.Write(n + " ");
        }

        List<string> prenoms = new List<string> { "othman", "jean", "cedric", "omar" };
        Console.WriteLine("\n");
        int indexOf = 0;

        foreach (string p in prenoms)
        {
            Console.WriteLine(p + " " + indexOf);
            indexOf++;
        }

        Console.WriteLine("\n");

        Dictionary<string, string> pays = new Dictionary<string, string>
        {
            {"France", "Paris"},
            { "Japon", "Tokyo"},
            {"Italie", "Rome"},
            {"Allemagne", "Berlin"}

        };

        foreach (var entry in pays)
        {
            Console.WriteLine(entry.Key + " : " + entry.Value);
        }*/

        //________________________________________________________________________________________________________
        // PARTIE FONCTION

        /*DireBonjour();*/
        
        // Pour faire un séparateur -------------------------------------------
        /*AfficherSeparateur();

        Console.ReadKey();*/

        /*Console.WriteLine(Additionner(3, 5));*/



        Console.ReadKey();
    }
}
