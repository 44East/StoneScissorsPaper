using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    sealed class PcPerson : Person
    { 
        public PcPerson(BaseTextMessages textMessages, string textCode) : base(textMessages, textCode)
        {
            if (textCode.Equals("Ru"))
                Name = "Компьютер";
            else
                Name = "Computer";
        }
        /// <summary>
        /// Random logic for PC choice
        /// </summary>
        /// <returns>
        /// Some figure
        /// </returns>
        public Shape GetPcChoice() 
        {
            Random rnd = new Random();
            var answer = rnd.Next(0, 3);
            Shape shape = default;
            switch (answer)
            {
                case (int)Figures.Stone:
                    shape = StoneShape;
                    break;
                case (int)Figures.Scisssors:
                    shape = ScissorsShape;
                    break;
                case (int)Figures.Paper:
                    shape = PaperShape;
                    break;
            }
            return shape;
        }
        public Figures GetFigure()
        {
            Random rnd = new Random();
            return (Figures)rnd.Next(0, 3);
        }
        public override void GiveWinInGames() => base.GiveWinInGames();
        public override void GetTheGameScore() { base.GetTheGameScore(); }
        

    


    }
}
