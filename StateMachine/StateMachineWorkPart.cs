using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{  
    
    internal partial class StateMachine
    {
        private States state;
        private BaseTextMessages textMessages;
        private PcPerson pcPerson;
        private UserPerson userPerson;
        private Stone stone;
        private Scissors scissors;
        private Paper paper;
        Action<string> outputMsg = MessageReflector.ShowMessage;
        public StateMachine()
        {
            Initialize();
            textMessages = new RussianTextMessages();
            SetObjectsLanguage();
            state = States.Start;
            MoveNext();
        }
        private void MoveNext()
        {
            outputMsg(menuMessages.GetValueOrDefault(state));
            List<Response> currentStateResponses = responses.GetValueOrDefault(state);
            bool isCorrectInput = false;
            do
            {
                var userInput = Console.ReadLine().Trim().ToLowerInvariant();

                try
                {
                    var response = (from resp in currentStateResponses where resp.EnKey.Contains(userInput) || resp.RuKey.Contains(userInput) select resp).SingleOrDefault();
                    response.Action.Invoke();
                    isCorrectInput = response != null;
                }
                catch (InvalidCastException ex)
                {
                    outputMsg(textMessages.IncorrectInput);
                    outputMsg(menuMessages.GetValueOrDefault(state));
                }
                catch (NullReferenceException ex)
                {
                    outputMsg(textMessages.IncorrectInput);
                    outputMsg(menuMessages.GetValueOrDefault(state));
                }
                catch (Exception ex)
                {
                    outputMsg(textMessages.IncorrectInput);
                    outputMsg(menuMessages.GetValueOrDefault(state));
                }
            } while (!isCorrectInput);
        }
        private void SetSystemLanguage()
        {
            BaseTextMessages.ResetInstance();
            textMessages = BaseTextMessages.CreateInstance();
            state = States.Start;
            SetObjectsLanguage();
            MoveNext();
        }
        private void SetObjectsLanguage()
        {
            InitializeMenuMessages();
            stone = new Stone(textMessages.TextCode);
            scissors = new Scissors(textMessages.TextCode);
            paper = new Paper(textMessages.TextCode);
            pcPerson = new(textMessages, textMessages.TextCode);
        }
        private void SelectFigure(Shape userShape)
        {
            Shape pcShape = (from s in shapes where s.TypeOfObject == pcPerson.GetFigure() select s).FirstOrDefault();
            ComparisonChoices(pcShape, userShape);
        }
        private void ComparisonChoices(Shape pcShape, Shape userShape)
        {
            bool isPcShapeSafe = pcShape.GetCondition(userShape);
            bool isUserShapeSafe = userShape.GetCondition(pcShape);

            if (isPcShapeSafe == isUserShapeSafe)
            {
                userShape.GetAppear();
                pcShape.GetAppear();
                outputMsg(textMessages.NobodysWin);
            }
            else if (isPcShapeSafe == true && isUserShapeSafe == false)
            {
                userShape.GetAppear();
                pcShape.GetAppear();
                outputMsg(textMessages.PCWinMessage);
                pcPerson.GiveWinInGames();
            }
            else
            {
                userShape.GetAppear();
                pcShape.GetAppear();
                outputMsg(textMessages.UserWinMessage);
                userPerson.GiveWinInGames();
            }
            MoveNext();
        }
        private void GetMainMenu()
        {
            state = States.MainMenu;
            GetName();
        }
        private void GetName()
        {
            userPerson = new(textMessages, textMessages.TextCode);
            MoveNext();
        }
        private void PlayGame()
        {
            ShapesInitialize();
            state = States.GameMenu;
            MoveNext();
        }
        private void OpenScoreMenu()
        {
            userPerson.GetTheGameScore();
            pcPerson.GetTheGameScore();
            MoveNext();
        }
        private void BackToLastMenu()
        {
            if (state == States.GameMenu)
                state = States.MainMenu;
            else if (state == States.MainMenu)
                state = States.Start;
            MoveNext();
        }
        private void ExitFromGame()
        {
            userPerson.GetTheGameScore();
            pcPerson.GetTheGameScore();
            Exit();
        }
        private void Exit() { return; }



    }
}
