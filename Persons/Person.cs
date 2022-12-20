using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    abstract class Person
    {
        internal BaseTextMessages textMessages;

        /// <summary>
        /// All persons must have the figures for playing process 
        /// </summary>
        public Person(BaseTextMessages textMessages, string textCode)
        {
            this.textMessages = textMessages;
            //StoneShape = new Stone(textCode);
            //ScissorsShape = new Scissors(textCode);
            //PaperShape = new Paper(textCode);
        }
        #region Shapes
        public Stone StoneShape;
        public Scissors ScissorsShape;
        public Paper PaperShape;
        #endregion
        public string Name { get; init; }
        #region Scores
        /// <value>
        /// One round has five games
        /// </value>
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

        /// <summary>
        /// The final output all scores
        /// </summary>
        public virtual void GetTheGameScore()
        {

            MessageReflector.ShowMessage($"{Name}\t  " + textMessages.GamesScore  + WinsInGame + textMessages.RoundsScore  + WinsInRounds + "\n");
        }



    }
}
