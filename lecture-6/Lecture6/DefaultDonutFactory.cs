using System;


namespace Lecture6
{
	class DefaultDonutFactory: DonutFactory
	{
		private string filling;

		private string glaze;


		public DefaultDonutFactory(string filling, string glaze)
		{
			this.filling = filling;
			this.glaze = glaze;
		}

		
		public Donut createDonut()
		{
			return new Donut(filling, glaze);
		}
	}
}
