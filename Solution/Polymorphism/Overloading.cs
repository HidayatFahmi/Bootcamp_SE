namespace OverloadingLibrary;
class Major
{
	public void Sains(string math)
	{
		Console.Write("Subject : "+math);
	}
	
	public void Sains(string physics, string biology, string chemistry)
	{
		Console.WriteLine($"Subject : {physics}, {biology}, {chemistry}");
	}
}


