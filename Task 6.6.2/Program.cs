class User
{
	private string login;

	public string Login
	{
		get
		{
			return login;
		}

		set
		{
			if (value.Length < 3)
			{
				Console.WriteLine("Логин должен быть длиной от 3 символов");
			}
			else
			{
				login = value;
			}
		}
	}

	private string email;

	public string Email
	{
		get
		{
			return email;
		}

		set
		{
			if (!value.Contains('@'))
			{
				Console.WriteLine("Неверный формат адреса электронной почты");
			}
			else
			{
				email = value;
			}
		}
	}
}
