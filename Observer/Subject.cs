namespace Observer;

//Реализация издателя
public class Subject : ISubject
{
	public int State { get; set; } = 0;

	private List<IObserver> _observers = new List<IObserver>();
	public void Attach(IObserver observer)
	{
		_observers.Add(observer);
	}

	public void Detach(IObserver observer)
	{
		_observers.Remove(observer);
	}

	public void Notify()
	{
		foreach (var observer in _observers)
		{
			observer.Update(this);
		}
	}

	public void SomeBusinessLogic()
	{
		Console.WriteLine("\nSubject: У меня есть некоторое сообщение.");
		this.State = new Random().Next(0, 10);

		Thread.Sleep(2000);

		Console.WriteLine("Subject: Мое состояние на данный момент: " + this.State);
		this.Notify();
	}
}
