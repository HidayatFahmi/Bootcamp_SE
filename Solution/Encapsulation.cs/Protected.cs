// namespace ProtectedLibrary;

// class BarcelonaPlayers
// {
// 	private int _sallary;
// 	protected int _age;
// 	protected int _yearsContract;
	
// 	public BarcelonaPlayers(int sallary, int age, int yearsContract)
// 	{
// 		_sallary = sallary;
// 		_age = age;
// 		_yearsContract = yearsContract;
// 	}
	
// 	public void Kick(string foot)
// 	{
// 		Console.WriteLine(foot);
// 	}
	
// 	private int GetSallary()
// 	{
// 		return _sallary;
// 	}
	
// 	protected int GetAge()
// 	{
// 		return _age;
// 	}
	
// 	public int GetYearsContract()
// 	{
// 		return _yearsContract;
// 	}
	
// }

// class Messi:BarcelonaPlayers
// {
// 	public Messi(int sallary, int age, int yearsContract) : base (sallary, age, yearsContract)
// 	{
// 	}
	
// 	public void Dribbling()
// 	{
// 		Console.WriteLine("Dribble King");
// 	}
// }

// class Iniesta:BarcelonaPlayers
// {
// 	public Iniesta(int sallary, int age, int yearsContract) : base(sallary, age, yearsContract)
// 	{
// 	}
	
// 	public void PlayMaker()
// 	{
// 		Console.WriteLine("Playmaker King");
// 	}
	
// 	public int GetAgeMore()
// 	{
// 		return GetAge();
// 	}
// }

// //Proteced hanya child yang bisa akses, 
// //private tidak bisa diakses termasuk child