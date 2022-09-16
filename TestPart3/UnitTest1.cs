using Point = Part_3.Point;

namespace TestPart3;

[TestClass]
public class UnitTestFigure
{
    [TestMethod]
    public void TestMethodTriangle()
    {
        Point a = new Point(0, 0);
        Point b = new Point(3, 0);
        Point c = new Point(3, 4);

        Figure triangle = new Figure(a, b, c);

        Assert.AreEqual(triangle.Name, "triangle");
    }

    [TestMethod]
    public void TestMethodQuadrangle()
    {
        Point a = new Point(0, 0);
        Point b = new Point(3, 0);
        Point c = new Point(3, 4);
        Point d = new Point(0, 4);

        Figure quadrangle = new Figure(a, b, c, d);

        Assert.AreEqual(quadrangle.Name, "quadrangle");
    }

    [TestMethod]
    public void TestMethodPentagon()
    {
        Point a = new Point(0, 0);
        Point b = new Point(3, 0);
        Point c = new Point(3, 4);
        Point d = new Point(0, 8);
        Point e = new Point(-3, 4);

        Figure pentagon = new Figure(a, b, c, d, e);

        Assert.AreEqual(pentagon.Name, "pentagon");
    }

    [TestMethod]
    public void TestMethodLengthSide()
    {
        Point a = new Point(0, 0);
        Point b = new Point(3, 0);
        Point c = new Point(3, 4);
        Figure triangle = new Figure(a, b, c);

        double side1 = triangle.LengthSide(a, b);
        double side2 = triangle.LengthSide(b, c);
        double side3 = triangle.LengthSide(a, c);
        double side3Inverted = triangle.LengthSide(c, a);

        Assert.AreEqual(side1, 3);
        Assert.AreEqual(side2, 4);
        Assert.AreEqual(side3, 5);
        Assert.AreEqual(side3, side3Inverted);
    }

    [TestMethod]
    public void TestMethodPerimeter()
    {
        Point a = new Point(0, 0);
        Point b = new Point(3, 0);
        Point c = new Point(3, 4);

        Figure triangle = new Figure(a, b, c);

        triangle.PerimeterCalculator();

        Assert.AreEqual(triangle.Perimeter, 3 + 4 + 5);
    }
}