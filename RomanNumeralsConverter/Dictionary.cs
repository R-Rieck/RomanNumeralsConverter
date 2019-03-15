using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsConverter
{
    public static class Dictionary
    {
        public static Dictionary<char, int> RomanToArabic = new Dictionary<char, int>()
        {
            {'I' , 1 },
            {'V' , 5 },
            {'X' , 10 },
            {'L' , 50 },
            {'C' , 100 },
            {'D' , 500 },
            {'M' , 1000 }
        };
    }
}
