
using System.Reflection;

namespace CardGameEngine
{
    /// <summary>
    /// An abstract class representing a collection of cards that is being used in active gameplay.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Pile<T> : CardCollection<T> where T : Card
    {
       


        public int Search(int cardID)
        {
            return _cards.FindIndex(t => t.ID == cardID);
        }
        public int Search(T card)
        {
            return Search(card.ID);
        }

    }
}
