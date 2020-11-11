using System;
using System.IO;


namespace Lecture6Composite
{
	class Directory: File
	{
		private string name;

		private File[] files;


		public Directory(string name, File[] files)
		{
			this.name = name;
			this.files = files;
		}


		public string GetName()
		{
			return name;
		}


		public void PrintOn(TextWriter writer, int indent = 0)
		{
			writer.WriteLine("{0}:", name);

			foreach (File file in files) {
				writer.Write("".PadLeft(indent * 3));
				writer.Write(" - ");
				file.PrintOn(writer, indent + 1);
			}
		}
	}
}
