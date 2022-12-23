using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{


    abstract class Shape
    {
        /// <summary>
        /// Delegate and event for display an "image" by strings
        /// </summary>
        /// <param name="sender">
        /// Each figure sends its props
        /// </param>
        /// <param name="col">
        /// Colors of the win/lose
        /// </param>
        /// <param name="e">
        /// Appearance - an image by strings
        /// </param>
        public delegate void AppearanceHandler(Shape sender, ConsoleColor col, AppearanceHandlerEventArgs e);
        public event AppearanceHandler Reflector = null;

        private string[] _russianNames = { "Камень", "Ножницы", "Бумага" };
        private string[] _englishNames = { "Stone", "Scissors", "Paper" };
        /// <summary>
        /// Check to contain the string key, if a shape contains key it returns true
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public abstract bool ContainsKey(string key);
        /// <summary>
        /// constructor decides the language of the naming shapes
        /// </summary>
        /// <param name="figure"></param>
        /// <param name="textCode"></param>
        public Shape(Figures figure, string textCode)
        {
            if (textCode.Equals("Ru"))
                NameOfObject = _russianNames[(int)figure];
            else
                NameOfObject = _englishNames[(int)figure];
            

        }
        /// <summary>
        /// ConsoleColor - For win it returns a "green" color symbols, for lose a "red" symbols
        /// </summary>
        protected abstract ConsoleColor Col { get; set; }
        public abstract string NameOfObject { get; init; }

        /// <value>
        /// Appearance it's an "image" for each figure
        /// </value>
        protected abstract string Appearance { get; }
        public abstract Figures TypeOfObject { get; init; }


        public void GetAppear()
        {
            Reflector?.Invoke(this, Col, new AppearanceHandlerEventArgs(Appearance));
        }

        /// <summary>
        /// it's a boolean logic, for comparison figures
        /// </summary>
        /// <param name="shape">
        /// The each figure comparisons with the other figure
        /// </param>
        /// <returns>
        /// If a figure loses in comparison, that logic returns [false], but if it's win or draw, it teturns [true] 
        /// </returns>
        public abstract bool GetCondition(Shape shape);//

    }
}
