using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipZ
{
    class GamePlay
    {
        //Member Variables
        public string[,] firstBoard;
        public string[,] secondBoard;
        public string[,] firstBoardShips;
        public string[,] secondBoardShips;
        int numberOfSpace;


        //Constructor
        public GamePlay()
        {
            numberOfSpace = 21;

            firstBoard = firstBoardShips = new string[21,21];
           secondBoard = secondBoardShips = new string[21,21];
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            firstBoard[0, 0] = "   ";
            secondBoard[0, 0] = "   ";

            for (int i = 1; i < 21; i++)
            {
               // if (i < 10)
                {
                    firstBoard[0, i] = firstBoardShips[0, i] = "  " + alpha[i - 1];
                    secondBoard[0, i] = secondBoardShips[0, i] = "  " + alpha[i - 1];

                }
                //else
                //{
                //    firstBoard[0, i] = " " + i.ToString();
                //    secondBoard[0, i] = " " + i.ToString();
                //}
            }
            for (int i = 1; i < 21; i++)
            {
                if (i < 10)
                {
                    firstBoard[i, 0] = "   " + i.ToString();
                    secondBoard[i, 0] = "   " + i.ToString();
                }
                else
                {
                   firstBoard[i, 0] = "  " + i.ToString();
                    secondBoard[i, 0] = "  " + i.ToString();
                }
            }

            for (int i = 1; i < 21; i++)
            {
                for (int j = 1; j < 21; j++)
                {
                    firstBoard[i, j] = " W ";
                    secondBoard[i, j] = " O ";
                }
            }
        }

        //Member Method
        public void DisplayBoard(string[,] currentBoard)
        {
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
                        Console.Write(currentBoard[i, j]);
                    }
                    counter++;
                }
            }
            Console.WriteLine("");
        }

        public void PlaceShip()
        {
            Console.WriteLine("Where to place Aircraft Carrier (5):");
            int shipSize = 5;
            Console.WriteLine("Virtical or horizontal? v or h");
            string orientauion = Console.ReadLine();
            Console.WriteLine("Enter x coordinate: 1 to 20");
            int xCoordinate = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y coordinate: 1 to 20");
            int yCoordinate = int.Parse(Console.ReadLine());

            if (orientauion == "v")
            {
                firstBoard[xCoordinate, yCoordinate] = "s";
                for (int i = 0; i < 2; i++)
                {
                    firstBoard[xCoordinate, yCoordinate] = "s";
                }


                for (int i = yCoordinate; i < yCoordinate + shipSize; i++)
                {
                    firstBoard[i, yCoordinate] = " S|";
                }
            }
            else
            {
                for (int i = xCoordinate; i < xCoordinate + shipSize; i++)
                {
                    firstBoard[i, 7] = " S|";
                }
            }

           

        }

    }
}
