using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    //The class that represents the mixed pasture of the army
    internal class ArmyUnit : IteratorAggregate
    {
        private List<IUnit> units = new List<IUnit>();
        private Iterator _iterator;

        // Adding a unit to the pen
        public void AddUnit(IUnit unit)
        {
            units.Add(unit);
        }

        public List<IUnit> GetUnits()
        {
            return units;
        }

        public void CreateIterator(Iterator iterator)
        {
            _iterator = iterator;
        }

        public IEnumerator GetEnumerator()
        {
            return _iterator;
        }
    }
}
