using GamesDevProject.cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GamesDevProject.cs {
    class MenuEng {
        public  readonly Dictionary<string, string> StatesEng;
        public MenuEng() {

            StatesEng = new Dictionary<string, string> {
                {"gamesMenuEng", "\n" + " GAMES MENU " + "\n" + "\n" + "Pyramid   Price: $2.5" + "\n" + "Matrix    Price: $3.4" + "\n" + "BiggerCard    Bet minimum : $1.00" },
                {"choosePayToPlayEng", "To play enter \"y\"" + "\n" + "To quit press \" enter \""},
                {"fillWalletPromptEng", "wallet ballance is empty!" + "\n" + "Fill your wallet " },
                {"choosePaymentMethodEng", "To pay with cash press \"1\"" + "\n" + "To pay with card press \"2\"" + "\n" + "To quit press \" enter \"" },
                {"insertPlayerNameEng", "Insert player name"},
                {"insertBalanceEng",  "Insert balance " },
                {"cardNamePromptEng", " Please insert card name" },
                {"insertCardNumberEng", "Insert card number" },
                {"chooseGameEng", "Choose a game " + "\n" + "Enter \"1\" for Pyramid  or \"2\" for Matrix" },
                {"emptyNameNote", "Name can't be empty!" },
                {"enterCashAmount", "Please enter amount "},
                {"enterUserName" , "Please enter username"},
                {"maybeNextTimeEng", "Ok maybe next time" + "\n" + "Have a nice day" },
                {"insertColumnRateEng", "Insert column rate" },
                {"insertRawRateEng", "\"Insert raw rate\"" },
                {"matrixPriceStateEng", "The price for this game is " + PayingToGaming.matrixPrice + "\n" },
                {"pyramidPriceEng" , "The price for this game is " + PayingToGaming.pyramidPrice + "\n"},
                {"pyramidGreetingEng", " Please insert number of pyramid levels wanted : " },
                {"refundPromptEng", "To refund and exit game press \"3 \"" + "\n" + "Press any key to play" },
                {"playAgainPromptEng", "To play again enter \"1\" " + "\n" + "To go to General Menu  enter \"2\"" + "\n" + " To exit press \" Enter \"" },
                {"confirmationOfCashPayment" , "Thank you " + "\n" + "Please take your change : "},
                { "questionAboutMoodEng", "Jump in to play some game?" + "\n" + "Please enter \"y\" if yes or \"n\" if no"},
                {"quitEng", "To exit menu press \" enter \" key OR :" + "\n" },
                {"questionAboutPlayingEng ", "Please enter \"y\" if yes or \"n\" if no to choose again" },
                {"goodbyeEng", "Thank you " + "\n" + "Bye bye" },
                {"notValidInputEng", "Not valid input " }
            };
        }
    }
}
