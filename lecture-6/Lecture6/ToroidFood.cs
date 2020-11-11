using System;


namespace Lecture6
{
	class ToroidFood
	{
		public static Bagel createBagel(string flavor)
		{
			return new Bagel(flavor);
		}


		public static Donut createDonut(string filling, string glaze)
		{
			return new Donut(filling, glaze);
		}
	}
}
