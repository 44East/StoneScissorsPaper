using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    abstract class Person
    {
        public Person(string textCode)
        {
            StoneShape = new Stone(textCode);
            ScissorsShape = new Scissors(textCode);
            PaperShape = new Paper(textCode);
        }
        #region Shapes
        public Stone StoneShape;
        public Scissors ScissorsShape;
        public Paper PaperShape;
        #endregion
        public string Name { get; init; }
        #region Scores
        private int winsInGame;
        public int WinsInGame
        {
            get => winsInGame;
            set
            {
                if (winsInGame < 5)
                {
                    winsInGame = value;
                }
                else
                {
                    winsInRounds++;
                    winsInGame = default;

                }
            }
        }

        private int winsInRounds;
        public int WinsInRounds => winsInRounds;
        #endregion

        public virtual void GiveWinInGames() => WinsInGame++;

        public virtual void GetTheGameScore(string textCode)
        {
            var textMessages = BaseTextMessages.GetTheInstance(textCode);
            MessageReflector.ShowMessage(Name+textMessages.GamesScore+WinsInGame+textMessages.RoundsScore+WinsInRounds+"\n");
        }



    }
}
