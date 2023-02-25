using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestProblems;
using System;
using System.Diagnostics;

namespace MSTestProject
{
    [TestClass]
    public class AdditionTestClass
    {
        [TestMethod]
        [DataRow(10,20,30)]
        [DataRow(70, 20, 90)]
        [DataRow(10, 10, 20)]
        public void Given_Two_Numbers_Should_Return_Sum(int first,int second,int expected)
        { 
            ///AAA Methodology
            // Arrange
            ///int first = 10; int second = 20;
            //int expected = 30;
            Calculator calculator=new Calculator();
            // Act
            int actual = calculator.Addition(first, second);  
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
