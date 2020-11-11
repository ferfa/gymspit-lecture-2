using System;
using System.Collections.Generic;


namespace Lecture6
{
	class Program
	{
		static void Main(string[] args)
		{
			// DonutFactory factory = new DefaultDonutFactory("Vanilla", "Raspberry");
			DonutFactory factory = new RandomDonutFactory(
				new string[] { "Vanilla", "Chocolate", "Jam" },
				new string[] { "Raspberry", "Chocolate", "Sugar" }
			);

			// --------------------------------------------------------------------

			Donut donut = factory.createDonut();
			Donut otherDonut = factory.createDonut();

			Console.WriteLine("Donut has {0} filling and {1} glaze", donut.Filling, donut.Glaze);
			Console.WriteLine("Other donut has {0} filling and {1} glaze", otherDonut.Filling, otherDonut.Glaze);
			Console.WriteLine("donut == otherDonut: {0}", donut == otherDonut);


			donut = ToroidFood.createDonut("Banana", "None");
			Bagel bagel = ToroidFood.createBagel("Ham");

			Console.WriteLine("Donut has {0} filling and {1} glaze", donut.Filling, donut.Glaze);
			Console.WriteLine("Bagel has {0} flavor", bagel.Flavor);
		}
	}
}
