using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1_MIKS
{
    /// <summary>
    /// Factory class for creating refurbished devices
    /// </summary>
    internal class RefurbishedDeviceFactory : DeviceFactory
    {
        /// <summary>
        /// Method for creating a refurbished device
        /// </summary>
        /// <returns></returns>
        public override Device CreateDevice()
        {
            return new RefurbishedDevice();
        }
    }
}
