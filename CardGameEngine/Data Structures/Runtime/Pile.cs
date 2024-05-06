
using System.Collections;

namespace CardGameEngine
{
    /// <summary>
    /// An abstract class representing a collection of cards that is being used in active gameplay.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Pile<T> : CardCollection<T> where T : Card
    {
       
    }
}
