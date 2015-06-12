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
        [TestMethod]
        public void TestThat2ReturnsII()
        {
            //act
            var result = RomanNumerals.arabicToRoman(2);
            //assert
            Assert.AreEqual("II", result);
        }

        [TestMethod]
        public void TestThat3ReturnsIII()
        {
            //act
            var result = RomanNumerals.arabicToRoman(3);
            //assert
            Assert.AreEqual("III", result);
        }

        [TestMethod]
        public void TestThe5RetunsV()
        {
            //act
            var result = RomanNumerals
                .arabicToRoman(5);
            //assert            
            Assert.AreEqual("V", result);
        } 
    }
}
