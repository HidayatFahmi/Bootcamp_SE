public interface ILempar
{
	public void Lempar();
}

public interface ISmash
{
	public void Smash();
}

public interface ITendang
{
	public void Tendang();
}

public interface ILompat
{
	public void Lompat();
}

public class SepakBola:ILempar, ITendang, ILompat
{
	public void Lempar()
	{
		Console.WriteLine("Football Throw-in");
	}
	
	public void Tendang()
	{
		Console.WriteLine("tendang");
	}
	
	public void Lompat()
	{
		Console.WriteLine("Lompat tandukan");
	}
}

public class Volley : ILompat, ISmash
{
	public void Lompat()
	{
		Console.WriteLine("Lompat smash");
	}
	
	public void Smash()
	{
		Console.WriteLine("Volley Smash");
	}
}


class Program
{
	static void Main()
	{
		SepakBola bola =new();
		ILompat lompat = bola;
		lompat.Lompat();
		
		Volley volley = new();
		ISmash smash = volley;
		smash.Smash();
	}
}