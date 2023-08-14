class Parent {
	public void ParentMethod () {
		Console.WriteLine("Parent");
	}
}

class Child : Parent {
	public void ChildMethod() {
		Console.WriteLine("Child");
	}
}


class Program
{
	static void Main() {
	Parent parent = new Parent(); //AB
	
	Child child = new();
	Parent parent2 = child;
	
	// Child child = (Child)parent; //ABCD <- AB
	// child.ParentMethod(); // child.A
	// child.ChildMethod(); //child.C
	
}
}

