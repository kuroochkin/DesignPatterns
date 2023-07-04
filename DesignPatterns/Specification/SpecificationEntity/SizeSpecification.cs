namespace DesignPatterns.Specification.SpecificationEntity;

public class SizeSpecification : CompositeSpecification<Product>
{
	private Size size;

	public SizeSpecification(Size size)
	{
		this.size = size;
	}

	public override bool IsSatisfiedBy(Product item)
	{
		return item.Size == size;
	}
}
