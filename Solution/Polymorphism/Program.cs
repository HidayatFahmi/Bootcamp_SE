//menmabahkan virtual pada parent dan override pada child
using OverloadingLibrary;

class Program
{
	static void Main()
	{
		Animal hewan = new Animal();
		Cat kucing = new Cat();
		Ant semut = new Ant();
		
		//Implementasi overriding
		hewan.MakeSound();
		kucing.MakeSound();
		semut.MakeSound();
		
		//Implementasi Overloading
		Major jurusan = new Major();
		jurusan.Sains("matematika");
		jurusan.Sains("fisika", "biologi", "kimia");
	}
}


//Implementasi overriding
class Animal
{
	public virtual void MakeSound()
	{
		Console.WriteLine("Sounding Animal");
	}
}

class Cat:Animal
{
	public override void MakeSound()
	{
		Console.WriteLine("Meow");
	}
}

class Dog:Animal
{
	public override void MakeSound()
	{
		Console.WriteLine("Barking");
	}
}

class Bird:Animal
{
	public override void MakeSound()
	{
		Console.WriteLine("....");
	}
}

class Ant:Animal
{
}