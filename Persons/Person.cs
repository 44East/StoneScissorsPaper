using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    abstract class Person
    {
        #region Shapes
        public Stone StoneShape = new();
        public Scissors ScissorsShape = new();
        public Paper PaperShape = new();
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

        public virtual void GetTheGameScore() { Console.WriteLine($"{Name}: cчет побед в играх - {WinsInGame}, в раундах - {WinsInRounds} "); }
        

    }
}
