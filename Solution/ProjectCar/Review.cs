
using System.ComponentModel.Design;
class Vehicle
{
	public int tahun;
	public int originOf;
	public Car ?car;
	public Motor ?motor;
	public void Run()
	{
		Console.WriteLine("Just Running");
	}
	
}

class Car 
{
	public string ?engineType;
	public void NumOfWheels()
	{
		Console.WriteLine("Car has 4 wheels");
	}
	
	public void CheckTire()
	{
		Console.WriteLine("Diameter of Tire = 50 cm");
	}
}

class Motor
{
	public void NumOfWheels()
	{
		Console.WriteLine("Motorcycle has 2 wheels");
	}
	
	public void CheckLamp()
	{
		Console.WriteLine("Lamp On");
	}
}



class Program
{
	static void Main()
	{
		Vehicle veh = new();
		Car civic = new();
		veh.car = civic;
		veh.car.NumOfWheels();
		
		
		civic.engineType = "combution";
		Console.WriteLine(veh.car.engineType);
	}
}