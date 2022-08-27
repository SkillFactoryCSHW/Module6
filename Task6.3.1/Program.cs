class Company
{
    public string Type = "Банк";
    public string Name = "sdf";
}

class Department
{
    public Company Company;
    public City City;
}

class City
{
    public string Name = "Санкт-Петербург";
}

class Program
{
    static void Main(string[] args)
    {
        var department = GetCurrentDepartment();
        if (department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург")
        {
            Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге",
                department?.Company?.Name ?? "Неизвестная компания");
        }
    }

    static Department GetCurrentDepartment()
    {
        Department department = new Department();
        department.Company.Type = "Банк";
        department.Company.Name = "123";
        department.City.Name = "Санкт-Петербург";
        return department;
    }
}