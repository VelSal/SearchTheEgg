using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OplossingEiSpelletje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] array = new string[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    array[i, j] = ".";
                }
            }
            bool gameOver = false;

            Random random = new Random();
            int randomX = random.Next(0, 10);
            int randomY = random.Next(0, 10);

            Console.WriteLine($"Random X = {randomX}\nRamdom Y = {randomY}");

            while (!gameOver)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        Console.Write(array[i, j] + ".");
                    }
                    Console.WriteLine();
                }

                Console.Write("X coordinaat :");
                int userX = int.Parse(Console.ReadLine());
                Console.Write("Y coordinaat :");
                int userY = int.Parse(Console.ReadLine());

                if (userX == randomX && userY == randomY)
                {
                    Console.WriteLine("Game over!");
                    gameOver = true;
                }
                else
                {
                    array[userX, userY] = "x";
                    if (userX < randomX)
                    {
                        Console.WriteLine("Hoger!");
                    }
                    else if (userX > randomX)
                    {
                        Console.WriteLine("Lager!");
                    }
                    if (userY < randomY)
                    {
                        Console.WriteLine("rechts!");
                    }
                    else if (userY > randomY)
                    {
                        Console.WriteLine("links!");
                    }

                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
