using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    sealed class Scissors : Shape
    {      

        public Scissors() { TypeOfObject = (int)Figures.Scisssors; }

        public override bool GetCondition(Shape shape)
        {
            bool getTheCondition = default;
            switch (shape)
            {
                case Stone:
                    getTheCondition = false;
                    break;
                case Scissors:
                    getTheCondition = true;
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
