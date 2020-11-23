using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipZ
{
    class Board
    {
        //Member Variables
        public string[,] FirstBoardDisplay;
        public string[,] firstBoardShips;
        int numberOfSpace;


        //Constructor
        public Board()
        {
            numberOfSpace = 21;

            FirstBoardDisplay = firstBoardShips = new string[21, 21];

            MakeBoard(FirstBoardDisplay);
            MakeBoard(firstBoardShips);
        }

        //Member Method
        //Fills a board with no ships on it. 
        public void MakeBoard(string[,] newBoard)
        {
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            newBoard[0, 0] = "   ";

            for (int i = 1; i < 21; i++)
            {
                {
                    newBoard[0, i] = "  " + alpha[i - 1];
                }
            }
            for (int i = 1; i < 21; i++)
            {
                if (i < 10)
                {
                    newBoard[i, 0] = "   " + i.ToString();
                }
                else
                {
                    newBoard[i, 0] = "  " + i.ToString();
                }
            }

            for (int i = 1; i < 21; i++)
            {
                for (int j = 1; j < 21; j++)
                {
                    newBoard[i, j] = " O ";
                }
            }
        }

        //Displays the contents of a board passed in.
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
    }
}
