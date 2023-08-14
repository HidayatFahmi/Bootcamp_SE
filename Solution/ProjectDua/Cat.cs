namespace CatLibrary;

class Cat
{
	public string ?name;
	public int age;
	
	public void MakeSound(string miaw)
	{
		Console.WriteLine("Make Sound " +miaw);
	}
	
	public void Eat(string food)
	{
		Console.WriteLine("Cat Eat "+food);
	}
}
