using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    sealed class UserPerson : Person
    {

        public UserPerson(BaseTextMessages textMessages, string textCode)
            : base(textMessages, textCode) { Name = GetTheName(); }
        private string GetTheName()
        {
            MessageReflector.ShowMessage(textMessages.Introducing);
            return Console.ReadLine();
        }
        /// <summary>
        /// This method get the option for user choose
        /// </summary>
        /// <returns>
        /// The figure that user selected
        /// </returns>
        public Shape GetUserChoice()
        {
            Action<string> reflector = (e) => MessageReflector.ShowMessage(e);


            reflector(textMessages.GameMenuMessage);

            Shape shape = default;
            bool correctInput;
            do
            {
                var input = Console.ReadLine()?.ToLowerInvariant().Trim();
                switch (input)
                {
                    case "к":
                    case "камень":
                    case "st":
                    case "stone":
                        {
                            shape = StoneShape;
                            correctInput = true;
                            break;
                        }
                    case "н":
                    case "ножницы":
                    case "sc":
                    case "scissors":
                        {
                            shape = ScissorsShape;
                            correctInput = true;
                            break;
                        }
                    case "б":
                    case "бумага":
                    case "p":
                    case "paper":
                        {
                            shape = PaperShape;
                            correctInput = true;
                            break;
                        }
                    default:
                        {
                            reflector(textMessages.IncorrectInput);
                            correctInput = false;
                            break;
                        }

                }
            }
            while (!correctInput);
            return shape;
        }
        public override void GiveWinInGames() => base.GiveWinInGames();
        public override void GetTheGameScore() { base.GetTheGameScore(); }

    }
}
