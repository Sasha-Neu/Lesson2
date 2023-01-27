namespace PerimeterApp
{
    public class Calculator
    {
        /// <summary>
        /// Calculates distance between points.
        /// </summary>
        /// <param name="a">Point A.</param>
        /// <param name="b">Point B.</param>
        /// <returns>Distance</returns>
        public double CalculateDistance(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow((a.X - b.X), 2) + Math.Pow(a.Y - b.Y, 2));
        }
        
        /// <summary>
        /// Calculates the triangle perimeter.
        /// </summary>
        /// <param name="a">Point A</param>
        /// <param name="b">Point B</param>
        /// <param name="c">Point C</param>
        /// <returns>Perimeter</returns>
        public double CalculatePerimeter(Point a, Point b, Point c)
        {
            return CalculateDistance(a, b)
                 + CalculateDistance(b, c)
                 + CalculateDistance(c, a);
        }
    }
}
