using GestionEmployer.Classes;
using GestionEmployer.Interfaces;
using System;

class Program
{
    public static void SauterLigne()
    {
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Entreprise Nestlé = new Entreprise();

        Manager manager = new Manager("Alice", 3000m, 5);
        Ingenieur ingenieur  = new Ingenieur("Alicia", 3000m, "Web designer");
        Manager chef = new Manager("Bob", 4500m, 10); // Test ajout Chef

        Nestlé.AjouterEmploye(manager);
        Nestlé.AjouterEmploye(ingenieur);

        Nestlé.AjouterEmploye(chef); // Test ajout Chef

        Nestlé.FaireTravaillerTous();

        // Test
        //Console.WriteLine($"Prime de {manager.Nom} : {manager.CalculerPrime()}");
        //Console.WriteLine($"Prime de {ingenieur.Nom} : {ingenieur.CalculerPrime()}");

        foreach (var emp in Nestlé.Employes) // Pour check tous à la fois
        {
            Console.WriteLine($"{emp.Nom} a une prime de {emp.CalculerPrime()} euros.");
        }


        //try 
        //{
        //    Ingenieur test = new Ingenieur("", 2500m, "");
        //    Nestlé.AjouterEmploye(test);
        //    Console.WriteLine("Employé ajouté avec nom vide ! (à traiter)");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine($"Erreur détectée : {ex.Message}");
        //}

        SauterLigne();

        Console.WriteLine($"Nombre total d\'employés : {Nestlé.Employes.Count}");
        int nbManager = Nestlé.Employes.OfType<Manager>().Count();
        Console.WriteLine($"Managers : {nbManager}");
        int nbIng = Nestlé.Employes.OfType<Ingenieur>().Count();
        Console.WriteLine($"Ingénieurs : {nbIng}");

        SauterLigne();

        foreach (var emp in Nestlé.Employes)
        {
            if (emp is ITravailleur travailleur)
            {
                Console.WriteLine(travailleur.Travailler());
            }
        }

    }
}
