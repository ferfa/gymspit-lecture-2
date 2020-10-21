using System;


namespace Lecture6Composite
{
	abstract class BinaryOperation: Expression
	{
		private Expression left;

		private Expression right;


		public BinaryOperation(Expression left, Expression right)
		{
			this.left = left;
			this.right = right;
		}


		public int GetValue()
		{
			return Compute(left.GetValue(), right.GetValue());
		}


		abstract protected int Compute(int left, int right);
	}
}
