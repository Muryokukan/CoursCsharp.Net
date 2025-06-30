/*using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Qu'elle jour de la semaine sommes-nous");
int jourSemaine;

jourSemaine = Convert.ToInt32(Console.ReadLine());


switch (jourSemaine) {
    case 1:
        Console.WriteLine("On est Lundi");
        break;
    case 2:
        Console.WriteLine("On est Mardi");
        break;
    case 3:
        Console.WriteLine("On est Mercredi");
        break;
    case 4:
        Console.WriteLine("On est Jeudi");
        break;
    case 5:
        Console.WriteLine("On est Vendredi");
        break;
    case 6:
        Console.WriteLine("On est Samedi");
        break;
    case 7:
        Console.WriteLine("On est Dimanche");
        break;
    default:
    Console.WriteLine("Rentrer un chiffre entre 1 et 7");
        break;
};*/

/*-------------------------------------------------------------------------------------*/

/*double somme = 0;
double nombre;

Console.WriteLine("Entrez des nombres (0 pour avoir le total) :");

while (true)
{
    Console.Write("");
    string saisie = Console.ReadLine();

    if (double.TryParse(saisie, out nombre))

    {
        if (nombre == 0)
        {
            break;
        }
        somme += nombre;
    }else
    {
        Console.WriteLine("Veuillez entrer un nombre valide.");
    }
}

Console.WriteLine($"total : {somme}");*/


/*-------------------------------------------------------------------------------------*/


/*double[] notes = { 10, 12, 15, 8 };
double sum = 0;

for(int i = 0; i < notes.Length; i++)
{
    sum + notes[i];
}
double average = sum / notes.Length;

Console.WriteLine(average);*/

/*-------------------------------------------------------------------------------------*/


/*Console.WriteLine("nombre de personne à ajouter ?");

int nombrePrenoms = Console.ReadLine();*/

/*List<string> firstName = new List<string>();*/

/*string prenom = ConsoleWriteLine();

while (firstName.length < nombresPrenom )
{
    firstName.Add(prenom);
}*/

/*-------------------------------------------------------------------------------------*/

/*var capitals = new Dictionary<string, string>
{
    ["France"] = "Paris",
    ["Espagne"] = "Madrid",
    ["Japon"] = "Tokyo"
};

capitals.Add("Italie", "Rome");

var city = capitals["France"];

Console.WriteLine(city);*/


/*using System;
using System.Collections.Generic;

Dictionary<string, string> myDict = new Dictionary<string, string>();

myDict.Add("France", "Paris");
myDict.Add("Japon", "Tokyo");
myDict.Add("Allemagne", "Berlin");

Console.WriteLine("ajouter d'un pays et de la capitale");
string userAdd = Console.ReadLine();

if (myDict.ContainsKey(userAdd))
{
    Console.WriteLine("Déjà présent dans la liste");
    
}else
{
    string capitale = Console.ReadLine();
    myDict.Add(userAdd, capitale);
}
;*/

