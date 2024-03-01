using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp5_01_03
{
    public interface IDisplayable
    {
        void DisplayInfo();
    }

    
    public class Passport : IDisplayable
    {
        public string FullName { get; set; }
        public string Nationality { get; set; }
        public DateTime DateOfBirth { get; set; }

        
        public Passport(string fullName, string nationality, DateTime dateOfBirth)
        {
            FullName = fullName;
            Nationality = nationality;
            DateOfBirth = dateOfBirth;
        }

        
        public void DisplayInfo()
        {
            Console.WriteLine($"Full Name: {FullName}");
            Console.WriteLine($"Nationality: {Nationality}");
            Console.WriteLine($"Date of Birth: {DateOfBirth.ToShortDateString()}");
        }
    }

    
    public class ForeignPassport : Passport, IDisplayable
    {
        public string PassportNumber { get; set; }
        public List<string> Visas { get; set; }

       
        public ForeignPassport(string fullName, string nationality, DateTime dateOfBirth, string passportNumber)
            : base(fullName, nationality, dateOfBirth)
        {
            PassportNumber = passportNumber;
            Visas = new List<string>();
        }

        
        public void AddVisa(string visa)
        {
            Visas.Add(visa);
        }

        
        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Passport Number: {PassportNumber}");
            Console.WriteLine("Visas:");
            foreach (var visa in Visas)
            {
                Console.WriteLine(visa);
            }
        }
    }
}
