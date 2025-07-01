using GestionEmployer.Interfaces;
using System;

namespace GestionEmployer.Classes
{
    public class Manager : Employe, ITravailleur
    {
        public int EquipeTaille { get; }

        public Manager(string nom, decimal salaire, int equipeTaille)
            : base(nom, salaire) // Appel du constructeur de base pour nom et salaire
        {
            EquipeTaille = equipeTaille;
        }


        public override decimal CalculerPrime() // Le gars s'met bien
        {
            return Salaire * 0.20m + EquipeTaille * 100;
        }

        public string Travailler()
        {
            return $"Le manager {Nom} gère une équipe de {EquipeTaille} personnes.";
        }
    }
}
