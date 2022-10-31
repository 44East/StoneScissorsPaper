using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    class PlayingField
    {
        
        private UserPerson userPerson = new UserPerson();
        private PcPerson pcPerson = new();
        Action<string> ActionReflector = (e) => MessageReflector.ShowMessage(e);

        
        public void GetOpen()
        {
            /* Get the method to persons shapes delegate */
            pcPerson.PaperShape.Reflector += MessageReflector.ShowAppearance;
            pcPerson.ScissorsShape.Reflector += MessageReflector.ShowAppearance;
            pcPerson.StoneShape.Reflector += MessageReflector.ShowAppearance;
            userPerson.PaperShape.Reflector += MessageReflector.ShowAppearance;
            userPerson.ScissorsShape.Reflector += MessageReflector.ShowAppearance;
            userPerson.StoneShape.Reflector += MessageReflector.ShowAppearance;


            ActionReflector(TextMessages.OpeningMessages);
            ActionReflector(TextMessages.OpeningMessages);
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
                ActionReflector(TextMessages.NobodysWin); 
            }
            else if (isPcShapeSafe == true && isUserShapeSafe == false)
            {
                userChoice.GetAppear();
                pcChoice.GetAppear();
                ActionReflector(TextMessages.PCWinMessage);
                pcPerson.GiveWinInGames();
            }
            else
            {
                userChoice.GetAppear();
                pcChoice.GetAppear();
                ActionReflector(TextMessages.UserWinMessage);
                userPerson.GiveWinInGames();
            }
            GetTheSolution();
        }
        void GetTheSolution()
        {
            ActionReflector(TextMessages.DecisionQuestion);
            bool correctInput;
            do
            {
                var input = Console.ReadLine()?.Trim().ToLowerInvariant();
                switch (input)
                {
                    case "и":
                    case "игра":
                        GetTheGame();  
                        correctInput = true;
                        break;
                    case "в":
                    case "выход":
                        GetTheExit();
                        correctInput = true;
                        break;
                    default:
                        ActionReflector(TextMessages.IncorrectInput);
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
