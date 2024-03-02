namespace CSharp5_01_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            
            Device[] devices = new Device[4];

            Console.WriteLine("Введіть назву та характеристики кожного пристрою:");

            for (int i = 0; i < devices.Length; i++)
            {
                Console.WriteLine($"Пристрій #{i + 1}:");
                Console.Write("Назва: ");
                string name = Console.ReadLine();
                Console.Write("Характеристики: ");
                string characteristics = Console.ReadLine();

                switch (i)
                {
                    case 0:
                        devices[i] = new Kettle(name, characteristics);
                        break;
                    case 1:
                        devices[i] = new Microwave(name, characteristics);
                        break;
                    case 2:
                        devices[i] = new Car(name, characteristics);
                        break;
                    case 3:
                        devices[i] = new Steamboat(name, characteristics);
                        break;
                }
            }

          
            Console.WriteLine("\nЗвук кожного пристрою:");
            foreach (Device device in devices)
            {
                device.Sound();
            }
        }
    }
}
