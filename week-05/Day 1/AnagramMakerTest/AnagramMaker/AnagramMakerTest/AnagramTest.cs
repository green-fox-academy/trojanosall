using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnagramMaker;
using NUnit.Framework;

namespace AnagramMakerTest
{
    [TestFixture]
    public class AnagramTest
    {

        [Test]
        public void StringCompared()
        {
            string input1 = "kaka";
            string input2 = "akka";
            Assert.AreEqual(true, Anagram.IsAnagram(input1, input2));
            input1 = "hotel";
            input2 = "holel";
            Assert.AreEqual(false, Anagram.IsAnagram(input1, input2));
        }

        [Test]
        public void CompareCases()
        {
            string input1 = "Hello";
            string input2 = "ehlol";
            Assert.AreEqual(true, Anagram.IsAnagram(input1, input2));
        }


        [Test]
        public void WhiteSpaces()
        {
            string input1 = "Hel     lo";
            string input2 = "ehlol";
            Assert.AreEqual(true, Anagram.IsAnagram(input1, input2));
        }

        [Test]
        public void Null()
        {
            string input1 = null;
            string input2 = "nunit";
            Assert.AreEqual(false, Anagram.IsAnagram(input1, input2));
        }

        [Test]
        public void EmptyStrings()
        {
            string input1 = "";
            string input2 = "";
            Assert.AreEqual(true, Anagram.IsAnagram(input1, input2));
        }
    }
}
