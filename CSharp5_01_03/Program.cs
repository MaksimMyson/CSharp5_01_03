namespace CSharp5_01_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            List<IHomeAppliance> devices = new List<IHomeAppliance>();

            string choice;
            do
            {
                Console.WriteLine("Введіть назву та характеристики кожного пристрою:");
                Console.Write("Назва: ");
                string name = Console.ReadLine();
                Console.Write("Характеристики: ");
                string characteristics = Console.ReadLine();

                try
                {
                    IHomeAppliance device = HomeApplianceFactory.CreateDevice(name, characteristics);
                    devices.Add(device);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.Write("Бажаєте додати ще один пристрій? (y/n): ");
                choice = Console.ReadLine();
            } while (choice.ToLower() == "y");

            Console.WriteLine("\nСписок пристроїв:");
            foreach (var device in devices)
            {
                Console.WriteLine($"Назва пристрою: {device.Name}");
            }

            Console.WriteLine("\nЗвуки пристроїв:");
            foreach (var device in devices)
            {
                device.Sound();
            }
        }
    }
}