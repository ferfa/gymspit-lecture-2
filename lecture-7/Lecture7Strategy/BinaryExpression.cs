using System;


namespace Lecture7
{
	class BinaryExpression: Expression
	{
		private readonly Expression left;

		private readonly Expression right;

		private readonly BinaryOperation operation;


		public BinaryExpression(Expression left, Expression right, BinaryOperation operation)
		{
			this.left = left;
			this.right = right;
			this.operation = operation;
		}


		public int GetValue()
		{
			return operation.Compute(left.GetValue(), right.GetValue());
		}
	}
}
