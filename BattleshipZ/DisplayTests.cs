using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipZ
{
    class DisplayTests
    {
        //Member Variables
        public string[,] stringBoard;
        public int numberOfSpace;

        public DisplayTests()
        {
            numberOfSpace = 21;
            stringBoard = new string[numberOfSpace, numberOfSpace];
        }

        //Member Method
        //Assign ships
        public void FillEmptyBoard()
        {
            stringBoard[0, 0] = "   ";

            for (int i = 1; i < 21; i++)
            {
                if (i < 10)
                {
                    stringBoard[0, i] = "  " + i.ToString();

                }
                else
                {
                    stringBoard[0, i] = " " + i.ToString();
                }
            }
            for (int i = 1; i < 21; i++)
            {
                if (i < 10)
                {
                    stringBoard[i, 0] = "   " + i.ToString();

                }
                else
                {
                    stringBoard[i, 0] = "  " + i.ToString();
                }
            }

            for (int i = 1; i < numberOfSpace; i++)
            {
                for (int j = 1; j < numberOfSpace; j++)
                {
                    stringBoard[i, j] = "__|";
                }
            }

        }

        public void PlaceSHip()
        {

            int VirticalPlacement = 9;
            for (int i = VirticalPlacement; i < VirticalPlacement + 5; i++)
            {
                stringBoard[7, i] = "SS|";
            }

            int counter = 1;
            for (int i = 0; i < numberOfSpace; i++)
            {
                for (int j = 0; j < numberOfSpace; j++)
                {
                    if (counter == 21)
                    {
                        Console.WriteLine("");
                        counter = 0;
                    }
                    else
                    {
                        Console.Write(stringBoard[i, j]);

                    }
                    counter++;
                }
            }
        }

        public void CheckingDisplayColors()
        {
            // Display current Background color 
            Console.WriteLine("Default Background Color: {0}", Console.BackgroundColor);

            // Set the Background color to blue 
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            // Display current Background color 
            Console.WriteLine("--------------------------------------------", Console.BackgroundColor);
            Console.Write("|            |", Console.BackgroundColor);

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("              ", Console.BackgroundColor);

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("|               |\n", Console.BackgroundColor);

            Console.WriteLine("|____________|______________|_______________|", Console.BackgroundColor);


            // Set the Background color to blue 
            Console.BackgroundColor = ConsoleColor.Gray;

            // Display current Background color 
            Console.WriteLine("Changed Background Color: {0}", ConsoleColor.Red, Console.BackgroundColor);


            Console.ReadLine();
        }
    }
}
