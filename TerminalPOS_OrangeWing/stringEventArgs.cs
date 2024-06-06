using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalPOS_Orangewing
{
    public class stringEventArgs : EventArgs
    {
        public string Message { get; private set; }

        public stringEventArgs(string message)
        {
            Message = message;
        }
    }
}
