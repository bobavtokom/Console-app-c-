using System;

namespace GamesDevProject.cs {
    public class ColorNotes : IColoredNotes {
        public void ColoredNotes() {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("BEWARE OF HAZARD");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("This game is for entertaining purposes only");
            Console.ResetColor();
        }
    }
}