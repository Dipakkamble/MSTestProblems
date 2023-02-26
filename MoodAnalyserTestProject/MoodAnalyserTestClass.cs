using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestProblems;
using System;

namespace MoodAnalyserTestProject
{
    [TestClass]
    public class MoodAnalyserTestClass
    {
        [TestMethod]
        [DataRow("I am happy mood","happy")]
        [DataRow("I am SAD mood", "sad")]
        public void Given_Message_Should_Return_UserMood(string message, string expected)
        {
            /// AAA Methodology
            // Arrange
           // string message = "I am happy mood";
           // string expected = "happy";
            MoodAnalyser mood = new MoodAnalyser(message);
            //Act
            string actual = mood.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        //[DataRow(null, "object reference not set to an instance of object.")]
        //[DataRow(null, "happy")]
        public void Given_NullMessage_Should_Return_Exception()
        {
            string message=null; 
            string expected= "Message is having null";
            try
            {
                //Arrange
                MoodAnalyser mood = new MoodAnalyser(message);
                //Act
                string actual = mood.AnalyseMood();
                //Assert
                Assert.AreEqual(expected, actual); 
            }
            catch (CustomMoodAnalyserException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        //3.2 Test Case
        [TestMethod]
        public void Given_EmptyMessage_Should_Return_CustomException()
        {
            string message = "";
            string expected = "Message is having empty";
            try
            {
                //Arrange
                MoodAnalyser mood = new MoodAnalyser(message);
                //Act
                string actual = mood.AnalyseMood();
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (CustomMoodAnalyserException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}
