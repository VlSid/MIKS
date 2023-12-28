namespace Lab4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Traveler traveler = new Traveler(new WalkTravelStrategy());

            traveler.Travel("TownA", "TownB", 0);   // On foot, without spending money
            traveler.Travel("TownC", "TownD", 60);  // On a horse
            traveler.Travel("TownE", "TownF", 35);  // By train (not enough money for a steamboat)
            traveler.Travel("TownG", "TownH", 40);  // On a steamboat
        }
    }
}