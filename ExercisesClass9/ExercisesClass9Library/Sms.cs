﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesClass9Library
{
    public class Sms
    {
        public void GetMessage(string message)
        {
            if (message != null)
            {
                Console.WriteLine($"{message}  - got the message through SMS.");
            }
        }
    }
}
