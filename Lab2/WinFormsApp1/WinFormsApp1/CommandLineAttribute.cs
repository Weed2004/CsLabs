using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    internal class CommandLineAttribute:Attribute
    {
        public string CommandSwitch { get; }

        public CommandLineAttribute(string commandSwitch)
        {
            CommandSwitch = commandSwitch;
        }
    }
}
