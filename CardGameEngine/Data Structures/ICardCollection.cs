using System.Collections;

namespace CardGameEngine
{
    /// <summary>
    /// An inteface for all types of collections of cards.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICardCollection<T> : ICollection<T>, IEnumerable<T>, IEnumerable where T : Card
    {


    }
}
