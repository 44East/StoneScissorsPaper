using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    internal abstract class BaseTextMessages
    {
        private static BaseTextMessages textMessages;
        public abstract string TextCode { get; }
        public abstract string ChoosingMessages { get; } 
        public abstract string OpeningMessages { get; } 
        public abstract string PCWinMessage { get; }
        public abstract string UserWinMessage { get; }
        public abstract string NobodysWin { get; }
        public abstract string IncorrectInput { get; } 
        public abstract string DecisionQuestion { get; } 
        public abstract string Introducing { get; }
        public abstract string GamesScore{ get; }
        public abstract string RoundsScore{ get; }
        
        private static string langSelect = "|Select and enter your language / Выберите свой язык и введите его|\n" +
                                           "|Enter / Ввод (En/Ру): ";
        public static BaseTextMessages CreateInstance()
        {
            if (textMessages != null)
                return textMessages; 
            do
            {
                MessageReflector.ShowMessage(langSelect);
                var userChoice = Console.ReadLine().Trim().ToLowerInvariant();
                switch(userChoice)
                {
                    case "en":
                    case "english":
                        textMessages = new EnglishTextMessages();
                        return textMessages;
                    case "ru":
                    case "russian":
                    case "ру":
                    case "русский":
                        textMessages = new RussianTextMessages();
                        return textMessages;
                    default:
                        MessageReflector.ShowMessage("Incorrect input / Неверный ввод");
                        break;
                }
            }
            while (true);
        }
    }
}
