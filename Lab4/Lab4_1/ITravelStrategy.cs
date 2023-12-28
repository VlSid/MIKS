using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    internal interface ITravelStrategy
    {
        void Move(string start, string destination);
    }
}
