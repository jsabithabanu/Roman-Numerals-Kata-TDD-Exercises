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

        [Test]
        public void Testing_To_Convert_Number_Three_To_Roman_Numeral()
        {
            numberToRomanConverter.NumberToRoman(3).Should().Be("III");
        }

        [Test]
        public void Testing_To_Convert_Number_Four_To_Roman_Numeral()
        {
            numberToRomanConverter.NumberToRoman(4).Should().Be("IV");
        }

        [Test]
        public void Testing_To_Convert_Number_Five_To_Roman_Numeral()
        {
            numberToRomanConverter.NumberToRoman(5).Should().Be("V");
        }

        [Test]
        public void Testing_To_Convert_Number_Six_To_Roman_Numeral()
        {
            numberToRomanConverter.NumberToRoman(6).Should().Be("VI");
        }

        [Test]
        public void Testing_To_Convert_Number_Seven_To_Roman_Numeral()
        {
            numberToRomanConverter.NumberToRoman(7).Should().Be("VII");
        }

        [Test]
        public void Testing_To_Convert_Number_Eight_To_Roman_Numeral()
        {
            numberToRomanConverter.NumberToRoman(8).Should().Be("VIII");
        }

        [Test]
        public void Testing_To_Convert_Number_Nine_To_Roman_Numeral()
        {
            numberToRomanConverter.NumberToRoman(9).Should().Be("IX");
        }

        [Test]
        public void Testing_To_Convert_Number_Ten_To_Roman_Numeral()
        {
            numberToRomanConverter.NumberToRoman(10).Should().Be("X");
        }

        [Test]
        public void Testing_To_Convert_Number_Eleven_To_Roman_Numeral()
        {
            numberToRomanConverter.NumberToRoman(11).Should().Be("XI");
        }

        [Test]
        public void Testing_To_Convert_Number_Fourteen_To_Roman_Numeral()
        {
            numberToRomanConverter.NumberToRoman(14).Should().Be("XIV");
        }

        [Test]
        public void Testing_To_Convert_Number_Fifteen_To_Roman_Numeral()
        {
            numberToRomanConverter.NumberToRoman(15).Should().Be("XV");
        }

        [Test]
        public void Testing_To_Convert_Number_Sixteen_To_Roman_Numeral()
        {
            numberToRomanConverter.NumberToRoman(16).Should().Be("XVI");
        }
    }
}
