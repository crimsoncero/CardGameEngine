

namespace CardGameEngine
{
    public interface IDrawable<T> where T : Card
    {
        public T Draw();
    }
}
