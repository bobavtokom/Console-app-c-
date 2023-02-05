using GamesDevProject.cs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace GamesDevProject {
    public class PyramidGame {
        public static double pyramidPrice = 2.5;
        public static string yes = "1";
        public static string no = "2";
        public static string refund = "3";
        public static string emptyFields = " ";
        public static string stars = "* ";
        public static string playAgainAnswer;
        public string PlayAgainAnswer { get; set; }
        public PyramidGame() {
            PlayAgainAnswer = playAgainAnswer;
            if (playAgainAnswer == "1") {
                playAgainAnswer = "yes";
            }
            if (playAgainAnswer == no) playAgainAnswer = "no";
        }
        public static void PlayAgainPrompt(string playAgainPrompt) => Console.WriteLine(playAgainPrompt);
        public static void PyramidGreeting(string pyramidGreeting) => Console.WriteLine(pyramidGreeting);
        public static void WriteLevelsAndStars() {
            var inputLevels = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= inputLevels; i++) {
                for (int j = 1; j <= inputLevels - i; j++) {
                    Console.Write(emptyFields);
                }
                for (int j = 1; j <= i; j++) {
                    Console.Write(stars);
                }
                Console.WriteLine();
            }
        }
        public static void StartPyramid() {
            
                    PyramidGreeting(Parameters.PyramidGreeting);
                    WriteLevelsAndStars();
                    PlayAgainPrompt(Parameters.PlayAgainPrompt);
                    var playAgainAnswer = Console.ReadLine();
            while (playAgainAnswer != yes && playAgainAnswer != no) {
                PlayAgainPrompt(Parameters.PlayAgainPrompt);
                playAgainAnswer = Console.ReadLine();

            }
            switch (playAgainAnswer) {
                case "1":
                    while (PayingToGaming.currentBalance < Parameters.GamePrice) {
                        PayingToGaming.EmptyWallet(Parameters.FillWalletPrompt, Parameters.InsertPlayerName,
                        Parameters.InsertBalance, Parameters.CardNamePrompt, Parameters.InsertCardNumber, new PayingNotes());
                        PayingToGaming.currentBalance = PlayerWallet.walletBalance;
                    }
                    GeneralGamesMenu.PriceToPlayState();
                    PayingToGaming.PayForGame(Parameters.GamePrice);
                    GeneralGamesMenu.RefundPrompt(Parameters.RefundPrompt);
                    if (GeneralGamesMenu.refundAnswer == refund) {
                        PayingToGaming payingToGaming = new PayingToGaming();
                        payingToGaming.Refund(Parameters.GamePrice);
                    } else StartPyramid();
                    break;
                    case "2": GeneralGamesMenu.Greeting(); break;
            }
        }
    }
}
    

