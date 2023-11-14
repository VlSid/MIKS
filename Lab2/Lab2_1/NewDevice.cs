using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1_MIKS
{
    internal class NewDevice : Device
    {
        /// <summary>
        /// Method showing device description
        /// </summary>
        /// <returns></returns>
        public override string GetDescription()
        {
            return "New original device";
        }
    }

}
