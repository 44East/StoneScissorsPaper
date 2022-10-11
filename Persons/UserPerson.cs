﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    sealed class UserPerson : Person
    {
        public UserPerson(string name) { Name = name; }
        public Shape GetUserChoice()
        {
            Action<string> reflector = (e) => MessageReflector.ShowMessage(e);
            TextMessages textMessages = new();
            reflector(textMessages.ChoosingMessages);

            Shape shape = default;
            bool correctInput;
            do
            {
                var input = Console.ReadLine()?.ToLowerInvariant().Trim();
                switch (input)
                {
                    case "к":
                    case "камень":
                        {
                            shape = StoneShape;
                            correctInput = true;
                            break;
                        }
                    case "н":
                    case "ножницы":
                        {
                            shape = ScissorsShape;
                            correctInput = true;
                            break;
                        }
                    case "б":
                    case "бумага":
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