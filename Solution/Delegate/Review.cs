// using System.Security.Cryptography.X509Certificates;

// public delegate void SimpleDelagate(string call);

// public class SayIt
// {
// 	public void SayHi(string Hi)
// 	{
// 		Console.WriteLine("Hiiiiii "+Hi);
// 	}
	
// 	public void SayHello(string Hello)
// 	{
// 		Console.WriteLine("Helloooo "+Hello);
// 	}
// }

// class Program
// {
// 	static void Main()
// 	{
// 		SayIt say = new();
// 		SimpleDelagate simple = say.SayHi;
// 		simple("fahmi");
// 		simple += say.SayHello;
// 		simple("hidayat");
// 	}
// }

///////////////////////////////////////////////////////////////////////////

// public delegate int MyCalculator (int a, int b);

// class Calculator
// {
// 	public int Add(int a, int b)
// 	{
// 		int hasil = a+b;
// 		return hasil;
// 	}
	
// 	public int Multiply(int x, int y)
// 	{
// 		return x*y;
// 	}
// }

// class Program
// {
// 	static void Main()
// 	{
// 		Calculator calc = new();
// 		MyCalculator calculator = calc.Add;
// 		int pertambahan = calculator(9,10);
// 		calculator = calc.Multiply;
// 		int perkalian = calculator(9,9);
		
// 		Console.WriteLine(pertambahan);
// 		Console.WriteLine(perkalian);
// 	}
// }

///////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////

public delegate void Notification(string notif);

class Publisher
{
	public Notification myEvent;
	
	public void NotificationPublisher(string notif)
	{
		myEvent.Invoke(notif);
	}
}

class Subscribber
{
	public void Notification1(string notif)
	{
		Console.WriteLine("Done subscribe by user 1 "+notif);
	}
	
	public void Notification2(string notif)
	{
		Console.WriteLine("Done subscribe by user 2 "+notif);
	}
}

class Program
{
	static void Main()
	{
		Publisher publisher = new();
		Subscribber sub = new();
		publisher.myEvent += sub.Notification1;
		publisher.myEvent += sub.Notification2;
		
		publisher.NotificationPublisher("Hiii");
	}
}