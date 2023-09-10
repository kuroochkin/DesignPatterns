using System;

namespace Observer.Example;

public interface ISubject
{
    void Attach(IObserver observer);

    void Detach(IObserver observer);

    void Notify();
}
