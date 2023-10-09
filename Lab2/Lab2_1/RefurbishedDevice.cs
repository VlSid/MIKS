using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1_MIKS
{
    internal class RefurbishedDevice : Device
    {
        /// <summary>
        /// Method showing device description
        /// </summary>
        /// <returns></returns>
        public override string GetDescription()
        {
            Random random = new Random();
            //Assigning the result to a random function to determine the original or replica
            int randomNumber = random.Next(50, 100);
            Console.WriteLine(randomNumber);

            if(randomNumber <= 50)
            {
                return "Original refurbished device";
            } 
            else 
            {
                return "Cheap Chinese replica";
            }
            
        }
    }
}
