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
        public Shape(Figures figures, string textCode)
        {
            if (textCode.Equals("Ru"))
                NameOfObject = _russianNames[(int)figures];
            else
                NameOfObject = _englishNames[(int)figures];
        }
        /// <summary>
        /// ConsoleColor - For win it returns "green" color symbols, for lose "red" symbols
        /// </summary>
        protected abstract ConsoleColor Col { get; set; }
        public abstract string NameOfObject { get; init; }

        /// <value>
        /// Appearance it's an "image" for each figure
        /// </value>
        protected abstract string Appearance { get; }
        public Figures TypeOfObject { get; init; }

        
        public void GetAppear()
        {
            Reflector?.Invoke(this, Col, new AppearanceHandlerEventArgs(Appearance));
        }
        
        /// <summary>
        /// it's a boolean logic, for comparison figures
        /// </summary>
        /// <param name="shape">
        /// Each figure comparisons other figure
        /// </param>
        /// <returns>
        /// If figure loses in comparison, that logic returns [false], but if it's win or draw, it teturns [true] 
        /// </returns>
        public abstract bool GetCondition(Shape shape);//
        
    }
}
