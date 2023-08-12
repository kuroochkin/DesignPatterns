
using Adapter;
using Adapter.Adapter;
using Adapter.Transport;

List<VectorObject> vectorObjects
	  = new List<VectorObject>
	{
	  new VectorRectangle(1, 1, 10, 10),
	  new VectorRectangle(3, 3, 6, 6)
	};

List<Point> points = new List<Point>();


void DrawPoint(Point p)
{
	//simulation
	Console.Write(".");
}

void Draw()
{
	foreach (var vo in vectorObjects)
	{
		foreach (var line in vo)
		{
			var adapter = new LineToPointAdapter(line);
			foreach(var ad in adapter)
			{
				DrawPoint(ad);
			}
		}
	}
}

Draw();

// __________________________________________________________

ITransport car = new Car();
car.Drive();
ITransport camel = new CamelTransAdapter();
camel.Drive();


