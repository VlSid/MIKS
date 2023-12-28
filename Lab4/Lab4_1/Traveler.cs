using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    internal class Traveler
    {

        private ITravelStrategy travelStrategy;

        public Traveler(ITravelStrategy strategy)
        {
            this.travelStrategy = strategy;
        }

        public void SetTravelStrategy(ITravelStrategy strategy)
        {
            this.travelStrategy = strategy;
        }

        /// <summary>
        /// Method of traveling with expenses
        /// </summary>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <param name="money"></param>
        public void Travel(string start, string destination, int money)
        {

            if (money >= 50)
            {
                SetTravelStrategy(new HorseTravelStrategy());
                travelStrategy.Move(start, destination);
            } else if (money >= 40){
                SetTravelStrategy(new SteamboatTravelStrategy());
                travelStrategy.Move(start, destination);
            } else if (money >= 30){
                SetTravelStrategy(new TrainTravelStrategy());
                travelStrategy.Move(start, destination);
                
            } else {
                SetTravelStrategy(new WalkTravelStrategy());
                travelStrategy.Move(start, destination);
            }
        }
    }
}
