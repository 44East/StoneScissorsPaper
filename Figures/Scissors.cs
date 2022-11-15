using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    sealed class Scissors : Shape
    {
        public override string NameOfObject { get; } = "Ножницы";
        protected override string Appearance { get; } = "####################\n" +
                                                        "########-#######-###\n" +
                                                        "#######--#####--####\n" +
                                                        "#######--####--#####\n" +
                                                        "#######--##---######\n" +
                                                        "########----########\n" +
                                                        "######--###--#######\n" +
                                                        "####-##-###-#-######\n" +
                                                        "#####--#####-#######\n";
        protected override ConsoleColor Col { get; set; }

        public Scissors() { TypeOfObject = Figures.Scisssors; }

        public override bool GetCondition(Shape shape)
        {
            bool getTheCondition = default;
            switch (shape)
            {
                case Stone:
                    getTheCondition = false;
                    Col = ConsoleColor.Red;
                    break;
                case Scissors:
                    getTheCondition = true;
                    Col = ConsoleColor.Green;
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
