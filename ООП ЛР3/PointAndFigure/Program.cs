namespace PointAndFigure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(new Point(1, 1, "A"), new Point(4, 1, "B"), new Point(4, 5, "C"));
            Console.WriteLine(figure.PerimeterCalculator());
        }
    }
}