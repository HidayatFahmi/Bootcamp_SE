// using AbstractLibrary;
// using EngineLIbrary;
// using GetSetLibrary;
// using ConcretClass;
// using AbstractAndInterfaceLibrary;
// class Program
// {
// 	static void Main()
// 	{
// 	///////Abstract
// 	Child child = new Child();
// 	ParentAbstract parent = child;
// 	parent.Add();
// 	parent.GetTotal();
	
// 	//EngineLibrary
// 	CombustionEngine engineComb = new();
// 	DieselEngine engineDiesel = new();
// 	ElectricEngine engineElectric = new();
	
// 	Car car = new Car(engineElectric); //
// 	car.Start();
	
// 	ConcretClass
// 	Parent parent = new Parent();
// 	Child child = new Child();
	
// 	child.ParentMethod();
// 	child.ParentMethod2();
// 	child.ChildMethod();
	
// 	Parent parent2 = child;
// 	parent2.ParentMethod();
// 	parent2.ParentMethod2();
// 	parent2.ChildMethod();
	
// 	GetSet
// 	Car car = new();
// 	string x = car.name; //get
// 	car.name =  "Yusuf"; //set
	
// 	Printer3Juta print3 = new();
// 	var print4 = new Printer3Juta();
// 	Printer700Ribu print2 = new();
// 	Printer300Ribu print1 = new();

// 	IPrint printerMurah = print1;
// 	printerMurah.Print();

// 	IPrint printerMahal = print3;
// 	printerMahal.Print();

// 	IScan printerscan = print3;
// 	printerscan.Scan();
// 	}
// }