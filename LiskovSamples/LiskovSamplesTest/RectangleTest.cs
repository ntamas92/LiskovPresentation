using LiskovSamples;
using LiskovSamples.Square;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LiskovSamplesTest
{
    [TestClass]
    public class RectangleTest
    {
        public Rectangle _rectangle = Locator.GetInstance<Rectangle>();


        [TestMethod]
        public void RectangleWidthTest()
        {
            _rectangle.Width = 5;

            Assert.AreEqual(5, _rectangle.Width);
        }

        [TestMethod]
        public void RectangleAreaCalculationTest()
        {
            _rectangle.Width = 5;
            _rectangle.Height = 10;

            Assert.AreEqual(50, _rectangle.Area);
        }
    }
}
