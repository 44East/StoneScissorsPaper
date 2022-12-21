using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    sealed class PcPerson : Person
    {
        public PcPerson(BaseTextMessages textMessages, string textCode) : base(textMessages)
        {
            if (textCode.Equals("Ru"))
                Name = "Компьютер";
            else
                Name = "Computer";
        }
        public override void GiveWinInGames() => base.GiveWinInGames();
        public override void GetTheGameScore() =>base.GetTheGameScore(); 

    }
}
