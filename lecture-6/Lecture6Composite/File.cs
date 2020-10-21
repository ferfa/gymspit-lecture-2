using System;
using System.IO;


namespace Lecture6Composite
{
	interface File
	{
		public string GetName();

		public void PrintOn(TextWriter writer, int indent = 0);
	}
}
