namespace Lab2_2_MIKS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarBuilder builder = new StandardCarBuilder();
            string? answer;
            do
            {
                Console.WriteLine("Welcome to the Automobile Salon\n" +
                "Configure the car you want to buy\n" +
                "-------List of customizable components------\n" +
                "Required: Engine, Wheels, Headlights, Transmission\n" +
                "Optional: Cameras, Safety Systems, Panoramic roof\n" +
                "---------------------------------------------");
                Console.Write("Ready start?(Y/N) ");
                answer = Console.ReadLine();
            }
            while (answer != "Y" && answer != "N");
            
            if(answer == "Y")
            {
                //Methods for selecting vehicle components
                SelectEngine(builder);
                SelectWheels(builder);
                SelectHeadlights(builder);
                SelectTransmission(builder);
                SelectCameras(builder);
                SelectSafetySystems(builder);
                SelectPanoramicRoof(builder);
                             
                Console.WriteLine("Your car configuration:");
                builder.Car.DisplayConfiguration();
            }
            else
            {
                Console.WriteLine("Have a good day!");
            }
            Console.WriteLine("Have a good day!");
        }

        
        static public void SelectEngine(CarBuilder builder)
        {
            Console.WriteLine("------------------------------------------");
            string choice;
            Console.Write("Select engine\n" +
                    "list of available components:\n" +
                    "1.v6\n" +
                    "2.v8\n" +
                    "3.v12\n" +
                    "Choice:");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    builder.BuildEngineV6();
                    break;
                case "2":
                    builder.BuildEngineV8();
                    break;
                case "3":
                    builder.BuildEngineV12();
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            Console.WriteLine("------------------------------------------");
        }

        
        static public void SelectWheels(CarBuilder builder)
        {
            Console.WriteLine("------------------------------------------");
            string choice;
            Console.Write("Select wheels\n" +
                    "list of available components:\n" +
                    "1.13 inches\n" +
                    "2.15 inches\n" +
                    "3.17 inches\n" +
                    "4.18 inches\n" +
                    "Choice:");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    builder.BuildWheels13();
                    break;
                case "2":
                    builder.BuildWheels15();
                    break;
                case "3":
                    builder.BuildWheels17();
                    break;
                case "4":
                    builder.BuildWheels18();
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            Console.WriteLine("------------------------------------------");
        }

        static public void SelectHeadlights(CarBuilder builder)
        {
            Console.WriteLine("------------------------------------------");
            string choice;
            Console.Write("Select headlights\n" +
                    "list of available components:\n" +
                    "1.Halogen\n" +
                    "2.LED\n" +
                    "3.Xenon\n" +
                    "Choice:");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    builder.BuildHalogenHeadlights();
                    break;
                case "2":
                    builder.BuildLEDHeadlights();
                    break;
                case "3":
                    builder.BuildXenonHeadlights();
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            Console.WriteLine("------------------------------------------");
        }

        static public void SelectTransmission(CarBuilder builder)
        {
            Console.WriteLine("------------------------------------------");
            string choice;
            Console.Write("Select transmission\n" +
                    "list of available components:\n" +
                    "1.Manual\n" +
                    "2.Automatic\n" +
                    "Choice:");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    builder.BuildManualTransmission();
                    break;
                case "2":
                    builder.BuildAutomaticTransmission();
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            Console.WriteLine("------------------------------------------");
        }

        static public void SelectCameras(CarBuilder builder)
        {
            Console.WriteLine("------------------------------------------");
            string choice;
            Console.Write("Select Cameras\n" +
                    "list of available components:\n" +
                    "1.All Round\n" +
                    "2.Rear View\n" +
                    "Choice:");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    builder.BuildCamerasAllRound();
                    break;
                case "2":
                    builder.BuildCamerasRearView();
                    break;
                case "":
                    builder.BuildCamerasRearView();
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            Console.WriteLine("------------------------------------------");
        }

        static public void SelectSafetySystems(CarBuilder builder)
        {
            Console.WriteLine("------------------------------------------");
            string choice;
            Console.Write("Select Safety Systems\n" +
                    "list of available components:\n" +
                    "1.Active\n" +
                    "2.Passive\n" +
                    "Choice:");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    builder.BuildActiveSafetySystems();
                    break;
                case "2":
                    builder.BuildPassiveSafetySystems();
                    break;
                case "":
                    builder.BuildPassiveSafetySystems();
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

            Console.WriteLine("------------------------------------------");
        }

        static public void SelectPanoramicRoof(CarBuilder builder)
        {
            Console.WriteLine("------------------------------------------");
            string choice;
            Console.Write("Select Panoramic roof\n" +
                    "list of available components:\n" +
                    "1.Yes\n" +
                    "2.No\n" +
                    "Choice:");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    builder.BuildTPanoramicRoof();
                    break;
                case "2":
                    builder.BuildFPanoramicRoof();
                    break;
                case "":
                    builder.BuildFPanoramicRoof();
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            Console.WriteLine("------------------------------------------");
        }


    }

    
}