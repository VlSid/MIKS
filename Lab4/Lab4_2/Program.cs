namespace Lab4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArmyUnit army = new ArmyUnit();
            army.AddUnit(new Archer());
            army.AddUnit(new Cavalry());
            army.AddUnit(new Archer());
            army.AddUnit(new Infantry());

            CommandForTroop(army, new CavalryIterator(army), "Cavalry");
            CommandForTroop(army, new ArcherIterator(army), "Archer");
            CommandForTroop(army, new InfantryIterator(army), "Infantry");
        }

        //The method of launching commands for individual units
        public static void CommandForTroop(ArmyUnit army, Iterator it, string nameTroop)
        {
            Console.WriteLine("\n--------------------------------" +
                $"\n{nameTroop} command:"); ;
            army.CreateIterator(it);
            foreach (var unit in army)
            {
                Console.WriteLine(unit);
            }
            Console.WriteLine("--------------------------------");
        }
    }
}