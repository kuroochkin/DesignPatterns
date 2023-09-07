namespace TemplateMethod;

public class University : Education
{

	public void Practice()
	{
        Console.WriteLine("Проходим практику в университете");
    }

	public override void Enter()
	{
		Console.WriteLine("Поступаем на первый курс");
	}

	public override void Study()
	{
		Console.WriteLine("Обучаемся в университете");
	}

	public override void PassExams()
	{
		Console.WriteLine("Сдаем экзамен по специальности");
	}

	public override void GetDocument()
	{
        Console.WriteLine("Поулчаем диплом");
    }
}
