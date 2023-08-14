class Program
{
	static void Main()
	{
		Input input = new();
		input.inputAngka(15);	
	}
}


public class Input
{
	public string printKata;
	public string inputAngka(int angka)
	{
			
		for(int a=1;a<=angka;a++)
		{
			if(a%3==0 && a%5==0)
			{
				printKata="FooBar";
				Console.WriteLine(printKata);
			}
			else if (a%3 == 0)
			{
				printKata="Foo";
				Console.WriteLine(printKata);
				
				
			}
			else if(a%5==0)
			{
				printKata="Bar";
				Console.WriteLine(printKata);
			}
			else
			{
				printKata = a.ToString();
				Console.WriteLine(printKata);		
			}
		}
		return printKata;
	}
}


