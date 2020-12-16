using System;
using System.Collections;
using System.Collections.Generic;


namespace Lecture8Visitor
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


		public abstract void Accept(ExpressionVisitor visitor);


		public IEnumerator<Expression> GetEnumerator()
		{
			foreach (Expression expr in left) {
				yield return expr;
			}

			yield return this;

			foreach (Expression expr in right) {
				yield return expr;
			}
		}


		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}


		abstract protected int Compute(int left, int right);
	}
}
