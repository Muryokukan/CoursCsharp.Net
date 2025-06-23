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

    static bool EstPair(int nombre)
    {
        return nombre % 2 == 0;

        /*if(nombre % 2 == 0) { return "oui"; }
        else { return "non";}*/
    }

    static void Aboyer(string nom, string aboiement = "Wouaf")
    {
        Console.WriteLine($"{nom} aboie comme ça : {aboiement}");
    }

    static double CalculerTTC(double prixHT, double TVA = 0.20)
    {
        return prixHT * (1 + TVA);
    }

    //___________________________________________________________________________________________________________

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


        /*Console.WriteLine(Additionner(3, 5));
        Console.WriteLine(Additionner(10, 20));
        Console.WriteLine(Additionner(-5, 8));*/

        /*Console.WriteLine(EstPair(33));

        Aboyer("Médor");
        Aboyer("Pochi", "Wouf");*/

        Console.WriteLine(CalculerTTC(100));
        Console.WriteLine($"{CalculerTTC(100, 0.10):F2}"); 
        // :F2 pour deux décimal pour éviter l'imprécision du double
        // ou bien remplacer double par decimal

        Console.ReadKey();
    }
}
