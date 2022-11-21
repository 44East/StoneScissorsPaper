﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    class PlayingField
    {
        private BaseTextMessages textMessages; 
        private UserPerson userPerson;
        private PcPerson pcPerson;
        public PlayingField()
        {
            textMessages = BaseTextMessages.CreateInstance();
            userPerson = new(textMessages.TextCode);
            pcPerson = new(textMessages.TextCode);
            GetOpen();
        }
        

        
        Action<string> ActionReflector = (e) => MessageReflector.ShowMessage(e);

        
        void GetOpen()
        {
            
            /* Get the method to persons shapes delegate */
            pcPerson.PaperShape.Reflector += MessageReflector.ShowAppearance;
            pcPerson.ScissorsShape.Reflector += MessageReflector.ShowAppearance;
            pcPerson.StoneShape.Reflector += MessageReflector.ShowAppearance;
            userPerson.PaperShape.Reflector += MessageReflector.ShowAppearance;
            userPerson.ScissorsShape.Reflector += MessageReflector.ShowAppearance;
            userPerson.StoneShape.Reflector += MessageReflector.ShowAppearance;


            ActionReflector(textMessages.OpeningMessages);
            ActionReflector(textMessages.OpeningMessages);
            MessageReflector.GetClearConsole();
            GetTheGame();

        }
        void GetTheGame()
        {
            Shape userChoice = userPerson.GetUserChoice();
            Shape pcChoice = pcPerson.GetPcChoice();
            GetCompare(userChoice, pcChoice);
        }


        void GetCompare(Shape userChoice, Shape pcChoice)
        {
            bool isPcShapeSafe = pcChoice.GetCondition(userChoice);
            bool isUserShapeSafe = userChoice.GetCondition(pcChoice);

            if (isPcShapeSafe == isUserShapeSafe) 
            {
                userChoice.GetAppear();
                pcChoice.GetAppear();
                ActionReflector(textMessages.NobodysWin); 
            }
            else if (isPcShapeSafe == true && isUserShapeSafe == false)
            {
                userChoice.GetAppear();
                pcChoice.GetAppear();
                ActionReflector(textMessages.PCWinMessage);
                pcPerson.GiveWinInGames();
            }
            else
            {
                userChoice.GetAppear();
                pcChoice.GetAppear();
                ActionReflector(textMessages.UserWinMessage);
                userPerson.GiveWinInGames();
            }
            GetTheSolution();
        }
        void GetTheSolution()
        {
            ActionReflector(textMessages.DecisionQuestion);
            bool correctInput;
            do
            {
                var input = Console.ReadLine()?.Trim().ToLowerInvariant();
                switch (input)
                {
                    case "и":
                    case "игра":
                    case "p":
                    case "play":
                        GetTheGame();  
                        correctInput = true;
                        break;
                    case "в":
                    case "выход":
                    case "e":
                    case "exit":
                        GetTheExit();
                        correctInput = true;
                        break;
                    default:
                        ActionReflector(textMessages.IncorrectInput);
                        correctInput = false;
                        break;
                }
            }
            while (!correctInput);

        }
        void GetTheExit()
        {
            userPerson.GetTheGameScore();
            pcPerson.GetTheGameScore();

            Console.ReadKey(); //Delay
        }

    }
}
