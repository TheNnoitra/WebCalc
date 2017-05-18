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
            // Arrange
            var test = new CalcLibrary.Calc();
            var test2 = new CalcLibrary.DefaultOperations.DivideOperation();
            var test3 = new CalcLibrary.DefaultOperations.SumOperation();
            var test4 = new CalcLibrary.DefaultOperations.MinOperation();
            var test5 = new CalcLibrary.DefaultOperations.MulOperation();

            // Act
            var result = test2.Execute(3, 1);

            var result1 = test3.Execute(1, 5);
            var result2 = test4.Execute(0, 2);
            var result3 = test5.Execute(2, 3);
            var result4 = test2.Execute(5, 2);

            var result5 = test3.Execute(1, 0.5);
            var result6 = test4.Execute(0, 1.5);
            var result7 = test5.Execute(1.5, 3);
            var result8 = test2.Execute(6, 2);

            // Assert
            Assert.AreEqual(result, 3);

            Assert.AreEqual(result1, 6);
            Assert.AreEqual(result2, -2);
            Assert.AreEqual(result3, 6);
            Assert.AreEqual(result4, 2.5);

            Assert.AreEqual(result5, 1.5);
            Assert.AreEqual(result6, -1.5);
            Assert.AreEqual(result7, 4.5);
            Assert.AreEqual(result8, 3);
        }
    }
    

}
