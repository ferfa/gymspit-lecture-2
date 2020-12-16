using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture8Visitor
{
	class PrintExpressionVisitor : ExpressionVisitor
	{
		public void Visit(Expression expression)
		{
			expression.Accept(this);
		}


		public void VisitAddition(Addition expression)
		{
			Console.WriteLine('+');
		}


		public void VisitDivision(Division expression)
		{
			Console.WriteLine('/');
		}


		public void VisitMultiplication(Multiplication expression)
		{
			Console.WriteLine('*');
		}


		public void VisitSubtraction(Subtraction expression)
		{
			Console.WriteLine('-');
		}


		public void VisitValue(Value expression)
		{
			Console.WriteLine(expression.GetValue());
		}
	}
}
