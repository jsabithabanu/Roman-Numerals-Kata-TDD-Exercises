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
                {"V", 5},
                {"IX", 9},
                {"X", 10},
                {"XL", 40},
                {"L", 50},
                {"XC", 90},
                {"C", 100},
                {"CD", 400},
                {"D", 500},
                {"CM", 900},
                {"M", 1000}
            };

            string RomanNumeral = "";
            
            //This checks starting from larger number in the dictionary
            //and finds the Roman numerals
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
