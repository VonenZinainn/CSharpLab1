namespace Part_2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter 1st rectangle side: ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter 2nd rectangle side: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new(side1, side2);

            Console.WriteLine($"The area of the rectangle w/ this sides: {rectangle.Area}");
            Console.WriteLine($"The perimeter of the rectangle w/ this sides: {rectangle.Perimeter}");
        }
    }

    public class Rectangle
    {
        private double _side1;
        private double _side2;

        public Rectangle(double side1 = 0, double side2 = 0) => (_side1, _side2) = (side1, side2);

        private double AreaCalculator() => _side1 * _side2;
        private double PerimeterCalculator() => 2 * (_side1 + _side2);


        public double Area => AreaCalculator();

        public double Perimeter => PerimeterCalculator();
    }
}