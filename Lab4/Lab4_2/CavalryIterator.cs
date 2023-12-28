using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    internal class CavalryIterator : Iterator
    {
        private ArmyUnit _army;
        private int _position = -1;
        private bool _reverse = false;
        private const string commandCavalry = "FastMove";

        public CavalryIterator(ArmyUnit army, bool reverse = false)
        {
            this._army = army;
            this._reverse = reverse;

            if (reverse)
            {
                this._position = army.GetUnits().Count;
            }
        }

        public override object Current()
        {
            return this._army.GetUnits()[_position];
        }

        public override int Key()
        {
            return this._position;
        }

        public override bool MoveNext()
        {
            int updatedPosition = this._position + (this._reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < this._army.GetUnits().Count)
            {
                this._position = updatedPosition;
                if (_army.GetUnits()[_position].Name.Equals("Cavalry"))
                {
                    _army.GetUnits()[_position].ExecuteCommand(commandCavalry);
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Reset()
        {
            this._position = this._reverse ? this._army.GetUnits().Count - 1 : 0;
        }
    }
}
