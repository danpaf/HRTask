using HRTask.Interfaces;

namespace HRTask.Models;

public class Triangle : IShape
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    public double GetArea()
    {
        // По формуле Герона
        double s = (_sideA + _sideB + _sideC) / 2;
        return Math.Sqrt(s * (s - _sideA) * (s - _sideB) * (s - _sideC));
    }

    public bool IsRightAngled()
    {
        double[] sides = {_sideA, _sideB, _sideC};
        Array.Sort(sides);
        return sides[2] * sides[2] == sides[0] * sides[0] + sides[1] * sides[1];
    }
}