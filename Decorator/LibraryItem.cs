namespace Decorator
{
    public abstract class LibraryItem
    {
        public int Copies { get; set; }

        public abstract void Display();
    }
}
