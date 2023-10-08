using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_MoodAnalyserPracticeProblems
{
    public class MoodAnalyser
    {
        private string message;

        // Default constructor
        public MoodAnalyser()
        {
            this.message = string.Empty;
        }

        // Constructor with parameters
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            // Convert the message to lowercase for case-insensitive comparison
            string lowercaseMessage = message.ToLower();

            if (lowercaseMessage.Contains("happy"))
            {
                return "Sad"; // Return "Sad" when "Happy" is found
            }
            else if (lowercaseMessage.Contains("sad"))
            {
                return "Sad";
            }
            else
            {
                return "Happy"; // Return "Happy" when neither "Sad" nor "Happy" is found
            }
        }
    }
}
