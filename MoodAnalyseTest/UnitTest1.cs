using Day9_MoodAnalyserPracticeProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MoodAnalyseTest
{
    [TestClass]
    public class MoodAnalyserTests
    {
        [TestMethod]
        public void AnalyseMood_ShouldReturnSAD_WhenGivenSadMessage()
        {
            // Arrange
            string message = "I am in sad Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            // Act
            string mood = moodAnalyser.AnalyseMood();

            // Assert
            Assert.AreEqual("Sad", mood);
        }
    }
}
