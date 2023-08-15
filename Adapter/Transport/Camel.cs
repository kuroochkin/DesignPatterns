namespace Adapter.Transport;

public class Camel : IAnimal
{
	public void Move()
	{
        Console.WriteLine("Еду на верблюде");
    }
}
