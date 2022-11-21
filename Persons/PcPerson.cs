using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    sealed class PcPerson : Person
    { 
        public PcPerson(string textCode) : base(textCode)
        {
            if (textCode.Equals("Ru"))
                Name = "Компьютер";
            else
                Name = "Computer";
        }
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
        public override void GiveWinInGames() => base.GiveWinInGames();
        public override void GetTheGameScore() { base.GetTheGameScore(); }
        

    


    }
}
