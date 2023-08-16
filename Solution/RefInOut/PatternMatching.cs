
// namespace Object
// {
// 	static class Program
// 	{
// 		static void Main()
// 		{
// 			int x = 5;
// 			object obj1 = x; // boxing
// 			int y = (int) obj1; // unboxing
// 			Console.WriteLine(y);

// 			int a = 10;
// 			object obj2 = a;
// 			//string str1 = (string)obj2;
// 			string str = ((int)obj2).ToString(); //unboxing and convert 
// 			Console.WriteLine(str);

// 			int c = 11;
// 			object obj3 = c;
// 			//long d = (long)(int)obj3; 
// 			long d = (int)obj3; //unboxing only cause upcast 
// 			Console.WriteLine(d);

// 			float e = 12.2f;
// 			object obj6 = e;
// 			//int i = (int)obj6; 
// 			int i = (int)(float)obj6; //unboxing 
// 			Console.WriteLine(i);

// 			object obj4 = "Hello, World! 1";
// 			if (obj4 is string)
// 			{
// 				string str4 = (string) obj4;
// 				Console.WriteLine(str4);
// 			}

// 			object obj5 = "Hello, World! 2";
// 			if (obj5 is string str5) //pattern matching
// 			{
// 				Console.WriteLine(str5); //check and convert 
// 			}

// 			object obj7 = "23";
// 			int j = obj7 as int? ?? 0; //explisit casting if true
// 			Console.WriteLine(j); //output 0;
// 			// Console.WriteLine($"tipe data obj7 = {obj7}");
// 			// Console.WriteLine($"tipe data J = {j}");
			
// 			string xy = "34";
// 			int yz = int.Parse(xy);
// 			Console.WriteLine(yz.GetType()); 
// 		}
// 	}
// }



// class Program
// {
// 	static void Main()
// 	{
// 		int umurCristiano = 38;
// 		object objUmur = umurCristiano;
// 		string umurRonaldo = ((int)objUmur).ToString(); //Unboxing and convert
// 		Console.WriteLine(umurRonaldo);		
// 		Console.WriteLine(umurRonaldo.GetType());
		
		
// 		int umurLionel = 36;
// 		object objUmurMessi = umurLionel;
// 		float umurMessi = (int)objUmurMessi; //unboxing and upcast
// 		Console.WriteLine(umurMessi);
// 		Console.WriteLine(umurMessi.GetType());
		
// 		long umurNeymar = 33;
// 		object objUmurNeymar = umurNeymar;
// 		int umurNeymarJr = (int)(long)objUmurNeymar;
// 		Console.WriteLine(umurNeymarJr);
// 		Console.WriteLine(umurNeymarJr.GetType());
		
// 		object pemainTerbaik = "Fahmi Hidayat 22";
// 		if(pemainTerbaik is string)
// 		{
// 			string fahmi = (string)pemainTerbaik;
// 			Console.WriteLine(fahmi);
// 		}
		
// 		object juara = 1;
// 		if(juara is int menang)
// 		{
// 			Console.WriteLine(menang);
// 			Console.WriteLine(menang.GetType());
// 		}
		
// 		object umurFahmi = 20;
// 		int umurHidayat = umurFahmi as int? ?? 0;
// 		Console.WriteLine(umurHidayat); //try parse
		
// 		// object umurFahmi2 = "fahmi";
// 		// string umurHidayat2 = umurFahmi2 as string? ?? 0;
// 		// Console.WriteLine(umurHidayat2);
// 	}
// }