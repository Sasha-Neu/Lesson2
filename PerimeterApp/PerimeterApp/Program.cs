namespace PerimeterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point a, b, c;

            a = EnterAndPrintPoint("A");
            b = EnterAndPrintPoint("B");
            c = EnterAndPrintPoint("C");

            var calculator = new Calculator();

            double perimeter;
            perimeter = calculator.CalculatePerimeter(a, b, c);

            Console.WriteLine($"The perimeter is {perimeter}");
        }

        /// <summary>
        /// Entering and printing point.
        /// </summary>
        /// <param name="pointName">Point name</param>
        /// <returns>Point</returns>
        public static Point EnterAndPrintPoint(string pointName)
        {
            Console.WriteLine($"Please enter the coordinates for point { pointName }:");
            var point = new Point();
            point.GetFromKeyboard();
            point.PrintTheCoordinates();
            return point;
        }

    }
}