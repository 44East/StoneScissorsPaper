using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    
    
    abstract class Shape 
    {
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
        
        protected abstract ConsoleColor Col { get; set; }
        public abstract string NameOfObject { get; init; }
        protected abstract string Appearance { get; }
        public Figures TypeOfObject { get; init; }

        
        public virtual void GetAppear()
        {
            Reflector?.Invoke(this, Col, new AppearanceHandlerEventArgs(Appearance));
        }
        
        public abstract bool GetCondition(Shape shape);
        
    }
}
