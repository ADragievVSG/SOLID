using OCP_After.Contracts;

namespace OCP_After.Classes
{
    public class CombinedAreaCalculator
    {
        public double CalculateAreas(IShape[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Area();
            }
            return area;
        }
    }
}
