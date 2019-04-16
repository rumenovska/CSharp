using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesClass9Library
{
    public static class IntExtensions
    {
        public static bool IsEven(this int num)
        {
            if(num%2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
