using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    internal  class RussianTextMessages : BaseTextMessages
    {
        public override string TextCode { get; } = "Ru";
        public override string ChoosingMessages { get; } = "|Выберите вариант из меню ниже:                            |\n" +
                                                           "|Введите если хотите играть: (К)амень, (Н)ожницы, (Б)умага |\n" +
                                                           "|Введите выбор ниже: ";
        public override string OpeningMessages { get; } =  "|   Добро пожаловать в игру - \"Камень, ножницы, бумага.\"   |\n" +
                                                           "|          Для продолжения нажмите любую клавишу.          |\n";
        public override string PCWinMessage { get; } =     "|             Увы, вы проиграли в этой баталии.            |\n";
        public override string UserWinMessage { get; } =   "|              Ура, вы победили в этой битве!              |\n";
        public override string NobodysWin { get; } =       "|                          Ничья!                          |\n";
        public override string IncorrectInput { get; } = "Введено некорректное значение, повторите ввод!\n";
        public override string DecisionQuestion { get; } = "|       Для продолжения введите: (В)ыход или (И)гра        |\n";
        public override string Introducing { get; } = "|Введите свое имя: ";
        public override string GamesScore { get; } = ": cчет побед в играх - ";
        public override string RoundsScore { get; } = ", в раундах - ";




    }
}
