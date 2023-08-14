class Program
{
	//String
void Main()
{
	int a = 2;
	int b = 3;
	int c = 4;
	
	Console.WriteLine("\nVariable 1 = {0}, variable 2 = {1}, variable 3 = {2}");
	Console.WriteLine("\nVariable 1 = {0}, variable 2 = {1}, variable 3 = {2}",a,b,c);
	Console.WriteLine(@"\nVariable 1 = {0}, variable 2 = {1}, variable 3 = {2}",a,b,c);
	Console.WriteLine("\\nVariable 1 = {0}, variable 2 = {1}, variable 3 = {2}");
	Console.WriteLine($"\nVariable 1 = {a}, variable 2 = {b}, variable 3 = {c}");
}

// You can define other methods, fields, classes and namespaces here 
}