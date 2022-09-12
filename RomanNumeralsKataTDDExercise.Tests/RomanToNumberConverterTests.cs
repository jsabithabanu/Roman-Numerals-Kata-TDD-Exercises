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
    }
}
