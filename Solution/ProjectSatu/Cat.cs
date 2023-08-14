//Method/Function/Behavior

namespace CatLibrary
{
public class Cat //Blueprint
{
	public bool isSmoothFur; 
	public string ?name;
	bool isMale;
	public int age;
	string ?color;
	
	public void MakeSound()
	{
		Console.WriteLine("Make Sound");
	}
	
	public void Scratch()
	{
		Console.WriteLine("Scratch");
	}
	
	public void sleep() // "sleep" should be capitalized to follow convention (Sleep)
	{
		Console.WriteLine("Sleep");
	}
	
	public void Eat()
	{
		Console.WriteLine("Eat");
	}
}
}