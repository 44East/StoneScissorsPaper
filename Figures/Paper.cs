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
        public override string NameOfObject { get; } = "Бумага";
        protected override ConsoleColor Col { get; set; }
        protected override string Appearance { get; } = "####################\n" +
                                                        "######------------##\n" +
                                                        "####-#-#!!!!!!!##-##\n" +
                                                        "##-#---##########-##\n" +
                                                        "##-#####!!!!!!!##-##\n" +
                                                        "##-##############-##\n" +
                                                        "3#-#####!!!!!!!##-##\n" +
                                                        "##----------------##\n" +
                                                        "####################\n";

        public Paper() { TypeOfObject = Figures.Paper; }

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
                    getTheCondition = false;
                    Col = ConsoleColor.Red;
                    break;
                case Paper:
                    getTheCondition = true;
                    Col = ConsoleColor.Green;
                    break;
            }
            return getTheCondition;
        }

    }
}
