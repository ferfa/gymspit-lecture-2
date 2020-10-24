using System;


namespace Lecture7
{
	class Program
	{
		static void Main(string[] args)
		{
			ArrayBuilder<int> builder = new ArrayBuilder<int>();

			for (int i = 0; i < 20; i += 1) {
				builder.Add(i * 10);
			}

			int[] array = builder.Get();
			Console.WriteLine(String.Join(", ", array));


			// Expression expr = new Addition(
			// 	new Value(15),
			// 	new Multiplication(new Value(3), new Value(9))
			// );
			BinaryExpressionBuilder rightExprBuilder = new BinaryExpressionBuilder();
			rightExprBuilder.Left = new Value(3);
			rightExprBuilder.Operation = BinaryExpressionBuilder.Operations.Multiplication;
			rightExprBuilder.Right = new Value(9);
			Expression rightExpr = rightExprBuilder.Get();

			BinaryExpressionBuilder exprBuilder = new BinaryExpressionBuilder();
			exprBuilder.Left = new Value(15);
			exprBuilder.Operation = BinaryExpressionBuilder.Operations.Addition;
			exprBuilder.Right = rightExpr;

			Expression expr = exprBuilder.Get();
			Console.WriteLine(expr.GetValue());
		}
	}
}
