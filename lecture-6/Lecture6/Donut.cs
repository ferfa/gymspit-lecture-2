using System;


namespace Lecture6
{
	class Donut: ToroidFood
	{
		public string Filling { get; private set; }

		public string Glaze { get; private set; }


		public Donut(string filling, string glaze)
		{
			Filling = filling;
			Glaze = glaze;
		}
	}
}