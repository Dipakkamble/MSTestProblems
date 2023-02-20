﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public void Given_Message_Should_Return_UserMood(string message,string expected)
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
    }
}