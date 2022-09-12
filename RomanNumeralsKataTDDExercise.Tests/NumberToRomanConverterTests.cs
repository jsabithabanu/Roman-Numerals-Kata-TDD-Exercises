using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKataTDDExercise.Tests
{
    public class NumberToRomanConverterTests
    {
        private NumberToRomanConverter numberToRomanConverter;
        
        [SetUp]
        public void Setup()
        {
            numberToRomanConverter = new NumberToRomanConverter();
        }

        [Test]
        public void Testing_To_Convert_Number_One_To_Roman_Numeral()
        {
            numberToRomanConverter.NumberToRoman(1).Should().Be("I");
        }

        [Test]
        public void Testing_To_Convert_Number_Two_To_Roman_Numeral()
        {
            numberToRomanConverter.NumberToRoman(2).Should().Be("II");
        }
    }
}
