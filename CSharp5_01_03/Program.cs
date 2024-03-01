using System;

namespace CSharp5_01_03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Builder bob = new Builder("Bob", 35, "Male", "Carpenter");
            Sailor alice = new Sailor("Alice", 28, "Female", "Sailboat");
            Pilot charlie = new Pilot("Charlie", 40, "Male", "Airbus A320");

            bob.DisplayInfo();
            bob.Build();

            alice.DisplayInfo();
            alice.Sail();

            charlie.DisplayInfo();
            charlie.Fly();
        }
    }

    
    public class Builder : Human
    {
        public string Specialization { get; set; }

        
        public Builder(string name, int age, string gender, string specialization)
            : base(name, age, gender)
        {
            Specialization = specialization;
        }

        
        public void Build()
        {
            Console.WriteLine($"{Name} is building with specialization {Specialization}");
        }
    }

    
    public class Sailor : Human
    {
        public string VesselType { get; set; }

        
        public Sailor(string name, int age, string gender, string vesselType)
            : base(name, age, gender)
        {
            VesselType = vesselType;
        }

        
        public void Sail()
        {
            Console.WriteLine($"{Name} is sailing on a {VesselType}");
        }
    }

    
    public class Pilot : Human
    {
        public string AircraftType { get; set; }

        
        public Pilot(string name, int age, string gender, string aircraftType)
            : base(name, age, gender)
        {
            AircraftType = aircraftType;
        }

        
        public void Fly()
        {
            Console.WriteLine($"{Name} is flying an {AircraftType}");
        }
    }
}
