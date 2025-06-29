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

using System.Numerics;

Dictionary<string, string> myDict = new Dictionary<string, string>();

myDict.Add("France", "Paris");
myDict.Add("Japon", "Tokyo");
myDict.Add("Allemagne", "Berlin");

int userAddCount = 0;


while (true)
{
    Console.WriteLine("Que veux tu faire ?\n 1 = Ajout pays/capitale,\n 2 = Liste complète,\n 3 = clear,\n 4 = nombre de payx ajouter,\n 5 recherche d'une capitale");

    int userChoice = Convert.ToInt32(Console.ReadLine());

    switch (userChoice)
    {
        case 1:
            Console.WriteLine("Ajouter un pays et sa capitale");
            Console.Write("Entrez le nom du pays : ");
            string userAdd = Console.ReadLine();

            if (myDict.ContainsKey(userAdd))
            {
                Console.WriteLine("Déjà dans la liste");
            }
            else
            {
                Console.Write("Entrez la capitale : ");
                string capitale = Console.ReadLine();
                myDict.Add(userAdd, capitale);
                Console.WriteLine($"Pays '{userAdd}' avec la capitale '{capitale}' ajouté");
                userAddCount++;
            }

            break;

        case 2:
            Console.WriteLine("\nListe complète :");
            foreach (var item in myDict)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            break;

        case 3:
            Console.Clear();
            break;

        case 4:
            Console.Clear();
            Console.WriteLine($"{userAddCount} pays ajouter");
            break;
        case 5:
            string userInput = "";
            string search = "";

            do
            {
                Console.WriteLine("Donnez un pays, sinon tapez 'fin'");
                userInput = Console.ReadLine();

                if (userInput != "fin")
                {
                    Console.WriteLine("Donnez sa capitale");
                    couples.Add(userInput, Console.ReadLine());
                }
            }
            while (userInput != "fin");
            break;
    };

}


