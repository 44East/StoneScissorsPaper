using System;

namespace StoneScissorsPaper
{

    //It is didn't use.
    class Dialogue
    {
        private string[,] BattleTexts = new string[4, 2] { { "Ничья!", "Ничья!" }, { "Камень бьет ножницы, вы проиграли в этом раунде!", "Бумага накрывает камень, вы выиграли в этом раунде!" }, { "Ножницы режут бумагу, вы проиграли в этом раунде!", "Камень бьет ножницы, вы выиграли в этом раунде!" }, { "Бумага накрывает камень, вы проиграли в этом раунде!", "Ножницы режут бумагу, вы выиграли в этом раунде!" } };

        public object this[int index, int index2] => BattleTexts[index, index2]; 


    }
}