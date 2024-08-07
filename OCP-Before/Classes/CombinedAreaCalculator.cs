namespace OCP_Before.Classes
{
    public class CombinedAreaCalculator
    {
        public double CalculateAreas(object[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                if (shape is Rectangle)
                {
                    Rectangle rectangle = (Rectangle)shape;
                    area += rectangle.Width * rectangle.Height;
                }
                else if (shape is Circle)
                {
                    Circle circle = (Circle)shape;
                    area += (circle.Radius * circle.Radius) * Math.PI;
                }
            }
            return area;
        }
    }
}
