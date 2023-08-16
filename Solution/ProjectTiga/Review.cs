using System.ComponentModel;

class BarcelonaPlayers
{
	public string ?name;
	public string ?age;
	public Messi ?messi;
	public Iniesta ?iniesta;
	public Neymar ?neymar;
	
	public void Run(string _name)
	{
		name = _name;
		Console.WriteLine($"{name} Just Running");
	}
	
	public void Jump()
	{
		messi?.Heading();
	}
}

class Messi
{
	public void Dribble()
	{
		Console.WriteLine("Messi king of dribbling");
	}
	
	public void Acceleration()
	{
		Console.WriteLine("Messi on TOP with acceleration");
	}
	
	public void Heading()
	{
		Console.WriteLine("Messi just heading");
	}
}


class Iniesta
{
	public void Playmaking()
	{
		Console.WriteLine("Iniesta king of play making");
	}
}

class Neymar
{
	public void Skill()
	{
		Console.WriteLine("Neymar king of skill");
	}
}


class Program
{
	static void Main()
	{
		BarcelonaPlayers barca = new();
		Messi messi = new();
		barca.messi = messi;
		barca.messi.Acceleration();
		barca.Jump();
	}
}