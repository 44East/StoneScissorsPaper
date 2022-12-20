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
        public override string GameMenuMessage { get; } =  "\n|                 *****[Игровое меню]*****                 |\n" +
                                                           "|     Для игры введите: [Камень] * [Ножницы] * [Бумага]    |\n" +
                                                           "|     Или введите:      [Очки] * [Назад]                   |\n" +
                                                           "|     [Введите выбор ниже]: ";
        public override string OpeningMessage { get; } =   "\n| *[Добро пожаловать в игру - \"Камень, ножницы, бумага.\"]* |\n" +
                                                           "|     Для продолжения введите команду из списка ниже:      |\n"+
                                                           "|    [Играть] * [Выход] * Or you can change [Language]     |\n" +
                                                           "|    [Введите выбор ниже]: ";
        public override string PCWinMessage { get; } =     "|             Увы, вы проиграли в этой баталии.            |\n";
        public override string UserWinMessage { get; } =   "|              Ура, вы победили в этой битве!              |\n";
        public override string NobodysWin { get; } =       "|                          Ничья!                          |\n";
        public override string IncorrectInput { get; } = "Введено некорректное значение, повторите ввод!\n";
        public override string MainMenuMessage { get; } =  "\n|                 *****[Главное меню]*****                 |\n" +
                                                           "|    Для продолжения выберите: [Выход] * [Игра] * [Очки]   |\n" +
                                                           "|    [Введите выбор ниже]: ";
        public override string Introducing { get; } = "|Введите свое имя: ";
        public override string GamesScore { get; } = ": cчет побед в играх - ";
        public override string RoundsScore { get; } = ", в раундах - ";




    }
}
