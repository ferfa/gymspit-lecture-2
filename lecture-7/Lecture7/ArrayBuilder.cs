using System;
using System.Collections.Generic;


namespace Lecture7
{
	class ArrayBuilder<T>
	{
		private List<T> buffer = new List<T>();


		public void Add(T item)
		{
			buffer.Add(item);
		}


		public T[] Get()
		{
			return buffer.ToArray();
		}
	}
}
