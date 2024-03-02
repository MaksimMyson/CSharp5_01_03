using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp5_01_03
{
    public interface IAnimal
    {
        void DisplayInfo();
    }

   
    public class Animal : IAnimal
    {
        
        protected string name;
        protected string species;

        
        public Animal(string name, string species)
        {
            this.name = name;
            this.species = species;
        }

        
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Ім'я: {name}");
            Console.WriteLine($"Вид: {species}");
        }
    }
}    
    
