class User
{
    private int age;
    private string login;
    private string email;

    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value < 18)
            {
                Console.WriteLine("Age > 18");
            }
            else
            {
                age = value;
            }
        }

    }

    public string Login 
    {
        get
        {
            return login;
        }
        set
        {
            if(value.Length < 3)
            {
                Console.WriteLine("Login > 3");
            }
            else
            {
                login = value;
            }
        }
    }

    public string MyProperty
    {
        get
        {
            return email;
        }
        set
        {
            if (value.Contains('@'))
            {
                value = email;
            }
            else
            {
                Console.WriteLine("Need @");
            }
        }
    }
}