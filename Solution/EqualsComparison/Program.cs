//Equal Comparison
using System;
class Program {
static void Main()
{
	var car1 = new Car(5);
	var car2 = new Car(5);
	//int x = 5;
	
	// (car1 == car2).Dump();
	Console.WriteLine(car1.Equals(car2));
}
}
class Car
{
	private int _id;
	public Car(int x){
		_id = x;
	}
	public int GetID(){
		return _id;
	}
	public override bool Equals(object x) {
		if(x == null) {
			return false;
		}
		if((x.GetType() == this.GetType()) )
		{
			Console.WriteLine("In step");
			return _id == ((Car)x).GetID();
			
		}
		return false;
	}
}



//////////////////////////
//  class BarcelonaPlayer
//  {
//  	private string name;
// 	private string age;
	
	
// 	public string GetName()
// 	{
// 		return name;
// 	}
// 	public void Kick(string footSide)
// 	{
// 		Console.WriteLine("using "+ footSide+" foot");
// 	}
//  }






















