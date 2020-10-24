using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture7
{
	class Addition: BinaryOperation
	{
		public Addition(Expression left, Expression right): base(left, right)
		{
		}


		protected override int Compute(int left, int right)
		{
			return left + right;
		}
	}
}
