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
        public override string GameMenuMessage { get; } =  "\n=============================================================\n" +
                                                           "||                  *****[Game Menu]*****                  ||\n" +
                                                           "||   -> For game enter: [Stone] * [Scissors] * [Paper]     ||\n" +
                                                           "||   -> Or enter:       [Score] * [Back]                   ||\n" +
                                                           "=============================================================\n" +
                                                           "[Enter your choice]: ";
        public override string OpeningMessage { get; } =  "\n==============================================================\n" +
                                                          "||   * [Welcome in the game - \"Stone, Scissors, Paper.\"]*   ||\n" +
                                                          "||   * For next step please enter the point name:           ||\n" +
                                                          "||  -> [Menu] * [Exit] * Или если хотите, смените [Язык]    ||\n" +
                                                          "==============================================================\n" +
                                                          "[Enter your choice]: ";
        public override string PCWinMessage { get; } =    "==============================================================\n" +
                                                          "||              Sorry, you lose in this game.               ||\n" +
                                                          "==============================================================\n";
        public override string UserWinMessage { get; } =  "==============================================================\n" +
                                                          "||               Yep, you win in this game!                 ||\n" +
                                                          "==============================================================\n";
        public override string NobodysWin { get; } =      "==============================================================\n" +
                                                          "||                      Nobody won.                         ||\n" +
                                                          "==============================================================\n";
        public override string IncorrectInput { get; } = "************** Incorrect input! **************\n";
        public override string MainMenuMessage { get; } = "\n==============================================================\n" +
                                                          "||                   *****[Main Menu]*****                  ||\n" +
                                                          "||  -> You can chose and enter: [Exit] * [Play] * [Score]   ||\n" +
                                                          "==============================================================\n" +
                                                          "[Enter your choice]: ";
        public override string Introducing { get; } =     "==============================================================\n" +
                                                          "||Please enter your name: ";
        public override string GamesScore { get; } = ": score wins in games - ";
        public override string RoundsScore { get; } = "| score in rounds - ";
    }
}
