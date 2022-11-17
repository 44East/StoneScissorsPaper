﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    internal abstract class BaseTextMessages
    {
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
        public static BaseTextMessages GetTheInstance(string textCode)
        {
            if (textCode.Equals("Ru"))
                return new RussianTextMessages();
            else
                return new EnglishTextMessages();
        }
        private static string langSelect = "|Select and enter your language / Выберите свой язык и введите его|\n" +
                                           "|Enter / Ввод (En/Ру): ";
        public static BaseTextMessages CreateFirstInstance()
        {
            MessageReflector.ShowMessage(langSelect);
            string userChoice;
            do
            {
                userChoice = Console.ReadLine().Trim().ToLower();
                switch(userChoice)
                {
                    case "en":
                    case "english":
                        return new EnglishTextMessages();
                    case "ru":
                    case "russian":
                    case "ру":
                    case "русский":
                        return new RussianTextMessages();
                    default:
                        MessageReflector.ShowMessage("Incorrect input / Неверный ввод");
                        break;
                }
            }
            while (true);
        }
    }
}
