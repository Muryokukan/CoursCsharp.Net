using GestionEmployer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmployer.Classes
{
    public class Ingenieur : Employe, ITravailleur
    {
        public string Specialite { get; }

        public Ingenieur(string nom, decimal salaire, string specialite)
            : base(nom, salaire)
        {
            Specialite = specialite;
        }

        public override decimal CalculerPrime() // override pour changer la prime qui de base était de 0.10m
        {
            return Salaire * 0.15m;
        }

        public string Travailler()
        {
            return $"L'ingénieur {Nom} travaille sur des projets de {Specialite}.";
        }
    }

}
