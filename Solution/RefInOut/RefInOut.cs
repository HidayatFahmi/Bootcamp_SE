class Program
{
	static void Main()
	{
		string nama = "Fahmi";
		int umur;
		string asal="Bangka Belitung";
		
		Player pemain = new Player();
		pemain.Nama(ref nama);
		pemain.Umur(out umur);
		pemain.Asal(in asal);
		// Umur(out umur);
		
		Console.WriteLine(nama);
		Console.WriteLine(umur);
		Console.WriteLine(asal);
		
	}
}

public class Player
{
	public void Nama(ref string namaBaru)
	{
		namaBaru += "Hidayat";
		// Console.WriteLine(namaBaru);
	}
	
	public void Umur(out int umurBaru)
	{
		umurBaru = 24;
		// Console.WriteLine(umurBaru);
	}
	
	public void Asal(in string asal)
	{
		Console.WriteLine(asal);
		// asal = "Batam"; can not change value cause it is read only value using in
	}
}