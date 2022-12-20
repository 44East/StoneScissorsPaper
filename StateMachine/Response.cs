using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
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
        public string RuKey { get; init; }
        public string EnKey { get; init; }
        public Action Action { get; set; }
    }
}
