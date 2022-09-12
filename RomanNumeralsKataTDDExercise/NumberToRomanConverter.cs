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
            //Dictionary to store Roman numerals and Integer number mapping
            var RomanToNumberMap = new Dictionary<string, int>
            {
                {"I", 1},
                {"IV", 4},
                {"V", 5}
            };

            string RomanNumeral = "";
            
            foreach (var item in RomanToNumberMap.Reverse())
            {
                if (number <= 0) break;
                while (number >= item.Value)
                {
                    RomanNumeral += item.Key;
                    number -= item.Value;
                }
            }
            return RomanNumeral;
        }
    }
}
