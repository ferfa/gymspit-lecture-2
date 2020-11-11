using System;
using System.Collections.Generic;


namespace Lecture7
{
	class BinaryExpressionBuilder
	{
		public enum Operations { Addition = 1, Subtraction, Multiplication, Division };

		public Expression Left { get; set; }

		public Expression Right { get; set; }

		public Operations Operation { get; set; }


		public BinaryOperation Get()
		{
			if (Left == null || Right == null) {
				throw new Exception("Left or Right is not set");
			}

			switch (Operation) {
				case Operations.Addition:
					return new Addition(Left, Right);
				case Operations.Subtraction:
					return new Subtraction(Left, Right);
				case Operations.Multiplication:
					return new Multiplication(Left, Right);
				case Operations.Division:
					return new Division(Left, Right);
				default:
					throw new Exception("Invalid operation");
			}
		}
	}
}
