using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    /// <summary>
    /// It stores the struct (it isn't System type "Struct") of the response to user input
    /// </summary>
    internal class Response
    {
        public Response() { }
        public Response(string ruKey, string enKey, Action action) 
        {
            RuKey = ruKey;
            EnKey = enKey;
            Action = action;
        }
        public Response(string ruKey, string enKey)
        {
            RuKey= ruKey;
            EnKey= enKey;
        }
        /// <summary>
        /// A [Ru] user input. The StateMachine checks this key with a user input by String.Contains() method.
        /// </summary>
        public string RuKey { get; init; }
        /// <summary>
        /// An [En] user input. The StateMachine checks this key with a user input by String.Contains() method.
        /// </summary>
        public string EnKey { get; init; }
        public Action Action { get; set; }
    }
}
