using HRTask.Models;
using HRTaskLibrary;

namespace HRUnitTest;

public class Tests
{
    [Test]
    public void CircleAreaCalculation()
    {
        double radius = 5;
        Circle circle = new Circle(radius);

        double area = circle.GetArea();

        Assert.That(area, Is.EqualTo(Math.PI * radius * radius));
    }

    [Test]
    public void TriangleAreaCalculation()
    {
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        Triangle triangle = new Triangle(sideA, sideB, sideC);

        double area = triangle.GetArea();

        Assert.AreEqual(6, area);
    }

    [Test]
    public void RightAngledTriangleCheck()
    {
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        Triangle triangle = new Triangle(sideA, sideB, sideC);

        bool isRightAngled = triangle.IsRightAngled();

        Assert.IsTrue(isRightAngled);
    }
}