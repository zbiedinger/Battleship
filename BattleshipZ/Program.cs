using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipZ
{
    class Program
    {
        static void Main(string[] args)
        {
            //DisplayTests checkingHowThingLook = new DisplayTests();
            //checkingHowThingLook.FillEmptyBoard();
            //checkingHowThingLook.PlaceSHip();
            //checkingHowThingLook.CheckingDisplayColors();


            GamePlay round = new GamePlay();
            round.DisplayBoard(round.firstBoard);
            round.DisplayBoard(round.firstBoardShips);
            round.DisplayBoard(round.secondBoard);
            round.DisplayBoard(round.secondBoardShips);

            Console.ReadLine();

        }
    }
}
