using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimeterApp
{
    /// <summary>
    /// Point
    /// </summary>
    public class Point
    {
        /// <summary>
        /// X-coordinate
        /// </summary>
        public double X { get; private set; }

        /// <summary>
        /// Y-coordinate
        /// </summary>
        public double Y { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// A method to get the point from keyboard.
        /// </summary>
        public void GetFromKeyboard()
        {
            Console.WriteLine("Please enter the X coordinate:");
            X = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the Y coordinate:");
            Y = double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Print point coordinates
        /// </summary>
        public void PrintTheCoordinates()
        {
            Console.WriteLine($"The coordinates are ({ X }, { Y }).");
        }
    }
}
