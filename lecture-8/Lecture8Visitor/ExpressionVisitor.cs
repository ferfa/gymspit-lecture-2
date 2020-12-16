namespace Lecture8Visitor
{
	interface ExpressionVisitor
	{
		void Visit(Expression expression);

		void VisitAddition(Addition expression);

		void VisitDivision(Division expression);

		void VisitMultiplication(Multiplication expression);

		void VisitSubtraction(Subtraction expression);

		void VisitValue(Value expression);
	}
}