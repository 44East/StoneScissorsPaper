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
        public abstract string GameMenuMessage { get; } 
        public abstract string OpeningMessage { get; } 
        public abstract string PCWinMessage { get; }
        public abstract string UserWinMessage { get; }
        public abstract string NobodysWin { get; }
        public abstract string IncorrectInput { get; } 
        public abstract string MainMenuMessage { get; } 
        public abstract string Introducing { get; }
        public abstract string GamesScore{ get; }
        public abstract string RoundsScore{ get; }
        
        private static string langSelect = "\n===========================================================================\n" +
                                           "|| [Select and enter your language] * [Выберите свой язык и введите его] ||\n" +
                                           "===========================================================================\n" +
                                           "Enter / Ввод [En/Ру]: ";
        /// <summary>
        /// Singleton for lagauage types 
        /// </summary>
        /// <returns>
        /// Englis or Russian instance 
        /// </returns>
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
        /// <summary>
        /// This method for reset language in game if user wants to change language. 
        /// </summary>
        public static void ResetInstance() => textMessages = null;
    }
}
