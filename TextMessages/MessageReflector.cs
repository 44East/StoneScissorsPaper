using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    class MessageReflector
    {
        public TextMessages textMessages = new();
        
        
        public static void ShowMessage(string message) => Console.WriteLine(message);
        public void GetClearConsole() => Console.Clear();
        public void ShowAppearance(Shape sender, ConsoleColor col, AppearanceHandlerEventArgs e)
        {
            Console.WriteLine($"Выбрана фигура: {sender.NameOfObject}");
            Console.ForegroundColor = col;
            Console.WriteLine(e.message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        
    }
}
