using System;


namespace Lecture7
{
	class Value: Expression
	{
		private readonly int value;


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
