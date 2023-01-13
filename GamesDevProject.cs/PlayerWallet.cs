using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GamesDevProject.cs {
    public class PlayerWallet {
        PayingToGaming payingToGaming = new PayingToGaming();
        public static string playerName;
        public static string cardName;
        public static string cardNumber;
        public static double walletBalance;
        public static string PlayerName { get; set; }
        public static double WalletBalance { get; set; }
        public static string insertPlayerNameEng = "Insert player name";
        public static string insertBalanceEng = "Insert balance ";
        public static string emptyNameNote = "Name can't be empty!";
        public static string notANumber = "not a number";
        public static string cardNamePromptEng = " Please insert card name";
        public static string insertCardNumberEng = "Insert card number";
        
        public static void FillWalletByCardNoteEng() {
            Console.WriteLine("Payment registered " + DateTime.Now + "\n" + "card name " + cardName + "\n" +
                              "card number " +
                              cardNumber + "\n" +  PlayerName, Convert.ToDouble(WalletBalance));
        }
        public static void InsertPlayerName(string insertPlayerName) {
            Console.WriteLine(insertPlayerName);
            playerName = Console.ReadLine();
            if (string.IsNullOrEmpty(playerName)) InsertPlayerNameException(insertPlayerName);
        }
        public static void InsertPlayerNameException(string insertPlayerName) {
             {
                Console.WriteLine(emptyNameNote);
                InsertPlayerName(insertPlayerName);
            }
        }
        public static void InsertCardNameException(string cardNamePrompt) {
            {
                Console.WriteLine(emptyNameNote);
                InsertCardName(cardNamePrompt);
            }
        }
        public static void InsertCardNumberException(string insertCardNumber) {
            Console.WriteLine(notANumber);
            Console.WriteLine(insertCardNumber);
            InsertCardNumber(insertCardNumber);
        }
        public static void InsertCardName(string cardNamePrompt) {
            Console.WriteLine(cardNamePrompt);
            cardName = Console.ReadLine();
            if (string.IsNullOrEmpty(cardName)) InsertCardNameException(cardNamePrompt);
        }
        public static void InsertCardNumber(string insertCardNumber) {
            Console.WriteLine(insertCardNumber);
             cardNumber = Console.ReadLine();
            double b;
            if (!double.TryParse(cardNumber, out b)) InsertCardNumberException(insertCardNumber);
        }
        public static void InsertBalanceException(string insertBalance) {
            Console.WriteLine(notANumber);
            InsertBalance(insertBalance);
        }
        public static void InsertBalance(string insertBalance) {
            Console.WriteLine(insertBalance);
            walletBalance = Convert.ToDouble(Console.ReadLine());
            double b;
            if (!Double.TryParse(walletBalance.ToString(), out b)) InsertBalanceException(insertBalance);
        }
        public static void FillWalletCash(string insertPlayerName, string insertBalance) {
            InsertPlayerName(insertPlayerName);
            InsertBalance(insertBalance);
            PayingToGaming.SuccessColor();
            PlayerWallet playerWallet = new PlayerWallet(playerName, walletBalance + PayingToGaming.currentBalance);
        }
        public static void FillWalletByCard(string insertPlayerName,string insertCardName, string insertCardNumber, string insertBalance) {
            InsertPlayerName(insertPlayerName);
            InsertCardName(insertCardName);
            InsertCardNumber(insertCardNumber);
            InsertBalance(insertBalance);
            PayingToGaming.SuccessColor();
            PlayerWallet playerWallet = new PlayerWallet(playerName, walletBalance + PayingToGaming.currentBalance);
        }
        public PlayerWallet(string playerName, double walletBalance) {
            PlayerName = playerName;
            WalletBalance = walletBalance;
            if (GeneralGamesMenu.languagePrompt == "1") Console.WriteLine("Player name {0}" + "\n" + " balance {1:C}", PlayerName, WalletBalance);
            if (GeneralGamesMenu.languagePrompt == "2") Console.WriteLine("Корисничко име {0}" + "\n" + " Состојба {1:C}", PlayerName, WalletBalance);
        }
    }
}
