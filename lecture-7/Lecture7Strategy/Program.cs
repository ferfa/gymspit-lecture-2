using System;
using System.IO;
using System.Text;

namespace Lecture7
{
	class Program
	{
		private static Addition addition = new Addition();

		private static Subtraction subtraction = new Subtraction();

		private static Multiplication multiplication = new Multiplication();

		private static Division division = new Division();


		static void SkipWhitespace(TextReader reader)
		{
			int next = reader.Peek();

			while (next != -1 && char.IsWhiteSpace((char) next)) {
				reader.Read();
				next = reader.Peek();
			}
		}


		static Expression ParseExpression(TextReader reader)
		{
			SkipWhitespace(reader);

			int next = reader.Peek();
			if (next != '(') {
				StringBuilder stringBuilder = new StringBuilder();

				if (next == '-') {
					stringBuilder.Append((char) reader.Read());
					next = reader.Peek();
				}

				while (next != -1 && char.IsDigit((char) next)) {
					stringBuilder.Append((char) reader.Read());
					next = reader.Peek();
				}

				return new Value(int.Parse(stringBuilder.ToString()));
			}
			reader.Read();

			BinaryExpressionBuilder builder = new BinaryExpressionBuilder();

			builder.Left = ParseExpression(reader);

			SkipWhitespace(reader);
			switch(reader.Read()) {
				case '+':
					builder.Operation = addition;
					break;
				case '-':
					builder.Operation = subtraction;
					break;
				case '*':
					builder.Operation = multiplication;
					break;
				case '/':
					builder.Operation = division;
					break;
				default:
					throw new Exception("Invalid operation");
			}

			builder.Right = ParseExpression(reader);

			SkipWhitespace(reader);
			if (reader.Read() != ')') {
				throw new Exception("Parentheses do not match");
			}

			return builder.Get();
		}


		static void Main(string[] args)
		{
			// Expression expr = new BinaryOperation(
			// 	new Value(15),
			// 	new BinaryOperation(new Value(3), new Value(9), multiplication),
			//	addittion
			// );
			BinaryExpressionBuilder rightExprBuilder = new BinaryExpressionBuilder();
			rightExprBuilder.Left = new Value(3);
			rightExprBuilder.Operation = multiplication;
			rightExprBuilder.Right = new Value(9);
			Expression rightExpr = rightExprBuilder.Get();

			BinaryExpressionBuilder exprBuilder = new BinaryExpressionBuilder();
			exprBuilder.Left = new Value(15);
			exprBuilder.Operation = addition;
			exprBuilder.Right = rightExpr;

			Expression expr = exprBuilder.Get();
			Console.WriteLine(expr.GetValue());

			Console.WriteLine("Enter an expression:");
			Console.WriteLine(ParseExpression(Console.In).GetValue());
		}
	}
}
