using System;
using Xunit;
using RomanNumerals.Application;

namespace RomanNumerals.Test
{
    public class RomanTests
    {
        RomanNumeral roman = new RomanNumeral();

        [Fact]
        public void Result_Shuld_Be_2021()
        {
            bool result = !roman.ToInteger("MMXXI").Equals(2021);
            Assert.False(result, "Result should be 2021");
        }

        [Fact]
        public void Result_Shuld_Be_4()
        {
            bool result = !roman.ToInteger("IV").Equals(4);
            Assert.False(result, "Result should be 4");
        }

        [Fact]
        public void Result_Shuld_Be_Zero()
        {
            bool result = !roman.ToInteger("").Equals(0);
            Assert.False(result, "Result should be 0");
        }

        [Fact]
        public void Result_Invalid_Format_Numeral()
        {
            Assert.Throws<Exception>(() => roman.ToInteger("IIXCDMLX"));
        }

        [Fact]
        public void Result_Invalid_Format_Input()
        {
            Assert.Throws<Exception>(() => roman.ToInteger("53534asd"));
        }

    }
}
