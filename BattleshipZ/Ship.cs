using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipZ
{
    class Ship
    {
        //Member Variables
        public string[] shipLength;

        //Constructor
        public Ship()
        {
        }

        //Member Method
        //This takes in three variables to assign ships locations on the board, if the piece 
        //is vertical, and its x and y position.
        public void PlaceShip(bool isVertical, char startingLetter, int startingNumber)
        {
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            int counter = 0;

            for (int i = 0; i < alpha.Length; i++)
            {
                if (startingLetter == alpha[i])
                {
                    counter = i;
                }
            }

            for (int i = 0; i < shipLength.Length; i++)
            {
                if (isVertical)
                {
                    shipLength[i] = startingLetter.ToString() + (startingNumber + i);
                }
                else
                {
                    shipLength[i] = alpha[counter + i].ToString() + startingNumber;
                }
            }
        }
    }
}
