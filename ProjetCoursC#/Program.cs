using System;

class Program
{
    static void Main(string[] args)
    {
        int[] entier = { 13, 31, 59 };

        

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
        }

        static void DireBonjour()
        {
            Console.WriteLine("Bonjour !");
        }

        DireBonjour();

    }
}
