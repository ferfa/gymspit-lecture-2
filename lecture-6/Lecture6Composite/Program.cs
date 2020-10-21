using System;

namespace Lecture6Composite
{
	class Program
	{
		static void Main(string[] args)
		{
			File file = new Directory("dir", new File[] {
				new RegularFile("hello.txt"),
				new Directory("dir2", new File[] {
					new RegularFile("inner.txt"),
					new RegularFile("inner2.txt"),
					new Directory("dir2", new File[] {
						new RegularFile("inner.txt"),
						new RegularFile("inner2.txt"),
					}),
				}),
				new RegularFile("hello3.txt"),
			});
				
			file.PrintOn(Console.Out);

			Expression expr = new Addition(
				new Value(15),
				new Multiplication(new Value(3), new Value(9))
			);
			Console.WriteLine(expr.GetValue());
		}
	}
}
