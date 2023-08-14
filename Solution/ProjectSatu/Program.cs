using CatLibrary; // Missing using statement for the Cat namespace
class Program
{
	static void Main()
	{
		Console.WriteLine("Hello World");
		Console.WriteLine("Hello World2");

		Cat alex = new Cat();
		alex.Eat();
		alex.name = "alex";
		alex.age = 2;
		string newName1 = alex.name;
		Console.WriteLine(newName1);

		Cat pedro = new Cat();
		pedro.MakeSound();
		pedro.isSmoothFur=true;
		bool pedroFur = pedro.isSmoothFur;
		pedro.name = "pedro";
		pedro.age = 5;
		Console.WriteLine(pedroFur);
		Console.WriteLine(pedro.age);
	}
}
