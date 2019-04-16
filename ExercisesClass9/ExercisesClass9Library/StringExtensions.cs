using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ExercisesClass9Library
{
    public static class StringExtensions
    {
        public static char GetFirstLetter(this string letter)
        {
            char c = letter.FirstOrDefault();
            return c;
        }

        public static char LastLetter(this string letter)
        {
            char c = letter.LastOrDefault();
            return c;
        }

       public static List<T> GetNfromList<T>(this List<T> value, int count)
        {
            List<T> list = new List<T>();
            for(int i = 0; i < count; i++)
            {
                list.Add(value[i]);
            }
            return list;
        }

        
    }
}
