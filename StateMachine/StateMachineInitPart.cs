using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace StoneScissorsPaper
{
    /// <summary>
    /// This part for initializing inputs/outputs collections and figures(shapes) collection.
    /// </summary>
    internal partial class StateMachine
    {
        /// <summary>
        /// This is collections for response to user text inputs
        /// </summary>
        private List<Shape> shapes = new List<Shape>();
        private Dictionary<States, List<Response>> responses = new Dictionary<States, List<Response>>();
        private Dictionary<States, string> menuMessages = new Dictionary<States, string>();
        /// <summary>
        /// Initializing a main text messages 
        /// </summary>
        private void InitializeMenuMessages()
        {
            menuMessages.Clear();
            #region Output responses
            menuMessages.Add(States.Start, textMessages.OpeningMessage);
            menuMessages.Add(States.MainMenu, textMessages.MainMenuMessage);
            menuMessages.Add(States.GameMenu, textMessages.GameMenuMessage);
            #endregion
        }
        /// <summary>
        /// Add figures to collection, and add the reflection method for a shapes event 
        /// </summary>
        private void ShapesInitialize()
        {
            shapes.Add(stone);
            shapes.Add(scissors);
            shapes.Add(paper);
            stone.Reflector += MessageReflector.ShowAppearance;
            scissors.Reflector += MessageReflector.ShowAppearance;
            paper.Reflector += MessageReflector.ShowAppearance;
        }
        /// <summary>
        /// The main initialize method in this part, it initializes "Dictonary<States,Response>" colletion for response to user input.
        /// </summary>
        private void Initialize()
        {
            List<Response> startResponses = new List<Response>()
            {
                new Response{RuKey = "язык",EnKey = "language" , Action = (()=> SetSystemLanguage()) },
                new Response{RuKey = "меню", EnKey = "menu", Action = (()=>GetMainMenu())},
                new Response{RuKey = "выход", EnKey = "exit", Action = (()=> Exit()) },
            };
            responses.Add(States.Start, startResponses);
            List<Response> mainMenuStates = new List<Response>()
            {
                new Response{RuKey = "играть", EnKey = "play", Action = (()=> PlayGame()) },
                new Response{RuKey = "назад", EnKey = "back", Action = (()=> BackToLastMenu())},
                new Response{RuKey = "очки", EnKey = "scores", Action = (()=> OpenScoreMenu())},
                new Response{RuKey = "выход", EnKey = "exit", Action = (()=> ExitFromGame())}
            };
            responses.Add(States.MainMenu, mainMenuStates);
            List<Response> gameMenu = new List<Response>()
            {
                new Response{RuKey = "назад", EnKey = "back", Action = (()=> BackToLastMenu())},
                new Response{RuKey = "очки", EnKey = "scores", Action = (()=> OpenScoreMenu())},
                new Response{RuKey = "камень", EnKey = "stone", Action = (()=> SelectFigure(stone))},
                new Response{RuKey = "ножницы", EnKey = "scissors", Action = (()=> SelectFigure(scissors))},
                new Response{RuKey = "бумага", EnKey = "paper", Action = (()=> SelectFigure(paper))}
            };
            responses.Add(States.GameMenu, gameMenu);
        }
    }
}
