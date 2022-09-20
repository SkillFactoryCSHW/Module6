class Triangle
{
    public double sideA;
    public double sideB;
    public double sideC;

    public double AreaCalculate()
    {
        return sideA * sideB * sideC;
    }

    public double LengthCalculate()
    {
        return sideA + sideB + sideC;
    }
}

class Circle
{
    public double radius;
    public const double pi = 3.14;

    public double AreaCalculate()
    {
        return radius * Math.Pow(pi, 2);
    }

    public double LengthCalculate()
    {
        return 2 * pi * radius;
    }
}

class Square
{
    public double side;

    public double AreaCalculate()
    {
        return Math.Pow(side, 2);
    }

    public double LengthCalculate()
    {
        return 4 * side;
    }
}