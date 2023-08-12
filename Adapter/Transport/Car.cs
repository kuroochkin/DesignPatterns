namespace Adapter.Transport;

public class Car : ITransport
{
	public void Drive()
	{
        Console.WriteLine("Еду на машине");
    }
}
