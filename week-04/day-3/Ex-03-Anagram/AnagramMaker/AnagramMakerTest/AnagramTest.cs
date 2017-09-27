using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnagramMaker;

namespace AnagramMakerTest
{
    [TestFixture]

    public class AnagramTest
    {

       [TestCase]
        public void TestAnagramMaker_WhenStringsDifferentLenght_ThenFalse()
        {
            //arrange
            string firstString = "kutyamutya";
            string secondString = "nyuszifulimulike";

            //act
            bool output = false;

            //assert
            Assert.AreEqual(output, Anagram.AnagramChecker(firstString, secondString));
        }

        [TestCase]
        public void TestAnagramMaker_WhenStringsEqualsLenghtButNotAnagram_ThenFalse()
        {
            //arrange
            string firstString = "kutyamutya";
            string secondString = "nuoyaluzia";

            //act
            bool output = false;

            //assert
            Assert.AreEqual(output, Anagram.AnagramChecker(firstString, secondString));
        }

        [TestCase]
        public void TestAnagramMaker_WhenStringsEqualsLenghtAndAnagram_ThenTrue()
        {
            //arrange
            string firstString = "kutyamutya";
            string secondString = "tyatyamuku";

            //act
            bool output = true;

            //assert
            Assert.AreEqual(output, Anagram.AnagramChecker(firstString, secondString));
        }

        [TestCase]
        public void TestAnagramMaker_WhenStringsEqualsLenghtWithSpace_ThenFalse()
        {
            //arrange
            string firstString = "kutyamutya";
            string secondString = "tyaty muku";

            //act
            bool output = false;

            //assert
            Assert.AreEqual(output, Anagram.AnagramChecker(firstString, secondString));
        }

        [TestCase]
        public void TestAnagramMaker_WhenStringsEqualsLenghtWithUpperLetter_ThenTrue()
        {
            //arrange
            string firstString = "nono";
            string secondString = "NoNo";

            //act
            bool output = true;

            //assert
            Assert.AreEqual(output, Anagram.AnagramChecker(firstString, secondString));
        }

        [TestCase]
        public void TestAnagramMaker_WhenOneStringEmpty_ThenFalse()
        {
            //arrange
            string firstString = "nono";
            string secondString = "";

            //act
            bool output = false;

            //assert
            Assert.AreEqual(output, Anagram.AnagramChecker(firstString, secondString));
        }
    }
}
