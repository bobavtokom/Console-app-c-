using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GamesDevProject.cs {
    public class GeneralGamesMenu {
        public static string languagePrompt;
        public static string chooseLanguage = "Choose language " + "\n" + " English press 1" + "\n" + " Македонски притисни 2";
        public static string enterGameChosen;
        public static string maybeNextTime = "Ok maybe next time" + "\n" + "Have a nice day";
        public static string questionAboutMood = "Jump in to play some game?" + "\n" + "Please enter \"y\" if yes or \"n\" if no";
        public string quit = "To exit menu press \" enter \" key OR :" + "\n";
        public string questionAboutPlaying = "Please enter \"y\" if yes or \"n\" if no to choose again";
        public string goodbye = "Thank you " + "\n" + "Bye bye";
        public static string chooseGameEng = "Choose a game " + "\n" + "Enter \"1\" for Pyramid  or \"2\" for Matrix";
        public static string notValidInput = "Not valid input " + "\n" + chooseGameEng;
        public string answerAboutMood;
        public static string pyramidPriceEng = "The price for this game is " + PayingToGaming.pyramidPrice + "\n";
        public static string matrixPriceEng = "The price for this game is " + PayingToGaming.matrixPrice + "\n";
        public static string refundPromptEng = "To refund and exit game press \"3 \"" + "\n" + "Press any key to play";
        public static string refundAnswer;
        public static void ChooseGame(string chooseGame) {
            Console.WriteLine(chooseGame);
            enterGameChosen = Console.ReadLine();
        }
        public static void ChooseLanguage() {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine(chooseLanguage);
            languagePrompt = Console.ReadLine();
        }
        public static void PriceToPlayMatrix(string matrixPrice) => Console.WriteLine(matrixPrice);
        public static void PriceToPlayPyramid(string pyramidPrice) => Console.WriteLine(pyramidPrice);
        public static void RefundPrompt(string refundPrompt) {
            Console.WriteLine(refundPrompt);
            refundAnswer = Console.ReadLine();
        }
        
        public void IfExceptionGenMenu() => Console.WriteLine(questionAboutMood);
        public static void Greeting()=> Console.WriteLine(questionAboutMood);
        public void MaybeNextTime() {
            Console.WriteLine(maybeNextTime);
            Console.WriteLine(goodbye);
        }
        
        public void SecondThoughtException() {
           string secondThought = Console.ReadLine().ToLower();
            if (secondThought != "y" || secondThought != "n") {
                IfExceptionGenMenu();
               
            }
        }
       

    }
}

