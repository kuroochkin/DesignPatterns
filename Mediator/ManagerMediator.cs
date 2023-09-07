namespace Mediator;

public class ManagerMediator : Mediator
{
	public ProgrammerCollegue Programmer { get; set; }
	public CustomerColleague Customer { get; set; }

	public ManagerMediator(
		ProgrammerCollegue programmer, 
		CustomerColleague customer)
	{
		Programmer = programmer;
		Customer = customer;
	}

	public ManagerMediator() { }

	public override void Send(string message, Colleague colleague)
	{
		if (Customer == colleague)
			Programmer.Notify(message);
		else if (Programmer == colleague)
			Customer.Notify(message);
	}
}
