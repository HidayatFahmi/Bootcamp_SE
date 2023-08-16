class Program
{
	static void Main()
	{
		List<int> list = new List<int>() {5,6,3,4,2,1,7};
		list.Add(8);
		Console.WriteLine(list[6]);
		Console.WriteLine(list.Count());
		list.Sort((a,b)=>b.CompareTo(a));
		
		foreach(int x in list)
		{
			Console.WriteLine(x);
		}
	}
}