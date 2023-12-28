using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    internal abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();

        /// <summary>
        /// Returns the key of the current element
        /// </summary>
        /// <returns></returns>
        public abstract int Key();

        /// <summary>
        /// Returns the current element
        /// </summary>
        /// <returns></returns>
        public abstract object Current();

        /// <summary>
        /// Moves to the next element.
        /// </summary>
        /// <returns></returns>
        public abstract bool MoveNext();


        /// <summary>
        /// Rewinds the Iterator to the first element.
        /// </summary>
        public abstract void Reset();
    }
}
