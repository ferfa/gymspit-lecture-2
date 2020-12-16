using System;

// https://en.wikipedia.org/wiki/Visitor_pattern

namespace Lecture8Visitor
{
	class Program
	{
		static void Main(string[] args)
		{
			Expression expr = new Subtraction(
				new Addition(
					new Multiplication(new Value(3), new Value(9)),
					new Value(15)
				),
				new Division(new Value(13), new Value(4))
			);

			PrintExpressionVisitor visitor = new PrintExpressionVisitor();

			foreach (Expression e in expr) {
				visitor.Visit(e);
			}
		}
	}
}
