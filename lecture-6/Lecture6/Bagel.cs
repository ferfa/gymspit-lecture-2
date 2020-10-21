using System;


namespace Lecture6
{
	class Bagel: ToroidFood
	{
		public string Flavor { get; private set; }

		public Bagel(string flavor)
		{
			Flavor = flavor;
		}
	}
}
