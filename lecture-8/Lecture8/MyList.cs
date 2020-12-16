using System;
using System.Collections;
using System.Collections.Generic;
// https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netcore-3.1


namespace Lecture8
{
	class MyList<T> : IEnumerable<T>
	{
		private const int INITIAL_CAPACITY = 10;

		private T[] items = new T[INITIAL_CAPACITY];

		private int count = 0;

		private int capacity = INITIAL_CAPACITY;


		public class Iterator : IEnumerator<T>
		{
			public T Current {
				get {
					try {
						return list.Get(position);
					} catch (ArgumentOutOfRangeException) {
						throw new InvalidOperationException();
					}
				}
			}

			object IEnumerator.Current => (object) Current;

			private MyList<T> list;

			private int position = -1;


			public Iterator(MyList<T> list)
			{
				this.list = list;
			}


			public void Dispose()
			{
			}


			public bool MoveNext()
			{
				position += 1;
				return position < list.Count();
			}


			public void Reset()
			{
				position = -1;
			}
		}


		public T Get(int i)
		{
			if (i < 0 || i >= count) {
				throw new ArgumentOutOfRangeException();
			}

			return items[i];
		}


		public void Add(T item)
		{
			if (count >= capacity) {
				capacity *= 2;
				Array.Resize(ref items, capacity);
			}

			items[count] = item;
			count += 1;
		}


		public int Count()
		{
			return count;
		}

		public IEnumerator<T> GetEnumerator()
		{
			return new Iterator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
