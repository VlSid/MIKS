namespace Lab2_1_MIKS
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int choice;
            Order order;

            do
            {
                Console.Write(
                "Welcome to the Apple Electronics Store\n" +
                "There are two categories of devices available in the store:\r\n" +
                "1 - new products\n" +
                "2 - refurbished products\n" +
                "Choose which one you want (1 or 2):"
                );
                choice = Convert.ToInt16(Console.ReadLine());
            }
            while (choice < 1 || choice > 2);


            if (choice == 1)
            {
                order = new Order(new NewDeviceFactory());
            }
            else
            {
                order = new Order(new RefurbishedDeviceFactory());
            }
            Console.WriteLine($"\nAfter ordering you received:{order.GetPurchaseInformation()}");
        }
    }
}