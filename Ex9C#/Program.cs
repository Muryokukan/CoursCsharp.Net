using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class NotesUtil
{
    //public static double CalculerMoyenne(double totalPoints, double nombreNotes)
    //{
    //    if(nombreNotes == 0)
    //    {
    //        //throw new InvalidOperationException("Veuillez rentrez au minimum une note");
    //    }
    //    return totalPoints / nombreNotes;
    //}

    //public static double CalculerMoyenne(int[] notes)
    //{
    //    int total = 0;

    //    foreach (int n in notes)
    //    {
    //        total += n;
    //    }
    //    return (double)total / notes.Length;
    //}

    //public int AfficherStats()
    //{
    //    Console.WriteLine(CalculerMoyenne.Min(notes));
    //}

    static void Main(string[] args)
    {
        //Console.WriteLine("Nombre de notes à ajouter ?");

        //int nNombreNotes = int.Parse(Console.ReadLine());

        //List<int> notes = new List<int>();

        //for (int i = 0; i < nNombreNotes; i++)
        //{
        //    Console.Write($"Entrez la note {i + 1} : ");
        //    if (int.TryParse(Console.ReadLine(), out int note))
        //    {
        //        notes.Add(note);
        //    }else
        //    {
        //        Console.WriteLine("Valeur non valide. retenter.");
        //        i--;
        //    }
        //}

        //if (notes.Count > 0)
        //{
        //    double moyenne = CalculerMoyenne(notes.ToArray());
        //    Console.WriteLine($"La moyenne est : {moyenne:F2}");
        //}else
        //{
        //    Console.WriteLine("Aucune note saisie.");
        //}

        //AfficherStat();

        //---------------------------------------------------------------------------
        // Exo Boucle 

        //int n = 0;
        //while (n <= 10)
        //{

        //    Console.WriteLine(n);n++;
        //}

        //int n = 1;
        //int total = 0;
        //while (n <= 100)
        //{
        //    total += n;
        //    Console.WriteLine(total);
        //    n++;
        //}

        //double somme = 0;
        //double nombre;

        //Console.WriteLine("Entrez des nombres (0 pour avoir le total) :");

        //while (true)
        //{
        //    Console.Write("");
        //    string saisie = Console.ReadLine();

        //    if (double.TryParse(saisie, out nombre))

        //    {
        //        if (nombre == 0)
        //        {
        //            break;
        //        }
        //        somme += nombre;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Veuillez entrer un nombre valide.");
        //    }
        //}

        //Console.WriteLine($"total : {somme}");

        //for (int i = 1; i <= 9; i++)
        //{
        //    for (int e = 1; e <= 9; e++)
        //    {
        //        int total = e * i;
        //        Console.WriteLine($"{e}  {i} = {total}");
        //    }
        //}

            
        
    }


}
}
