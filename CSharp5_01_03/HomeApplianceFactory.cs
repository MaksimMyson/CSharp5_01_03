using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharp5_01_03
{
    public static class HomeApplianceFactory
    {
        public static IHomeAppliance CreateDevice(string name, string characteristics)
        {
            // В залежності від назви створюємо відповідний об'єкт
            switch (name.ToLower())
            {
                case "чайник":
                    return new Kettle(name, characteristics);
                case "мікрохвильовка":
                    return new Microwave(name, characteristics);
                case "пилосос":
                    return new VacuumCleaner(name, characteristics);
                case "міксер":
                    return new Mixer(name, characteristics);
                default:
                    throw new ArgumentException("Невідомий пристрій");
            }
        }
    }
}