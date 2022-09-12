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

            if (number > 0 && number < 4)
            {
                for (int i = 0; i < number; i++)
                    RomanNumeral += "I";
            }
            else if (number == 4)
            {
                RomanNumeral = "IV";
            }
            return RomanNumeral;
        }
    }
}
