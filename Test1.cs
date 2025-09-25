using ClassLibrary;
namespace TestProject1
{
    [TestClass]
    public sealed class TestTask2
    {
        double a = 1, b = 2;
        [TestMethod]
        public void TestCalculateArea()
        {
            rectangle test = new rectangle(a, b);
            double area = test.area;
            Assert.AreEqual(area, (a * b));
        }

        [TestMethod]
        public void TestCalculatePerimetr()
        {
            rectangle test = new rectangle(a, b);
            double perimetr = test.perimetr;
            Assert.AreEqual(perimetr, (a + b));
        }

    }

    [TestClass]
    public sealed class TestTask3
    {
        point a = new point(4, 3);
        point b = new point(1, 7);
        point c = new point(5, 4);

        [TestMethod]
        public void TestLengthSide()
        {
            figure x = new figure(a, b, c);
            Assert.AreEqual(x.A, 5);
        }

        [TestMethod]
        public void TestPerimetr()
        {
            figure x = new figure(a, b, c);
            Assert.AreEqual(Math.Round(x.perimetrcalculator()), 11);
        }

    }


}
