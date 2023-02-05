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
        public static string notANumber = "not a number";

        public static void InsertPlayerName(string insertPlayerName) {
            Console.WriteLine(insertPlayerName);
            playerName = Console.ReadLine();
            while (string.IsNullOrEmpty(playerName)) InsertPlayerNameException(insertPlayerName);
        }
        public static void InsertPlayerNameException(string insertPlayerName) {
             {
                Parameters parameters = new Parameters();
                Console.WriteLine(Parameters.EmptyNameNote);
                InsertPlayerName(insertPlayerName);
            }
        }
       
        public static void InsertCardName(string cardNamePrompt) {
            Console.WriteLine(cardNamePrompt);
            cardName = Console.ReadLine();
            while (string.IsNullOrEmpty(cardName)) {
                Console.WriteLine(cardNamePrompt);
                cardName = Console.ReadLine();
            }
        }
        public static void InsertCardNumber(string insertCardNumber) {
            Console.WriteLine(insertCardNumber);
             cardNumber = Console.ReadLine();
            double b;
            while (!double.TryParse(cardNumber, out b)) {
                Console.WriteLine(insertCardNumber);
                cardNumber = Console.ReadLine();
            }
        }
        public static void InsertBalance(string insertBalance) {
            Console.WriteLine(insertBalance);
            string walletBalanceString;
            walletBalanceString = Console.ReadLine();
            double b;
            while (!double.TryParse(walletBalanceString, out b)) {
                Console.WriteLine(insertBalance);
                walletBalanceString = Console.ReadLine();
            }
            walletBalance = Convert.ToDouble(walletBalanceString);
        }
        public static void FillWalletCash(string insertPlayerName, string insertBalance,IColoredNotes coloredNotes) {
            Parameters parameters = new Parameters();    
            InsertPlayerName(insertPlayerName);
            InsertBalance(insertBalance);
            coloredNotes.ColoredNotes();
            PlayerWallet playerWallet = new PlayerWallet(playerName, walletBalance + PayingToGaming.currentBalance);
        }
        public static void FillWalletByCard(string insertPlayerName,string insertCardName, string insertCardNumber, string insertBalance, IColoredNotes coloredNotes) {
            Parameters parameters = new Parameters();
            InsertPlayerName(insertPlayerName);
            InsertCardName(insertCardName);
            InsertCardNumber(insertCardNumber);
            InsertBalance(insertBalance);
            coloredNotes.ColoredNotes();
            PlayerWallet playerWallet = new PlayerWallet(playerName, walletBalance + PayingToGaming.currentBalance);
        }
        public PlayerWallet(string playerName, double walletBalance) {
            PlayerName = playerName;
            WalletBalance = walletBalance;
            switch (GeneralGamesMenu.languagePrompt) {
                case "english": Console.WriteLine("Player name {0}" + "\n" + " balance {1:C}", PlayerName, WalletBalance);break;
                case "macedonian": Console.WriteLine("Корисничко име {0}" + "\n" + " Состојба {1:C}", PlayerName, WalletBalance);break;
            }
        }
    }
}
