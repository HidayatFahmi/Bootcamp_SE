class Email
{
	private string userName;
	private string password;
	protected string name;
	protected int umur;
	protected string asal;
	
	public Email(string name, int umur, string asal)
	{
		this.name = name;
		this.umur = umur;
		this.asal = asal;
	}
	
	public string UserName
	{
		get{return userName;}
		set{userName = value;}
	}
	
	public string SetPassword(string pass)
	{
		this.password = pass;
		return pass;
	}
	
	public bool GetPassword(string login)
	{
		if(this.password == login)
		{
			return true;
		}
		return false;
	}
}

class Program
{
	static void Main()
	{
		Email email =  new Email("fahmi", 24, "bangka Belitung");
		email.UserName = "hidayat";
		email.SetPassword("pass123");
		bool tesPass = email.GetPassword("pass123");
		Console.WriteLine(tesPass);
		
	}
}