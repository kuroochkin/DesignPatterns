namespace Builder.PersonBuilder;

public class PersonBuilder
{
	protected Person person;

	public PersonBuilder()
	{
		person = new Person();
	}
	public PersonBuilder(Person person)
	{
		this.person = person;
	}

	public PersonAddressBuilder Lives => new PersonAddressBuilder(person);

	public PersonJobBuilder Works => new PersonJobBuilder(person);

	public static implicit operator Person(PersonBuilder pb)
	{
		return pb.person;
	}
}
