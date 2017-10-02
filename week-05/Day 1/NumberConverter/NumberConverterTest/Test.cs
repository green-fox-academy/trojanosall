using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberConverter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace NumberConverterTest
{
    [TestFixture]
    public class Test
    {
        [Test]

        public void InIntOutString()
        {
            int input = 1;
            string output = "one";
            
            Assert.AreEqual(output, Program.Converter(input));
        }

        [Test]
        public void TwoIsTwo()
        {
            int input = 2;
            string output = "two";

            Assert.AreEqual(output, Program.Converter(input));
        }

        [Test]
        public void ThreeIsThree()
        {
            int input = 3;
            string output = "three";

            Assert.AreEqual(output, Program.Converter(input));
        }

        [Test]
        public void FourIsFour()
        {
            int input = 4;
            string output = "four";

            Assert.AreEqual(output, Program.Converter(input));
        }
    }
}
