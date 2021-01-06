namespace Flyweight.Items
{
    public class Box : Item
    {
        private string _color;
        private int _size;
        public Box(string color, int size)
        {
            _color = color;
            _size = size;
        }

        public override string Color => _color;

        public override int Size => _size;

        public override void Render()
        {
            System.Console.WriteLine($"Render {Color} box {Size}");
        }
    }
}
