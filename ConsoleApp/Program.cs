/*int a;

Console.WriteLine("Saisir un nombre :");

a = Convert.ToInt32(Console.ReadLine());

if (a > 10)
{
    Console.WriteLine("supérieur");
}
else
{
    Console.WriteLine("inférieur"}
;
};*/



/*Console.WriteLine("Hello, World!");*/

/*int nombre;

Console.WriteLine("Saisir un nombre :");

nombre = Convert.ToInt32(Console.ReadLine());

if (nombre == 0) {
    Console.WriteLine("est nul");
} else if (nombre < 0) 
{
    Console.WriteLine("est négatif"); 
} else
{
    Console.WriteLine("est positif");
}
    */

/*int age;

Console.WriteLine("Saisir son âge");

age = Convert.ToInt32(Console.ReadLine());

if (age < 18)
{
    Console.WriteLine("ous êtes mineur.");
} else
{
    Console.WriteLine("Vous êtes majeur");
}*/

/*int nombre;

Console.WriteLine("Saisir un nombre");

nombre = Convert.ToInt32(Console.ReadLine());

if (nombre % 2 == 0)
{
    Console.WriteLine("pair");
} else
{
    Console.WriteLine("impair");
};*/

/*11.Écrire un programme qui vérifie si un nombre est compris entre 10 et 20.*/

/*int nombre;

Console.WriteLine("saisir le nombre :");

nombre = Convert.ToInt32(Console.ReadLine());

if (nombre < 10)
{
    Console.WriteLine("le nombre est inférieur à 10");
}
else
{
    if (nombre > 20)
    {
        Console.WriteLine("le nombre est supérieur à 20");
    }
    else
    {
        Console.WriteLine("Le nomre est compris entre 10 et 20");
    }
};

Console.ReadKey();*/

/*12.Demander à l'utilisateur un âge et afficher s'il est un enfant (moins de 12 ans), 
    un adolescent (entre 12 et 18 ans) ou un adulte (plus de 18 ans).*/

/*int nombre;

Console.WriteLine("saisir votre âge :");

nombre = Convert.ToInt32(Console.ReadLine());

if (nombre > 18)
{
    Console.WriteLine("Vous êtes majeur");
} else
{
    if (nombre < 12)
    {
        Console.WriteLine("Vous êtes un enfant");
    } else
    {
        Console.WriteLine("Vous êtes un adolescent");
    }
};

Console.ReadKey();*/

/*13.Créer un programme qui vérifie si une année est bissextile ou non.*/

/*il faut vérifier si elle est divisible par 4 et non divisible par 100, ou si elle est divisible par 400*/

/*int annee;

Console.WriteLine("saisir une année :");

annee = Convert.ToInt32(Console.ReadLine());

if ((annee % 4 == 0 && annee % 100 != 0) || (annee % 400 == 0))
{
    Console.WriteLine("l'année est une année bissextile.");
}
else
{
    Console.WriteLine("l'année n'est pas une année bissextile.");
};

Console.ReadKey();*/


/*14.Vérifier si un nombre est positif et multiple de 5.*/

/*int nombre;

Console.WriteLine("saisir un nombre :");

nombre = Convert.ToInt32(Console.ReadLine());

if (nombre < 0)
{
    Console.WriteLine("le nombre est négatif");
} else
{
    if (nombre % 5 == 0)
    {
        Console.WriteLine("Le nombre est un multiple de 5");
    } else
    {
        Console.WriteLine("Le nombre est positif mais n'est pas un multiple de 5");
    }
};

Console.ReadKey();*/

/*15.Écrire un programme qui vérifie si une chaîne de caractères contient la lettre 'a'.*/

/*string isA;

Console.WriteLine("Saisir un mot");

for (int i = 0; i <= isA.Length; i++)
{
    if (isA == "a")
    {
        Console.WriteLine("Il y a la lettr a");
    } else
    {
        Console.WriteLine("il n'y a pas de lettre a");
    }
};*/


/*21.Afficher les nombres de 1 à 10 avec une boucle `for`.*//*


for (int i = 0; i < 11; i++)
{
    Console.WriteLine(i);
};

Console.ReadKey();*/

/*22.Afficher les nombres pairs entre 1 et 20.*/

