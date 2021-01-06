namespace Decorator.Decorator
{
    public abstract class Decorator : LibraryItem
    {
        protected LibraryItem _item;

        public Decorator(LibraryItem item)
        {
            _item = item;
        }
    }
}
