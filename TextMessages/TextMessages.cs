using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    internal static class TextMessages
    {
        public static string ChoosingMessages { get; } = "|Выберите ваиант из меню ниже:                             |\n" +
                                                  "|Введите если хотите играть: (К)амень, (Н)ожницы, (Б)умага |\n" +
                                                  "|Введите выбор ниже: ";
        public static string OpeningMessages { get; } = "|  Добро пожаловать в игру - \"Камень, ножницы, бумага.\"  |\n" +
                                                    "|          Для продолжения нажмите любую клавишу.          |\n";
        public static string PCWinMessage { get; } = "|             Увы, вы проиграли в этой баталии.            |\n";
        public static string UserWinMessage { get; } = "|              Ура, вы победили в этой битве!              |\n";
        public static string NobodysWin { get; } = "|                          Ничья!                          |\n";
        public static string IncorrectInput { get; } = "Введено некорректное значение, повторите ввод!\n";
        public static string DecisionQuestion { get; } = "|       Для продолжения введите: (В)ыход или (И)гра        |\n";
        public static string Introducing { get; } = "|Введите свое имя: ";




    }
}
