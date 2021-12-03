using MoodAnalyzerProblem;
using NUnit.Framework;

namespace MoodAnalyzerTesting
{
    public class Tests
    {
      
        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void GivenSadMessage_WhenAnalyze_ShouldReturnSad()
        {
            string message = "I am in a Sad mood";
            MoodAnalyzer mood = new MoodAnalyzer(message);
            string result = mood.AnalyzeMood();
            Assert.AreEqual(result, "Sad");
         }

        [Test]
        public void GivenAnyMessage_WhenAnalyze_ShouldReturnHappy()
        {
            string message = "I am in a Happy mood";
            MoodAnalyzer mood = new MoodAnalyzer(message);
            string result = mood.AnalyzeMood();
            Assert.AreEqual(result, "Happy");
          }

        [Test]
        public void GivenNullMessage_WhenAnalyze_ShouldReturnHappy()
        {
            string message = "Null";
            MoodAnalyzer mood = new MoodAnalyzer(message);
            string result = mood.AnalyzeMood();
            Assert.AreEqual(result, "Happy");
        }
    }
}