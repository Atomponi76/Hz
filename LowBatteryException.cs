using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class LowBatteryException : Exception
    {

        public MobilePhone? ExcceptionTarget { get; set; }

        public LowBatteryException(): base()
        {
        }
        public LowBatteryException(string message) : base(message)
        {

        }

        public LowBatteryException(string message,MobilePhone excceptionTarget) : base(message)
        {
            ExcceptionTarget = excceptionTarget;
        }
    }
}
