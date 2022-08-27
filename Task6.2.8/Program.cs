class Rectangle
{
    public int a, b;
    public int Square()
    {
        return a * b;
    }

    public Rectangle()
    {
        a = 10;
        b = 5;
    }

    public Rectangle(int side)
    {
        a = side;
        b = side;
    }

    public Rectangle(int first, int second)
    {
        a = first;
        b = second;
    }
}
