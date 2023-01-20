using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProject
{


    public class MoodAnalyser
    {
        string message;
        public MoodAnalyser(string Message)
        {
            this.message = Message;
        }
        public string AnalyzeMood()
        {
            if (message.ToLower().Contains("happy"))
            {
                return "happy";
            }
            else
            {
                return "sad";
            }
        }

    }
}
    