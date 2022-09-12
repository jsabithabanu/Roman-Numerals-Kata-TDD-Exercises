using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;



namespace RomanNumeralsKataTDDExercise.Tests
{
    public class RomanToNumberConverterTests
    {
        private RomanNumeralToNumberConverter romanToNumberConverter;

        [SetUp]
        public void Setup()
        {
            romanToNumberConverter = new RomanNumeralToNumberConverter();
        }

        [Test]
        public void Testing_To_Convert_Roman_Numeral_To_Number_One()
        {
            romanToNumberConverter.RomanToNumber("I").Should().Be(1);
        }

        [Test]
        public void Testing_To_Convert_Roman_Numeral_To_Number_Two()
        {
            romanToNumberConverter.RomanToNumber("II").Should().Be(2);
        }

        [Test]
        public void Testing_To_Convert_Roman_Numeral_To_Number_Three()
        {
            romanToNumberConverter.RomanToNumber("III").Should().Be(3);
        }

        [Test]
        public void Testing_To_Convert_Roman_Numeral_To_Number_Four()
        {
            romanToNumberConverter.RomanToNumber("IV").Should().Be(4);
        }

        [Test]
        public void Testing_To_Convert_Roman_Numeral_To_Number_Five()
        {
            romanToNumberConverter.RomanToNumber("V").Should().Be(5);
        }

        [Test]
        public void Testing_To_Convert_Roman_Numeral_To_Number_Fifty_Four()
        {
            romanToNumberConverter.RomanToNumber("LIV").Should().Be(54);
        }

        [Test]
        public void Testing_To_Convert_Roman_Numeral_To_Number_One_Hundred_And_Twenty_Nine()
        {
            romanToNumberConverter.RomanToNumber("CXXIX").Should().Be(129);
        }

        [Test]
        public void Testing_To_Convert_Roman_Numeral_To_Number_Four_Hundred_And_Forty_Nine()
        {
            romanToNumberConverter.RomanToNumber("CDXLIX").Should().Be(449);
        }

        [Test]
        public void Testing_To_Convert_Roman_Numeral_To_Number_One_Thousand_Three_Hundred_And_Sixty_Seven()
        {
            romanToNumberConverter.RomanToNumber("MCCCLXVII").Should().Be(1367);
        }
    }
}
