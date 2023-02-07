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
        public static string ComputerCardIs { get; set; }
        public static string PyramidGreeting { get; set; }
        public static string FillWalletPrompt { get; set; }
        public static string PlayAgainPrompt { get; set; }
        public static string RefundPrompt { get; set; }
        public static string MatrixPriceState { get; set; }
        public static string MaybeNextTime { get; set; }
        public static string DrawYourCard{ get; set; }

        public static string InsertColumnRate { get; set; }
        public static string InsertRawRate { get; set; }
        public static string ChoosePaymentMethod { get; set; }
        public static string GamesMenu { get; set; }
        public static string ChoosePayToPlay { get; set; }
        public static string NotValidInput { get; set; }
        public static string HazardGameNote { get; set; }
        public static double GamePrice { get; set; }
        public static string Success { get; set; }
        public static string DrawComputerCard { get; set; }
        public static string WinState { get; set; }
        public static string LoseState { get; set; }
        public static string NooneWinState { get; set; }
        public static string PlaceBet { get; set; }
        public static string YourCardIs { get; set; }
        public Parameters () {
            var languageNoteKey = new MenuEng();
            if (GeneralGamesMenu.languagePrompt == GeneralGamesMenu.english) {
                //switch (GeneralGamesMenu.languagePrompt) {
                //case "english":
                    ComputerCardIs = languageNoteKey["computerCardIsEng"];
                    YourCardIs = languageNoteKey["yourCardIsEng"];
                    PlaceBet = languageNoteKey["placeBetAmountEng"];
                    NooneWinState = languageNoteKey["nooneWinsEng"];
                    LoseState = languageNoteKey["loseStateEng"];
                    WinState = languageNoteKey["winStateEng"];
                    DrawComputerCard = languageNoteKey["drawComputerCardEng"];
                    Success = languageNoteKey["successEng"];
                    HazardGameNote = languageNoteKey["hazardGameNoteEng"];
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
                    DrawYourCard = languageNoteKey["drawYourCardEng"];
                   // break;
                   //  case "macedonian":

                    }
                    if (GeneralGamesMenu.languagePrompt == GeneralGamesMenu.macedonian) {

                    ComputerCardIs = languageNoteKey["computerCardIsMkd"];
                    YourCardIs = languageNoteKey["yourCardIsMkd"];
                    PlaceBet = languageNoteKey["placeBetAmountMkd"];
                    NooneWinState = languageNoteKey["nooneWinsMkd"];
                    LoseState = languageNoteKey["loseStateMkd"];
                    WinState = languageNoteKey["winStateMkd"];
                    DrawComputerCard = languageNoteKey["drawComputerCardMkd"];
                    Success = languageNoteKey["successMkd"];
                    HazardGameNote = languageNoteKey["hazardGameNoteMkd"];
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
                    DrawYourCard = languageNoteKey["drawYourCardMkd"];
                //break;
                // }
            }
             if (GeneralGamesMenu.enterGameChosen == PayingToGaming.pyramid)  GamePrice = 2.5; 
             if (GeneralGamesMenu.enterGameChosen == PayingToGaming.matrix) GamePrice = 3.4;
        }
        
    }
}
