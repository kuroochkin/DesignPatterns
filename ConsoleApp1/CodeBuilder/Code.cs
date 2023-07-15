using System.Text;

namespace Builder.CodeBuilder;

public class Code
{
	private const int countMargin = 2;
	public string ClassName { get; set; }
	public List<Property> Properties { get; set; } = new List<Property>();

	public override string ToString()
	{
		var margin = new string(' ', countMargin);
		var sb = new StringBuilder();

		sb.Append($"public class {ClassName}\n");
		sb.Append("{\n");
		foreach (var prop in Properties)
		{
			sb.Append($"{margin}public {prop.Type} {prop.Name};\n");
		}
		sb.Append("}");

		return sb.ToString();
	}
}
