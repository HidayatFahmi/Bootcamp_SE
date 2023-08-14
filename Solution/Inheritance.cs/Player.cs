namespace PlayerLibrary;

public class Barcelona
{
	protected string name;
	protected int umur;

	public string GetName
	{
		get{return name;}
		set{name = value;}
	}
	public void Kick(string leftRight)
	{
		Console.WriteLine($"{name} using {leftRight} foot");
	}
	
	public void Run()
	{
		Console.WriteLine("Just Run");
	}
	
	public void Heading()
	{
		Console.WriteLine("Just Heading");
	}
}

public class Messi:Barcelona
{
	public void Dribbling()
	{
		Console.WriteLine("messi dribble king");
	}
}

public class Iniesta:Barcelona
{
	public void playmaker()
	{
		Console.WriteLine("Playmaking king");
	}
}

public class Neymar
{
	public void Skill(){
		Console.WriteLine("King of skill");
	}
	
	public void Speed()
	{
		Console.WriteLine("Speed of neymar");
	}
}