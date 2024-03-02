using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp5_01_03
{
    public abstract class Device
    {
        protected string Name { get; set; }
        protected string Characteristics { get; set; }

        public Device(string name, string characteristics)
        {
            Name = name;
            Characteristics = characteristics;
        }

        public abstract void Sound();
    }
}
