using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmployer.Classes
{
    public abstract class Employe
    {
        public string Nom { get; }

        public decimal Salaire { get; protected set; }

        public static int NombreTotalEmployes { get; private set; }

        // le constructeur oblige à donner le nom et le salaire
        public Employe(string nom, decimal salaire)
        {
            if (string.IsNullOrWhiteSpace(nom))
                throw new ArgumentException("Le nom ne doit pas être vide.", nameof(nom));

            if (salaire <= 0)
                throw new ArgumentException("Le salaire doit être positif.", nameof(salaire));

            Nom = nom;
            Salaire = salaire;
            NombreTotalEmployes++;
        }

        public virtual decimal CalculerPrime() // pour pouvoir modifié même dans la classe enfant (si j'ai bien compris)
        {
            return Salaire * 0.10m;
        }

        public static void AfficherNombreEmployes()
        {
            Console.WriteLine($"Nombre total d'employés : {NombreTotalEmployes}");
        }
    }
}
