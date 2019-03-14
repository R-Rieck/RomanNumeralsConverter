using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralsConverter;
using System;

namespace RomanNumeralsConverter.Test
{
    [TestClass]
    public class ConverterTests
    {
        [TestMethod]
        public void ConvertI()
        {
            Converter.ConvertFromRomanToArabic("I");
        }

        [TestMethod]
        public void ConvertII()
        {
            Converter.ConvertFromRomanToArabic("II");
        }

        [TestMethod]
        public void ConvertIV()
        {
            Converter.ConvertFromRomanToArabic("IV");
        }

        [TestMethod]
        public void ConvertV()
        {
            Converter.ConvertFromRomanToArabic("V");
        }

        [TestMethod]
        public void ConvertIX()
        {
            Converter.ConvertFromRomanToArabic("IX");
        }

        [TestMethod]
        public void ConvertXLII()
        {
            Converter.ConvertFromRomanToArabic("XLII");
        }

        [TestMethod]
        public void ConvertXCLX()
        {
            Converter.ConvertFromRomanToArabic("XCIX");
        }

        [TestMethod]
        public void ConvertMMXIII()
        {
            Converter.ConvertFromRomanToArabic("MMXIII");
        }
    }
}
