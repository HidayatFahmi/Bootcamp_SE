// class Program
// {
// 	static void Main()
// 	{
		
// 		//Explisit Casting 
// 		// int a = 14;
// 		// double b = Convert.ToDouble(a) ;
// 		// double c = (double)a; //explisit casting
		
// 		// Console.WriteLine(a);
// 		// Console.WriteLine(b);
// 		// Console.WriteLine(c);	
		
// 		// Console.WriteLine(a.GetType());
// 		// Console.WriteLine(b.GetType());
// 		// Console.WriteLine(c.GetType());
		
// 		//Static
// 		// Calculator calculator = new();
// 		// calculator.Multiply(3,4);
// 		// Console.WriteLine(calculator.Multiply(4,5));
// 		// Console.WriteLine(calculator.Divider(20,2));
		
// 		// Console.WriteLine(calculator.Add(10,5)); //tidak bisa dipanggil karena methood add static sedangkan class non-static
		
		
// 		//// class BoxUnbox
// 		BoxUnbox kotak = new();
// 		kotak.Box();
		
		
// 	}
// }

// public class Calculator
// {
// 	public static int Add(int x, int y)
// 	{
// 		return x+y;
// 	}
	
// 	public int Multiply(int a, int b)
// 	{
// 		return a*b;
// 	}
	
// 	public double Divider(int x, int y)
// 	{
// 		return x/y;
// 	}
// }

// public class BoxUnbox
// {
// 	public int aa = 100;
// 	public object bb ;
// 	public int cc;
	
// 	public void Box()
// 	{
// 		bb = aa;
// 		cc = (int)bb;
		
// 		Console.WriteLine(aa);
// 		Console.WriteLine(aa.GetType());
// 		Console.WriteLine(bb);
// 		Console.WriteLine(bb.GetType());
// 		Console.WriteLine(cc);
// 		Console.WriteLine(cc.GetType());
		
// 	}
// }
