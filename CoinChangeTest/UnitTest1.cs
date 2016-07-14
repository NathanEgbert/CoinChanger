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
        public void singleQuarter()
        {
            //Arrange
            Class1 obj1 = new Class1();

            //Act
            obj1.MakeChange(25);
            var x = obj1.Quarters;
            //Assert
            Assert.AreEqual(x, 1);

        }//end test 1

        //single dime
        [TestMethod]
        public void singleDime()
        {
            //Arrange
            Class1 obj1 = new Class1();

            //Act
            obj1.MakeChange(10);
            var x = obj1.Dimes;
            //Assert
            Assert.AreEqual(x, 1);

        }//end test 1

        //single nickel
        [TestMethod]
        public void singleNickel()
        {
            //Arrange
            Class1 obj1 = new Class1();

            //Act
            obj1.MakeChange(5);
            var x = obj1.Nickels;
            //Assert
            Assert.AreEqual(x, 1);

        }//end test 1

        //single penny
        [TestMethod]
        public void singlePenny()
        {
            //Arrange
            Class1 obj1 = new Class1();

            //Act
            obj1.MakeChange(1);
            var x = obj1.Pennies;
            //Assert
            Assert.AreEqual(x, 1);

        }//end test 1


        //double quarter
        [TestMethod]
        public void doubleQuarter()
        {
            //Arrange
            Class1 obj1 = new Class1();

            //Act
            obj1.MakeChange(50);
            var x = obj1.Quarters;
            //Assert
            Assert.AreEqual(x, 2);

        }//end test 1

        //Quarter & Dime
        [TestMethod]
        public void quarterAnddime()
        {
            //Arrange
           Class1 obj1 = new Class1();

            //Act
            obj1.MakeChange(35);
            var x = obj1.Quarters;
            var y = obj1.Dimes;
            //Assert
            Assert.AreEqual(x, 1);
            Assert.AreEqual(y, 1);

        }//end test 1

       
    }
}
