//Operator Overloading
class Car {
	public string carBrand;
	public Car(string carBrand) {
		this.carBrand = carBrand;
	}
	public static Car operator +(Car carSatu, Car carDua) {
		string result = carSatu.carBrand + carDua.carBrand;
		return new Car(result);
	}
}

class Add
{
	public int _angka;
	public Add(int angka)
	{
		_angka = angka;
	}
	
	public static Add operator+(Add angka1, Add angka2)
	{
		int hasil = angka1._angka+angka2._angka;
		return new Add(hasil);
	}
	

}

class Program
{
	static void Main(){
	Car car1 = new Car("Budi");
	Car car2 = new Car("SMK");
	Car car3 = new Car("Ucok");
	Car car4 = new Car("Baba");
	
	Add angka1 = new Add(100);
	Add angka2 = new Add(20);
	
	Add hasilTambah= angka1 + angka2; 
	Console.WriteLine(hasilTambah._angka);
	
	
	Car resultCar = car1 + car2 + car3 + car4;
	Console.WriteLine(resultCar.carBrand);
} 
}
