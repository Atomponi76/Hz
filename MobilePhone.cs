using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class MobilePhone
    {
        public string Name { get; set; }
        public int Energy { get; set; }
        public bool SimCard { get; set; }

        public MobilePhone()
        {

        }

        public MobilePhone(string name, int energy, bool simCard)
        {
            Name = name;
            Energy = energy;
            SimCard = simCard;
        }

        public void Call(string phoneNumber)
        {
            if(Energy <= 0)
            {
                throw new LowBatteryException("...", this);
            }
            if(SimCard == false)
            {
                throw new ArgumentException();
            }
            if (phoneNumber.StartsWith("+380") == false){
                throw new FormatException() ;
            }
            Console.WriteLine("You call on " + phoneNumber);
        }
    }
}
