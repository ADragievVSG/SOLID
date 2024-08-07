using OCP_After.Contracts;

namespace OCP_After.Classes
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double Area()
        {
            return (Radius * Radius) * Math.PI;
        }
    }
}
