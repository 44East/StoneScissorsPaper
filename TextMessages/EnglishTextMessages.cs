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
        public override string ChoosingMessages { get; } = "|Chose the shape frome list below:                         |\n" +
                                                           "|(St)one, (Sc)issors, (P)aper                              |\n" +
                                                           "|Enter your choice: ";
        public override string OpeningMessages { get; } =  "|      Welcome in the game - \"Stone, Scissors, Paper.\"     |\n" +
                                                           "|         For next step please press any button.          |\n";
        public override string PCWinMessage { get; } =     "|              Sorry, you lose in this game.              |\n";
        public override string UserWinMessage { get; } =   "|               Yep, you win in this game!                |\n";
        public override string NobodysWin { get; } =       "|                      Nobody won.                        |\n";
        public override string IncorrectInput { get; } = "Incorrect input!\n";
        public override string DecisionQuestion { get; } = "|        You can chose and enter: (E)xit or (P)lay        |\n";
        public override string Introducing { get; } = "|Please enter your name: ";
        public override string GamesScore { get; } = ": score wins in games - ";
        public override string RoundsScore { get; } = "| score in rounds - ";
    }
}
