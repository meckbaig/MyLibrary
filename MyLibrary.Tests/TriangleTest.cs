namespace MyLibrary.Tests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void CalculateArea()
        {
            double a = 10;
            double b = 10;
            double c = 10;
            double expected = 43.30;

            Triangle triangle = new Triangle(a, b, c);
            double actual = triangle.CalculateArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateAreaAsFigure()
        {
            double a = 10;
            double b = 10;
            double c = 10;
            double expected = 43.30;

            Figure triangle = new Triangle(a, b, c);
            double actual = triangle.CalculateArea();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateAreaWithInputs()
        {
            double a = 10;
            double b = 10;
            double c = 10;
            double expected = 43.30;

            Triangle triangle = new Triangle();
            double actual = triangle.CalculateArea(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateAreaWith1Parameter()
        {
            double a = 10;
            double expected = 0;

            Triangle triangle = new Triangle() { A = a };
            double actual = triangle.CalculateArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateAreaWith1NegativeParameter()
        {
            double a = 10;
            double b = -10;
            double c = 10;

            Assert.ThrowsException<InvalidDataException>(() => new Triangle(a, b, c));
        }

        [TestMethod]
        public void IsRightTriangleTrue()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            bool expected = true;

            Triangle triangle = new Triangle(a, b, c);
            bool actual = triangle.IsRightTriangle();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsRightTriangleFalse()
        {
            double a = 3;
            double b = 3;
            double c = 5;
            bool expected = false;

            Triangle triangle = new Triangle(a, b, c);
            bool actual = triangle.IsRightTriangle();

            Assert.AreEqual(expected, actual);
        }
    }
}
