using OCP_After.Contracts;

namespace OCP_After.Classes
{
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double Area()
        {
            return Width * Height;
        }
    }
}
