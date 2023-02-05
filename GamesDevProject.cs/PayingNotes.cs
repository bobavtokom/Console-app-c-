using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesDevProject.cs {
    public class PayingNotes : IPayingNotes {
        public string  PromptToPay { get; set; }
        public string PromptToChoosePaymentMethod { get; set; }
        public void FillWalletByCardRegisterNote() {
            switch (GeneralGamesMenu.languagePrompt) {
                case "macedonian":
                    Console.WriteLine("Регистрирана уплата {0}" + "\n" + " име на картичка {1}" + "\n" +
                                   " број на картичка {2} " + "\n", DateTime.Now, PlayerWallet.cardName, PlayerWallet.cardNumber);
                    break;
                case "english":
                    Console.WriteLine("Payment registered " + DateTime.Now + "\n" + "card name " + PlayerWallet.cardName + "\n" +
                                  "card number " +
                                  PlayerWallet.cardNumber + "\n" + PlayerWallet.PlayerName, Convert.ToDouble(PlayerWallet.WalletBalance));
                    break;
            }
        }
        public void ChoosePayToPlay(string choosePayToPlay) {
            Console.WriteLine(choosePayToPlay);
            PromptToPay = Console.ReadLine().ToLower();
        }
        public void FillWalletPrompt(string fillWalletPrompt) {
            Console.WriteLine(fillWalletPrompt);
        }
        public void ChoosePayMethod(string choosePaymentMethod) {
            Console.WriteLine(choosePaymentMethod);
            PromptToChoosePaymentMethod = Console.ReadLine();
        }
    }
}
