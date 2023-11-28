using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{
    internal class CharacterСontrol
    {
        public void TravelCharacter(IMovement obj)
        {
            obj.Move();//Calling a movement method object
        }
    }
}
