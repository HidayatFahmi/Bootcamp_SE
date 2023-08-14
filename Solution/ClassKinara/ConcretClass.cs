// namespace ConcretClass;
// class Parent {
// 	public void ParentMethod() {
// 		Console.WriteLine("parent");
// 	}
// 	public void ParentMethod2() {
// 		Console.WriteLine("Parent2");
// 	}
// }
// class Child : Parent
// {
// 	public void ChildMethod() {
// 		Console.WriteLine("child method");
// 	}
// }
// void Main() {
// 	Parent parent = new Parent();
// 	Child child = new Child();
	
// 	child.ParentMethod();
// 	child.ParentMethod2();
// 	child.ChildMethod();
	
// 	Parent parent2 = child;
// 	parent2.ParentMethod();
// 	parent2.ParentMethod2();
// 	// parent2.ChildMethod(); 
// 	// Catatan: Perhatikan bahwa Anda tidak dapat memanggil child.ChildMethod() melalui variabel parent2, karena ChildMethod() tidak ada dalam kelas Parent. Metode ini hanya dapat diakses melalui variabel yang dideklarasikan dengan tipe Child.
	
// }