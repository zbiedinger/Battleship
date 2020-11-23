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
        Player firstplayer;
        Player SecondPlayer;

        //Constructor
        public GamePlay()
        {
            firstplayer = new Player();
            SecondPlayer = new Player();
        }

        //Member Method
        public void PlayAGame()
        {

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
                FirstBoardDisplay[xCoordinate, yCoordinate] = "s";
                for (int i = 0; i < 2; i++)
                {
                    FirstBoardDisplay[xCoordinate, yCoordinate] = "s";
                }


                for (int i = yCoordinate; i < yCoordinate + shipSize; i++)
                {
                    FirstBoardDisplay[i, yCoordinate] = " S|";
                }
            }
            else
            {
                for (int i = xCoordinate; i < xCoordinate + shipSize; i++)
                {
                    FirstBoardDisplay[i, 7] = " S|";
                }
            }

           

        }

    }
}
