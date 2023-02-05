using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesDevProject.cs {
    public interface IPayingNotes {
        string PromptToPay { get; set; }
        string PromptToChoosePaymentMethod { get; set; }
        void FillWalletByCardRegisterNote();
        void ChoosePayToPlay(string choosePayToPlay);
        void FillWalletPrompt(string fillWalletPrompt);
        void ChoosePayMethod(string ChoosePaymentMethod);
    }
}
