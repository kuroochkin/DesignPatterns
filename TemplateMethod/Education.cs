namespace TemplateMethod;

public abstract class Education
{
	public virtual void Enter() { }
	public virtual void Study() { }
	public virtual void PassExams() { }
	public virtual void GetDocument() { }

	public void Learn()
	{
		Enter();
		Study();
		PassExams();
		GetDocument();
	}
}
