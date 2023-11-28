using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{
    /// <summary>
    /// Adapter class for moving in a canyon
    /// </summary>
    internal class CanyonAdapter : IMovement
    {
        public Character character;

        public CanyonAdapter(Character character)
        {
            this.character = character;
        }

        public void Move()
        {
            character.MoveCharacter();
            Console.WriteLine("I cross the canyon on a hang glider");
        }
    }
}
