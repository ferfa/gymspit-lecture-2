using System;
using System.Collections;
using System.Collections.Generic;

namespace Lecture8Visitor
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


		public void Accept(ExpressionVisitor visitor)
		{
			visitor.VisitValue(this);
		}


		public IEnumerator<Expression> GetEnumerator()
		{
			yield return this;
		}


		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
