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
        Department department = new Department();
        department = GetCurrentDepartment();
        if (department.Company.Type == "Банк" && department.City.Name == "Санкт-Петербург")
        {
            Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.Company?.Name ?? "Неизвестная компания");
        }
        else
        {
            Console.WriteLine(department.City.Name);
        }
    }

    static Department GetCurrentDepartment()
    {
        Department department = new Department();
        department.City.Name = "Санкт-Петербург";
        department.Company.Name = "ВТБ";
        department.Company.Type = "Банк";

        return department;
    }
}