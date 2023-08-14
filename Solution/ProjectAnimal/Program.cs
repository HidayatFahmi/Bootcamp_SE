using System.Threading.Tasks.Sources;
using AnimalLibrary;

// class Program
// {
// static void Main()
// 	{	
// 	Animal hewan =  new Animal();
// 	Cat kucing =  new Cat();
// 	Bird burung =  new Bird();
// 	Turtle kura =  new Turtle();
	
// 	kucing.name = "Angora";
// 	Console.WriteLine(kucing.name);
	
// 	kucing.MakeSound();
// 	kura.age = 5;
// 	Console.WriteLine(kura.age);
// 	}
// }	


class Program
{
	public static void Main()
	{
		Bird burung = new Bird();
		Cat kucing = new Cat();
		Turtle kura = new();
		
		burung.age = 6;
		kucing.age = 3;
		
		burung.MakeSound();
		burung.Sleep();
		burung.Eat();
		
		Console.WriteLine(burung.age);
		Console.WriteLine(kucing.age);
		kura.MakeSound();

	}
}