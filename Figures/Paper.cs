using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    class Paper : Shape
    {
        
        public Paper() { TypeOfObject = (int)Figures.Paper; }

        public override bool GetCondition(Shape shape)
        {
            bool getTheCondition = default;
            switch(shape)
            {
                case Stone:
                    getTheCondition = true;
                    break;
                case Scissors:
                    getTheCondition = false;
                    break;
                case Paper:
                    getTheCondition = true;
                    break;
            }
            return getTheCondition;
        }

        public override void GetVoice(int index, int index2)
        {
            base.GetVoice(index, index2);
        }
    }
}
