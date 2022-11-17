using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    sealed class UserPerson : Person
    {
        public UserPerson(string textCode) 
        : base(textCode){ Name = GetTheName(textCode); }
        private string GetTheName(string textCode)
        {
            BaseTextMessages textMessages = BaseTextMessages.GetTheInstance(textCode);
            MessageReflector.ShowMessage(textMessages.Introducing);
            return Console.ReadLine();
        }
        public Shape GetUserChoice(string textCode)
        {
            
            Action<string> reflector = (e) => MessageReflector.ShowMessage(e);
            BaseTextMessages texteMessages = BaseTextMessages.GetTheInstance(textCode);

            reflector(texteMessages.ChoosingMessages);

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
                            reflector(texteMessages.IncorrectInput);
                            correctInput = false;
                            break;
                        }

                }
            }
            while (!correctInput);
            return shape;
        }
        public override void GiveWinInGames() => base.GiveWinInGames();
        public override void GetTheGameScore(string textCode) { base.GetTheGameScore(textCode); }

    }
}
