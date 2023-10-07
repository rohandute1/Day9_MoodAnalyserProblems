﻿using System;
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
            Console.WriteLine("Enter a message: ");
            string message = Console.ReadLine();

            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string mood = moodAnalyser.AnalyseMood();

            Console.WriteLine($"Mood: {mood}");
            Console.ReadLine();
        }
    }
}
