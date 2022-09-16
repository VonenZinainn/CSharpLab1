namespace TestPart2MS;

[TestClass]
public class UnitTestRectangle
{
    [TestMethod]
    public void TestArea()
    {
        double side1 = 2;
        double side2 = 3;
        Rectangle rectangle = new Rectangle(side1, side2);

        double area = rectangle.Area;

        Assert.AreEqual(area, 2 * 3);
    }

    [TestMethod]
    public void TestPerimeter()
    {
        double side1 = 2;
        double side2 = 3;
        
        Rectangle rectangle = new Rectangle(side1, side2);

        double perimeter = rectangle.Perimeter;

        Assert.AreEqual(perimeter, (2 + 3) * 2);
    }
}