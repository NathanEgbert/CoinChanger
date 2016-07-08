using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinChange;
namespace CoinChangeTest
{
    [TestClass]
    public class UnitTest1
    {
        //single quarter
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var obj1 = new Class1();

            //Act
            obj1.MakeChange(25);
            var x = obj1.getQuarters();
            //Assert
            Assert.AreEqual(x, 1);

        }//end test 1

        //single dime
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            var obj1 = new Class1();

            //Act
            obj1.MakeChange(10);
            var x = obj1.getDimes();
            //Assert
            Assert.AreEqual(x, 1);

        }//end test 1

        //single nickel
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            var obj1 = new Class1();

            //Act
            obj1.MakeChange(5);
            var x = obj1.getNickels();
            //Assert
            Assert.AreEqual(x, 1);

        }//end test 1

        //single penny
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            var obj1 = new Class1();

            //Act
            obj1.MakeChange(1);
            var x = obj1.getPennies();
            //Assert
            Assert.AreEqual(x, 1);

        }//end test 1


        //double quarter
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            var obj1 = new Class1();

            //Act
            obj1.MakeChange(50);
            var x = obj1.getQuarters();
            //Assert
            Assert.AreEqual(x, 2);

        }//end test 1

        //Quarter & Dime
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            var obj1 = new Class1();

            //Act
            obj1.MakeChange(35);
            var x = obj1.getQuarters();
            var y = obj1.getDimes();
            //Assert
            Assert.AreEqual(x, 1);
            Assert.AreEqual(y, 1);

        }//end test 1
    }
}
