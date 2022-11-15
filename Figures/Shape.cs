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
        protected abstract ConsoleColor Col { get; set; }
        public abstract string NameOfObject { get; }
        protected abstract string Appearance { get; }
        public Figures TypeOfObject { get; init; }

        
        public virtual void GetAppear()
        {
            Reflector?.Invoke(this, Col, new AppearanceHandlerEventArgs(Appearance));
        }
        
        public abstract bool GetCondition(Shape shape);
        
    }
}
