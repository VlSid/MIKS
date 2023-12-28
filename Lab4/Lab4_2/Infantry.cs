using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    internal class Infantry : IUnit
    {
        public string Name => "Infantry";
        public bool ExecuteCommand(string command)
        {
            if (command == "Hand-to-Hand")
            {
                Console.WriteLine("Infantry executing Hand-to-Hand command");
                return true;
            }
            return false;
        }
    }
}
