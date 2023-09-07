using Mediator;

var manager = new ManagerMediator();

var programmer = new ProgrammerCollegue(manager);
var customer = new CustomerColleague(manager);

manager.Customer = customer;
manager.Programmer = programmer;

customer.Send("Есть заказ, надо сделать программу");
programmer.Send("Программа готова, пользуйтесь");
