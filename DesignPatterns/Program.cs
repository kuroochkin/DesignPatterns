using DesignPatterns;
using DesignPatterns.Specification;
using DesignPatterns.Specification.SpecificationEntity;

var product1 = new Product("Apple", Size.Small, Color.Green);
var product2 = new Product("Car", Size.Medium, Color.Green);
var product3 = new Product("House", Size.Large, Color.Red);
var product4 = new Product("Notebook", Size.Small, Color.Blue);
var product5 = new Product("Airplane", Size.Large, Color.Blue);

Product[] products = { product1, product2, product3, product4, product5 };

var bf = new BetterFilter();

var largeBlueSpec = new AndSpecification<Product>(new SizeSpecification(Size.Large), new ColorSpecification(Color.Blue));
var smallOrGreenSpec = new OrSpecification<Product>(new SizeSpecification(Size.Small), new ColorSpecification(Color.Green));
var smallOrGreenAndBlueSpec = new AndSpecification<Product>(smallOrGreenSpec, new ColorSpecification(Color.Blue));

foreach (var p in bf.Filter(products, largeBlueSpec))
	Console.WriteLine($"{p.Name} is large and blue");

Console.WriteLine();

foreach (var p in bf.Filter(products, smallOrGreenSpec))
	Console.WriteLine($"{p.Name} is small or green");

Console.WriteLine();

foreach (var p in bf.Filter(products, smallOrGreenAndBlueSpec))
	Console.WriteLine($"{p.Name} is (small or green) and blue");



