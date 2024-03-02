using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp5_01_03
{
    public class Microwave : IHomeAppliance
    {
        public string Name { get; }

        public Microwave(string name, string characteristics)
        {
            Name = name;
        }

        public void Sound()
        {
            Console.WriteLine("Мікрохвильовка: Гудіння");
        }
    }
}
