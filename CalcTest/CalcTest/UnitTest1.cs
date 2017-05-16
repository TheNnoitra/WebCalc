using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcTest
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void TestSum()
        {
            //arrange
            var test = new CaclLibrary.Calc();
            //act
            var result = test.Divide(1, 2);
            //var result2 = test.Sum(double NaN, 2);
            //test
            Assert.AreEqual(result,3);
        }
    }

}
