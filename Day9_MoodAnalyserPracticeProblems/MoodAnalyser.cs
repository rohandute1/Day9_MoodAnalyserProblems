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
            this.message = message ?? throw new ArgumentNullException(nameof(message), "Message cannot be null");
        }

        public string AnalyseMood()
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                throw new InvalidOperationException("Message is empty or whitespace.");
            }

            // Convert the message to lowercase for case-insensitive comparison
            string lowercaseMessage = message.ToLower();

            if (lowercaseMessage.Contains("happy"))
            {
                return "Happy";
            }
            else if (lowercaseMessage.Contains("sad"))
            {
                return "Sad";
            }
            else
            {
                return "Happy"; // Return "Happy" for invalid moods
            }
        }
    }
}
