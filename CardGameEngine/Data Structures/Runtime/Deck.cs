
namespace CardGameEngine
{
    public class Deck<T> : Pile<T>, IDrawable<T> where T : Card
    {
        public T Draw()
        {
            throw new NotImplementedException();
        }
    }
}
