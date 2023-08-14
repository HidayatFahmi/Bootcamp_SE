// using AnimalLibrary;
using PlayerLibrary;

class Program
{
	static void Main()
	{
		Messi messi = new();
		messi.GetName="messi";
		Console.WriteLine(messi.GetName);
		messi.Kick("left");
		
	}
}