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
            var result = Converter.ConvertFromRomanToArabic("I");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ConvertII()
        {
            var result = Converter.ConvertFromRomanToArabic("II");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void ConvertIV()
        {
            var result = Converter.ConvertFromRomanToArabic("IV");
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void ConvertV()
        {
            var result = Converter.ConvertFromRomanToArabic("V");
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void ConvertIX()
        {
            var result = Converter.ConvertFromRomanToArabic("IX");
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void ConvertXLII()
        {
            var result = Converter.ConvertFromRomanToArabic("XLII");
            Assert.AreEqual(42, result);
        }

        [TestMethod]
        public void ConvertXCLX()
        {
            var result = Converter.ConvertFromRomanToArabic("XCIX");
            Assert.AreEqual(99, result);
        }

        [TestMethod]
        public void ConvertMMXIII()
        {
            var result = Converter.ConvertFromRomanToArabic("MMXIII");
            Assert.AreEqual(2013, result);
        }
    }
}
