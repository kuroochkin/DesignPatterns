namespace TemplateMethod;

public abstract class Education
{
	public abstract void Enter();
	public abstract void Study();
	public virtual void PassExams() { Console.WriteLine("Сдаем выпускные экзамены"); }
	public abstract void GetDocument();

	public void Learn()
	{
		Enter();
		Study();
		PassExams();
		GetDocument();
	}
}
