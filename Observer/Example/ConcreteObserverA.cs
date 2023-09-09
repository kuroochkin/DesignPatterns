namespace Observer;

public class ConcreteObserverA : IObserver
{
	public void Update(ISubject subject)
	{
		if ((subject as Subject).State < 3)
		{
			Console.WriteLine("ConcreteObserverA: Спасибо, это важная для меня информация.");
		}
	}
}
