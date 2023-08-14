namespace ToyBoxLibrary;

public class ToyBox<T>
{
	private T Toy;
	
	public ToyBox (T nilai)
	{
		Toy = nilai;
	}
	
	public T ToyBoxMethod(T parameter)
	{
		Console.WriteLine($"berikut nilai = {Toy}");
		Console.WriteLine($"Berikut paramter {parameter}");
		
		return parameter;
	}
}