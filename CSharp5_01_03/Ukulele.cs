using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicInstruments
{
    public class Ukulele : IMusicalInstrument
    {
        public string Name { get; }
        public string Characteristics { get; }

        public Ukulele(string name, string characteristics)
        {
            Name = name;
            Characteristics = characteristics;
        }

        public void Sound()
        {
            Console.WriteLine("Укулеле: Звук укулеле");
        }

        public void Show()
        {
            Console.WriteLine($"Назва музичного інструменту: {Name}");
        }

        public void Desc()
        {
            Console.WriteLine("Опис музичного інструменту: Це струнний інструмент");
        }

        public void History()
        {
            Console.WriteLine("Історія створення музичного інструменту: Гавайські острови");
        }
    }
}