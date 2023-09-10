namespace IObserver;

public class LocationReporter : IObserver<Location>
{
	private IDisposable unsubscriber;
	private string instName;

	public LocationReporter(string name)
	{
		this.instName = name;
	}

	public string Name
	{ get { return this.instName; } }

	// Подписка на издателя
	public virtual void Subscribe(IObservable<Location> provider)
	{
		if (provider != null)
			unsubscriber = provider.Subscribe(this);
	}

	public virtual void OnCompleted()
	{
		Console.WriteLine("Трекер местоположения завершил передачу данных на {0}.", this.Name);
		this.Unsubscribe();
	}

	public virtual void OnError(Exception e)
	{
		Console.WriteLine("{0}: Местоположение определить невозможно.", this.Name);
	}

	public virtual void OnNext(Location value)
	{
		Console.WriteLine("{2}: Текущая локация: {0}, {1}", value.Latitude, value.Longitude, this.Name);
	}

	public virtual void Unsubscribe()
	{
		unsubscriber.Dispose();
	}
}