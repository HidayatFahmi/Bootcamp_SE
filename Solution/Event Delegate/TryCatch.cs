class Program
{

static void Main() 
{
	Console.WriteLine("Hello");
	TryParsing();
	Parsing();
	try
	{

	}
	catch(DivideByZeroException e) 
	{
		Console.WriteLine(e.Message);
	}
	catch(IndexOutOfRangeException e) 
	{
		Console.WriteLine(e.Message);
	}
	catch(Exception e) 
	{
		Console.WriteLine(e.Message);
	}
	Console.WriteLine("Final");
}

void Zero(int x, int y) {
	int z = x / y;
}

void Array() {
	int[] arrayInt = {1,2,3,4};
	int z = arrayInt[4];
}

void Recursive() {
	Recursive();
}

static void Parsing() {
	string input = Console.ReadLine();
	int x = int.Parse(input);
	Console.WriteLine(x);
}

static void TryParsing() {
	string input = Console.ReadLine();
	bool status = int.TryParse(input, out int x);
	Console.WriteLine("status" +status);
}
}