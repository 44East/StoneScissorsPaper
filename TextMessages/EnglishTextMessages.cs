using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    internal class EnglishTextMessages : BaseTextMessages
    {
        public override string TextCode { get; } = "En";
        public override string GameMenuMessage { get; } =  "\n|                  *****[Game Menu]*****                  |\n" +
                                                           "|      For game enter: [Stone] * [Scissors] * [Paper]     |\n" +
                                                           "|      Or enter:       [Score] * [Back]                   |\n" +
                                                           "|      [Enter your choice]: ";
        public override string OpeningMessage { get; } =  "\n|    *[Welcome in the game - \"Stone, Scissors, Paper.\"]*   |\n" +
                                                          "|        For next step please enter the point name:        |\n" +
                                                          "|     [Menu] * [Exit] * Или если хотите, смените [Язык]    |\n" +
                                                          "|     [Enter your choice]: ";
        public override string PCWinMessage { get; } =    "|              Sorry, you lose in this game.               |\n";
        public override string UserWinMessage { get; } =  "|               Yep, you win in this game!                 |\n";
        public override string NobodysWin { get; } =      "|                      Nobody won.                         |\n";
        public override string IncorrectInput { get; } = "Incorrect input!\n";
        public override string MainMenuMessage { get; } = "\n|                   *****[Main Menu]*****                  |\n" +
                                                          "|     You can chose and enter: [Exit] * [Play] * [Score]   |\n" +
                                                          "|     [Enter your choice]: ";
        public override string Introducing { get; } = "|Please enter your name: ";
        public override string GamesScore { get; } = ": score wins in games - ";
        public override string RoundsScore { get; } = "| score in rounds - ";
    }
}
