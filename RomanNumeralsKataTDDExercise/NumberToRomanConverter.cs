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

            if (number > 0 && number < 3)
            {
                for (int i = 0; i < number; i++)
                    RomanNumeral += "I";
            }
            return RomanNumeral;
        }
    }
}
