using System.Collections;
using System.Collections.Generic;

namespace VRage.Collections
{
	public struct DictionaryKeysReader<K, V> : IEnumerable<K>, IEnumerable
	{
		private readonly Dictionary<K, V> m_collection;

		public int Count => m_collection.Count;

		public DictionaryKeysReader(Dictionary<K, V> collection)
		{
			m_collection = collection;
		}

		public Dictionary<K, V>.KeyCollection.Enumerator GetEnumerator()
		{
			return m_collection.Keys.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		IEnumerator<K> IEnumerable<K>.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
