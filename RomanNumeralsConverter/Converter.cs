using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsConverter
{
    public static class Converter
    {
        public static void ConvertFromRomanToArabic(string roman)
        {
            Display(Convert(roman));
        }

        public static void Display(int number)
        {
            Console.WriteLine(number);
        }
        public static int Convert(string roman)
        {
            var result = 0;
            var romanNumberArray = roman.ToCharArray();

            for (int index = 0; index < romanNumberArray.Length; index++)
            {
                var romanCharToNumber = Dictionary.RomanToArabic.Single(x => x.Key == romanNumberArray[index]).Value;
                var nextRomanCharToNumber = Dictionary.RomanToArabic.Single(x => x.Key == romanNumberArray[index + 1]).Value;

                if (((index + 1) > romanNumberArray.Length - 1))
                {
                    result += romanCharToNumber;
                    break;
                }

                else if (romanCharToNumber > nextRomanCharToNumber)
                {
                    result += romanCharToNumber;
                }

                else if (romanCharToNumber < nextRomanCharToNumber)
                {
                    var value = nextRomanCharToNumber - romanCharToNumber;
                    index++;

                    result += value;
                }

                else
                {
                    result += romanCharToNumber;
                }
            }

            return result;
        }
    }
}
