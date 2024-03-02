using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp5_01_03
{
    public class Product : IMoney
    {
        private Money price;

        public Product()
        {
            Console.WriteLine("Введіть кількість доларів:");
            int dollars;
            if (!int.TryParse(Console.ReadLine(), out dollars))
            {
                Console.WriteLine("Некоректне значення. Введіть ціле число для кількості доларів.");
                return;
            }

            Console.WriteLine("Введіть кількість центів:");
            int cents;
            if (!int.TryParse(Console.ReadLine(), out cents))
            {
                Console.WriteLine("Некоректне значення. Введіть ціле число для кількості центів.");
                return;
            }

            price = new Money(dollars, cents);
        }

        public int GetDollars()
        {
            return price.GetDollars();
        }

        public int GetCents()
        {
            return price.GetCents();
        }

        public void DisplayAmount()
        {
            price.DisplayAmount();
        }

        public void DecreasePrice(int decreaseAmount)
        {
            int totalCents = price.GetCents() + price.GetDollars() * 100;
            totalCents -= decreaseAmount;

            if (totalCents < 0)
            {
                Console.WriteLine("Помилка: неможливо зменшити ціну на дану суму.");
                return;
            }

            price.SetAmount(totalCents / 100, totalCents % 100);
        }

        public void SetAmount(int dollars, int cents)
        {
            throw new NotImplementedException();
        }
    }

}
