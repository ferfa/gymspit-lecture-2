using System;
using System.Collections.Generic;


namespace Lecture7
{
	class BinaryExpressionBuilder
	{
		public Expression Left { get; set; }

		public Expression Right { get; set; }

		public BinaryOperation Operation { get; set; }


		public BinaryExpression Get()
		{
			if (Left == null || Right == null || Operation == null) {
				throw new Exception("Left or Right or Operation is not set");
			}

			return new BinaryExpression(Left, Right, Operation);
		}
	}
}
