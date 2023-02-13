using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBoxProject;
using System;

namespace MindBoxProjectTest
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        [DataRow(-1,5,5,0, "Длина стороны треугольника не может быть отрицательной или равной нулю")]
        [DataRow(1, -1, 5, 0, "Длина стороны треугольника не может быть отрицательной или равной нулю")]
        [DataRow(1, 5, -5, 0, "Длина стороны треугольника не может быть отрицательной или равной нулю")]
        [DataRow(3, 4, 5, 6)]
        [DataRow(6, 7, 8, 20.333162567588939)]
        [DataRow(6.3, 5.6, 5.2, 13.788204877720659)]
        [DataRow(108.5, 14, 110, 758.78545788236477)]
        [DataRow(345, 14, 11, 0, "Не правильный треугольник")]
        public void TriangleAreaTest(double a, double b, double c, double res,string error = null)
        {
            try
            {
                var result = new Triangle().Area(a,b,c);
                Assert.AreEqual(result, res);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, error);
            }
        }
        
        [TestMethod]
        [DataRow(-1, 5, 5, false, "Длина стороны треугольника не может быть отрицательной или равной нулю")]
        [DataRow(1, -1, 5, false, "Длина стороны треугольника не может быть отрицательной или равной нулю")]
        [DataRow(1, 5, -5, false, "Длина стороны треугольника не может быть отрицательной или равной нулю")]
        [DataRow(3, 4, 5, true)]
        [DataRow(6, 7, 8, false)]
        [DataRow(345, 14, 11, false, "Не правильный треугольник")]
        public void IsRectangularTest(double a, double b, double c, bool res, string error = null)
        {
            try
            {
                var result = new Triangle().IsRectangular(a, b, c);
                Assert.AreEqual(result, res);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, error);
            }
        }
    }
}
