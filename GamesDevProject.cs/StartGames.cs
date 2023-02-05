using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesDevProject.cs {
    public class StartGames : IStartGame{
        public void StartGame() {
            switch (GeneralGamesMenu.enterGameChosen) {
                case "1": PyramidGame.StartPyramid(); break;
                case "2": MatrixGame.StartMatrix(); break;
                    case "3": BiggerCardGame.PlayBiggerCard(new ColorNotes(), new GeneralGamesMenu(), new PayingNotes()); break;
            }
        }
    }
}
