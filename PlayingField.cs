using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    class PlayingField
    {
        private ShowerMessages showerMessages = new();
        private UserPerson userPerson = new(PlayingField.Introduce());
        private PcPerson pcPerson = new();

        static string Introduce()
        {
            ShowerMessages show = new ShowerMessages();
            show.ShowTheMessage(show.textMessages.Introducing);
            var introduce = Console.ReadLine();
            return introduce;
        }

        public void GetOpen()
        {
            showerMessages.ShowTheMessage(showerMessages.textMessages.OpeningMessages);
            showerMessages.GetClearConsole();
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

            if (isPcShapeSafe == isUserShapeSafe) { showerMessages.ShowTheMessage(showerMessages.textMessages.NobodysWin); }
            else if (isPcShapeSafe == true && isUserShapeSafe == false)
            {
                showerMessages.ShowTheMessage(showerMessages.textMessages.PCWinMessage);
                pcPerson.GiveWinInGames();
            }
            else
            {
                showerMessages.ShowTheMessage(showerMessages.textMessages.UserWinMessage);
                userPerson.GiveWinInGames();
            }
            GetTheSolution();
        }
        void GetTheSolution()
        {
            showerMessages.ShowTheMessage(showerMessages.textMessages.DecisionQuestion);
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
                        showerMessages.ShowTheMessage(showerMessages.textMessages.IncorrectInput);
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
