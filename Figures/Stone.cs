using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    sealed class Stone : Shape
    {
        public Stone() { TypeOfObject = (int)Figures.Stone; }

        public override bool GetCondition(Shape shape)
        {
            bool getTheCondition = default;
            switch (shape)
            {
                case Stone:
                    getTheCondition = true;
                    break;
                case Scissors:
                    getTheCondition = true;
                    break;
                case Paper:
                    getTheCondition = false;
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
