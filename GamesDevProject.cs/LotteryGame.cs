using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;
using System.Globalization;
using System.Security;

namespace GamesDevProject.cs {
    public class CardsGame {
        public static int min = 1;
        public static int max = 52;
        public static Random deckOfCards = new Random();
        public static int drawCard1 = deckOfCards.Next(min, max);
        public static int drawCard2 = deckOfCards.Next(min, max);
        public static void DrawCard1() => Console.WriteLine(drawCard1);
        public static void DrawCard2() { Console.WriteLine(drawCard2);}
        public static void Win() {
            if (drawCard1 > drawCard2) Console.WriteLine("you win");
            else if (drawCard1 == drawCard2) Console.WriteLine("No one wins, try again ");
            else Console.WriteLine("You lose ");
        }
        



        /*public static string card = "        " + "\n" +
                                    " A      " + "\n" +
                                    "        " + "\n" +
                                    "   ♠    " + "\n" +
                                    "        " + "\n" +
                                    "      A " + "\n" +
                                    "        ";
        public static void DisplayCards() {

            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            string s = @"C:\Test Folder\документи";
            Console.WriteLine(s);

            // input C:\Test Folder\документи
            

            
        }*/

    }
}
