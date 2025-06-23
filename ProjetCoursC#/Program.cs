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

    static int Multiplier(int a, int b)
    {
        return a * b;
    }
    
    static int Multiplier(int a, int b, int c)
    {
        return a * b * c;
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

        *//*Aboyer("Médor");
        Aboyer("Pochi", "Wouf");*//*

        Console.WriteLine(CalculerTTC(100));
        Console.WriteLine($"{CalculerTTC(100, 0.10):F2}"); 
        // :F2 pour deux décimal pour éviter l'imprécision du double
        // ou bien remplacer double par decimal*/


        /*Console.WriteLine(Multiplier(5, 5));
        Console.WriteLine(Multiplier(2, 3, 4));*/

        // EXO 8 Alexandre taille

        Console.Write("Taille en cm : ");
        int taille = int.Parse(Console.ReadLine());

        Console.Write("Poids en kg : ");
        int poids = int.Parse(Console.ReadLine());

        if (taille >= 145 && taille <= 169 && poids <= 65)
        {
            Console.WriteLine("Taille 1");
        }
        else if (taille >= 170 && taille <= 179 && poids <= 75)
        {
            Console.WriteLine("Taille 2");
        }
        else if (taille >= 180 && taille <= 189 && poids <= 85)
        {
            Console.WriteLine("Taille 3");
        }
        else
        {
            Console.WriteLine("trop grand ou trop gros (pense à faire un régime");
        }

        Console.ReadKey();
    }
}
