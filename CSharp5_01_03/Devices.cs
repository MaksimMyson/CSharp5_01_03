using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharp5_01_03
{
    public class Kettle : Device
    {
        public Kettle(string name, string characteristics) : base(name, characteristics)
        {
        }

        public override void Sound()
        {
            Console.WriteLine($"{Name}: Шипіння кип'ятка");
        }
    }

    public class Microwave : Device
    {
        public Microwave(string name, string characteristics) : base(name, characteristics)
        {
        }

        public override void Sound()
        {
            Console.WriteLine($"{Name}: Гудіння мікрохвильовки");
        }
    }

    public class Car : Device
    {
        public Car(string name, string characteristics) : base(name, characteristics)
        {
        }

        public override void Sound()
        {
            Console.WriteLine($"{Name}: Рев автомобіля");
        }
    }

    public class Steamboat : Device
    {
        public Steamboat(string name, string characteristics) : base(name, characteristics)
        {
        }

        public override void Sound()
        {
            Console.WriteLine($"{Name}: Гудіння пароплава");
        }
    }
}
