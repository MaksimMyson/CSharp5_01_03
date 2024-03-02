using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp5_01_03
{
    public abstract class Figure
    {
        public abstract double CalculateArea();
        public abstract string GetFigureType();
    }

    public class Rectangle : Figure
    {
        private double length;
        private double width;

        public Rectangle()
        {
            Console.WriteLine("Введіть довжину прямокутника:");
            length = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть ширину прямокутника:");
            width = double.Parse(Console.ReadLine());
        }

        public override double CalculateArea()
        {
            return length * width;
        }

        public override string GetFigureType()
        {
            return "прямокутника";
        }
    }

    public class Circle : Figure
    {
        private double radius;

        public Circle()
        {
            Console.WriteLine("Введіть радіус кола:");
            radius = double.Parse(Console.ReadLine());
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public override string GetFigureType()
        {
            return "кола";
        }
    }

    public class RightTriangle : Figure
    {
        private double baseLength;
        private double height;

        public RightTriangle()
        {
            Console.WriteLine("Введіть довжину основи прямокутного трикутника:");
            baseLength = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть висоту прямокутного трикутника:");
            height = double.Parse(Console.ReadLine());
        }

        public override double CalculateArea()
        {
            return 0.5 * baseLength * height;
        }

        public override string GetFigureType()
        {
            return "прямокутного трикутника";
        }
    }

    public class Trapezoid : Figure
    {
        private double base1;
        private double base2;
        private double height;

        public Trapezoid()
        {
            Console.WriteLine("Введіть довжину першої основи трапеції:");
            base1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть довжину другої основи трапеції:");
            base2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть висоту трапеції:");
            height = double.Parse(Console.ReadLine());
        }

        public override double CalculateArea()
        {
            return 0.5 * (base1 + base2) * height;
        }

        public override string GetFigureType()
        {
            return "трапеції";
        }
    }
}
