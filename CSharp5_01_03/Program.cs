namespace CSharp5_01_03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Figure[] figures = new Figure[4];
            figures[0] = new Rectangle();
            figures[1] = new Circle();
            figures[2] = new RightTriangle();
            figures[3] = new Trapezoid();

            foreach (var figure in figures)
            {
                string figureType = figure.GetFigureType();
                double area = figure.CalculateArea();
                Console.WriteLine($"Площа {figureType}: {area}");
            }
        }

    }

}