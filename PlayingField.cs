using System;
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

        /// <summary>
        /// Init the game, select the languahe
        /// </summary>
        public PlayingField()
        {
            textMessages = BaseTextMessages.CreateInstance();
            userPerson = new(textMessages,textMessages.TextCode);
            pcPerson = new(textMessages, textMessages.TextCode);
            GetOpen();
        }
        

        
        Action<string> ActionReflector = (e) => MessageReflector.ShowMessage(e);

        /// <summary>
        /// Add the output method to shapes events,
        /// Greeting, and open game.
        /// </summary>
        void GetOpen()
        {
            
            
            pcPerson.PaperShape.Reflector += MessageReflector.ShowAppearance;
            pcPerson.ScissorsShape.Reflector += MessageReflector.ShowAppearance;
            pcPerson.StoneShape.Reflector += MessageReflector.ShowAppearance;
            userPerson.PaperShape.Reflector += MessageReflector.ShowAppearance;
            userPerson.ScissorsShape.Reflector += MessageReflector.ShowAppearance;
            userPerson.StoneShape.Reflector += MessageReflector.ShowAppearance;


            ActionReflector(textMessages.OpeningMessage);
            ActionReflector(textMessages.OpeningMessage);
            MessageReflector.GetClearConsole();
            GetTheGame();

        }
        
        void GetTheGame()
        {
            Shape userChoice = userPerson.GetUserChoice();
            Shape pcChoice = pcPerson.GetPcChoice();
            GetCompare(userChoice, pcChoice);
        }

        /// <summary>
        /// Comparison figures by boolean logic in a base shape class
        /// </summary>
        void GetCompare(Shape userShape, Shape pcShape)
        {
            bool isPcShapeSafe = pcShape.GetCondition(userShape);
            bool isUserShapeSafe = userShape.GetCondition(pcShape);

            if (isPcShapeSafe == isUserShapeSafe) 
            {
                userShape.GetAppear();
                pcShape.GetAppear();
                ActionReflector(textMessages.NobodysWin); 
            }
            else if (isPcShapeSafe == true && isUserShapeSafe == false)
            {
                userShape.GetAppear();
                pcShape.GetAppear();
                ActionReflector(textMessages.PCWinMessage);
                pcPerson.GiveWinInGames();
            }
            else
            {
                userShape.GetAppear();
                pcShape.GetAppear();
                ActionReflector(textMessages.UserWinMessage);
                userPerson.GiveWinInGames();
            }
            GetTheSolution();
        }
        /// <summary>
        /// Two options for user - get the next match or leave the game
        /// </summary>
        void GetTheSolution()
        {
            ActionReflector(textMessages.MainMenuMessage);
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
