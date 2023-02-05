using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesDevProject.cs {
    public class MenuMkd {
        public static string gamesMenuMkd = "\n" + " Игри " + "\n" + "\n" + "Пирамида         Цена: $2.5" + "\n" + "Матрица          Цена: $3.4" + "\n" + "Поголема Карта      минимален влог: $1.00";
        public static string choosePayToPlayMkd = "За игра \"y\"" + "\n" + " Откажување \" enter \"";
        public static string fillWalletPromptMkd = "Паричникот е празен! " + "\n" + "Наполни го паричникот ";
        public static string choosePaymentMethodMkd = "Плати во готово \"1\"" + "\n" + "Плати со картичка \"2\"" + "\n" + "Откажување \" enter \"";
        public static string insertPlayerNameMkd = "Внеси корисничко име";
        public static string pyramidPriceStateMkd = "Цената на оваа игра е " + PayingToGaming.pyramidPrice + "\n";
        public static string matrixPriceStateMkd = "Цената на оваа игра е " + PayingToGaming.matrixPrice + "\n";
        public static string chooseGameMkd = "Одбери игра " + "\n" + "Внеси \"1\" за Пирамида или \"2\" за Матрица  \"3\" за Поголема карта ";
        public static string cardNamePromptMkd = "Внеси име на картичка ";
        public static string insertCardNumberMkd = "Внеси број на картичка ";
        public static string insertBalanceMkd = "Внеси сума ";
        public static string pyramidGreetingMkd = " Внесете број на нивоа : ";
        public static string playAgainPromptMkd = "Играј повторно \"1\" Главно Мени \"2\"" + "\n" + " За излез \" Enter \"";
        public static string refundPromptMkd = "За поврат на средства и излез \"3 \"" + "\n" + "Притисни било што за игра";
        public static string emptyNameNoteMkd = "Полето е празно";
        public static string enterCashAmountMkd = "Внеси сума";
        public static string enterUserNameMkd = "Внеси корисничко име";
        public static string confirmationOfCashPaymentMkd = "Благодарам " + "\n" + "Остаток од сумата : ";
        public static string maybeNextTimeMkd = "Можеби следен пат" + "\n" + "Убав ден";
        public static string insertColumnRateMkd = "Внеси број на низи";
        public static string insertRawRateMkd = "Внеси број на редови";
        public static string notValidInputMkd = "Невалидна вредност";


        public static void GamesMenuMkd() {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine(gamesMenuMkd);
        }
    }
}
