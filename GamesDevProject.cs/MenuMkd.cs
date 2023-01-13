using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesDevProject.cs {
    public class MenuMkd {
        public static string gamesMenuMkd = "\n" + " Игри " + "\n" + "\n" + "Пирамида   Цена: $2.5" + "\n" + "Матрица    Цена: $3.4" + "\n";
        public static string choosePayToPlayMkd = "За игра \"y\"" + "\n" + " Откажување \" enter \"";
        public static string fillWalletPromptMkd = "Паричникот е празен! " + "\n" + "Наполни го паричникот ";
        public static string choosePaymentMethodMkd = "Плати во готово \"1\"" + "\n" + "Плати со картичка \"2\"" + "\n" + "Откажување \" enter \"";
        public static string insertPlayerNameMkd = "Внеси корисничко име";
        public static string pyramidPriceMkd = "Цената на оваа игра е " + PayingToGaming.pyramidPrice + "\n";
        public static string matrixPriceMkd = "Цената на оваа игра е " + PayingToGaming.matrixPrice + "\n";
        public static string chooseGameMkd = "Одбери игра " + "\n" + "Внеси \"1\" за Пирамида или \"2\" за Матрица";
        public static string cardNamePromptMkd = "Внеси име на картичка ";
        public static string insertCardNumberMkd = "Внеси број на картичка ";
        public static string insertBalanceMkd = "Внеси сума ";
        public static string pyramidGreetingMkd = " Внесете број на нивоа : ";
        public static string playAgainPromptMkd = "Играј повторно \"1\" Главно Мени \"2\"" + "\n" + " За излез \" Enter \"";
        public static string refundPromptMkd = "За поврат на средства и излез \"3 \"" + "\n" + "Притисни било што за игра";

        public static void FillWalletByCardNoteMkd() {
            Console.WriteLine("Регистрирана уплата " + DateTime.Now + "\n" + " име на картичка " + PlayerWallet.cardName + "\n" +
                              " број на картичка " + PlayerWallet.cardNumber + "\n" );
        }
        public static void GamesMenuMkd() {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine(gamesMenuMkd);
        }
    }
}
