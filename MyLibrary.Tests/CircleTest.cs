namespace MyLibrary.Tests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CalculateArea()
        {
            double radius = 10;
            double expected = 314.16;

            Circle circle = new Circle(radius);
            double actual = circle.CalculateArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateAreaAsFigure()
        {
            double radius = 10;
            double expected = 314.16;

            Figure circle = new Circle(radius);
            double actual = circle.CalculateArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateAreaWithRadiusInput()
        {
            double radius = 10;
            double expected = 314.16;

            Circle circle = new Circle();
            double actual = circle.CalculateArea(radius);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateAreaWithoutRadius()
        {
            double expected = 0;

            Circle circle = new Circle();
            double actual = circle.CalculateArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateAreaWithNegativeRadiusInput()
        {
            double radius = -10;

            Circle circle = new Circle();

            Assert.ThrowsException<InvalidDataException>(() => circle.CalculateArea(radius));
        }
    }
}