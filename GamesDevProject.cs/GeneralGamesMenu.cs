using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GamesDevProject.cs {
    public class GeneralGamesMenu : ILanguages {
        public static string macedonian = "2";
        public static string cash = "1";
        public static string card = "2";
        public static string english = "1";
        public static string languagePrompt;
        public static string promptToChoosePaymentMethod;
        public string  LanguagePrompt { get; set; }
        public GeneralGamesMenu() {
            LanguagePrompt = languagePrompt;
            if (languagePrompt == macedonian) languagePrompt = "macedonian";
            if (languagePrompt == english) languagePrompt = "english";
            if (promptToChoosePaymentMethod == cash) promptToChoosePaymentMethod = "cash";
            if (promptToChoosePaymentMethod == card) promptToChoosePaymentMethod = "card";
        }
        public static string chooseLanguage = "Choose language " + "\n" + " English press 1" + "\n" + " Македонски притисни 2";
        public static string enterGameChosen;
        public static string questionAboutMood = "Jump in to play some game?" + "\n" + "Please enter \"y\" if yes or \"n\" if no";
        public string answerAboutMood;
        public static string refundAnswer;
        public static void ChooseGame(string chooseGame) {
            Console.WriteLine(Parameters.ChooseGame);
            enterGameChosen = Console.ReadLine();
        }
        
        public void ChooseLanguage() {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine(chooseLanguage);
            languagePrompt = Console.ReadLine();
        }
        public static void PriceToPlayState() {
            Parameters parameters = new Parameters();
            if (GeneralGamesMenu.enterGameChosen != null) {
                switch (languagePrompt) {
                    case "english": Console.WriteLine("The price for this game is " + Parameters.GamePrice + "\n") ;break;
                    case "macedonian": Console.WriteLine("Цената на оваа игра е " + Parameters.GamePrice + "\n"); break;
                }
            }
        }
        public static void RefundPrompt(string refundPrompt) {
            Console.WriteLine(refundPrompt);
            refundAnswer = Console.ReadLine();
        }
        public static void Greeting()=> Console.WriteLine(questionAboutMood);
    }
}

