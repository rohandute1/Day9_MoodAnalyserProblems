using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_MoodAnalyserPracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser problems");
            // Test case 1: Analyzing a message with "Sad"
            string message1 = "I am in Sad Mood";
            MoodAnalyser moodAnalyser1 = new MoodAnalyser(message1);
            string mood1 = moodAnalyser1.AnalyseMood();
            Console.WriteLine($"Mood 1: {mood1}"); 

            // Test case 2: Analyzing a message with "Any" (as per the updated condition)
            string message2 = "I am in Any Mood";
            MoodAnalyser moodAnalyser2 = new MoodAnalyser(message2);
            string mood2 = moodAnalyser2.AnalyseMood();
            Console.WriteLine($"Mood 2: {mood2}"); 

            // Test case 3: Analyzing a message with "Happy" in constructor
            string message3 = "I am in Happy Mood";
            MoodAnalyser moodAnalyser3 = new MoodAnalyser(message3);
            string mood3 = moodAnalyser3.AnalyseMood();
            Console.WriteLine($"Mood 3: {mood3}"); 

            // Test case 4: Analyzing a message with "Happy" in constructor and no params
            string message4 = "I am in Happy Mood";
            MoodAnalyser moodAnalyser4 = new MoodAnalyser(message4);
            string mood4 = moodAnalyser4.AnalyseMood();
            Console.WriteLine($"Mood 4: {mood4}"); 
            Console.ReadLine();
        }
    }
}
