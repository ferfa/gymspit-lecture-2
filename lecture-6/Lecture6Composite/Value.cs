using System;


namespace Lecture6Composite
{
	class Value: Expression
	{
		int value;


		public Value(int value)
		{
			this.value = value;
		}


		public int GetValue()
		{
			return value;
		}
	}
}
