using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GamesDevProject.cs {
    public class PayingToGaming {
        
        
        readonly GeneralGamesMenu generalGamesMenu = new GeneralGamesMenu();
        public string gamesMenuEng = "\n" + " GAMES MENU " + "\n" + "\n" + "Pyramid   Price: $2.5"
                                     + "\n" + "Matrix    Price: $3.4" + "\n";
        public static string choosePaymentMethodEng = "To pay with cash press \"1\"" + "\n" + "To pay with card press \"2\"" +
                                                      "\n" + "To quit press \" enter \"";
        public static string choosePayToPlayEng = "To play enter \"y\"" + "\n" + "To quit press \" enter \"";
        public static string promptToPay;
        public static double gamePrice;
        public static double currentBalance;
        public static string promptToChoosePaymentMethod;
        public string enterCashAmount = "Please enter amount ";
        public static double pyramidPrice = 2.5;
        public static double matrixPrice = 3.4;
        public static string userName;
        public string enterUserName = "Please enter username";
        public string confirmationOfCashPayment = "Thank you " + "\n" + "Please take your change : ";
        public static string paymentNote = "payment registered " + DateTime.Now + " on name : ";

        public string cardNumberPrompt = "Please insert card number";
        public string confirmCardUsage = "\"To confirm press \"y\" \" To exit press  \" enter \"\"";
        public static string cardNameAnswer;
        public static string fillCardNumber;
        public static string fillWalletPromptEng = "wallet ballance is empty!" + "\n" + "Fill your wallet ";
        public static string currentBalanceState = "Your current balance is : ";
        public void GamesMenu(string gamesMenu) {
            Console.WriteLine(gamesMenu);
        }
        public static void SuccessColor() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Success");
            Console.ResetColor();
        }
        public static void ChoosePayMethod(string choosePaymentMethod) {
            Console.WriteLine(choosePaymentMethod);
            promptToChoosePaymentMethod = Console.ReadLine();
        }
        public void Refund(double gamePrice) {
            currentBalance = currentBalance + gamePrice;
            if (GeneralGamesMenu.languagePrompt == "1") Console.WriteLine("balance : {0:C}" , currentBalance);
            if (GeneralGamesMenu.languagePrompt == "2") Console.WriteLine("Состојба : {0:C}", currentBalance);
        }
        public static void PayForGame(double gamePrice) {
            currentBalance = Convert.ToDouble(PlayerWallet.WalletBalance) - gamePrice;
            PlayerWallet.walletBalance = currentBalance;
            PlayerWallet playerWallet = new PlayerWallet(PlayerWallet.playerName,PlayerWallet.walletBalance);
        }
        public static void EmptyWallet(string fillWalletPrompt, string choosePayToPlay, string choosePaymentMethod, string insertPlayerName,
            string insertBalance, string insertCardName, string insertCardNumber, string chooseGame, string pyramidPriceState, string matrixPriceState) {
            Console.WriteLine(fillWalletPrompt);
            ChoosePayToPlay(choosePayToPlay);
            if (promptToPay == "y") ChoosePayMethod(choosePaymentMethod); 
            switch (promptToChoosePaymentMethod) {
                case "1": PlayerWallet.FillWalletCash(insertPlayerName, insertBalance); break;
                case "2": PlayerWallet.FillWalletByCard(insertPlayerName, insertCardName, insertCardNumber, insertBalance); break;
            }
        }
        public static void ChoosePayToPlay(string choosePayToPlay) {
            Console.WriteLine(choosePayToPlay);
            promptToPay = Console.ReadLine().ToLower();
        }
        public void Inception() {
            while (true) {
                GeneralGamesMenu.ChooseLanguage();
                if (GeneralGamesMenu.languagePrompt == "1") {
                    GamesMenu(gamesMenuEng);
                    ChoosePayToPlay(choosePayToPlayEng);
                    while (promptToPay != "y") {
                        ChoosePayToPlay(choosePayToPlayEng);
                    } 
                    Console.WriteLine(fillWalletPromptEng);
                    ChoosePayMethod(choosePaymentMethodEng);
                    while (promptToChoosePaymentMethod != "1" && promptToChoosePaymentMethod != "2") { ChoosePayMethod(choosePaymentMethodEng); }
                    if (promptToChoosePaymentMethod == "1") PlayerWallet.FillWalletCash(PlayerWallet.insertPlayerNameEng, PlayerWallet.insertBalanceEng);
                    if (promptToChoosePaymentMethod == "2") {
                        PlayerWallet.FillWalletByCard(PlayerWallet.insertPlayerNameEng, PlayerWallet.cardNamePromptEng,
                        PlayerWallet.insertCardNumberEng, PlayerWallet.insertBalanceEng);
                        PlayerWallet.FillWalletByCardNoteEng();
                    }
                    GeneralGamesMenu.ChooseGame(GeneralGamesMenu.chooseGameEng);
                    while (GeneralGamesMenu.enterGameChosen != "1" && GeneralGamesMenu.enterGameChosen != "2") GeneralGamesMenu.ChooseGame(GeneralGamesMenu.chooseGameEng);
                    if (GeneralGamesMenu.enterGameChosen == "1") {
                        PayForGame(pyramidPrice);
                        GeneralGamesMenu.PriceToPlayPyramid(GeneralGamesMenu.pyramidPriceEng);
                        PyramidGame.StartPyramid();
                    }
                    if (GeneralGamesMenu.enterGameChosen == "2") {
                        PayForGame(matrixPrice);
                        GeneralGamesMenu.PriceToPlayMatrix(GeneralGamesMenu.matrixPriceEng);
                        MatrixGame.StartMatrix();
                    }
                } else if (GeneralGamesMenu.languagePrompt == "2") {
                    GamesMenu(MenuMkd.gamesMenuMkd);
                    ChoosePayToPlay(MenuMkd.choosePayToPlayMkd);
                    while (promptToPay != "y") {
                        ChoosePayToPlay(MenuMkd.choosePayToPlayMkd);
                    }
                    Console.WriteLine(MenuMkd.fillWalletPromptMkd);
                    ChoosePayMethod(MenuMkd.choosePaymentMethodMkd); 
                while (promptToChoosePaymentMethod != "1" && promptToChoosePaymentMethod != "2") { ChoosePayMethod(MenuMkd.choosePaymentMethodMkd); }
                    if (promptToChoosePaymentMethod == "1") PlayerWallet.FillWalletCash(MenuMkd.insertPlayerNameMkd, MenuMkd.insertBalanceMkd);
                    if (promptToChoosePaymentMethod == "2") {
                        PlayerWallet.FillWalletByCard(MenuMkd.insertPlayerNameMkd, MenuMkd.cardNamePromptMkd,
                        MenuMkd.insertCardNumberMkd, MenuMkd.insertBalanceMkd);
                        MenuMkd.FillWalletByCardNoteMkd();
                    }
                    GeneralGamesMenu.ChooseGame(MenuMkd.chooseGameMkd);
                    while (GeneralGamesMenu.enterGameChosen != "1" && GeneralGamesMenu.enterGameChosen != "2") GeneralGamesMenu.ChooseGame(MenuMkd.chooseGameMkd);
                    if (GeneralGamesMenu.enterGameChosen == "1") {
                        PayForGame(pyramidPrice);
                        GeneralGamesMenu.PriceToPlayPyramid(MenuMkd.pyramidPriceMkd);
                        PyramidGame.StartPyramid();
                    }
                    if (GeneralGamesMenu.enterGameChosen == "2") {
                        GeneralGamesMenu.PriceToPlayMatrix(MenuMkd.matrixPriceMkd);
                        PayForGame(matrixPrice);
                        MatrixGame.StartMatrix();
                    }
                }
            }
        }
    }
}


