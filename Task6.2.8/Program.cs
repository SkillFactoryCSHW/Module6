class Rectangle
{
    public int a;
    public int b;

    public int Square()
    {
        return a * b;
    }

    public Rectangle(int firstSide, int secondSide)
    { 

    }

    public Rectangle(int c)
    {
        c = 5;
        a = c;
        b = c;
    }

    public Rectangle()
    {
        a = 6;
        b = 4;
    }
}