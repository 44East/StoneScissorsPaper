using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    class AppearanceHandlerEventArgs : EventArgs
    {
        public readonly string message;
        public AppearanceHandlerEventArgs(string message)
        {
            this.message = message;
        }
    }
}
