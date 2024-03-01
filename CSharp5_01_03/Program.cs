using CSharp5_01_03;
using System;

namespace PassportProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Passport passport = new Passport("John Doe", "USA", new DateTime(1990, 5, 15));
            ForeignPassport foreignPassport = new ForeignPassport("Jane Smith", "Canada", new DateTime(1985, 10, 20), "AB123456");

            foreignPassport.AddVisa("Schengen Visa");
            foreignPassport.AddVisa("UK Visa");

            Console.WriteLine("Passport Information:");
            passport.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("Foreign Passport Information:");
            foreignPassport.DisplayInfo();
        }
    }
}