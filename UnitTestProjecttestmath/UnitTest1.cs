using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjecttestmath
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1addition()
        {
            var controller = new ValuesController();
            var result = controller.Add(2, 3);
            Assert.Equals(5, result);
        }
        [TestMethod]
        public void Test1subtraction()
        {
            var controller = new ValuesController();
            var result = controller.Subtract(10, 3);
            Assert.Equals(7, result);
        }
        [TestMethod]
        public void Test1Multiply()
        {
            var controller = new ValuesController();
            var result = controller.Multiply(5, 3);
            Assert.Equals(15, result);
        }
        [TestMethod]
        public void Test1division()
        {
            var controller = new ValuesController();
            var result = controller.Divide(9, 3);
            Assert.Equals(3, result);
        }

    }
}
