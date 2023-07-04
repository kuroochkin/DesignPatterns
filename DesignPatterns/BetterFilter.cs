using DesignPatterns.Specification;

namespace DesignPatterns;

public class BetterFilter
{
	public IEnumerable<Product> Filter(
		IEnumerable<Product> items, 
		ISpecification<Product> spec)
	{
		foreach (var i in items)
			if (spec.IsSatisfiedBy(i))
				yield return i;
	}
}