/*for (int i = 1; i < 21; i++)
{
    if (i % 2 == 0) {
        Console.WriteLine(i);
    }
};

Console.ReadKey();
*/

/*24.Demander à l'utilisateur un nombre de 1 à 10 et afficher la table de multiplication.*/

/*int nombre;

nombre = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Saisir un nombre entre 1 et 10 :");

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(i * nombre);
};

Console.ReadKey();*/

/*25.Afficher les éléments d'une chaîne de caractères un par un.*/

/*string oneByOne;

oneByOne = Convert.ToString(Console.ReadLine());

oneByOne = Console.WriteLine("Saisir un mot");

oneByOne = oneByOne.Split(' ');

for (int i = 0; i < oneByOne; i++)
{
    Console.WriteLine(oneByOne);
};
*/
/*TODO: à compléter...*/

/*31.Utiliser une boucle `while` pour afficher les nombres de 1 à 10.*/

/*int nombre = 1;

while (nombre <= 10)
{
    Console.WriteLine(nombre);
    nombre = nombre + 1;
}
;

Console.ReadKey();*/

/*34.Créer une boucle infinie qui demande un mot de passe jusqu'à ce qu'il soit correct.*/

/*string mdp;
string correctMdp = "password";

Console.WriteLine("Saisir le mot de passe :");

while (mdp != correctMdp)
{
    Console.Write("Mot de passe incorrect. Réessayez :");
    mdp = Console.ReadLine();
}
;

Console.WriteLine("Mot de passe correct. Accès autorisé.");

Console.ReadKey();*/


/*Exercise 5 :*/

/*int numbOfNote = 0;

int[] numbers = {};

while (numbOfNote < 5)
{
    Console.WriteLine("Ajouter une nouvelle note sur 20 :");
    Console.ReadLine()
    numbOfNote = numbOfNote + 1;
};

Console.ReadKey();*/


/*int[] numbers = { 12, 19, 3, 8, 5 };

Console.Write(numbers[1]);


int sum = 0;
int max = numbers[1];
int min = numbers[2];*/


/*
for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}
;

Console.WriteLine("La note la plus haute est :" + max);

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}
;

Console.WriteLine("La note la plus basse est :" + min);

foreach (int number in numbers)
{
    sum += number;
}
;

double moyenne = (double)sum / numbers.Length;

Console.WriteLine("La moyenne des notes :" + moyenne);*/






/*Correction*/

/*int nombre;

Console.WriteLine("--- gestion de notes ---\n'");

const int nbNotes = 5;
int[] notes = new int[nbNotes];

Console.WriteLine($"Veuillez saisir {nbNotes} notes :\n");



for (int i = 0; i nbNotes; i++)
{
    Console.WriteLine($"\t - MErci de saisir les notes {i + 1} (sur 20) : ");

    int.TryParse(Console.Write(), out notes[i]);

    while (notes[i] >= 0 && notes <= 20)
    {

    }
};

Console.ReadKey();*/


/*var rand = new Random();
int number = rand.Next(1, 51);
int guess;
*//* initialisation du compteur de "try"*//*
int count = 1; 

while (true)
{

    Console.Write("Devinez un nombre entre 1 et 50 : ");
    *//* Check si le nombre est valide (1 à 50) *//*
    if (int.TryParse(Console.ReadLine(), out guess) && guess >= 1 && guess <= 50)
        break;
    Console.WriteLine("Entrée invalide.");
}

while (guess != number)
{
    Console.WriteLine(guess < number ? "Trop bas !" : "Trop haut !");
    Console.Write("Réessayez : ");
    guess = int.Parse(Console.ReadLine());
    count++;
}

Console.WriteLine("Bravo !" + "t'as trouvé en " + count + " try !");

Console.ReadKey();*/


/*exo 7*/

/*Console.ReadKey();*/



Dictionary<string, string> myDict = new Dictionary<string, string>();

myDict.Add("France", "Paris");
myDict.Add("Japon", "Tokyo");
myDict.Add("Allemagne", "Berlin");

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
    Console.WriteLine($"Pays '{userAdd}' avec la capitale '{capitale}' ajouté!");
}

Console.WriteLine("\nListe complète :");
foreach (var item in myDict)
{
    Console.WriteLine($"{item.Key} : {item.Value}");
}
