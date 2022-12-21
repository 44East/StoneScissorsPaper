using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
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
        /// <summary>
        /// Main method in class. It realizes state by user input and compares input with states collections. 
        /// If collections contain string value and String.Contains returns true, this method calls method from delegate in [Response.cs] object from collection. 
        /// Collections and reflections stored in second part this class. 
        /// </summary>
        private void MoveNext()
        {
            MessageReflector.GetClearConsole();
            outputMsg(menuMessages.GetValueOrDefault(state));
            List<Response> currentStateResponses = responses.GetValueOrDefault(state);
            bool isCorrectInput = false;
            do
            {
                var userInput = Console.ReadLine().Trim().ToLower();

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
        /// <summary>
        /// If user wants to change langauge, method MoveNext() calls this method.
        /// </summary>
        private void SetSystemLanguage()
        {
            BaseTextMessages.ResetInstance();
            textMessages = BaseTextMessages.CreateInstance();
            state = States.Start;
            SetObjectsLanguage();
            MoveNext();
        }
        /// <summary>
        /// This method initializes system language by property - TextCode from BaseTextMessages.
        /// If user changes system language, it reinitializes language in all objects.
        /// </summary>
        private void SetObjectsLanguage()
        {
            InitializeMenuMessages();
            stone = new Stone(textMessages.TextCode);
            scissors = new Scissors(textMessages.TextCode);
            paper = new Paper(textMessages.TextCode);
            pcPerson = new(textMessages, textMessages.TextCode);
        }
        /// <summary>
        /// Calls method from PcPerson to get PC choice and receives user choice, and sends both Shapes in Compare method. 
        /// </summary>
        /// <param name="userShape"></param>
        private void SelectFigure(Shape userShape)
        {
            Random random= new Random();
            Shape pcShape = shapes[random.Next(0, 3)];
            CompareChoices(pcShape, userShape);
        }
        /// <summary>
        /// Compares both Shapes [Pc vs User], which fugure returns true it wins.
        /// But if both shapes return [true] = draw.
        /// </summary>
        /// <param name="pcShape"></param>
        /// <param name="userShape"></param>
        private void CompareChoices(Shape pcShape, Shape userShape)
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
            Thread.Sleep(5000);
            MoveNext();
        }
        /// <summary>
        /// Set state and initialize UserPerson type
        /// </summary>
        private void GetMainMenu()
        {
            state = States.MainMenu;
            GetName();
        }
        /// <summary>
        /// Set User name.
        /// </summary>
        private void GetName()
        {
            userPerson = new(textMessages);
            MoveNext();
        }
        /// <summary>
        /// Initializes shapes collection from second part this class.
        /// Set state.
        /// </summary>
        private void PlayGame()
        {
            ShapesInitialize();
            state = States.GameMenu;
            MoveNext();
        }
        /// <summary>
        /// Temp method, it calls method from Person for displaying scores for each type. 
        /// </summary>
        private void OpenScoreMenu()
        {
            userPerson.GetTheGameScore();
            pcPerson.GetTheGameScore();
            Thread.Sleep(5000);
            MoveNext();
        }
        /// <summary>
        /// Changes state StateMachine if user wants to return back
        /// </summary>
        private void BackToLastMenu()
        {
            if (state == States.GameMenu)
                state = States.MainMenu;
            else if (state == States.MainMenu)
                state = States.Start;
            MoveNext();
        }
        /// <summary>
        /// Exit with displaying scores
        /// </summary>
        private void ExitFromGame()
        {
            userPerson.GetTheGameScore();
            pcPerson.GetTheGameScore();
            Exit();
        }
        /// <summary>
        /// Just exit.
        /// </summary>
        private void Exit() { return; }



    }
}
