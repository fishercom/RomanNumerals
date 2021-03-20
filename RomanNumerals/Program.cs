using System;
using RomanNumerals.Application;

namespace RomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            RomanNumeral roman = new RomanNumeral();
            //Example 1: XXI is 21 Example 2: XL is 40 Example 3: LVIII is 58
            Console.WriteLine(roman.ToInteger("XXI"));
            Console.WriteLine(roman.ToInteger("XL"));
            Console.WriteLine(roman.ToInteger("LVIII"));

        }
    }
}
