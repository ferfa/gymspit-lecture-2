using System;
using System.IO;


namespace Lecture6Composite
{
	class RegularFile : File
	{
		private string name;


		public RegularFile(string name)
		{
			this.name = name;
		}


		public string GetName()
		{
			return name;
		}


		public void PrintOn(TextWriter writer, int indent = 0)
		{
			writer.WriteLine(name);
		}
	}
}
