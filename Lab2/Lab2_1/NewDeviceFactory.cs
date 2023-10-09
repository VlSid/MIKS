using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1_MIKS
{
    /// <summary>
    /// Factory class for creating new devices
    /// </summary>
    internal class NewDeviceFactory : DeviceFactory
    {
        /// <summary>
        /// Method for creating a new device
        /// </summary>
        /// <returns></returns>
        public override Device CreateDevice()
        {
            return new NewDevice();
        }
    }
}
