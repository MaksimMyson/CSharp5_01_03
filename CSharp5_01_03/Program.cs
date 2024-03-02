namespace CSharp5_01_03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Product product = new Product();

            Console.WriteLine("Ціна товару:");
            product.DisplayAmount();

            Console.WriteLine("Введіть суму на яку потрібно зменшити ціну товару:");
            int decreaseAmount = int.Parse(Console.ReadLine());
            product.DecreasePrice(decreaseAmount);

            Console.WriteLine("Нова ціна товару:");
            product.DisplayAmount();
        }
    }
}
