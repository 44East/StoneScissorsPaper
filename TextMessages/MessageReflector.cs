using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    internal static class MessageReflector
    {
        /// <summary>
        /// It can be, messagebox or other output
        /// </summary>
        public static void ShowMessage(string message) => Console.Write(message);
        public static void GetClearConsole() => Console.Clear();

        /// <summary>
        /// Method for the Shape type event 
        /// </summary>
        public static void ShowAppearance(Shape sender, ConsoleColor col, AppearanceHandlerEventArgs e)
        {
            Console.WriteLine(/*"Выбрана фигура: */$"{sender.NameOfObject}");
            Console.ForegroundColor = col;
            Console.WriteLine(e.message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        
    }
}
