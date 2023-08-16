public interface ISms
{
	public void Sms();
}

public interface ICall
{
	public void Call();
}

public interface ICamera
{
	public void Camera();
}

public interface IInstagram
{
	public void Instagram();
}

public class HandPhone300 : ISms, ICall
{
	public void Sms()
	{
		Console.WriteLine("Sms mertua");
	}
	
	public void Call()
	{
		Console.WriteLine("Call Istri");
	}
}

public class HandPhone700:ISms, ICall, ICamera
{
	public void Sms()
	{
		Console.WriteLine("Sms mama");
	}
	public void Call()
	{
		Console.WriteLine("Call Bussiness collegue");
	}
	public void Camera()
	{
		Console.WriteLine("Selfie");
	}
}


public class HandPhone1000:ISms, ICall, ICamera, IInstagram
{
	public void Sms()
	{
		Console.WriteLine("Sms ayank");
	}
	public void Call()
	{
		Console.WriteLine("Call Lecture");
	}
	public void Camera()
	{
		Console.WriteLine("Content");
	}
	
	public void Instagram()
	{
		Console.WriteLine("Social Media");
	}
}

class Program
{
	static void Main()
	{
		HandPhone300 HpMurah = new();
		HandPhone700 HpSedang = new();
		HandPhone1000 HpMahal = new();
		
		ICamera camera1 = HpSedang;
		camera1.Camera();
	}
}