using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2_MIKS
{
    /// <summary>
    /// class with the properties of the necessary components for building a car
    /// </summary>
    internal class CarConfiguration
    {
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public string Headlights { get; set; }
        public string Wheels { get; set; }
        public string Cameras { get; set; }
        public string SafetySystems { get; set; }
        public bool PanoramicRoof { get; set; }

        /// <summary>
        /// Show info about Car
        /// </summary>
        public void DisplayConfiguration()
        {
            Console.WriteLine($"Engine: {Engine}");
            Console.WriteLine($"Transmission: {Transmission}");
            Console.WriteLine($"Headlight type: {Headlights}");
            Console.WriteLine($"Wheels: {Wheels}");
            Console.WriteLine($"Cameras: {Cameras}");
            Console.WriteLine($"SafetySystems: {SafetySystems}");
            Console.WriteLine($"PanoramicRoof: {PanoramicRoof}");
        }
    }
}
