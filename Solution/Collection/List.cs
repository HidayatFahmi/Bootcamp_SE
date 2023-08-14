// //List
// //Type safety
// //Dynamic size

// class Program
// {
// 	static void Main()
// {
// 	List<int> intLists = new();
// 	intLists.Add(5);
// 	intLists.Add(10);
// 	intLists.Add(6);
// 	intLists.Add(11);
// 	intLists.Add(53);
// 	intLists.Add(32);
// 	intLists.Add(55);
// 	intLists.Add(123);
	
// 	//intLists.Add("5"); List typesafety
// 	//intLists.Add(true);

// 	Console.WriteLine(intLists.Contains(5)); 
// 	foreach(int i in intLists) {
// 		Console.WriteLine(i);
// 	}
	
// 	Console.WriteLine(intLists.Count); 
	
// 	intLists[1] = 0;
// 	intLists.Remove(10);
// 	intLists.Clear();
// }
// }