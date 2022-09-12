using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKataTDDExercise
{
    public class RomanNumeralToNumberConverter
    {
        public int RomanToNumber(string romanNumeral)
        {
            //Dictionary to store Roman numerals and Integer number mapping
            var RomanMap = new Dictionary<string, int>
            {
                {"I", 1},
                {"V", 5}
            };

            int number = 0;
            if(!string.IsNullOrEmpty(romanNumeral))
            {
                for (int i = 0; i < romanNumeral.Length; i++)
                {
                    if (i + 1 < romanNumeral.Length && RomanMap[romanNumeral[i].ToString()] < RomanMap[romanNumeral[i + 1].ToString()])
                    {
                        number -= RomanMap[romanNumeral[i].ToString()];
                    }
                    else
                    {
                        number += RomanMap[romanNumeral[i].ToString()];
                    }
                }
                return number;
            }
            else
                return -1;

        }
    }
}
