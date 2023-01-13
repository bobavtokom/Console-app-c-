using GamesDevProject.cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesDevProject {
    class MatrixGame {
        public static void EnterMatrixColumnRate() => Console.WriteLine("Insert column rate");
        public static void EnterMatrixRawRate() => Console.WriteLine("Insert raw rate");
        public static void MatrixGreeting() => Console.WriteLine("You may play now");
        public static void MatrixDisplay() {
            EnterMatrixRawRate();
            int matrixRawRate = Convert.ToInt32(Console.ReadLine());
            EnterMatrixColumnRate();
            int matrixColumnRate = Convert.ToInt32(Console.ReadLine());
            int[,] TableCalendar = new int[50,50];
            for (int i = 0; i < TableCalendar.GetLength(0); i += matrixRawRate) {
                for (int j = 0; j < TableCalendar.GetLength(1); j += matrixColumnRate) {
                    TableCalendar[i, j] = i + j;
                    Console.Write(TableCalendar[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }
     
        public static void StartMatrix() {
            MatrixGreeting();
            MatrixDisplay();
            PyramidGame.PlayAgainPrompt(PyramidGame.playAgainPromptEng);
            var playAgainAnswer = Console.ReadLine();
            if (playAgainAnswer == "1") {
                GeneralGamesMenu.PriceToPlayMatrix(GeneralGamesMenu.matrixPriceEng);
                PayingToGaming payingToGaming = new PayingToGaming();
                PayingToGaming.PayForGame(PayingToGaming.matrixPrice);
                StartMatrix();
            } else if (playAgainAnswer == "2") {
                GeneralGamesMenu.Greeting();
            } 
        }
    }
}
