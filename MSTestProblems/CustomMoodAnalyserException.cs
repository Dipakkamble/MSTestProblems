﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestProblems
{
    public class CustomMoodAnalyserException:Exception
    {
        public ExceptionTypes exceptionTypes;
        public enum ExceptionTypes
        {
            NULL_MOOD,
            EMPTY_MOOD            
        }
        public CustomMoodAnalyserException(string message, ExceptionTypes exceptionTypes):base(message)
        {
            this.exceptionTypes = exceptionTypes;
        }
    }
}
