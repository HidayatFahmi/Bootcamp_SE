using System.Collections;

class Program 
{
	static void Main()
	{
		// int[] arrayAngka = {1,2,3,4,5,6,7};
		
		ArrayList arrayAngka = new();
		
		arrayAngka.Add(9);
		arrayAngka.Add(99);
		arrayAngka.Add(78);
		
		Console.WriteLine(arrayAngka.Contains(8));
		foreach(int angka in arrayAngka)
		{
			Console.WriteLine(angka);
		}
	}
}