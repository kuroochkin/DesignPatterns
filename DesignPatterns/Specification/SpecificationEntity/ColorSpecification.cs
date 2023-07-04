namespace DesignPatterns.Specification.SpecificationEntity;

public class ColorSpecification : CompositeSpecification<Product>
{
	private Color color;

	public ColorSpecification(Color color)
	{
		this.color = color;
	}

	public override bool IsSatisfiedBy(Product item)
	{
		return item.Color == color;
	}
}
