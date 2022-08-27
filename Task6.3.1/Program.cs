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