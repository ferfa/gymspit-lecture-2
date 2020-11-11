using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture7
{
	class Subtraction: BinaryOperation
	{
		public Subtraction(Expression left, Expression right): base(left, right)
		{
		}


		protected override int Compute(int left, int right)
		{
			return left * right;
		}
	}
}
