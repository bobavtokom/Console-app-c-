using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GamesDevProject.cs {
     class Parameters : MenuEng {
        public static string InsertPlayerName { get; set; }
        public static string InsertBalance { get; set; }
        public static string CardNamePrompt { get; set; }
        public static string InsertCardNumber { get; set; }
        public static string ChooseGame { get; set; }
        public static string EmptyNameNote { get; set; }
        public static string EnterCashAmount { get; set; }
        public static string EnterUserName { get; set; }
        public static string ConfirmationOfCashPayment { get; set; }
        public static string PyramidPriceState { get; set; }
                            
        public static string PyramidGreeting { get; set; }
        public static string FillWalletPrompt { get; set; }
        public static string PlayAgainPrompt { get; set; }
        public static string RefundPrompt { get; set; }
        public static string MatrixPriceState { get; set; }
        public static string MaybeNextTime { get; set; }

        public static string InsertColumnRate { get; set; }
        public static string InsertRawRate { get; set; }
        public static string ChoosePaymentMethod { get; set; }
        public static string GamesMenu { get; set; }
        public static string ChoosePayToPlay { get; set; }
        public static string NotValidInput { get; set; }
        public static double GamePrice { get; set; }
        
        public Parameters () {
             if (GeneralGamesMenu.languagePrompt == GeneralGamesMenu.english) {
            //switch (GeneralGamesMenu.languagePrompt) {
                //case "english":
                    InsertPlayerName = MenuEngStates.insertPlayerNameEng;
                    InsertBalance = MenuEngStates.insertBalanceEng;
                    CardNamePrompt = MenuEngStates.cardNamePromptEng;
                    InsertCardNumber = MenuEngStates.insertCardNumberEng;
                    ChooseGame = MenuEngStates.chooseGameEng;
                    EmptyNameNote = MenuEngStates.emptyNameNote;
                    EnterCashAmount = MenuEngStates.enterCashAmount;
                    EnterUserName = MenuEngStates.enterUserNameEng;
                    ConfirmationOfCashPayment = MenuEngStates.confirmationOfCashPaymentEng;
                    PyramidPriceState = MenuEngStates.pyramidPriceStateEng;
                    PyramidGreeting = MenuEngStates.pyramidGreetingEng;
                    FillWalletPrompt = MenuEngStates.fillWalletPromptEng;
                    PlayAgainPrompt = MenuEngStates.playAgainPromptEng;
                    RefundPrompt = MenuEngStates.refundPromptEng;
                    MatrixPriceState = MenuEngStates.matrixPriceStateEng;
                    MaybeNextTime = MenuEngStates.maybeNextTimeEng;
                    InsertColumnRate = MenuEngStates.insertColumnRateEng;
                    InsertRawRate = MenuEngStates.insertRawRateEng;
                    ChoosePaymentMethod = MenuEngStates.choosePaymentMethodEng;
                    GamesMenu = MenuEngStates.gamesMenuEng;
                    ChoosePayToPlay = MenuEngStates.choosePayToPlayEng;
                    NotValidInput = MenuEngStates.notValidInputEng;
                   // break;
                   //  case "macedonian":

                    }
                    if (GeneralGamesMenu.languagePrompt == GeneralGamesMenu.macedonian) {

                    InsertPlayerName = MenuMkd.insertPlayerNameMkd;
                    InsertBalance = MenuMkd.insertBalanceMkd;
                    CardNamePrompt = MenuMkd.cardNamePromptMkd;
                    InsertCardNumber = MenuMkd.insertCardNumberMkd;
                    ChooseGame = MenuMkd.chooseGameMkd;
                    EmptyNameNote = MenuMkd.emptyNameNoteMkd;
                    EnterCashAmount = MenuMkd.enterCashAmountMkd;
                    EnterUserName = MenuMkd.enterUserNameMkd;
                    ConfirmationOfCashPayment = MenuMkd.confirmationOfCashPaymentMkd;
                    PyramidPriceState = MenuMkd.pyramidPriceStateMkd;
                    PyramidGreeting = MenuMkd.pyramidGreetingMkd;
                    FillWalletPrompt = MenuMkd.fillWalletPromptMkd;
                    PlayAgainPrompt = MenuMkd.playAgainPromptMkd;
                    RefundPrompt = MenuMkd.refundPromptMkd;
                    MatrixPriceState = MenuMkd.matrixPriceStateMkd;
                    MaybeNextTime = MenuMkd.maybeNextTimeMkd;
                    InsertColumnRate = MenuMkd.insertColumnRateMkd;
                    InsertRawRate = MenuMkd.insertRawRateMkd;
                    ChoosePaymentMethod = MenuMkd.choosePaymentMethodMkd;
                    GamesMenu = MenuMkd.gamesMenuMkd;
                    ChoosePayToPlay = MenuMkd.choosePayToPlayMkd;
                    NotValidInput = MenuMkd.notValidInputMkd;
                    //break;
           // }
            }
             if (GeneralGamesMenu.enterGameChosen == PayingToGaming.pyramid)  GamePrice = 2.5; 
             if (GeneralGamesMenu.enterGameChosen == PayingToGaming.matrix) GamePrice = 3.4;
        }
    }
}
