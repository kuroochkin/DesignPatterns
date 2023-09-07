namespace TemplateMethod;

public class School : Education
{
	// идем в первый класс
	public override void Enter() 
	{
		Console.WriteLine("Идем в первый класс"); 
	}

	public override void Study()
	{
        Console.WriteLine("Обучаемся в школе");
    }

	public override void GetDocument()
	{
		Console.WriteLine("Получаем аттестат");
	}
}
