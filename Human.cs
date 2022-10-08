using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Human
    {
        public string Name {  get; set; } 
        
        public int Age { get; set; }

        public Human()
        {
        }

        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Fly()
        {
            throw new NotImplementedException("Human cannot fly yet");
        }
        public void BuyWeapon()
        {
            if(Age >= 21)
            {
                Console.WriteLine("You buy a weapon");
            }
            else
            {
                throw new MemberAccessException("You canot buy a weopon");
            }
        }
    }
}
