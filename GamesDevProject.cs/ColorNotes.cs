using System;

namespace GamesDevProject.cs {
    public class ColorNotes : IColoredNotes {
        public void ColoredNotes(string note1) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(note1);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}