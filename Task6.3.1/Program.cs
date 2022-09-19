class Company
{
    public string Type;
    public string Name;
}

class Department
{
    public Company Company;
    public City City;
}

class City
{
    public string Name;
}

class Program
{
    static void Main(string[] args)
    {
        var department = GetCurrentDeprtment();
        if (department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург")
        {
            Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.Company?.Name ?? "Неизвестная компания");
        }
    }

    static Department GetCurrentDeprtment()
    {
        Department department = new Department();
        department.City.Name = "Санкт-Петербург";
        department.Company.Type = "Банк";
        department.Company.Name = "ВТБ";
        
        
        return department;
    }
}