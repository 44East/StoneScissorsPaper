using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    class ShowerMessages
    {
        public TextMessages textMessages = new();
        
        public void ShowTheMessage(string message) => Console.WriteLine(message);        
        public void GetClearConsole() => Console.Clear(); 
    }
}
