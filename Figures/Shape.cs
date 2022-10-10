using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    abstract class Shape 
    {
        public int TypeOfObject { get; init; }

        Dialogue voice = new Dialogue();

        //it is didn't use
        public virtual void GetVoice(int index, int index2)
        {
           var getVoice = voice[index, index2];
           Console.WriteLine(getVoice);
        }

        public virtual bool GetCondition(Shape shape)
        {
            bool getTheCondition = default;
            return getTheCondition;
        }
    }
}
