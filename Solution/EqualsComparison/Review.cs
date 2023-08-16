class Barcelona
{
	public int Id;
	
	public Barcelona(int _Id)
	{
		Id = _Id;
	}

	public override bool Equals(object z)
	{
		if(z.GetType() == this.GetType())
		{
			return Id == ((Barcelona)z).Id; 
		}
		return false;
	}
}

class Program
{
	static void Main(String[] args)
	{
		Barcelona palyer1 = new(9);
		Barcelona player2 = new(9);
		
		Console.WriteLine(palyer1.Equals(player2));
	}
}