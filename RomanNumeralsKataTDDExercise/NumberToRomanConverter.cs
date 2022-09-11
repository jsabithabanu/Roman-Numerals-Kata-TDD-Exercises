using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKataTDDExercise
{
    public class NumberToRomanConverter
    {
        public string NumberToRoman(int number)
        {
            string RomanNumeral = "";
            if (number == 1)
                RomanNumeral = "I";
            return RomanNumeral;
        }
    }
}
