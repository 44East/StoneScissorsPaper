using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    class TextMessages
    {
        public string ChoosingMessages { get; } = "|Выберите ваиант из меню ниже:                             |\n" +
                                                  "|Введите если хотите играть: (К)амень, (Н)ожницы, (Б)умага |\n" +
                                                  "|Ввод: ";
        public string OpeningMessages { get; } = "|Добро пожаловать в игру - \"Камень, ножницы, бумага.\"|\n" +
                                                 "|Для продолжения нажмите любую клавишу.              |";
        public string PCWinMessage { get; } = "|Увы, вы проиграли в этой баталии.|";
        public string UserWinMessage { get; } = "|Ура, вы победили в этой битве!|";
        public string NobodysWin { get; } = "|Ничья!|";
        public string IncorrectInput { get; } = "Введено некорректное значение, повторите ввод!";
        public string DecisionQuestion { get; } = "|Для продолжения введите: (В)ыход или (И)гра |";
        public string Introducing { get; } = "|Введите свое имя: |";




    }
}
