namespace IObserver;

// Класс издателя, т.к. реализует интерфейс IObservable
// Он предоставляет сведения о Location
public class LocationTracker : IObservable<Location>
{
	// Лист с подписчиками на изменения Location
	private List<IObserver<Location>> observers;

	// Создание списка
	public LocationTracker()
	{
		observers = new List<IObserver<Location>>();
	}


	public IDisposable Subscribe(IObserver<Location> observer)
	{
		if (!observers.Contains(observer))
			observers.Add(observer);
		return new Unsubscriber(observers, observer);
	}

	// Если значение Location - null, то вызываем метод наблюдателя OnError и передаем в него LoationUnknownException
	public void TrackLocation(Nullable<Location> loc)
	{
		foreach (var observer in observers)
		{
			if (!loc.HasValue)
				observer.OnError(new LocationUnknownException());
			else
				observer.OnNext(loc.Value);
		}
	}

	public void EndTransmission()
	{
		foreach (var observer in observers.ToArray())
			if (observers.Contains(observer))
				observer.OnCompleted();

		observers.Clear();
	}

	// ---------------------------------------------------------

	private class Unsubscriber : IDisposable
	{
		private List<IObserver<Location>> _observers;
		private IObserver<Location> _observer;

		public Unsubscriber(List<IObserver<Location>> observers, IObserver<Location> observer)
		{
			this._observers = observers;
			this._observer = observer;
		}

		public void Dispose()
		{
			if (_observer != null && _observers.Contains(_observer))
				_observers.Remove(_observer);
		}
	}
}
