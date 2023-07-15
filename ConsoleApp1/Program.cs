using Builder;
using Builder.CodeBuilder;
using Builder.HtmlBuilder;
using Builder.PersonBuilder;

var words = new[] { "hello", "world" };
var builder = new HtmlBuilder("ul");

foreach (var word in words)
	builder.AddChild("li", word);

Console.WriteLine(builder.ToString());


//Строим Person
var pb = new PersonBuilder();

Person person = pb
	.Lives
		.At("123 London Road")
		.In("London")
		.WithPostcode("SW12")
	.Works
		.At("Fabrikam")
		.AsA("Engineer")
		.Earning(123000);

Console.WriteLine(person);

var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
Console.WriteLine(cb);
