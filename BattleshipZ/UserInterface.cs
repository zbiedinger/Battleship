using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipZ
{
    static class UserInterface
    {
        public static void DisplayGameSetup()
        {
            Console.WriteLine("+++++++++++++++++++++++++");
            Console.WriteLine("\tWelcome to");
            Console.WriteLine("\tBATTLESHIP");
            Console.WriteLine("+++++++++++++++++++++++++\n");
            ContinuePrompt("Are you ready to battle for you life in the open ocean? (y/n)");
            Console.Clear();
        }




        public static bool ContinuePrompt(string output)
        {
            Console.WriteLine(output);
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "y":
                case "yes":
                    return true;
                case "n":
                case "no":
                    return false;
                default:
                    Console.WriteLine("\nInvalid input");
                    return ContinuePrompt(output);
            }
        }
    }
}
