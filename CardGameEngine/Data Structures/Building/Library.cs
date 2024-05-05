
using System.Collections;

namespace CardGameEngine
{
    /// <summary>
    /// An abstract class representing a collection of cards being used outside of gameplay, for example during deck building.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Library<T> : ICardCollection<T> where T : Card
    {
        public abstract int Count { get; }
        public abstract bool IsReadOnly { get; }

        public abstract void Add(T item);
        public abstract bool Remove(T item);
        public abstract void Clear();
        public abstract bool Contains(T item);
        public abstract void CopyTo(T[] array, int arrayIndex);
       
        public abstract IEnumerator<T> GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
