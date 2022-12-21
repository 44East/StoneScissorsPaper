using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    sealed class UserPerson : Person
    {

        public UserPerson(BaseTextMessages textMessages)
            : base(textMessages) { Name = GetTheName(); }
        private string GetTheName()
        {
            MessageReflector.ShowMessage(textMessages.Introducing);
            return Console.ReadLine();
        }
        
        public override void GiveWinInGames() => base.GiveWinInGames();
        public override void GetTheGameScore() { base.GetTheGameScore(); }

    }
}
