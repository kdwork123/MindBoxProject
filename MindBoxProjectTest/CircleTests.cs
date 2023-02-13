using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBoxProject;
using System;

namespace MindBoxProjectTest
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        [DataRow(-1,0, "Радиус круга не может быть отрицательным или равным нулю")]
        [DataRow(0,0, "Радиус круга не может быть отрицательным или равным нулю")]
        [DataRow(1, 3.1415926535897931)]
        [DataRow(1.2, 4.5238934211693023)]
        [DataRow(3.7, 43.008403427644275)]
        [DataRow(28, 2463.0086404143976)]
        public void CircleAreaTest(double r, double res,string error = null)
        {
            try
            {
                var result = new Circle().Area(r);
                Assert.AreEqual(result, res);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, error);
            }
        }
    }
}
