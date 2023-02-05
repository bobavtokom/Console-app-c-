using GamesDevProject.cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GamesDevProject {
    class MatrixGame {
        public static void EnterMatrixColumnRate(string insertColumnRate) => Console.WriteLine(insertColumnRate);
        public static void EnterMatrixRawRate(string insertRawRate) => Console.WriteLine(insertRawRate);
        public static void MatrixDisplay() {
            EnterMatrixRawRate(Parameters.InsertRawRate);
            int matrixRawRate = Convert.ToInt32(Console.ReadLine());
            EnterMatrixColumnRate(Parameters.InsertColumnRate);
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
            MatrixDisplay();
            PyramidGame.PlayAgainPrompt(Parameters.PlayAgainPrompt);
            var playAgainAnswer = Console.ReadLine();
            if (playAgainAnswer == "1") {
                GeneralGamesMenu.PriceToPlayState();
                PayingToGaming payingToGaming = new PayingToGaming();
                PayingToGaming.PayForGame(PayingToGaming.matrixPrice);
                StartMatrix();
            } else if (playAgainAnswer == "2") {
                GeneralGamesMenu.Greeting();
            } 
        }
    }
}
