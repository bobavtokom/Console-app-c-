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
        public static readonly double minimumBetAmount = 1;
        public static int min = 1;
        public static int max = 14;
        public static Random deckOfCards = new Random();
        public static int yourCard = deckOfCards.Next(min, max);
        public static int compCard = deckOfCards.Next(min, max);
            public static double BetAmount { get; set; }
        public static void DrawYourCard(string drawYourCard, string yourCardIs) {
            Console.WriteLine(drawYourCard);
            string yourCardPrompt = Console.ReadLine();
            while (yourCardPrompt != "1" && yourCardPrompt != null) {
                Console.WriteLine(drawYourCard);
                yourCardPrompt = Console.ReadLine();
            }
            Console.WriteLine(yourCardIs + yourCard);
        }
        public static void DrawComputerCard(string drawComputerCard, string computerCardIs) {
            Console.WriteLine(drawComputerCard);
            string compCardPrompt = Console.ReadLine();
            while (compCardPrompt != "2" && compCardPrompt != null) {
                Console.WriteLine(drawComputerCard);
                compCardPrompt = Console.ReadLine();
            }
            Console.WriteLine(computerCardIs + compCard);
        }
        public static void PlaceYourBet(string placeBet) {
            Console.WriteLine(placeBet);
            string betAmountString;
            betAmountString = Console.ReadLine();
            double b;
            while (!double.TryParse(betAmountString, out b)) {
                Console.WriteLine(placeBet);
                betAmountString = Console.ReadLine();
            }
            BetAmount = Convert.ToDouble(betAmountString);
        }

        public static void PlayBiggerCard(IColoredNotes coloredNotes, ILanguages languages, IPayingNotes payingNotes) {
            coloredNotes.ColoredNotes(Parameters.HazardGameNote);
            Parameters parameters = new Parameters();
            payingNotes.ChoosePayToPlay(Parameters.ChoosePayToPlay);
            while (payingNotes.PromptToPay != confirm) payingNotes.ChoosePayToPlay(Parameters.ChoosePayToPlay);
            PlaceYourBet(Parameters.PlaceBet);
            while (BetAmount > PlayerWallet.WalletBalance && BetAmount < minimumBetAmount) PlaceYourBet(Parameters.PlaceBet);
            Console.WriteLine("your bet: {0:C}", BetAmount);
            DrawYourCard(Parameters.DrawYourCard, Parameters.YourCardIs);
            DrawComputerCard(Parameters.DrawComputerCard, Parameters.ComputerCardIs);
            if (yourCard > compCard) {
                Console.WriteLine(Parameters.WinState);
                PlayerWallet.WalletBalance += BetAmount;
            } else if (yourCard == compCard) Console.WriteLine(Parameters.NooneWinState);
            else {
                Console.WriteLine(Parameters.LoseState);
                PlayerWallet.WalletBalance -= BetAmount;
            }
            PlayerWallet playerWallet = new PlayerWallet(PlayerWallet.PlayerName, PlayerWallet.WalletBalance);
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