/*-------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;

class Program
{
    // Fonction pour centrer le texte dans la console
    static void EcrireCentre(string texte)
    {
        int largeurConsole = Console.WindowWidth;
        int espaces = (largeurConsole - texte.Length) / 2;
        Console.WriteLine(new string(' ', Math.Max(0, espaces)) + texte);
    }

    // Fonction pour créer une ligne de séparation centrée
    static void LigneSeparation(int longueur = 50)
    {
        EcrireCentre(new string('-', longueur));
    }

    // Fonction pour afficher le menu principal
    static void AfficherMenu()
    {
        Console.Clear();
        LigneSeparation(60);
        EcrireCentre("GESTIONNAIRE DE PAYS ET CAPITALES");
        LigneSeparation(60);
        Console.WriteLine();

        EcrireCentre("Que souhaitez-vous faire ?");
        Console.WriteLine();

        EcrireCentre("1. Ajouter un pays et sa capitale");
        EcrireCentre("2. Afficher la liste complete");
        EcrireCentre("3. Nombre de pays ajoutes");
        EcrireCentre("4. Rechercher une capitale");
        EcrireCentre("5. Quitter le programme");

        Console.WriteLine();
        LigneSeparation(30);
        Console.Write(new string(' ', (Console.WindowWidth - "Votre choix : ".Length) / 2) + "Votre choix : ");
    }

    // Fonction pour attendre une action de l'utilisateur
    static void AttendreContinuation()
    {
        Console.WriteLine();
        EcrireCentre("Appuyez sur une touche pour continuer...");
        Console.ReadKey();
    }

    static void Main(string[] args)
    {
        Console.Title = "Gestionnaire de Pays et Capitales";

        // Initialisation du dictionnaire avec des données de base
        Dictionary<string, string> myDict = new Dictionary<string, string>();
        myDict.Add("France", "Paris");
        myDict.Add("Japon", "Tokyo");
        myDict.Add("Allemagne", "Berlin");

        int userAddCount = 0;
        bool continuer = true;

        while (continuer)
        {
            AfficherMenu();

            int userChoice;
            try
            {
                userChoice = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                userChoice = 0;
            }

            switch (userChoice)
            {
                case 1: // Ajout d'un pays
                    Console.Clear();
                    LigneSeparation();
                    EcrireCentre("AJOUT D'UN NOUVEAU PAYS");
                    LigneSeparation();
                    Console.WriteLine();

                    Console.Write(new string(' ', (Console.WindowWidth - "Entrez le nom du pays : ".Length) / 2) + "Entrez le nom du pays : ");
                    string userAdd = Console.ReadLine();

                    Console.Write(new string(' ', (Console.WindowWidth - "Entrez la capitale : ".Length) / 2) + "Entrez la capitale : ");
                    string userCapitale = Console.ReadLine();

                    if (!string.IsNullOrEmpty(userAdd) && !string.IsNullOrEmpty(userCapitale))
                    {
                        if (!myDict.ContainsKey(userAdd))
                        {
                            myDict.Add(userAdd, userCapitale);
                            userAddCount++;

                            Console.WriteLine();
                            EcrireCentre($"Pays ajoute avec succes : {userAdd} -> {userCapitale}");
                        }
                        else
                        {
                            Console.WriteLine();
                            EcrireCentre("Ce pays existe deja dans la liste !");
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        EcrireCentre("Erreur : Veuillez remplir tous les champs !");
                    }
                    AttendreContinuation();
                    break;

                case 2: // Affichage de la liste
                    Console.Clear();
                    LigneSeparation();
                    EcrireCentre("LISTE COMPLETE DES PAYS ET CAPITALES");
                    LigneSeparation();
                    Console.WriteLine();

                    if (myDict.Count > 0)
                    {
                        foreach (var item in myDict)
                        {
                            EcrireCentre($"{item.Key} -> {item.Value}");
                        }
                        Console.WriteLine();
                        EcrireCentre($"Total : {myDict.Count} pays dans la liste");
                    }
                    else
                    {
                        EcrireCentre("Aucun pays dans la liste !");
                    }
                    AttendreContinuation();
                    break;

                case 3: // Nombre de pays ajoutés par l'utilisateur
                    Console.Clear();
                    LigneSeparation();
                    EcrireCentre("STATISTIQUES D'AJOUT");
                    LigneSeparation();
                    Console.WriteLine();

                    EcrireCentre($"Vous avez ajoute {userAddCount} pays");
                    EcrireCentre($"Il y a {myDict.Count} pays au total dans la liste");
                    EcrireCentre($"Il y avait {myDict.Count - userAddCount} pays par defaut");

                    AttendreContinuation();
                    break;

                case 4: // Recherche d'une capitale
                    Console.Clear();
                    LigneSeparation();
                    EcrireCentre("RECHERCHE DE CAPITALE");
                    LigneSeparation();
                    Console.WriteLine();

                    Console.Write(new string(' ', (Console.WindowWidth - "Entrez le nom du pays : ".Length) / 2) + "Entrez le nom du pays : ");
                    string paysRecherche = Console.ReadLine();

                    Console.WriteLine();
                    if (myDict.ContainsKey(paysRecherche))
                    {
                        EcrireCentre($"La capitale de {paysRecherche} est : {myDict[paysRecherche]}");
                    }
                    else
                    {
                        EcrireCentre("Pays non trouve dans la liste !");
                        EcrireCentre("Verifiez l'orthographe ou ajoutez ce pays d'abord");
                    }
                    AttendreContinuation();
                    break;

                case 5: // Quitter
                    Console.Clear();
                    LigneSeparation();
                    EcrireCentre("MERCI D'AVOIR UTILISE NOTRE PROGRAMME !");
                    EcrireCentre("Au revoir !");
                    LigneSeparation();

                    continuer = false;
                    break;

                default: // Gestion des choix invalides
                    Console.Clear();
                    LigneSeparation();
                    EcrireCentre("CHOIX INVALIDE");
                    LigneSeparation();
                    Console.WriteLine();

                    EcrireCentre("Veuillez choisir une option entre 1 et 5");

                    AttendreContinuation();
                    break;
            }
        }
    }
}


if (operateur == "=")
{
    double resultat = CalculerExpression(historiqueCalculs);
    Console.WriteLine();
    MesFonctions.EcrireCentre($"Résultat : {string.Join(" ", historiqueCalculs)} = {resultat}");
    Console.WriteLine();

    // Demander continuation
    Console.Write("Nouveau calcul ? (o/n) : ");
    string reponse = Console.ReadLine()?.ToLower();

    continuer = (reponse == "o" || reponse == "oui");

    if (continuer)
        historiqueCalculs.Clear(); // Reset pour nouveau calcul
}
