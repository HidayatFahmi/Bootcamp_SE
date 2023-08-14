namespace AnimalLibrary;

class Animal
{
	public int age;
	public int species;
	
	public void Sleep(string time)
	{
		Console.WriteLine("Sleep at "+time);
	}
	public void Eat(string kind)
	{
		Console.WriteLine("Just Eat "+kind);
	}
	public void MakeSound(string sound)
	{
		Console.WriteLine(sound);
	}
}


class Goat:Animal
{
	public void Horn()
	{
		Console.WriteLine("Has Horn");
	}
}

class Tiger:Animal
{
	public void Claw()
	
	{
		Console.WriteLine("Has Claw");
	}
}

