namespace PrivateLibrary;

class PrivateData
{
	private string _name;
	private int _age;
	private string _address;
	
	public PrivateData(string name, int age, string address)
	{
		_name = name;
		_age = age;
		_address = address;
	}
	
	public string GetName()
	{
		return _name;
	}
	
	public bool SetName(string newName)
	{
		if(newName.Length > 0) 
		{
			_name = newName;
			return true;
		}
		return false;
	}
}

