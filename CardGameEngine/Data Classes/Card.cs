
namespace CardGameEngine
{
    public abstract class Card : IComparable<Card>, IEquatable<Card>
    {
        public int ID { get; init; }

        public Card(int id)
        {
            ID = id;
        }




        public int CompareTo(Card? other)
        {
            return this.ID.CompareTo(other?.ID);
        }
        public bool Equals(Card? other)
        {
            return ID.Equals(other?.ID);
        }
    }
}
