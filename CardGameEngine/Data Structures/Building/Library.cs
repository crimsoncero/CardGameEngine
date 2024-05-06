
using System.Collections;

namespace CardGameEngine
{
    /// <summary>
    /// An abstract class representing a collection of cards being used outside of gameplay, for example during deck building.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Library<T> : CardCollection<T> where T : Card
    {
        
    }
}
