using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EiSpelletje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Créer un jeu dans lequel il faut trouver un oeuf dans une grille de 10x10.
            Utiliser un array de 2 dimentions.
            L'oeuf est placé dans une case xy aléatoire.
            Demander à l'utilisateur la position x et y.
            Si l'utilisateur a trouvé l'oeuf, écrire un message "Bravo, vous avez trouvé un message".
            S'il ne trouve pas: laisser une marque "x" à l'endroit où le joueur a déjà cherché.
            */

            Random rnd = new Random();
            int randomX = rnd.Next(0, 10);
            int randomY = rnd.Next(0, 10);
            string[,] array = new string[10, 10];
            bool gameOver = false;

            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        Console.Write("_", array[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            Console.WriteLine($"Random Y = {randomX} \nRandom X = {randomY}");  //Random test
            while (!gameOver)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write("_", array[i, j]);
                    }
                    Console.WriteLine();
                }

                Console.Write("Give X coordinate: ");
                int userX = int.Parse(Console.ReadLine());
                Console.Write("Give Y coordinate: ");
                int userY = int.Parse(Console.ReadLine());

                if (userX == randomX && userY == randomY)
                {
                    Console.WriteLine("GG! You found the egg!");
                    gameOver = true;
                }
                else
                {
                    string changeElement = array[userX,userY].Replace("_","*");
                    Console.WriteLine(changeElement);
                }
                
                Console.ReadLine();
                //Console.Clear();

            }
        }
    }
}
