using GestionEmployer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmployer.Classes
{
    public class Entreprise
    {
        private List<Employe> employes; // Boite à Employer

        public Entreprise() // Création d'entreprise (vide)
        {
            employes = new List<Employe>();
        }

        public void AjouterEmploye(Employe employe) // Ici j'ajoute l'employer
        {
            employes.Add(employe);
        }

        public List<Employe> Employes
        {
            get { return employes; }
        }

        public void FaireTravaillerTous() // ON check leurs différents travails
        {
            foreach (var employe in employes)
            {
                if (employe is ITravailleur travailleur)
                {
                    Console.WriteLine(travailleur.Travailler());
                }
            }
        }
    }
}
