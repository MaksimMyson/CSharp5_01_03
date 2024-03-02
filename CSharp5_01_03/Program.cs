using MusicInstruments;

namespace CSharp5_01_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            List<IMusicalInstrument> instruments = new List<IMusicalInstrument>();

            string choice;
            do
            {
                Console.WriteLine("Введіть назву та характеристики кожного музичного інструменту:");
                Console.Write("Назва: ");
                string name = Console.ReadLine();
                Console.Write("Характеристики: ");
                string characteristics = Console.ReadLine();

                Console.WriteLine("\nВиберіть тип музичного інструменту:");
                Console.WriteLine("1. Скрипка");
                Console.WriteLine("2. Тромбон");
                Console.WriteLine("3. Укулеле");
                Console.WriteLine("4. Віолончель");
                Console.Write("Ваш вибір: ");
                int instrumentType = int.Parse(Console.ReadLine());

                IMusicalInstrument instrument;
                switch (instrumentType)
                {
                    case 1:
                        instrument = new Violin(name, characteristics);
                        break;
                    case 2:
                        instrument = new Trombone(name, characteristics);
                        break;
                    case 3:
                        instrument = new Ukulele(name, characteristics);
                        break;
                    case 4:
                        instrument = new Cello(name, characteristics);
                        break;
                    default:
                        throw new ArgumentException("Невідомий тип музичного інструменту");
                }

                instruments.Add(instrument);

                Console.Write("Бажаєте додати ще один музичний інструмент? (y/n): ");
                choice = Console.ReadLine();
            } while (choice.ToLower() == "y");

            Console.WriteLine("\nІнформація про музичні інструменти:");
            foreach (var instrument in instruments)
            {
                Console.WriteLine();
                instrument.Show();
                instrument.Desc();
                instrument.Sound();
                instrument.History();
            }
        }
    }
}
