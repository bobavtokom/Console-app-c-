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
using System.Security.Policy;

namespace GamesDevProject.cs {
    public class BiggerCardGame {
        public static string confirm = "y";
        public static string cash = "1";
        public static string card = "2";
        public static int min = 1;
        public static int max = 14;
        public static Random deckOfCards = new Random();
        public static int yourCard = deckOfCards.Next(min, max);
        public static int compCard = deckOfCards.Next(min, max);
            public static double BetAmount { get; set; }
        public static void DrawYourCard() {
            Console.WriteLine("Press \"1\" to draw your card");
            string yourCardPrompt = Console.ReadLine();
            while (yourCardPrompt != "1" && yourCardPrompt != null) {
                Console.WriteLine("Press \"1\" to draw your card");
                yourCardPrompt = Console.ReadLine();
            }
            Console.WriteLine("Your card is " + yourCard);
        }
        public static void DrawComputerCard() {
            Console.WriteLine("Press \"2\" to see computer card");
            string compCardPrompt = Console.ReadLine();
            while (compCardPrompt != "2" && compCardPrompt != null) {
                Console.WriteLine("Press \"2\" to see computer card");
                compCardPrompt = Console.ReadLine();
            }
            Console.WriteLine("Computer card is " + compCard);
        }
        public static void PlaceYourBet() {
            Console.WriteLine("Place bet amount");
            string betAmountString;
            betAmountString = Console.ReadLine();
            double b;
            while (!double.TryParse(betAmountString, out b)) {
                Console.WriteLine("Place bet amount");
                betAmountString = Console.ReadLine();
            }
            BetAmount = Convert.ToDouble(betAmountString);
        }

        public static void PlayBiggerCard(IColoredNotes coloredNotes, ILanguages languages, IPayingNotes payingNotes) {
            coloredNotes.ColoredNotes();
            Parameters parameters = new Parameters();
            payingNotes.ChoosePayToPlay(Parameters.ChoosePayToPlay);
            while (payingNotes.PromptToPay != confirm) payingNotes.ChoosePayToPlay(Parameters.ChoosePayToPlay);
            PlaceYourBet();
            DrawYourCard();
            DrawComputerCard();
            if (yourCard > compCard) Console.WriteLine("you win");
            else if (yourCard == compCard) Console.WriteLine("No one wins, try again ");
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
