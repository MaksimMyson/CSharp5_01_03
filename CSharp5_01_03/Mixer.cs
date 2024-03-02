using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp5_01_03
{
    public class Mixer : IHomeAppliance
    {
        public string Name { get; }

        public Mixer(string name, string characteristics)
        {
            Name = name;
        }

        public void Sound()
        {
            Console.WriteLine("Міксер: Шум від змішування продуктів");
        }
    }
}
