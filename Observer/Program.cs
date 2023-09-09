using Observer;

var subject = new Subject();
var observerA = new ConcreteObserverA();
var observerB = new ConcreteObserverB();

subject.Attach(observerA);
subject.Attach(observerB);

subject.SomeBusinessLogic();

subject.Detach(observerB);

subject.SomeBusinessLogic();
