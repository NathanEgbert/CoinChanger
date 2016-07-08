using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinChange;
namespace CoinChangeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var obj1 = new Class1();

            //Act
            obj1.GreaterThanTwentyFive(25);

            //Assert
            Assert.AreEqual(obj1.qCount, 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            var obj1 = new Class1();

            //Act
            obj1.GreaterThanTwentyFive(10);

            //Assert
            Assert.AreEqual(obj1.dCount, 1);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            var obj1 = new Class1();

            //Act
            obj1.GreaterThanTwentyFive(5);

            //Assert
            Assert.AreEqual(obj1.nCount, 1);
        }

        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            var obj1 = new Class1();

            //Act
            obj1.GreaterThanTwentyFive(1);

            //Assert
            Assert.AreEqual(obj1.pCount, 1);
        }

        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            var obj1 = new Class1();

            //Act
            obj1.GreaterThanTwentyFive(80);

            //Assert
            Assert.AreEqual(obj1.qCount, 3);
            Assert.AreEqual(obj1.nCount, 1);
        }


    }
}
