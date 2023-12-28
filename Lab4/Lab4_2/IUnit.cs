using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    internal interface IUnit
    {
        string Name { get; } //Name of troop

        //Method of executing commands by a troop
        bool ExecuteCommand(string command);
    }
}
