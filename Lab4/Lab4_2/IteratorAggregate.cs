using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    internal interface IteratorAggregate : IEnumerable
    {
        public IEnumerator GetEnumerator();
    }
}
