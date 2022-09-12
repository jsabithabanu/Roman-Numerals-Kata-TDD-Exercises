using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKataTDDExercise
{
    public class RomanNumeralToNumberConverter
    {
        public int RomanToNumber(string numeral)
        {
            int number = 0;
            if(!string.IsNullOrEmpty(numeral))
            {                
                for (int i=0; i < numeral.Length; i++)
                {
                    if (numeral[i].ToString().Equals("I"))
                        number++;
                }
                return number;
            }
            else
                return -1;

        }
    }
}
