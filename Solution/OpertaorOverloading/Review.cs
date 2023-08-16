
class Calculator
{
	public int hasil;
	
	public Calculator(int angka)
	{
		this.hasil= angka;
	}
	
	public static Calculator operator+(Calculator angka1, Calculator angka2)
	{
		int result = angka1.hasil+angka2.hasil;
		return new Calculator(result);
	}
}

class Program
{
	static void Main()
	{
		Calculator calc1 = new(90);
		Calculator calc2 = new(98);
		
		Calculator hasil = calc1 + calc2;
		Console.WriteLine(hasil.hasil);
		
	}
}