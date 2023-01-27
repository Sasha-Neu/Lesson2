using PerimeterApp;
using Xunit.Sdk;

namespace PerimeterAppTests
{
    [TestClass]
    public class PerimeterTests
    {
        /// <summary>
        /// Tests if perimeter correct
        /// </summary>
        [TestMethod]
        public void TestPerimeterCalculation()
        {
            Point a, b, c;
            a = new Point(0, 0);
            b = new Point(8, 2);
            c = new Point(-2, 6);

            var calculator = new Calculator();
            var actualPerimeter = calculator.CalculatePerimeter(a, b, c);

            Assert.AreEqual(25.34, actualPerimeter, 0.1);
        }
    }
}