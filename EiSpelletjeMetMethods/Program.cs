using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EiSpelletjeMetMethode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Find the egg!";

            string[,] array = new string[10, 10];
            PopulateArray(array);
            bool gameOver = false;

            Random random = new Random();
            int randomX, randomY;
            RandomizeXY(random, out randomX, out randomY);

            ShowCoordinates(randomX, randomY);
            gameOver = GameLogic(array, gameOver, randomX, randomY);
        }

        private static bool GameLogic(string[,] array, bool gameOver, int randomX, int randomY)
        {
            while (!gameOver)
            {
                ShowHeader(array);
                DrawArray(array);

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
                    array[userX, userY] = "X";
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
                    ShowCoordinates(randomX, randomY);
                }
            }

            return gameOver;
        }

        private static void RandomizeXY(Random random, out int randomX, out int randomY)
        {
            randomX = random.Next(0, 10);
            randomY = random.Next(0, 10);
        }

        private static void ShowCoordinates(int randomX, int randomY)
        {
            Console.WriteLine($"Random X = {randomX}\nRamdom Y = {randomY}\n");
        }

        private static void DrawArray(string[,] array)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(i);
                Console.ResetColor();

                for (int j = 0; j < 10; j++)
                {
                    if (array[i,j] == "X")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor= ConsoleColor.Green;
                    }
                    Console.Write($"{array[i, j].PadLeft(4)}");
                }
                Console.WriteLine();
            }

            Console.ResetColor();
            Console.WriteLine();

        }

        private static void PopulateArray(string[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = "_";
                }
            }
        }

        private static void ShowHeader(string[,] array)
        {
            Console.Write(" ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(i.ToString().PadLeft(4));
                Console.ResetColor();
            }
            Console.WriteLine();

        }



    }
}
