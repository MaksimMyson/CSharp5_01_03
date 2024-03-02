using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicInstruments
{
    public class Trombone : IMusicalInstrument
    {
        public string Name { get; }
        public string Characteristics { get; }

        public Trombone(string name, string characteristics)
        {
            Name = name;
            Characteristics = characteristics;
        }

        public void Sound()
        {
            Console.WriteLine("Тромбон: Звук тромбона");
        }

        public void Show()
        {
            Console.WriteLine($"Назва музичного інструменту: {Name}");
        }

        public void Desc()
        {
            Console.WriteLine("Опис музичного інструменту: Це духовий інструмент");
        }

        public void History()
        {
            Console.WriteLine("Історія створення музичного інструменту: Епоха Відродження");
        }
    }
}
