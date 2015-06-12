using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumeralsKata.Tests
{
    [TestClass]
    public class TestRomanNumeralsKata
    {
        [TestMethod]
        public void TestThat1ReturnsI()
        {
            //act
            var result = RomanNumerals.arabicToRoman(1);

            //assert
            Assert.AreEqual("I", result);
        }
    }
}
