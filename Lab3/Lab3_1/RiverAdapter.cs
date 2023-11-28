using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{
    /// <summary>
    /// Adapter class for moving in a river
    /// </summary>
    internal class RiverAdapter: IMovement
    {
        public Character character;

        public RiverAdapter(Character character)
        {
            this.character = character;
        }

        public void Move()
        {
            character.MoveCharacter();
            Console.WriteLine("I cross the river in a boat");
        }
    }
}
