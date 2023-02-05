using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GamesDevProject.cs {
    public class PayingToGaming : MenuEngStates , IColoredNotes {


        GeneralGamesMenu generalGamesMenu = new GeneralGamesMenu();

        public static string promptToPay;
        public static string confirm = "y";
        public static double gamePrice;
        public static double currentBalance;
        public static string pyramid = "1";
        public static string matrix = "2";
        public static string biggerCard = "3";
        public static double pyramidPrice = 2.5;
        public static double matrixPrice = 3.4;
        public static string userName;
        public static string cardNameAnswer;
        public static string fillCardNumber;
        public int MyProperty { get; set; }
        List<string> gameNames = new List<string>() { pyramid, matrix, biggerCard };

        public static void GamesMenu(string gamesMenu) {
            Parameters parameters = new Parameters();   
            Console.WriteLine(Parameters.GamesMenu);
        }
        public void ColoredNotes() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Success");
            Console.ResetColor();
        }
       
        public void Refund(double gamePrice) {
            currentBalance = currentBalance + gamePrice;
            switch (GeneralGamesMenu.languagePrompt) {
                case "english": Console.WriteLine("balance : {0:C}", currentBalance); break;
                case "macedonian": Console.WriteLine("Состојба : {0:C}", currentBalance); break;
            }
        }
        public static void PayForGame(double gamePrice) {
            Parameters.GamePrice = gamePrice;
            currentBalance = Convert.ToDouble(PlayerWallet.WalletBalance) - gamePrice;
            PlayerWallet.walletBalance = currentBalance;
            PlayerWallet playerWallet = new PlayerWallet(PlayerWallet.playerName,PlayerWallet.walletBalance);
        }
        public static void EmptyWallet(string fillWalletPrompt, string insertPlayerName,
            string insertBalance, string insertCardName, string insertCardNumber,IPayingNotes payingNotes) {
            Parameters parameters = new Parameters();
            Console.WriteLine(fillWalletPrompt);
            payingNotes.ChoosePayToPlay(Parameters.ChoosePayToPlay);
            if (promptToPay == confirm) payingNotes.ChoosePayMethod(Parameters.ChoosePaymentMethod);
            switch (promptToChoosePaymentMethod) {
                case "1": PlayerWallet.FillWalletCash(insertPlayerName, insertBalance, new PayingToGaming()); break;
                case "2": PlayerWallet.FillWalletByCard(insertPlayerName, insertCardName, insertCardNumber, insertBalance, new PayingToGaming()); break;
            }
        }
        
        public void Inception(ILanguages languages, IPayingNotes payingNotes, IStartGame startGame) {
                languages.ChooseLanguage();
            while(languagePrompt != "1" && languagePrompt != "2") languages.ChooseLanguage();
            GamesMenu(Parameters.GamesMenu);
                payingNotes.ChoosePayToPlay(Parameters.ChoosePayToPlay);
                while (payingNotes.PromptToPay != confirm) payingNotes.ChoosePayToPlay(Parameters.ChoosePayToPlay);
                payingNotes.FillWalletPrompt(Parameters.FillWalletPrompt);
                payingNotes.ChoosePayMethod(Parameters.ChoosePaymentMethod);
                while (payingNotes.PromptToChoosePaymentMethod != cash && payingNotes.PromptToChoosePaymentMethod != card) payingNotes.ChoosePayMethod(Parameters.ChoosePaymentMethod);
                switch (payingNotes.PromptToChoosePaymentMethod) {
                    case "1": PlayerWallet.FillWalletCash(Parameters.InsertPlayerName, Parameters.InsertBalance, new PayingToGaming()); break;
                    case "2": 
                            PlayerWallet.FillWalletByCard(Parameters.InsertPlayerName, Parameters.CardNamePrompt,
                            Parameters.InsertCardNumber, Parameters.InsertBalance, new PayingToGaming());
                            payingNotes.FillWalletByCardRegisterNote();
                    break;
                }
                GeneralGamesMenu.ChooseGame(Parameters.ChooseGame);
                while (gameNames.All(item => item != GeneralGamesMenu.enterGameChosen)) GeneralGamesMenu.ChooseGame(Parameters.ChooseGame);
                GeneralGamesMenu.PriceToPlayState();
                PayForGame(Parameters.GamePrice);
                startGame.StartGame();
        }
    }
}


