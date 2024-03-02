namespace CSharp5_01_03
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            
            Tiger tiger = new Tiger("Шерхан", "Тигр");
            Crocodile crocodile = new Crocodile("Алігатор", "Крокодил");
            Kangaroo kangaroo = new Kangaroo("Скіппі", "Кенгуру");

            
            tiger.DisplayInfo();
            Console.WriteLine();
            crocodile.DisplayInfo();
            Console.WriteLine();
            kangaroo.DisplayInfo();
        }
    }

    public class Tiger : Animal
    {
        public Tiger(string name, string species) : base(name, species)
        {
        }
    }

   
    public class Crocodile : Animal
    {
        public Crocodile(string name, string species) : base(name, species)
        {
        }
    }

  
    public class Kangaroo : Animal
    {
        public Kangaroo(string name, string species) : base(name, species)
        {
        }
    }
}