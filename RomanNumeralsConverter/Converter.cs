using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsConverter
{
    public static class Converter
    {
        public static int ConvertFromRomanToArabic(string roman)
        {
            var result = 0;
            var romanNumberArray = roman.ToCharArray();
        
            for (int index = 0; index < romanNumberArray.Length; index++)
            {
                if((index + 1) > romanNumberArray.Length - 1) { 
                    result += parseRomanToArabic(romanNumberArray[index]);
                    break;
                }

                if (parseRomanToArabic(romanNumberArray[index]) > parseRomanToArabic(romanNumberArray[index + 1]))
                {
                    result += parseRomanToArabic(romanNumberArray[index]);
                }
                else if (parseRomanToArabic(romanNumberArray[index]) < parseRomanToArabic(romanNumberArray[index + 1]))
                {
                    var value = parseRomanToArabic(romanNumberArray[index + 1]) - parseRomanToArabic(romanNumberArray[index]);
                    index++;

                    result += value;
                }
                else
                {
                    result += parseRomanToArabic(romanNumberArray[index]);
                }
            }

            return result;
        }

        private static int parseRomanToArabic (char roman)
        {
            return new Dictionary().RomanToArabic.Single(x => x.Key == roman).Value;
        }
    }
}
