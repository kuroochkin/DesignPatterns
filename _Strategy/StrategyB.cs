namespace _Strategy;

public class StrategyB : IStrategy
{
	public object DoAlgorithm(object data)
	{
		var list = data as List<string>;
		list.Sort();
		list.Reverse();

		return list;
	}
}
