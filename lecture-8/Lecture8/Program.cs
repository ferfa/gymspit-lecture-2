using System;

// https://docs.microsoft.com/cs-cz/dotnet/csharp/programming-guide/concepts/iterators

namespace Lecture8
{
	class Program
	{
		static void Main(string[] args)
		{
			MyList<int> intList = new MyList<int>();
			intList.Add(10);
			intList.Add(24);
			intList.Add(15);
			intList.Add(16);
			intList.Add(42);

			foreach (int i in intList) {
				Console.WriteLine(i);
				if (i % 8 == 0) {
					foreach (int j in intList) {
						Console.WriteLine("  {0}", j);
					}
				}
			}
			Console.WriteLine();

			var intListIterator = intList.GetEnumerator();
			while (intListIterator.MoveNext()) {
				int i = intListIterator.Current;
				Console.WriteLine(i);
			}
			Console.WriteLine();

			// (((3 * 9) + 15) - (13 / 4))
			Expression expr = new Subtraction(
				new Addition(
					new Multiplication(new Value(3), new Value(9)),
					new Value(15)
				),
				new Division(new Value(13), new Value(4))
			);
			Console.WriteLine(expr.GetValue());

			foreach (Expression e in expr) {
				Console.WriteLine(e.GetValue());
			}
		}
	}
}
