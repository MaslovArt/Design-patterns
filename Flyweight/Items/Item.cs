namespace Flyweight.Items
{
    public abstract class Item
    {
        public abstract string Color { get; }
        public abstract int Size { get; }
        public abstract void Render();
    }
}
