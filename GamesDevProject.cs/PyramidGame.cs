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
        
        public static string emptyFields = " ";
        public static string stars = "* ";
        public static string pyramidGreetingEng = " Please insert number of pyramid levels wanted : ";
        public static string playAgainPromptEng = "To play again enter \"1\" " + "\n" + "To go to General Menu  enter \"2\"" + "\n" + " To exit press \" Enter \"";
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
            if (GeneralGamesMenu.languagePrompt == "1") {
                    PyramidGreeting(pyramidGreetingEng);
                    WriteLevelsAndStars();
                    PlayAgainPrompt(playAgainPromptEng);
                    var playAgainAnswer = Console.ReadLine();
                while (playAgainAnswer != "1" && playAgainAnswer != "2") PlayAgainPrompt(playAgainPromptEng);
                if (playAgainAnswer == "1") {
                    GeneralGamesMenu.PriceToPlayPyramid(GeneralGamesMenu.pyramidPriceEng);
                    while (PayingToGaming.currentBalance < pyramidPrice) {
                        PayingToGaming.EmptyWallet(PayingToGaming.fillWalletPromptEng, PayingToGaming.choosePayToPlayEng,
                    PayingToGaming.choosePaymentMethodEng, PlayerWallet.insertPlayerNameEng,
                    PlayerWallet.insertBalanceEng, PlayerWallet.cardNamePromptEng, PlayerWallet.insertCardNumberEng, GeneralGamesMenu.chooseGameEng,
                    GeneralGamesMenu.pyramidPriceEng, GeneralGamesMenu.matrixPriceEng);
                        PayingToGaming.currentBalance = PlayerWallet.walletBalance;
                    }
                    GeneralGamesMenu.PriceToPlayPyramid(GeneralGamesMenu.pyramidPriceEng);
                    PayingToGaming.PayForGame(pyramidPrice);
                    GeneralGamesMenu.RefundPrompt(GeneralGamesMenu.refundPromptEng);
                    if (GeneralGamesMenu.refundAnswer == "3") {
                        PayingToGaming payingToGaming = new PayingToGaming();
                        payingToGaming.Refund(pyramidPrice);
                    } else StartPyramid();
                }
                if (playAgainAnswer == "2") GeneralGamesMenu.Greeting();
            }else if (GeneralGamesMenu.languagePrompt == "2") {
                    PyramidGreeting(MenuMkd.pyramidGreetingMkd);
                    WriteLevelsAndStars();
                    PlayAgainPrompt(MenuMkd.playAgainPromptMkd);
                    var playAgainAnswer = Console.ReadLine();
                while (playAgainAnswer != "1" && playAgainAnswer != "2") PlayAgainPrompt(MenuMkd.playAgainPromptMkd);
                if (playAgainAnswer == "1") {
                    GeneralGamesMenu.PriceToPlayPyramid(MenuMkd.pyramidPriceMkd);
                    while (PayingToGaming.currentBalance < pyramidPrice) {
                        PayingToGaming.EmptyWallet(MenuMkd.fillWalletPromptMkd, MenuMkd.choosePayToPlayMkd,
                    MenuMkd.choosePaymentMethodMkd, MenuMkd.insertPlayerNameMkd,
                    MenuMkd.insertBalanceMkd, MenuMkd.cardNamePromptMkd, MenuMkd.insertCardNumberMkd, MenuMkd.chooseGameMkd,
                    MenuMkd.pyramidPriceMkd, MenuMkd.matrixPriceMkd);
                        PayingToGaming.currentBalance = PlayerWallet.walletBalance;
                    }
                    GeneralGamesMenu.PriceToPlayPyramid(MenuMkd.pyramidPriceMkd);
                    PayingToGaming.PayForGame(pyramidPrice);
                    GeneralGamesMenu.RefundPrompt(MenuMkd.refundPromptMkd);
                    if (GeneralGamesMenu.refundAnswer == "3") {
                        PayingToGaming payingToGaming = new PayingToGaming();
                        payingToGaming.Refund(pyramidPrice);
                    } else StartPyramid();
                }
            }
        }
    }
}
    

