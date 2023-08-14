namespace ProjectTiga;

public class Car
{
	public Engine ?engine;
	public Lamp ?lamp;
	public Tire ?tire;
	
	public void EngineStart() 
	{
		engine?.EngineRun();
	}
	public void LampCheck() 
	{
		lamp?.TurnOn();
	}
	
	public void CheckTire()
	{
		tire?.tireSize();
	}
}

