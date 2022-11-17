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
            var answer = rnd.Next(1, 4);
            Shape shape = default;
            switch (answer)
            {
                case 1:
                    shape = StoneShape;
                    break;
                case 2:
                    shape = ScissorsShape;
                    break;
                case 3:
                    shape = PaperShape;
                    break;
            }
            return shape;
        }
        public override void GiveWinInGames() => base.GiveWinInGames();
        public override void GetTheGameScore(string textCode) { base.GetTheGameScore(textCode); }
        

    


    }
}
