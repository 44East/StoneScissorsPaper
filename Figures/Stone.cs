using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    sealed class Stone : Shape
    {
        public override string NameOfObject { get; } = "Камень";
        protected override string Appearance { get; } = "####################\n" +
                                                        "######--------######\n" +
                                                        "####-###-######-####\n" +
                                                        "##----------------##\n" +
                                                        "###-###-########-###\n" +
                                                        "#####-##-#####-#####\n" +
                                                        "#######-#-##-#######\n" +
                                                        "#########--#########\n" +
                                                        "####################\n";
        protected override ConsoleColor Col { get; set; }
        public Stone() { TypeOfObject = Figures.Stone; }

        public override bool GetCondition(Shape shape)
        {
            bool getTheCondition = default;
            switch (shape)
            {
                case Stone:
                    getTheCondition = true;
                    Col = ConsoleColor.Green;
                    break;
                case Scissors:
                    getTheCondition = true;
                    Col = ConsoleColor.Green;
                    break;
                case Paper:
                    getTheCondition = false;
                    Col = ConsoleColor.Red;
                    break;
            }
            return getTheCondition;

        }

        
        
    }
}
