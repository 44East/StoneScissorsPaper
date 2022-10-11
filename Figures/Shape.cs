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
        public int TypeOfObject { get; init; }

        Dialogue voice = new Dialogue();
        public virtual void GetAppear()
        {
            Reflector?.Invoke(this, Col, new AppearanceHandlerEventArgs(Appearance));
        }
        #region
        /*it is didn't use **************/
        public virtual void GetVoice(int index, int index2)
        {
           var getVoice = voice[index, index2];
           Console.WriteLine(getVoice);
        }
        /********************************/
        #endregion
        public abstract bool GetCondition(Shape shape);
        
    }
}
