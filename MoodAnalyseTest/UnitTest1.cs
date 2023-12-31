﻿using Day9_MoodAnalyserPracticeProblems;
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

        [TestMethod]
        public void AnalyseMood_ShouldReturnHAPPY_WhenGivenAnyMessageExceptSad()
        {
            // Arrange
            string message = "I am in Any Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            // Act
            string mood = moodAnalyser.AnalyseMood();

            // Assert
            Assert.AreEqual("Happy", mood);
        }

        [TestMethod]
        public void AnalyseMood_ShouldReturnSAD_WhenMessageProvidedInConstructor()
        {
            // Arrange
            string message = "I am in Sad Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            // Act
            string mood = moodAnalyser.AnalyseMood();

            // Assert
            Assert.AreEqual("Sad", mood);
        }

        [TestMethod]
        public void AnalyseMood_ShouldReturnSAD_WhenCalledWithNoParamsAfterMessageInConstructor()
        {
            // Arrange
            string message = "I am in Sad Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            // Act
            string mood = moodAnalyser.AnalyseMood();

            // Assert
            Assert.AreEqual("Sad", mood);
        }
        [TestMethod]
        public void AnalyseMood_ShouldReturnSAD_WhenGivenHappyMessageInConstructor()
        {
            // Arrange
            string message = "I am in Happy Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            // Act
            string mood = moodAnalyser.AnalyseMood();

            // Assert
            Assert.AreEqual("Sad", mood);
        }
    }
}
