using System;
using System.Collections.Generic;


namespace Lecture6
{
	class RandomDonutFactory: DonutFactory
	{
		private string[] fillings;

		private string[] glazes;

		private Random random;


		public RandomDonutFactory(string[] fillings, string[] glazes)
		{
			this.fillings = fillings;
			this.glazes = glazes;
			this.random = new Random();
		}

		
		public Donut createDonut()
		{
			int filling = random.Next(fillings.Length);
			int glaze = random.Next(glazes.Length);
			return new Donut(fillings[filling], glazes[glaze]);
		}
	}
}
