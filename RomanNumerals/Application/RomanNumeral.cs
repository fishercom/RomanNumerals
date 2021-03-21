using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RomanNumerals.Application
{
    public class RomanNumeral
    {

        private readonly Dictionary<string, int> romans = new Dictionary<string, int>
        {
            //list of all combinable roman numerals
            {"M", 1000},
            {"CM", 900},
            {"D",  500},
            {"CD", 400},
            {"C",  100},
            {"XC",  90},
            {"L",   50},
            {"XL",  40},
            {"X",   10},
            {"IX",   9},
            {"V",    5},
            {"IV",   4},
            {"I",    1}
        };

        public int ToInteger(string input)
        {
            int result = 0; //initialize result
            string numeral = input.ToUpper(); //convert to upper cases
            var match = Regex.Match(numeral, "^M{0,4}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$"); //validate format roman numeral

            if (!match.Success) { // trow exception if is bad format
                throw new Exception("Invalid Format input");
            } 

            while (numeral.Length != 0) //looping numeral
            {
                foreach (var key in romans.Keys) //looping romans list
                {
                    if (numeral.StartsWith(key)) //check the first occurrence of roman key
                    {
                        numeral = numeral.Substring(key.Length); //remove the first occurrence of input
                        result += romans[key]; //summarize with new value
                    }
                }
            }
            return result; //return final result
        }
    }
}
