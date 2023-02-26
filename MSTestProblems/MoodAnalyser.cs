using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestProblems
{
    public class MoodAnalyser
    {
        public string message;
        public MoodAnalyser(string message) 
        {
            this.message = message;
        }
        public string AnalyseMood() 
        {
            try
            {
                if (message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else if (message.Equals(string.Empty))
                {
                    throw new CustomMoodAnalyserException("Message is having empty", CustomMoodAnalyserException.ExceptionTypes.EMPTY_MOOD);
                }
                else
                {
                    return "sad";
                }
            }
            catch (NullReferenceException ex) 
            {
                Console.WriteLine(ex.Message);
                throw new CustomMoodAnalyserException("Message is having null",CustomMoodAnalyserException.ExceptionTypes.NULL_MOOD);
            }
        }
    }
}
