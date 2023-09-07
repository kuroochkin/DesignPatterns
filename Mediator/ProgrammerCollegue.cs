namespace Mediator;

public class ProgrammerCollegue : Colleague
{
	public ProgrammerCollegue(Mediator mediator) : base(mediator)
	{
	}

	public override void Notify(string message)
	{
		Console.WriteLine("Сообщение программисту: " + message);
	}
}
