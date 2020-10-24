using System;


namespace Lecture7
{
	abstract class BinaryOperation: Expression
	{
		private readonly Expression left;

		private readonly Expression right;


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
