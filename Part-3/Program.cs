namespace Part_3
{
    class Program
    {
        static void Main()
        {
            Point a = new(0, 0);
            Point b = new(4, 0);
            Point c = new(4, 4);
            Point d = new(0, 4);
            Figure polygon = new(a, b, c, d);
            polygon.PerimeterCalculator();
            Console.WriteLine($"Figure {polygon.Name}; Perimeter = {polygon.Perimeter}");
        }
    }

    public class Point
    {
        private int _x;
        private int _y;

        public Point(int x, int y) => (_x, _y) = (x, y);

        public int X => _x;

        public int Y => _y;
    }

    public class Figure
    {
        public string Name { get; set; }
        private Point _p1;
        private Point _p2;
        private Point _p3;
        private Point? _p4;
        private Point? _p5;

        public double Perimeter { get; set; }


        public Figure(Point p1, Point p2, Point p3)
            => (_p1, _p2, _p3, _p4, _p5, Name) = (p1, p2, p3, null, null, "triangle");

        public Figure(Point p1, Point p2, Point p3, Point p4)
            => (_p1, _p2, _p3, _p4, _p5, Name) = (p1, p2, p3, p4, null, "quadrangle");

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
            => (_p1, _p2, _p3, _p4, _p5, Name) = (p1, p2, p3, p4, p5, "pentagon");

        public double LengthSide(Point a, Point b)
            => Math.Sqrt(Math.Pow(Math.Abs(b.X - a.X), 2) + Math.Pow(Math.Abs(b.Y - a.Y), 2));

        public void PerimeterCalculator()
        {
            if (Name == "triangle")
            {
                Perimeter = LengthSide(_p1, _p2) + LengthSide(_p2, _p3) + LengthSide(_p3, _p1);
            }
            else if (_p4 != null)
            {
                Perimeter = LengthSide(_p1, _p2) + LengthSide(_p2, _p3) + LengthSide(_p3, _p4)
                            + LengthSide(_p4, _p1);
            }
            else if (_p4 != null && _p5 != null)
            {
                Perimeter = LengthSide(_p1, _p2) + LengthSide(_p2, _p3) + LengthSide(_p3, _p4)
                            + LengthSide(_p4, _p5) + LengthSide(_p5, _p1);
            }
        }
    }
}