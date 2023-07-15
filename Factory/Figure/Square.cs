﻿using Factory;

namespace AbstractFactory.Figure;

public class Square : IShape
{
	public void Draw()
	{
		Console.WriteLine("Basic square");
	}
}