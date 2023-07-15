using Builder.HtmlBuilder;

namespace Builder.CodeBuilder;

public class CodeBuilder
{
	private Code code;
	public CodeBuilder()
	{

	}

	public CodeBuilder(string className)
	{
		code = new Code();
		code.ClassName = className;
	}

	public CodeBuilder AddField(string name, string type)
	{
		var prop = new Property { Name = name, Type = type };
		code.Properties.Add(prop);
		return this;
	}

	public override string ToString()
	{
		return code.ToString();
	}

	public static implicit operator Code
		(CodeBuilder builder)
	{
		return builder.code;
	}
}


