using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp5_01_03
{
    public interface IMoney
    {
        int GetDollars();
        int GetCents();
        void DisplayAmount();
        void SetAmount(int dollars, int cents);
    }

    public class Money : IMoney
    {
        private int dollars;
        private int cents;

        public Money(int dollars = 0, int cents = 0)
        {
            this.dollars = dollars;
            this.cents = cents;
        }

        public int GetDollars()
        {
            return dollars;
        }

        public int GetCents()
        {
            return cents;
        }

        public void DisplayAmount()
        {
            Console.WriteLine($"Сума: {dollars} доларів {cents} центів");
        }

        public void SetAmount(int dollars, int cents)
        {
            this.dollars = dollars;
            this.cents = cents;
        }
    }
}