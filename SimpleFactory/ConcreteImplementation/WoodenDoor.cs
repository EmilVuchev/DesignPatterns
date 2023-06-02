using SimpleFactory.Interfaces;

namespace SimpleFactory.ConcreteImplementation
{
    public class WoodenDoor : IDoor
    {
        public WoodenDoor(int height, int width)
        {
            this.Width = width;
            this.Height = height;
        }

        private int Height { get; set; }

        private int Width { get; set; }

        public int GetHeight()
        {
            return this.Height;
        }

        public int GetWidth()
        {
            return this.Width;
        }

        public override string ToString()
        {
            return $"Door with height {this.Height} and width {this.Width}";
        }
    }
}
