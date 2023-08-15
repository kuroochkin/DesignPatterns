namespace Adapter.Transport;

public class CamelTransAdapter : ITransport
{
	private Camel camel = new Camel();
	public void Drive()
	{
		camel.Move();
	}
}
