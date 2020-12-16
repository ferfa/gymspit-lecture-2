using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture8Visitor
{
	class Division: BinaryOperation
	{
		public Division(Expression left, Expression right): base(left, right)
		{
		}


		public override void Accept(ExpressionVisitor visitor)
		{
			visitor.VisitDivision(this);
		}


		protected override int Compute(int left, int right)
		{
			return left / right;
		}
	}
}
