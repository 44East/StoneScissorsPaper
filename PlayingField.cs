using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    class PlayingField
    {
        TextMessages textMessages = new();
        private MessageReflector messageReflector = new();
        private UserPerson userPerson = new(PlayingField.Introduce());
        private PcPerson pcPerson = new();
        Action<string> MessagesReflector = (e) => MessageReflector.ShowMessage(e);

        static string Introduce()
        {
            Console.Write(TextMessages.Introducing);
            var introduce = Console.ReadLine();
            return introduce;
        }

        public void GetOpen()
        {
            /* Get the method to persons shapes delegate */
            pcPerson.PaperShape.Reflector += messageReflector.ShowAppearance;
            pcPerson.ScissorsShape.Reflector += messageReflector.ShowAppearance;
            pcPerson.StoneShape.Reflector += messageReflector.ShowAppearance;
            userPerson.PaperShape.Reflector += messageReflector.ShowAppearance;
            userPerson.ScissorsShape.Reflector += messageReflector.ShowAppearance;
            userPerson.StoneShape.Reflector += messageReflector.ShowAppearance;


            MessagesReflector(textMessages.OpeningMessages);
            MessagesReflector(textMessages.OpeningMessages);
            messageReflector.GetClearConsole();
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
                MessagesReflector(textMessages.NobodysWin); 
            }
            else if (isPcShapeSafe == true && isUserShapeSafe == false)
            {
                userChoice.GetAppear();
                pcChoice.GetAppear();
                MessagesReflector(textMessages.PCWinMessage);
                pcPerson.GiveWinInGames();
            }
            else
            {
                userChoice.GetAppear();
                pcChoice.GetAppear();
                MessagesReflector(textMessages.UserWinMessage);
                userPerson.GiveWinInGames();
            }
            GetTheSolution();
        }
        void GetTheSolution()
        {
            MessagesReflector(textMessages.DecisionQuestion);
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
                        MessagesReflector(textMessages.IncorrectInput);
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
