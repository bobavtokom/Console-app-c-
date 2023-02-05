using GamesDevProject.cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesDevProject {
     class Program {
        static void Main(string[] args) {
             PayingToGaming payment = new PayingToGaming();
             payment.Inception(new GeneralGamesMenu(), new PayingNotes(),new StartGames());


            //BiggerCardGame.PlayBiggerCard();
            

           

        }
    }
}
