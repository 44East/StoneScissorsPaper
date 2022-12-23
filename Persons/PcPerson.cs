using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    sealed class PcPerson : Person
    {
        public PcPerson(BaseTextMessages textMessages, string textCode) : base(textMessages)
        {
            if (textCode.Equals("Ru"))
                Name = "Компьютер";
            else
                Name = "Computer";
        }
        /// <summary>
        /// Receives the Shape collection by reference and sends PC choice by the Random class.
        /// </summary>
        /// <param name="shapes"></param>
        /// <returns></returns>
        public Shape GetUserShape(ref List<Shape> shapes)
        {
            Random random = new Random();
            Shape shape = null;
            while (shape == null)
                shape = shapes.Find(shape => shape.TypeOfObject == (Figures)random.Next(0, 3));
            return shape;
        }
        public override void GiveWinInGames() => base.GiveWinInGames();
        public override void GetTheGameScore() => base.GetTheGameScore();

    }
}
