using MoodAnalyzerProblem;
using System;
using System.Runtime.Serialization;
using static MoodAnalyzerProblem.MoodAnalyzerException;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        string message;
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public MoodAnalyzer()
        {

        }

        public string AnalyzeMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.ENTERED_EMPTY, "Mood should not be Empty");
                }
                if (message.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch (MoodAnalyzerException)
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.ENTERED_NULL, "mood should not be null");
            }
        }
    }
}
   
