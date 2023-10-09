using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2_MIKS
{
    /// <summary>
    /// Builder class for building many variants of vehicle components
    /// </summary>
    internal class StandardCarBuilder : CarBuilder
    {
        public StandardCarBuilder() 
        {
            car = new CarConfiguration();
        }

        public override void BuildActiveSafetySystems()
        {
            car.SafetySystems = "Active";
        }
        public override void BuildPassiveSafetySystems()
        {
            car.SafetySystems = "Passive";
        }

        public override void BuildAutomaticTransmission()
        {
            car.Transmission = "Automatic";
        }
        public override void BuildManualTransmission()
        {
            car.Transmission = "Manual";
        }

        public override void BuildCamerasAllRound()
        {
            car.Cameras = "AllRound";
        }
        public override void BuildCamerasRearView()
        {
            car.Cameras = "RearView";
        }

        public override void BuildEngineV12()
        {
            car.Engine = "V12";
        }

        public override void BuildEngineV6()
        {
            car.Engine = "V6";
        }

        public override void BuildEngineV8()
        {
            car.Engine = "V8";
        }

        public override void BuildFPanoramicRoof()
        {
            car.PanoramicRoof = false;
        }
        public override void BuildTPanoramicRoof()
        {
            car.PanoramicRoof = true;
        }

        public override void BuildHalogenHeadlights()
        {
            car.Headlights = "Halogen";
        }

        public override void BuildLEDHeadlights()
        {
            car.Headlights = "LED";
        }
        public override void BuildXenonHeadlights()
        {
            car.Headlights = "Xenon";
        }

        public override void BuildWheels13()
        {
            car.Wheels = "13 inches";
        }

        public override void BuildWheels15()
        {
            car.Wheels = "15 inches";
        }

        public override void BuildWheels17()
        {
            car.Wheels = "17 inches";
        }

        public override void BuildWheels18()
        {
            car.Wheels = "18 inches";
        }
    }
}
