class Bus
{
    public int? Load;
    public void PrintStatus()
    {
        if(Load.HasValue)
        {
            Console.WriteLine("It is {0} passangers in the bus", Load.Value);
        }
        else
        {
            Console.WriteLine("Bus empty");
        }
    }
}