using System.Collections;

namespace CardGameEngine
{
    public abstract class CardCollection<T> : ICardCollection<T> where T : Card
    {
        protected List<T> _cards;
        public virtual int Count { get { return _cards.Count; } }
        public bool IsReadOnly { get { return false; } }

        public T this[int index] { get { return _cards[index]; } protected set { _cards[index] = value; } }
        public virtual void Add(T card)
        {
            _cards.Add(card);
        }
        public virtual bool Remove(T card)
        {
            return _cards.Remove(card);
        }
        public virtual void Clear()
        {
            _cards.Clear();
        }
        public virtual bool Contains(T card)
        {
            return _cards.Contains(card);
        }
        public virtual void CopyTo(T[] array, int arrayIndex)
        {
            _cards.CopyTo(array, arrayIndex);
        }

        public virtual IEnumerator<T> GetEnumerator()
        {
            return _cards.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}