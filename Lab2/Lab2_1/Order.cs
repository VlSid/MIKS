using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1_MIKS
{
    /// <summary>
    /// Class for information about purchased devices
    /// </summary>
    internal class Order
    {
        Device device;
        public Order(DeviceFactory factory) {
            device = factory.CreateDevice();
        }

        /// <summary>
        /// Method for obtaining information about a purchase
        /// </summary>
        /// <returns></returns>
        public string GetPurchaseInformation()
        {
            return device.GetDescription();
        }
    }
}
