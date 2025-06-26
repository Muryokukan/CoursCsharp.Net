using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100ExoC_
{
    public class function
    {
        public static void SayHi()
        {
            Console.WriteLine("Hi");
        }

        public static void Square()
        {
            Console.WriteLine("Rectangle de combien de largeur ?");

            int size = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= size; i++)
            {
                Console.WriteLine(new string('x', size));
            }

            //Console.WriteLine(size);
            //Console.ReadKey();
        }
        public static void IsPerfect()
        {
            Console.WriteLine("Nombre ?");

            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = number - 1; i > 0; i--)
                if (number % i == 0)
                    sum += i;

            if (sum == number)
                Console.WriteLine("le nombre est parfait");
            else
                Console.WriteLine("le nombre n'est pas parfait");
        }

        public static void EachChar()
        {
            Console.WriteLine("Un mot");

            string myString = Console.ReadLine();
            //Console.WriteLine(myString);
            for(int i = 0; i < myString.Length; i++)
            {
                Console.WriteLine(myString[i]);
            }
        }

        public static void Pyramide()
        {
            // Exo 53   
            string ligne = "";
            string pyramide = "";
            int chiffre = 1;
            string userInput = "";
            int userInputInInt = 0;

            do
            {
                Console.WriteLine("Entrez une taille de pyramide");
                userInput = Console.ReadLine();
            } while (!int.TryParse(userInput, out userInputInInt));


            for (int i = 0; i < userInputInInt; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    ligne += $"{chiffre} ";
                    chiffre++;
                }
                pyramide += $"{ligne}\n";
                ligne = "";
            }

            Console.WriteLine(pyramide);
        }

        public static void IsDivisible()
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
