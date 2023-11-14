using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2_MIKS
{
    abstract class CarBuilder 
    {
        protected CarConfiguration car;

        public CarConfiguration Car
        {
            get { return car; }
        }

        //Abstract methods for variation of car components
        public abstract void BuildEngineV6();
        public abstract void BuildEngineV8();
        public abstract void BuildEngineV12();

        public abstract void BuildManualTransmission();
        public abstract void BuildAutomaticTransmission();

        public abstract void BuildLEDHeadlights();
        public abstract void BuildHalogenHeadlights();
        public abstract void BuildXenonHeadlights();
        public abstract void BuildWheels13();
        public abstract void BuildWheels15();
        public abstract void BuildWheels17();
        public abstract void BuildWheels18();
        public abstract void BuildCamerasRearView();
        public abstract void BuildCamerasAllRound();
        public abstract void BuildActiveSafetySystems();
        public abstract void BuildPassiveSafetySystems();
        public abstract void BuildTPanoramicRoof();
        public abstract void BuildFPanoramicRoof();
    }
}
