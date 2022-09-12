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
            if(!string.IsNullOrEmpty(numeral))
            {
                if (numeral == "I")
                    return 1;
                else 
                    return -1;
            }
            else
                return -1;

        }
    }
}
